using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SmartDesk
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SmartDesk_DB.mdf;Integrated Security=True;Current Language=Polish;";
        private bool isUpdatingCheckState = false;   // zapobiega zapętlaniu się zdarzeń
        private bool isDarkTheme = false;
        private Timer appTimer;

        public Form1()
        {
            InitializeComponent();
            LoadTasks();
            LoadCompletedTasks();
            LoadTopics();
            LoadAppTime();
            InitializeAppTimer();
        }

        private void InitializeAppTimer()
        {
            appTimer = new Timer();   // tworzenie nowego obiektu
            appTimer.Interval = 60000;   // ustawianie interwału na 60s
            appTimer.Tick += AppTimer_Tick;   // przypisanie metody
            appTimer.Start();
        }

        private void AppTimer_Tick(object sender, EventArgs e)
        {
            SaveMinuteToDatabase();   // zapisywanie czasu do bazy danych
            LoadAppTime();   // wyświetlanie czasu
        }

        private void LoadAppTime()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM AppTime";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        int count = (int)checkCmd.ExecuteScalar();   // konwersja objektu na int, który zwraca pierwszą kolumnę wiersza
                        if (count == 0)
                        {
                            string insertQuery = "INSERT INTO AppTime (TotalMinutes) VALUES (0)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                            {
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // pobiera liczbę minut z bazy i wyświetla jako format HH:mm na etykiecie
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 TotalMinutes FROM AppTime", connection))
                    {
                        int mins = Convert.ToInt32(cmd.ExecuteScalar());   // pobiera minuty z bazy danych
                        label_czas_spedzony.Text = $"{mins / 60:D2}:{mins % 60:D2}";   // zamienia minuty na format godziny:minuty i wyświetla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd pobierania czasu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveMinuteToDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE AppTime SET TotalMinutes = TotalMinutes + 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd zapisu czasu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    LoadAppTime();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd połączenia: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void LoadTasks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, content FROM Tasks";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);   // tworzenie adaptera
                    DataTable dt = new DataTable();   // tworzenie nowej tabeli danych
                    adapter.Fill(dt);   // podłączanie adaptera do tabeli danych

                    isUpdatingCheckState = true;   // zabepiczenie przed zapętleniem zdarzenia
                    checkedListBox_lista_zadan.DataSource = dt;
                    checkedListBox_lista_zadan.DisplayMember = "content";
                    checkedListBox_lista_zadan.ValueMember = "Id";

                    for (int i = 0; i < checkedListBox_lista_zadan.Items.Count; i++)
                    {
                        checkedListBox_lista_zadan.SetItemChecked(i, false);   // odznacza wszystkie checkboxy pokolei
                    }
                    isUpdatingCheckState = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania zadań: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCompletedTasks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TOP 6 Id, content FROM TasksCompleted ORDER BY Id DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    listBox_zadania_wykonane.DataSource = dt;
                    listBox_zadania_wykonane.DisplayMember = "content";
                    listBox_zadania_wykonane.ValueMember = "Id";

                    string countQuery = "SELECT COUNT(*) FROM TasksCompleted";
                    using (SqlCommand cmdCount = new SqlCommand(countQuery, connection))
                    {
                        int count = (int)cmdCount.ExecuteScalar();   // pobiera i konwertuje pierwszą kolumnę wiersza na typ int
                        label_liczba_wykonanych_zadan.Text = count.ToString();   // przypisanie ilości wykonanych zadań do labela
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania wykonanych zadań: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTopics()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Name, Note FROM Topics";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBox_lista_tematow.DataSource = dt;
                    comboBox_lista_tematow.DisplayMember = "Name";
                    comboBox_lista_tematow.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania tematów: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_tresc_zadania_TextChanged(object sender, EventArgs e) { }

        private void button_dodaj_zadanie_Click(object sender, EventArgs e)
        {
            string content = textBox_tresc_zadania.Text.Trim();   // pobieranie treści zadania

            if (content.Length < 3)   // sprawdzanie czy treść ma conajmniej 3 znaki
            {
                MessageBox.Show("Treść zadania musi zawierać co najmniej 3 znaki.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Tasks (content) VALUES (@content)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@content", SqlDbType.NVarChar, -1).Value = content;   // przypisanie danych jako nvarchar z polskimi znakami
                        command.ExecuteNonQuery();   // wykonanie zapytania
                    }
                }

                textBox_tresc_zadania.Clear();   // wyczyszczenie pola zadania po dodaniu zadania
                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania zadania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_edytuj_zadanie_Click(object sender, EventArgs e)
        {
            if (checkedListBox_lista_zadan.SelectedItem == null)   // sprawdza czy jakikolwiek checkbox z listy jest zaznaczony
            {
                MessageBox.Show("Wybierz zadanie z listy do edycji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string content = textBox_tresc_zadania.Text.Trim();   // pobranie treści zadania

            if (content.Length < 3)
            {
                MessageBox.Show("Treść zadania musi zawierać co najmniej 3 znaki.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = Convert.ToInt32(checkedListBox_lista_zadan.SelectedValue);   // konwersja id zaznaczonego elementu na int 

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Tasks SET content = @Content WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Content", SqlDbType.NVarChar, -1).Value = content;   // przypisanie tekstu nvarchar pod zmienna zapytania
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = selectedId;   // przypisanie inta pod zmienna id

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)   // sprawdza czy komenda wykonała jakąś akcję
                        {
                            LoadTasks();   // załadowanie listy zadań
                            textBox_tresc_zadania.Clear();   // wyczyszczenie treści zadania
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas edycji zadania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_usun_zadanie_Click(object sender, EventArgs e)
        {
            if (checkedListBox_lista_zadan.CheckedItems.Count == 0)
            {
                MessageBox.Show("Zaznacz co najmniej jedno zadanie do usunięcia za pomocą checkboxa.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone zadania?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (var item in checkedListBox_lista_zadan.CheckedItems)   // przygotowanie do sprawdzenia każdego zaznaczonego elementu checkedListBox
                    {
                        if (item is DataRowView row)   // jeżeli element istnieje w DataRowView
                        {
                            int id = Convert.ToInt32(row["Id"]);   // konwertuje jego id na int
                            string query = "DELETE FROM Tasks WHERE Id = @Id";   // usuwa zadanie jeśli jest zaznaczone

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;   // przypisanie inta do zmiennej zapytania
                                command.ExecuteNonQuery();   // wykonanie zapytania
                            }
                        }
                    }
                }

                LoadTasks();   // załadowanie zadań
                textBox_tresc_zadania.Clear();   // wyczyszczenie pola
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas usuwania zadania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkedListBox_lista_zadan_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (isUpdatingCheckState) return;

            Point cursorPoint = checkedListBox_lista_zadan.PointToClient(Cursor.Position);   // przeliczenie pozycji myszy na współrzędne wewnątrz kontrolki
            Rectangle itemRect = checkedListBox_lista_zadan.GetItemRectangle(e.Index);   // pobranie wymiarów klikniętego wiersza
            Rectangle checkboxRect = new Rectangle(itemRect.Left, itemRect.Top, 20, itemRect.Height);   // wyznaczenie obszaru samego kwadracika checkboxa

            if (!checkboxRect.Contains(cursorPoint))   // sprawdzenie czy kliknięcie trafiło poza sam kwadrat checkboxa
            {
                e.NewValue = e.CurrentValue;   // cofnięcie zmiany stanu zaznaczenia
                return;
            }

            if (e.NewValue == CheckState.Checked)
            {
                if (checkedListBox_lista_zadan.Items[e.Index] is DataRowView row)
                {
                    int id = Convert.ToInt32(row["Id"]);   // konwersja i pobranie id
                    string content = row["content"].ToString();   // konwersja i pobranie contentu

                    BeginInvoke((MethodInvoker)(() =>   // bezpieczne uruchomienie funkcji, żeby zaktualizować interfejs użytkownika
                    {
                        MoveTaskToCompleted(id, content);   // przenoszenie zadania do zakończonych
                    }));
                }
            }
        }

        private void MoveTaskToCompleted(int id, string content)   // metoda przenoszenia zadań do ukończonych
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();   // otwieranie połączenia z bazą

                    string insertQuery = "INSERT INTO TasksCompleted (content) VALUES (@content)";
                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, connection))
                    {
                        cmdInsert.Parameters.Add("@content", SqlDbType.NVarChar, -1).Value = content;   // podstawienie tekstu nvarchar pod zmienne
                        cmdInsert.ExecuteNonQuery();   // wykonanie polecenia
                    }

                    string deleteQuery = "DELETE FROM Tasks WHERE Id = @Id";
                    using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, connection))
                    {
                        cmdDelete.Parameters.Add("@Id", SqlDbType.Int).Value = id;   // podstawienie inta pod zmienne
                        cmdDelete.ExecuteNonQuery();   // wykonanie polecenia
                    }
                }

                LoadTasks();   // załadowanie zadań niewykonanych
                LoadCompletedTasks();   // załadowanie zadań wykonanych
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas przenoszenia zadania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_tresc_tematu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_dodaj_temat_Click(object sender, EventArgs e)
        {
            string topicName = textBox_tresc_tematu.Text.Trim();

            if (topicName.Length < 3)
            {
                MessageBox.Show("Nazwa tematu musi zawierać co najmniej 3 znaki.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Topics (Name, Note) VALUES (@Name, @Note)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Name", SqlDbType.NVarChar, -1).Value = topicName;   // podstawienie tekstu nvarchar tematu do bazy
                        command.Parameters.Add("@Note", SqlDbType.NVarChar, -1).Value = string.Empty;   // podstawienie pustej notatki typu nvarchar
                        command.ExecuteNonQuery();   // wykonanie polecenia
                    }
                }

                textBox_tresc_tematu.Clear();   // wyczyszczenie pola
                LoadTopics();   // załadowanie dostępnych tematów
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania tematu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_lista_tematow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_lista_tematow.SelectedItem is DataRowView row)   // jeżeli jest zaznaczony element w comboBox
            {
                textBox_tresc_notatki.Text = row["Note"].ToString();   // uzupełnij pole notatki
            }
        }

        private void button_usun_temat_Click(object sender, EventArgs e)
        {
            if (comboBox_lista_tematow.SelectedItem == null)   // jeżeli pole nie jest zaznaczone -> ukazuje się komunikat
            {
                MessageBox.Show("Wybierz temat do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć ten temat wraz z jego notatką i powiązanymi zadaniami?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            int selectedTopicId = Convert.ToInt32(comboBox_lista_tematow.SelectedValue);   // konwertowanie id zaznaczonego tematu do int

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))   // tworzenie połączenia
                {
                    connection.Open();   // otwieranie połączenia

                    string query = "DELETE FROM Topics WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = selectedTopicId;   // podstawienie inta pod zmienne
                        command.ExecuteNonQuery();   // wykonanie polecenia
                    }
                }

                LoadTopics();   // załadowanie tematów
                textBox_tresc_notatki.Clear();   // wyczyszczenie pola notatki
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas usuwania tematu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_tresc_notatki_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button_zapisz_notatke_Click(object sender, EventArgs e)
        {
            if (comboBox_lista_tematow.SelectedItem == null)   // jeżeli temat nie jest wybrany -> ukazuje się komunikat
            {
                MessageBox.Show("Wybierz temat, do którego chcesz zapisać notatkę.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedTopicId = Convert.ToInt32(comboBox_lista_tematow.SelectedValue);   // konwersja wybranego id wybranego tematu na int
            string noteContent = textBox_tresc_notatki.Text;   // pobieranie treści notatki

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))   // tworzenie połączenia
                {
                    connection.Open();   // otwieranie połączenia
                    string query = "UPDATE Topics SET Note = @Note WHERE Id = @Id";   // zaktualizuj notatkę tematu gdzie id = zmiennej id wybranego tematu

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Note", SqlDbType.NVarChar, -1).Value = noteContent;   // podstawienie notatki nvarchar pod zmienne
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = selectedTopicId;   // podstawienie inta tematu pod zmienne
                        command.ExecuteNonQuery();
                    }
                }

                LoadTopics();   // załadowanie tematów
                comboBox_lista_tematow.SelectedValue = selectedTopicId;   // ustawienie wybranego tematu do comboBoxa

                button_zapisz_notatke.Text = "ZAPISANO!";
                button_zapisz_notatke.BackColor = Color.FromArgb(45, 120, 55);
                button_zapisz_notatke.ForeColor = Color.White;

                await Task.Delay(1500);   // asynchroniczne zatrzymanie bez zamrażania interfejsu

                button_zapisz_notatke.Text = "ZAPISZ";
                if (isDarkTheme)
                {
                    button_zapisz_notatke.BackColor = Color.FromArgb(50, 50, 55);
                    button_zapisz_notatke.ForeColor = Color.White;
                }
                else
                {
                    button_zapisz_notatke.BackColor = SystemColors.Window;
                    button_zapisz_notatke.ForeColor = SystemColors.ControlText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisywania notatki: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_wyczysc_notatke_Click(object sender, EventArgs e)
        {
            textBox_tresc_notatki.Clear();   // wyczyszczenie pola notatki
        }

        private void button_wyswietl_notatke_Click(object sender, EventArgs e)
        {
            if (comboBox_lista_tematow.SelectedItem == null)
            {
                MessageBox.Show("Wybierz temat do wyświetlenia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string topicName = string.Empty;
            if (comboBox_lista_tematow.SelectedItem is DataRowView row)
            {
                topicName = row["Name"].ToString();
            }
            else
            {
                topicName = comboBox_lista_tematow.Text;
            }

            string noteContent = textBox_tresc_notatki.Text;

            // utworzenie nowego okna (treść notatki)
            Form oknoNotatki = new Form();
            // właściwości okna notatki
            oknoNotatki.Text = $"Podgląd notatki – {topicName}";
            oknoNotatki.Size = new Size(500, 420);
            oknoNotatki.StartPosition = FormStartPosition.CenterParent;
            oknoNotatki.FormBorderStyle = FormBorderStyle.FixedDialog;
            oknoNotatki.MaximizeBox = false;
            oknoNotatki.MinimizeBox = false;
            oknoNotatki.ShowIcon = false;
            oknoNotatki.BackColor = isDarkTheme ? Color.FromArgb(28, 28, 28) : Color.FromArgb(224, 224, 224);

            // właściwości tytułu w oknie notatki
            Label labelTytul = new Label();
            labelTytul.Text = $"TEMAT: {topicName}";
            labelTytul.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            labelTytul.ForeColor = isDarkTheme ? Color.White : Color.FromArgb(80, 80, 220);
            labelTytul.Location = new Point(15, 15);
            labelTytul.Size = new Size(455, 30);

            // właściwości treści notatki w oknie notatki
            TextBox textTresc = new TextBox();
            textTresc.Multiline = true;
            textTresc.ReadOnly = true;
            textTresc.ScrollBars = ScrollBars.Vertical;
            textTresc.Font = new Font("Arial", 10.2F);
            textTresc.Text = noteContent;
            textTresc.Location = new Point(15, 55);
            textTresc.Size = new Size(455, 270);
            textTresc.BorderStyle = BorderStyle.FixedSingle;
            textTresc.BackColor = isDarkTheme ? Color.FromArgb(20, 20, 20) : SystemColors.Window;
            textTresc.ForeColor = isDarkTheme ? Color.White : SystemColors.WindowText;

            // właściwości przycisku zamknij w oknie notatki
            Button btnZamknijOkno = new Button();
            btnZamknijOkno.Text = "ZAMKNIJ";
            btnZamknijOkno.Font = new Font("Candara", 7.8F, FontStyle.Bold);
            btnZamknijOkno.Size = new Size(110, 32);
            btnZamknijOkno.Location = new Point(360, 335);
            btnZamknijOkno.FlatStyle = FlatStyle.Flat;
            btnZamknijOkno.FlatAppearance.BorderSize = 1;
            btnZamknijOkno.FlatAppearance.BorderColor = Color.Black;
            btnZamknijOkno.BackColor = isDarkTheme ? Color.FromArgb(95, 45, 45) : Color.FromArgb(255, 192, 192);
            btnZamknijOkno.ForeColor = isDarkTheme ? Color.White : SystemColors.ControlText;
            btnZamknijOkno.Click += (s, ev) => oknoNotatki.Close();   // przypisanie akcji zamknięcia okna do przycisku

            // dodanie kontrolek do okna notatki
            oknoNotatki.Controls.Add(labelTytul);
            oknoNotatki.Controls.Add(textTresc);
            oknoNotatki.Controls.Add(btnZamknijOkno);

            // ukazanie okna notatki po kliknięciu przycisku
            oknoNotatki.ShowDialog(this);
        }

        private void checkedListBox_lista_zadan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox_lista_zadan.SelectedItem is DataRowView row)
            {
                textBox_tresc_zadania.Text = row["content"].ToString();
            }
        }

        private void label_liczba_wykonanych_zadan_Click(object sender, EventArgs e)
        {

        }

        private void button_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isDarkTheme)
            {
                this.BackColor = Color.FromArgb(28, 28, 28);
                panel1.BackColor = Color.FromArgb(37, 37, 38);
                panel2.BackColor = Color.FromArgb(37, 37, 38);
                panel3.BackColor = Color.FromArgb(37, 37, 38);

                textBox_tresc_notatki.BackColor = Color.FromArgb(20, 20, 20);
                textBox_tresc_notatki.ForeColor = Color.White;

                textBox_tresc_tematu.BackColor = Color.FromArgb(20, 20, 20);
                textBox_tresc_tematu.ForeColor = Color.White;

                textBox_tresc_zadania.BackColor = Color.FromArgb(20, 20, 20);
                textBox_tresc_zadania.ForeColor = Color.White;

                comboBox_lista_tematow.BackColor = Color.FromArgb(20, 20, 20);
                comboBox_lista_tematow.ForeColor = Color.White;
                comboBox_lista_tematow.FlatStyle = FlatStyle.Flat;

                checkedListBox_lista_zadan.BackColor = Color.FromArgb(20, 20, 20);
                checkedListBox_lista_zadan.ForeColor = Color.White;

                listBox_zadania_wykonane.BackColor = Color.FromArgb(20, 20, 20);
                listBox_zadania_wykonane.ForeColor = Color.White;

                label1.ForeColor = Color.FromArgb(140, 140, 255);
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label4.ForeColor = Color.Gainsboro;
                label6.ForeColor = Color.Gainsboro;
                label7.ForeColor = Color.Gainsboro;
                label8.ForeColor = Color.Gainsboro;
                label10.ForeColor = Color.Gainsboro;
                label11.ForeColor = Color.Gainsboro;
                label12.ForeColor = Color.Gainsboro;
                label13.ForeColor = Color.Gainsboro;
                label14.ForeColor = Color.Gainsboro;
                label_czas_spedzony.ForeColor = Color.FromArgb(140, 140, 255);
                label_liczba_wykonanych_zadan.ForeColor = Color.FromArgb(140, 140, 255);

                button_dodaj_zadanie.BackColor = Color.FromArgb(45, 85, 55);
                button_dodaj_zadanie.ForeColor = Color.White;

                button_edytuj_zadanie.BackColor = Color.FromArgb(95, 75, 40);
                button_edytuj_zadanie.ForeColor = Color.White;

                button_usun_zadanie.BackColor = Color.FromArgb(95, 45, 45);
                button_usun_zadanie.ForeColor = Color.White;

                button_dodaj_temat.BackColor = Color.FromArgb(45, 85, 55);
                button_dodaj_temat.ForeColor = Color.White;

                button_usun_temat.BackColor = Color.FromArgb(95, 45, 45);
                button_usun_temat.ForeColor = Color.White;

                button_wyswietl_notatke.BackColor = Color.FromArgb(95, 75, 40);
                button_wyswietl_notatke.ForeColor = Color.White;

                button_zapisz_notatke.BackColor = Color.FromArgb(50, 50, 55);
                button_zapisz_notatke.ForeColor = Color.White;

                button_wyczysc_notatke.BackColor = Color.FromArgb(85, 85, 50);
                button_wyczysc_notatke.ForeColor = Color.White;

                button_eksportuj_notatki.BackColor = Color.FromArgb(55, 55, 70);
                button_eksportuj_notatki.ForeColor = Color.White;

                button_zmien_motyw.BackColor = Color.FromArgb(45, 45, 48);
                button_zmien_motyw.ForeColor = Color.White;

                button_zamknij.BackColor = Color.FromArgb(95, 45, 45);
                button_zamknij.ForeColor = Color.White;

                isDarkTheme = true;
                button_zmien_motyw.Text = "JASNY MOTYW";
            }
            else
            {
                this.BackColor = Color.FromArgb(224, 224, 224);
                panel1.BackColor = Color.FromArgb(128, 128, 255);
                panel2.BackColor = Color.FromArgb(128, 128, 255);
                panel3.BackColor = Color.FromArgb(192, 192, 255);

                textBox_tresc_notatki.BackColor = SystemColors.Window;
                textBox_tresc_notatki.ForeColor = SystemColors.WindowText;

                textBox_tresc_tematu.BackColor = SystemColors.Window;
                textBox_tresc_tematu.ForeColor = SystemColors.WindowText;

                textBox_tresc_zadania.BackColor = SystemColors.Window;
                textBox_tresc_zadania.ForeColor = SystemColors.WindowText;

                comboBox_lista_tematow.BackColor = SystemColors.Window;
                comboBox_lista_tematow.ForeColor = SystemColors.WindowText;
                comboBox_lista_tematow.FlatStyle = FlatStyle.Standard;

                checkedListBox_lista_zadan.BackColor = SystemColors.Window;
                checkedListBox_lista_zadan.ForeColor = SystemColors.WindowText;

                listBox_zadania_wykonane.BackColor = SystemColors.Window;
                listBox_zadania_wykonane.ForeColor = SystemColors.WindowText;

                label1.ForeColor = Color.FromArgb(80, 80, 220);
                label2.ForeColor = SystemColors.Control;
                label3.ForeColor = SystemColors.Control;
                label9.ForeColor = SystemColors.Control;
                label4.ForeColor = SystemColors.ControlText;
                label6.ForeColor = SystemColors.ControlText;
                label7.ForeColor = SystemColors.ControlText;
                label8.ForeColor = SystemColors.ControlText;
                label10.ForeColor = SystemColors.ControlText;
                label11.ForeColor = SystemColors.ControlText;
                label12.ForeColor = SystemColors.ControlText;
                label13.ForeColor = SystemColors.ControlText;
                label14.ForeColor = SystemColors.ControlText;
                label_czas_spedzony.ForeColor = Color.FromArgb(128, 128, 255);
                label_liczba_wykonanych_zadan.ForeColor = Color.FromArgb(128, 128, 255);

                button_dodaj_zadanie.BackColor = Color.FromArgb(192, 255, 192);
                button_dodaj_zadanie.ForeColor = SystemColors.ControlText;

                button_edytuj_zadanie.BackColor = Color.FromArgb(255, 224, 192);
                button_edytuj_zadanie.ForeColor = SystemColors.ControlText;

                button_usun_zadanie.BackColor = Color.FromArgb(255, 192, 192);
                button_usun_zadanie.ForeColor = SystemColors.ControlText;

                button_dodaj_temat.BackColor = Color.FromArgb(192, 255, 192);
                button_dodaj_temat.ForeColor = SystemColors.ControlText;

                button_usun_temat.BackColor = Color.FromArgb(255, 192, 192);
                button_usun_temat.ForeColor = SystemColors.ControlText;

                button_wyswietl_notatke.BackColor = Color.FromArgb(255, 224, 192);
                button_wyswietl_notatke.ForeColor = SystemColors.ControlText;

                button_zapisz_notatke.BackColor = SystemColors.Window;
                button_zapisz_notatke.ForeColor = SystemColors.ControlText;

                button_wyczysc_notatke.BackColor = Color.FromArgb(255, 255, 192);
                button_wyczysc_notatke.ForeColor = SystemColors.ControlText;

                button_eksportuj_notatki.BackColor = Color.FromArgb(255, 224, 192);
                button_eksportuj_notatki.ForeColor = SystemColors.ControlText;

                button_zmien_motyw.BackColor = Color.Gray;
                button_zmien_motyw.ForeColor = Color.White;

                button_zamknij.BackColor = Color.FromArgb(255, 192, 192);
                button_zamknij.ForeColor = SystemColors.ControlText;

                isDarkTheme = false;
                button_zmien_motyw.Text = "CIEMNY MOTYW";
            }
        }

        private void button_eksportuj_notatki_Click(object sender, EventArgs e)
        {
            // tworzenie okna dialogowego wyboru lokalizacji pliku
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // właściwości okna eksploratora i pliku do zapisania
                saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.Title = "Eksportuj notatki do pliku";
                saveFileDialog.FileName = "Moje_Notatki_SmartDesk.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();   // tworzenie stringbuildera (rozbudowanego stringa)

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT Name, Note FROM Topics";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string topicName = reader["Name"].ToString();
                                        string noteContent = reader["Note"].ToString();

                                        // formatowanie notatki
                                        sb.AppendLine($"TEMAT: {topicName}");
                                        sb.AppendLine(noteContent);
                                        sb.AppendLine();   // pusta linia oddzielająca wpisy
                                    }
                                }
                            }
                        }

                        // zapisanie wygenerowanego tekstu do wybranego pliku
                        File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd podczas eksportu notatek: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}