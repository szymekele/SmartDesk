namespace SmartDesk
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox_lista_zadan = new System.Windows.Forms.CheckedListBox();
            this.listBox_zadania_wykonane = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_usun_zadanie = new System.Windows.Forms.Button();
            this.button_edytuj_zadanie = new System.Windows.Forms.Button();
            this.button_dodaj_zadanie = new System.Windows.Forms.Button();
            this.textBox_tresc_zadania = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_wyswietl_notatke = new System.Windows.Forms.Button();
            this.button_wyczysc_notatke = new System.Windows.Forms.Button();
            this.button_usun_temat = new System.Windows.Forms.Button();
            this.button_zapisz_notatke = new System.Windows.Forms.Button();
            this.textBox_tresc_notatki = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_lista_tematow = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_dodaj_temat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_tresc_tematu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label_czas_spedzony = new System.Windows.Forms.Label();
            this.label_liczba_wykonanych_zadan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_zmien_motyw = new System.Windows.Forms.Button();
            this.button_eksportuj_notatki = new System.Windows.Forms.Button();
            this.button_zamknij = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "SmartDesk";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkedListBox_lista_zadan);
            this.panel1.Controls.Add(this.listBox_zadania_wykonane);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button_usun_zadanie);
            this.panel1.Controls.Add(this.button_edytuj_zadanie);
            this.panel1.Controls.Add(this.button_dodaj_zadanie);
            this.panel1.Controls.Add(this.textBox_tresc_zadania);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 580);
            this.panel1.TabIndex = 1;
            // 
            // checkedListBox_lista_zadan
            // 
            this.checkedListBox_lista_zadan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_lista_zadan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBox_lista_zadan.FormattingEnabled = true;
            this.checkedListBox_lista_zadan.Location = new System.Drawing.Point(3, 132);
            this.checkedListBox_lista_zadan.Name = "checkedListBox_lista_zadan";
            this.checkedListBox_lista_zadan.Size = new System.Drawing.Size(327, 268);
            this.checkedListBox_lista_zadan.TabIndex = 16;
            this.checkedListBox_lista_zadan.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_lista_zadan_ItemCheck);
            this.checkedListBox_lista_zadan.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_lista_zadan_SelectedIndexChanged);
            // 
            // listBox_zadania_wykonane
            // 
            this.listBox_zadania_wykonane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_zadania_wykonane.Font = new System.Drawing.Font("Arial", 10.2F);
            this.listBox_zadania_wykonane.FormattingEnabled = true;
            this.listBox_zadania_wykonane.ItemHeight = 19;
            this.listBox_zadania_wykonane.Location = new System.Drawing.Point(3, 424);
            this.listBox_zadania_wykonane.Name = "listBox_zadania_wykonane";
            this.listBox_zadania_wykonane.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_zadania_wykonane.Size = new System.Drawing.Size(327, 135);
            this.listBox_zadania_wykonane.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(2, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Zadania zakończone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(2, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Zadania do wykonania";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(2, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Dodaj/edytuj/usuń zadanie";
            // 
            // button_usun_zadanie
            // 
            this.button_usun_zadanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_usun_zadanie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_usun_zadanie.FlatAppearance.BorderSize = 1;
            this.button_usun_zadanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_usun_zadanie.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usun_zadanie.Location = new System.Drawing.Point(251, 80);
            this.button_usun_zadanie.Name = "button_usun_zadanie";
            this.button_usun_zadanie.Size = new System.Drawing.Size(79, 29);
            this.button_usun_zadanie.TabIndex = 5;
            this.button_usun_zadanie.Text = "USUŃ";
            this.button_usun_zadanie.UseVisualStyleBackColor = false;
            this.button_usun_zadanie.Click += new System.EventHandler(this.button_usun_zadanie_Click);
            // 
            // button_edytuj_zadanie
            // 
            this.button_edytuj_zadanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_edytuj_zadanie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_edytuj_zadanie.FlatAppearance.BorderSize = 1;
            this.button_edytuj_zadanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edytuj_zadanie.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edytuj_zadanie.Location = new System.Drawing.Point(173, 80);
            this.button_edytuj_zadanie.Name = "button_edytuj_zadanie";
            this.button_edytuj_zadanie.Size = new System.Drawing.Size(75, 29);
            this.button_edytuj_zadanie.TabIndex = 4;
            this.button_edytuj_zadanie.Text = "EDYTUJ";
            this.button_edytuj_zadanie.UseVisualStyleBackColor = false;
            this.button_edytuj_zadanie.Click += new System.EventHandler(this.button_edytuj_zadanie_Click);
            // 
            // button_dodaj_zadanie
            // 
            this.button_dodaj_zadanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_dodaj_zadanie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_dodaj_zadanie.FlatAppearance.BorderSize = 1;
            this.button_dodaj_zadanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dodaj_zadanie.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj_zadanie.Location = new System.Drawing.Point(3, 80);
            this.button_dodaj_zadanie.Name = "button_dodaj_zadanie";
            this.button_dodaj_zadanie.Size = new System.Drawing.Size(167, 29);
            this.button_dodaj_zadanie.TabIndex = 3;
            this.button_dodaj_zadanie.Text = "DODAJ ZADANIE";
            this.button_dodaj_zadanie.UseVisualStyleBackColor = false;
            this.button_dodaj_zadanie.Click += new System.EventHandler(this.button_dodaj_zadanie_Click);
            // 
            // textBox_tresc_zadania
            // 
            this.textBox_tresc_zadania.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tresc_zadania.Font = new System.Drawing.Font("Arial", 10.2F);
            this.textBox_tresc_zadania.Location = new System.Drawing.Point(3, 49);
            this.textBox_tresc_zadania.Name = "textBox_tresc_zadania";
            this.textBox_tresc_zadania.Size = new System.Drawing.Size(327, 27);
            this.textBox_tresc_zadania.TabIndex = 2;
            this.textBox_tresc_zadania.TextChanged += new System.EventHandler(this.textBox_tresc_zadania_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "PANEL ZADAŃ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_wyswietl_notatke);
            this.panel2.Controls.Add(this.button_wyczysc_notatke);
            this.panel2.Controls.Add(this.button_usun_temat);
            this.panel2.Controls.Add(this.button_zapisz_notatke);
            this.panel2.Controls.Add(this.textBox_tresc_notatki);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox_lista_tematow);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button_dodaj_temat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_tresc_tematu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(353, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 580);
            this.panel2.TabIndex = 2;
            // 
            // button_wyswietl_notatke
            // 
            this.button_wyswietl_notatke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_wyswietl_notatke.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_wyswietl_notatke.FlatAppearance.BorderSize = 1;
            this.button_wyswietl_notatke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_wyswietl_notatke.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyswietl_notatke.Location = new System.Drawing.Point(6, 546);
            this.button_wyswietl_notatke.Name = "button_wyswietl_notatke";
            this.button_wyswietl_notatke.Size = new System.Drawing.Size(144, 29);
            this.button_wyswietl_notatke.TabIndex = 13;
            this.button_wyswietl_notatke.Text = "WYŚWIETL";
            this.button_wyswietl_notatke.UseVisualStyleBackColor = false;
            this.button_wyswietl_notatke.Click += new System.EventHandler(this.button_wyswietl_notatke_Click);
            // 
            // button_wyczysc_notatke
            // 
            this.button_wyczysc_notatke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_wyczysc_notatke.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_wyczysc_notatke.FlatAppearance.BorderSize = 1;
            this.button_wyczysc_notatke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_wyczysc_notatke.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyczysc_notatke.Location = new System.Drawing.Point(158, 546);
            this.button_wyczysc_notatke.Name = "button_wyczysc_notatke";
            this.button_wyczysc_notatke.Size = new System.Drawing.Size(144, 29);
            this.button_wyczysc_notatke.TabIndex = 12;
            this.button_wyczysc_notatke.Text = "WYCZYŚĆ";
            this.button_wyczysc_notatke.UseVisualStyleBackColor = false;
            this.button_wyczysc_notatke.Click += new System.EventHandler(this.button_wyczysc_notatke_Click);
            // 
            // button_usun_temat
            // 
            this.button_usun_temat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_usun_temat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_usun_temat.FlatAppearance.BorderSize = 1;
            this.button_usun_temat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_usun_temat.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usun_temat.Location = new System.Drawing.Point(311, 103);
            this.button_usun_temat.Name = "button_usun_temat";
            this.button_usun_temat.Size = new System.Drawing.Size(145, 29);
            this.button_usun_temat.TabIndex = 11;
            this.button_usun_temat.Text = "USUŃ TEMAT";
            this.button_usun_temat.UseVisualStyleBackColor = false;
            this.button_usun_temat.Click += new System.EventHandler(this.button_usun_temat_Click);
            // 
            // button_zapisz_notatke
            // 
            this.button_zapisz_notatke.BackColor = System.Drawing.SystemColors.Window;
            this.button_zapisz_notatke.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_zapisz_notatke.FlatAppearance.BorderSize = 1;
            this.button_zapisz_notatke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zapisz_notatke.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zapisz_notatke.Location = new System.Drawing.Point(310, 546);
            this.button_zapisz_notatke.Name = "button_zapisz_notatke";
            this.button_zapisz_notatke.Size = new System.Drawing.Size(146, 29);
            this.button_zapisz_notatke.TabIndex = 7;
            this.button_zapisz_notatke.Text = "ZAPISZ";
            this.button_zapisz_notatke.UseVisualStyleBackColor = false;
            this.button_zapisz_notatke.Click += new System.EventHandler(this.button_zapisz_notatke_Click);
            // 
            // textBox_tresc_notatki
            // 
            this.textBox_tresc_notatki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tresc_notatki.Font = new System.Drawing.Font("Arial", 10.2F);
            this.textBox_tresc_notatki.Location = new System.Drawing.Point(3, 157);
            this.textBox_tresc_notatki.Multiline = true;
            this.textBox_tresc_notatki.Name = "textBox_tresc_notatki";
            this.textBox_tresc_notatki.Size = new System.Drawing.Size(453, 383);
            this.textBox_tresc_notatki.TabIndex = 10;
            this.textBox_tresc_notatki.TextChanged += new System.EventHandler(this.textBox_tresc_notatki_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dodaj/edytuj notatkę";
            // 
            // comboBox_lista_tematow
            // 
            this.comboBox_lista_tematow.Font = new System.Drawing.Font("Arial", 10.2F);
            this.comboBox_lista_tematow.FormattingEnabled = true;
            this.comboBox_lista_tematow.Location = new System.Drawing.Point(3, 103);
            this.comboBox_lista_tematow.Name = "comboBox_lista_tematow";
            this.comboBox_lista_tematow.Size = new System.Drawing.Size(302, 27);
            this.comboBox_lista_tematow.TabIndex = 8;
            this.comboBox_lista_tematow.SelectedIndexChanged += new System.EventHandler(this.comboBox_lista_tematow_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Wybierz temat\r\n";
            // 
            // button_dodaj_temat
            // 
            this.button_dodaj_temat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_dodaj_temat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_dodaj_temat.FlatAppearance.BorderSize = 1;
            this.button_dodaj_temat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dodaj_temat.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj_temat.Location = new System.Drawing.Point(311, 50);
            this.button_dodaj_temat.Name = "button_dodaj_temat";
            this.button_dodaj_temat.Size = new System.Drawing.Size(145, 29);
            this.button_dodaj_temat.TabIndex = 6;
            this.button_dodaj_temat.Text = "DODAJ TEMAT";
            this.button_dodaj_temat.UseVisualStyleBackColor = false;
            this.button_dodaj_temat.Click += new System.EventHandler(this.button_dodaj_temat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(2, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dodawanie tematu\r\n";
            // 
            // textBox_tresc_tematu
            // 
            this.textBox_tresc_tematu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tresc_tematu.Font = new System.Drawing.Font("Arial", 10.2F);
            this.textBox_tresc_tematu.Location = new System.Drawing.Point(3, 50);
            this.textBox_tresc_tematu.Name = "textBox_tresc_tematu";
            this.textBox_tresc_tematu.Size = new System.Drawing.Size(302, 27);
            this.textBox_tresc_tematu.TabIndex = 3;
            this.textBox_tresc_tematu.TextChanged += new System.EventHandler(this.textBox_tresc_tematu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "NAUKA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label_czas_spedzony);
            this.panel3.Controls.Add(this.label_liczba_wykonanych_zadan);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(821, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 580);
            this.panel3.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(19, 543);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 30);
            this.label14.TabIndex = 17;
            this.label14.Text = "Autor:\r\nSzymon Elendt";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_czas_spedzony
            // 
            this.label_czas_spedzony.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_czas_spedzony.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_czas_spedzony.Location = new System.Drawing.Point(19, 167);
            this.label_czas_spedzony.Name = "label_czas_spedzony";
            this.label_czas_spedzony.Size = new System.Drawing.Size(111, 35);
            this.label_czas_spedzony.TabIndex = 16;
            this.label_czas_spedzony.Text = "0";
            this.label_czas_spedzony.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_liczba_wykonanych_zadan
            // 
            this.label_liczba_wykonanych_zadan.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_liczba_wykonanych_zadan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_liczba_wykonanych_zadan.Location = new System.Drawing.Point(19, 82);
            this.label_liczba_wykonanych_zadan.Name = "label_liczba_wykonanych_zadan";
            this.label_liczba_wykonanych_zadan.Size = new System.Drawing.Size(111, 37);
            this.label_liczba_wykonanych_zadan.TabIndex = 15;
            this.label_liczba_wykonanych_zadan.Text = "0";
            this.label_liczba_wykonanych_zadan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_liczba_wykonanych_zadan.Click += new System.EventHandler(this.label_liczba_wykonanych_zadan_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(22, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 30);
            this.label11.TabIndex = 14;
            this.label11.Text = "Czas spędzony \r\nna nauce:\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(19, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 47);
            this.label10.TabIndex = 13;
            this.label10.Text = "Liczba wykonanych\r\nzadań:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(-1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "STATYSTYKI";
            // 
            // button_zmien_motyw
            // 
            this.button_zmien_motyw.BackColor = System.Drawing.Color.Gray;
            this.button_zmien_motyw.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_zmien_motyw.FlatAppearance.BorderSize = 1;
            this.button_zmien_motyw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zmien_motyw.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zmien_motyw.ForeColor = System.Drawing.Color.White;
            this.button_zmien_motyw.Location = new System.Drawing.Point(768, 9);
            this.button_zmien_motyw.Name = "button_zmien_motyw";
            this.button_zmien_motyw.Size = new System.Drawing.Size(100, 45);
            this.button_zmien_motyw.TabIndex = 5;
            this.button_zmien_motyw.Text = "ZMIEŃ MOTYW";
            this.button_zmien_motyw.UseVisualStyleBackColor = false;
            this.button_zmien_motyw.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_eksportuj_notatki
            // 
            this.button_eksportuj_notatki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_eksportuj_notatki.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_eksportuj_notatki.FlatAppearance.BorderSize = 1;
            this.button_eksportuj_notatki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eksportuj_notatki.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_eksportuj_notatki.Location = new System.Drawing.Point(600, 9);
            this.button_eksportuj_notatki.Name = "button_eksportuj_notatki";
            this.button_eksportuj_notatki.Size = new System.Drawing.Size(162, 45);
            this.button_eksportuj_notatki.TabIndex = 6;
            this.button_eksportuj_notatki.Text = "EKSPORTUJ NOTATKI";
            this.button_eksportuj_notatki.UseVisualStyleBackColor = false;
            this.button_eksportuj_notatki.Click += new System.EventHandler(this.button_eksportuj_notatki_Click);
            // 
            // button_zamknij
            // 
            this.button_zamknij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_zamknij.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_zamknij.FlatAppearance.BorderSize = 1;
            this.button_zamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zamknij.Font = new System.Drawing.Font("Candara", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zamknij.Location = new System.Drawing.Point(874, 9);
            this.button_zamknij.Name = "button_zamknij";
            this.button_zamknij.Size = new System.Drawing.Size(96, 45);
            this.button_zamknij.TabIndex = 7;
            this.button_zamknij.Text = "ZAMKNIJ";
            this.button_zamknij.UseVisualStyleBackColor = false;
            this.button_zamknij.Click += new System.EventHandler(this.button_zamknij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.button_zamknij);
            this.Controls.Add(this.button_eksportuj_notatki);
            this.Controls.Add(this.button_zmien_motyw);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartDesk – inteligentny pulpit ucznia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_dodaj_zadanie;
        private System.Windows.Forms.TextBox textBox_tresc_zadania;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_usun_zadanie;
        private System.Windows.Forms.Button button_edytuj_zadanie;
        private System.Windows.Forms.TextBox textBox_tresc_tematu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_dodaj_temat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_usun_temat;
        private System.Windows.Forms.Button button_zapisz_notatke;
        private System.Windows.Forms.TextBox textBox_tresc_notatki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_lista_tematow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_wyswietl_notatke;
        private System.Windows.Forms.Button button_wyczysc_notatke;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_liczba_wykonanych_zadan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_czas_spedzony;
        private System.Windows.Forms.CheckedListBox checkedListBox_lista_zadan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox_zadania_wykonane;
        private System.Windows.Forms.Button button_zmien_motyw;
        private System.Windows.Forms.Button button_eksportuj_notatki;
        private System.Windows.Forms.Button button_zamknij;
    }
}