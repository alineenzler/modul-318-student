namespace MySwissTranport
{
    partial class MySwissTransport
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxVerbindungen = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelNach2 = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelVon2 = new System.Windows.Forms.Label();
            this.listBoxAbfahrt = new System.Windows.Forms.ListBox();
            this.listBoxAnkunft = new System.Windows.Forms.ListBox();
            this.listBoxDauer = new System.Windows.Forms.ListBox();
            this.textBoxVon = new System.Windows.Forms.TextBox();
            this.textBoxNach = new System.Windows.Forms.TextBox();
            this.radioButtonAnkunft = new System.Windows.Forms.RadioButton();
            this.radioButtonAbfahrt = new System.Windows.Forms.RadioButton();
            this.listBoxDropDownVon = new System.Windows.Forms.ListBox();
            this.listBoxDropDownNach = new System.Windows.Forms.ListBox();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.buttonDarkMode = new System.Windows.Forms.Button();
            this.buttonPinkMode = new System.Windows.Forms.Button();
            this.buttonNormalMode = new System.Windows.Forms.Button();
            this.labelVon = new System.Windows.Forms.Label();
            this.labelNach = new System.Windows.Forms.Label();
            this.labelDatumUhrzeit = new System.Windows.Forms.Label();
            this.labelDesign = new System.Windows.Forms.Label();
            this.groupBoxApp = new System.Windows.Forms.GroupBox();
            this.groupBoxFahrplan = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.labelStation = new System.Windows.Forms.Label();
            this.labelStationName = new System.Windows.Forms.Label();
            this.dateTimePickerUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewFahrplan = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVerbindungen.SuspendLayout();
            this.groupBoxApp.SuspendLayout();
            this.groupBoxFahrplan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFahrplan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVerbindungen
            // 
            this.groupBoxVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVerbindungen.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxVerbindungen.Controls.Add(this.listBoxAnkunft);
            this.groupBoxVerbindungen.Controls.Add(this.label11);
            this.groupBoxVerbindungen.Controls.Add(this.label10);
            this.groupBoxVerbindungen.Controls.Add(this.label9);
            this.groupBoxVerbindungen.Controls.Add(this.labelEnd);
            this.groupBoxVerbindungen.Controls.Add(this.labelNach2);
            this.groupBoxVerbindungen.Controls.Add(this.labelStart);
            this.groupBoxVerbindungen.Controls.Add(this.labelVon2);
            this.groupBoxVerbindungen.Controls.Add(this.listBoxAbfahrt);
            this.groupBoxVerbindungen.Controls.Add(this.listBoxDauer);
            this.groupBoxVerbindungen.Location = new System.Drawing.Point(13, 308);
            this.groupBoxVerbindungen.Name = "groupBoxVerbindungen";
            this.groupBoxVerbindungen.Size = new System.Drawing.Size(724, 278);
            this.groupBoxVerbindungen.TabIndex = 1;
            this.groupBoxVerbindungen.TabStop = false;
            this.groupBoxVerbindungen.Text = "Verbindungen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Dauer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ankunft";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Abfahrt";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(61, 73);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(0, 13);
            this.labelEnd.TabIndex = 20;
            // 
            // labelNach2
            // 
            this.labelNach2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNach2.AutoSize = true;
            this.labelNach2.Location = new System.Drawing.Point(7, 73);
            this.labelNach2.Name = "labelNach2";
            this.labelNach2.Size = new System.Drawing.Size(33, 13);
            this.labelNach2.TabIndex = 19;
            this.labelNach2.Text = "Nach";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(61, 40);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(0, 13);
            this.labelStart.TabIndex = 18;
            // 
            // labelVon2
            // 
            this.labelVon2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelVon2.AutoSize = true;
            this.labelVon2.Location = new System.Drawing.Point(7, 40);
            this.labelVon2.Name = "labelVon2";
            this.labelVon2.Size = new System.Drawing.Size(26, 13);
            this.labelVon2.TabIndex = 15;
            this.labelVon2.Text = "Von";
            // 
            // listBoxAbfahrt
            // 
            this.listBoxAbfahrt.FormattingEnabled = true;
            this.listBoxAbfahrt.Location = new System.Drawing.Point(171, 40);
            this.listBoxAbfahrt.Name = "listBoxAbfahrt";
            this.listBoxAbfahrt.Size = new System.Drawing.Size(133, 199);
            this.listBoxAbfahrt.TabIndex = 17;
            // 
            // listBoxAnkunft
            // 
            this.listBoxAnkunft.FormattingEnabled = true;
            this.listBoxAnkunft.Location = new System.Drawing.Point(301, 40);
            this.listBoxAnkunft.Name = "listBoxAnkunft";
            this.listBoxAnkunft.Size = new System.Drawing.Size(130, 199);
            this.listBoxAnkunft.TabIndex = 16;
            // 
            // listBoxDauer
            // 
            this.listBoxDauer.FormattingEnabled = true;
            this.listBoxDauer.Location = new System.Drawing.Point(428, 40);
            this.listBoxDauer.Name = "listBoxDauer";
            this.listBoxDauer.Size = new System.Drawing.Size(119, 199);
            this.listBoxDauer.TabIndex = 15;
            // 
            // textBoxVon
            // 
            this.textBoxVon.Location = new System.Drawing.Point(6, 52);
            this.textBoxVon.Name = "textBoxVon";
            this.textBoxVon.Size = new System.Drawing.Size(166, 20);
            this.textBoxVon.TabIndex = 0;
            this.textBoxVon.TextChanged += new System.EventHandler(this.textBoxVon_TextChanged);
            // 
            // textBoxNach
            // 
            this.textBoxNach.Location = new System.Drawing.Point(248, 52);
            this.textBoxNach.Name = "textBoxNach";
            this.textBoxNach.Size = new System.Drawing.Size(166, 20);
            this.textBoxNach.TabIndex = 1;
            this.textBoxNach.TextChanged += new System.EventHandler(this.textBoxNach_TextChanged);
            // 
            // radioButtonAnkunft
            // 
            this.radioButtonAnkunft.AutoSize = true;
            this.radioButtonAnkunft.Location = new System.Drawing.Point(642, 76);
            this.radioButtonAnkunft.Name = "radioButtonAnkunft";
            this.radioButtonAnkunft.Size = new System.Drawing.Size(62, 17);
            this.radioButtonAnkunft.TabIndex = 3;
            this.radioButtonAnkunft.Text = "Ankunft";
            this.radioButtonAnkunft.UseVisualStyleBackColor = true;
            // 
            // radioButtonAbfahrt
            // 
            this.radioButtonAbfahrt.AutoSize = true;
            this.radioButtonAbfahrt.Checked = true;
            this.radioButtonAbfahrt.Location = new System.Drawing.Point(642, 53);
            this.radioButtonAbfahrt.Name = "radioButtonAbfahrt";
            this.radioButtonAbfahrt.Size = new System.Drawing.Size(59, 17);
            this.radioButtonAbfahrt.TabIndex = 4;
            this.radioButtonAbfahrt.TabStop = true;
            this.radioButtonAbfahrt.Text = "Abfahrt";
            this.radioButtonAbfahrt.UseVisualStyleBackColor = true;
            // 
            // listBoxDropDownVon
            // 
            this.listBoxDropDownVon.FormattingEnabled = true;
            this.listBoxDropDownVon.Location = new System.Drawing.Point(6, 69);
            this.listBoxDropDownVon.Name = "listBoxDropDownVon";
            this.listBoxDropDownVon.Size = new System.Drawing.Size(166, 108);
            this.listBoxDropDownVon.TabIndex = 5;
            this.listBoxDropDownVon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxDropDownVon_MouseClick);
            // 
            // listBoxDropDownNach
            // 
            this.listBoxDropDownNach.FormattingEnabled = true;
            this.listBoxDropDownNach.Location = new System.Drawing.Point(248, 69);
            this.listBoxDropDownNach.Name = "listBoxDropDownNach";
            this.listBoxDropDownNach.Size = new System.Drawing.Size(166, 108);
            this.listBoxDropDownNach.TabIndex = 6;
            this.listBoxDropDownNach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxDropDownNach_MouseClick);
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSuchen.ForeColor = System.Drawing.Color.White;
            this.buttonSuchen.Location = new System.Drawing.Point(538, 213);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(180, 68);
            this.buttonSuchen.TabIndex = 7;
            this.buttonSuchen.Text = "Verbindungen Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = false;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // buttonDarkMode
            // 
            this.buttonDarkMode.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonDarkMode.ForeColor = System.Drawing.Color.White;
            this.buttonDarkMode.Location = new System.Drawing.Point(196, 239);
            this.buttonDarkMode.Name = "buttonDarkMode";
            this.buttonDarkMode.Size = new System.Drawing.Size(87, 42);
            this.buttonDarkMode.TabIndex = 8;
            this.buttonDarkMode.Text = "DarkMode";
            this.buttonDarkMode.UseVisualStyleBackColor = false;
            this.buttonDarkMode.Click += new System.EventHandler(this.buttonDarkMode_Click);
            // 
            // buttonPinkMode
            // 
            this.buttonPinkMode.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonPinkMode.ForeColor = System.Drawing.Color.White;
            this.buttonPinkMode.Location = new System.Drawing.Point(103, 239);
            this.buttonPinkMode.Name = "buttonPinkMode";
            this.buttonPinkMode.Size = new System.Drawing.Size(87, 42);
            this.buttonPinkMode.TabIndex = 9;
            this.buttonPinkMode.Text = "PinkMode";
            this.buttonPinkMode.UseVisualStyleBackColor = false;
            this.buttonPinkMode.Click += new System.EventHandler(this.buttonPinkMode_Click);
            // 
            // buttonNormalMode
            // 
            this.buttonNormalMode.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonNormalMode.ForeColor = System.Drawing.Color.White;
            this.buttonNormalMode.Location = new System.Drawing.Point(10, 239);
            this.buttonNormalMode.Name = "buttonNormalMode";
            this.buttonNormalMode.Size = new System.Drawing.Size(87, 42);
            this.buttonNormalMode.TabIndex = 10;
            this.buttonNormalMode.Text = "Normal";
            this.buttonNormalMode.UseVisualStyleBackColor = false;
            this.buttonNormalMode.Click += new System.EventHandler(this.buttonNormalMode_Click);
            // 
            // labelVon
            // 
            this.labelVon.AutoSize = true;
            this.labelVon.Location = new System.Drawing.Point(7, 33);
            this.labelVon.Name = "labelVon";
            this.labelVon.Size = new System.Drawing.Size(26, 13);
            this.labelVon.TabIndex = 11;
            this.labelVon.Text = "Von";
            // 
            // labelNach
            // 
            this.labelNach.AutoSize = true;
            this.labelNach.Location = new System.Drawing.Point(245, 36);
            this.labelNach.Name = "labelNach";
            this.labelNach.Size = new System.Drawing.Size(155, 13);
            this.labelNach.TabIndex = 12;
            this.labelNach.Text = "Nach (Leer lassen für Fahrplan)";
            // 
            // labelDatumUhrzeit
            // 
            this.labelDatumUhrzeit.AutoSize = true;
            this.labelDatumUhrzeit.Location = new System.Drawing.Point(498, 36);
            this.labelDatumUhrzeit.Name = "labelDatumUhrzeit";
            this.labelDatumUhrzeit.Size = new System.Drawing.Size(76, 13);
            this.labelDatumUhrzeit.TabIndex = 13;
            this.labelDatumUhrzeit.Text = "Datum/Uhrzeit";
            // 
            // labelDesign
            // 
            this.labelDesign.AutoSize = true;
            this.labelDesign.Location = new System.Drawing.Point(7, 223);
            this.labelDesign.Name = "labelDesign";
            this.labelDesign.Size = new System.Drawing.Size(40, 13);
            this.labelDesign.TabIndex = 14;
            this.labelDesign.Text = "Design";
            // 
            // groupBoxApp
            // 
            this.groupBoxApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxApp.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxApp.Controls.Add(this.dateTimePickerUhrzeit);
            this.groupBoxApp.Controls.Add(this.dateTimePickerDatum);
            this.groupBoxApp.Controls.Add(this.labelDesign);
            this.groupBoxApp.Controls.Add(this.labelDatumUhrzeit);
            this.groupBoxApp.Controls.Add(this.labelNach);
            this.groupBoxApp.Controls.Add(this.labelVon);
            this.groupBoxApp.Controls.Add(this.buttonNormalMode);
            this.groupBoxApp.Controls.Add(this.buttonPinkMode);
            this.groupBoxApp.Controls.Add(this.buttonDarkMode);
            this.groupBoxApp.Controls.Add(this.buttonSuchen);
            this.groupBoxApp.Controls.Add(this.listBoxDropDownNach);
            this.groupBoxApp.Controls.Add(this.listBoxDropDownVon);
            this.groupBoxApp.Controls.Add(this.radioButtonAbfahrt);
            this.groupBoxApp.Controls.Add(this.radioButtonAnkunft);
            this.groupBoxApp.Controls.Add(this.textBoxNach);
            this.groupBoxApp.Controls.Add(this.textBoxVon);
            this.groupBoxApp.Location = new System.Drawing.Point(13, 13);
            this.groupBoxApp.Name = "groupBoxApp";
            this.groupBoxApp.Size = new System.Drawing.Size(724, 287);
            this.groupBoxApp.TabIndex = 0;
            this.groupBoxApp.TabStop = false;
            // 
            // groupBoxFahrplan
            // 
            this.groupBoxFahrplan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxFahrplan.BackColor = System.Drawing.Color.White;
            this.groupBoxFahrplan.Controls.Add(this.dataGridViewFahrplan);
            this.groupBoxFahrplan.Controls.Add(this.labelStationName);
            this.groupBoxFahrplan.Controls.Add(this.labelStation);
            this.groupBoxFahrplan.Location = new System.Drawing.Point(744, 13);
            this.groupBoxFahrplan.Name = "groupBoxFahrplan";
            this.groupBoxFahrplan.Size = new System.Drawing.Size(339, 573);
            this.groupBoxFahrplan.TabIndex = 2;
            this.groupBoxFahrplan.TabStop = false;
            this.groupBoxFahrplan.Text = "Fahrplan";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(501, 53);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerDatum.TabIndex = 15;
            // 
            // labelStation
            // 
            this.labelStation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStation.AutoSize = true;
            this.labelStation.Location = new System.Drawing.Point(6, 34);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(43, 13);
            this.labelStation.TabIndex = 24;
            this.labelStation.Text = "Station:";
            // 
            // labelStationName
            // 
            this.labelStationName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStationName.AutoSize = true;
            this.labelStationName.Location = new System.Drawing.Point(55, 34);
            this.labelStationName.Name = "labelStationName";
            this.labelStationName.Size = new System.Drawing.Size(0, 13);
            this.labelStationName.TabIndex = 25;
            // 
            // dateTimePickerUhrzeit
            // 
            this.dateTimePickerUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerUhrzeit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerUhrzeit.Location = new System.Drawing.Point(501, 79);
            this.dateTimePickerUhrzeit.Name = "dateTimePickerUhrzeit";
            this.dateTimePickerUhrzeit.ShowUpDown = true;
            this.dateTimePickerUhrzeit.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerUhrzeit.TabIndex = 16;
            // 
            // dataGridViewFahrplan
            // 
            this.dataGridViewFahrplan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFahrplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFahrplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.To});
            this.dataGridViewFahrplan.Location = new System.Drawing.Point(9, 53);
            this.dataGridViewFahrplan.Name = "dataGridViewFahrplan";
            this.dataGridViewFahrplan.Size = new System.Drawing.Size(314, 512);
            this.dataGridViewFahrplan.TabIndex = 26;
            // 
            // Category
            // 
            this.Category.HeaderText = "Zug/Bus";
            this.Category.Name = "Category";
            // 
            // To
            // 
            this.To.HeaderText = "Nach";
            this.To.Name = "To";
            this.To.Width = 170;
            // 
            // MySwissTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1092, 601);
            this.Controls.Add(this.groupBoxFahrplan);
            this.Controls.Add(this.groupBoxVerbindungen);
            this.Controls.Add(this.groupBoxApp);
            this.Name = "MySwissTransport";
            this.Text = "MySwissTransport";
            this.groupBoxVerbindungen.ResumeLayout(false);
            this.groupBoxVerbindungen.PerformLayout();
            this.groupBoxApp.ResumeLayout(false);
            this.groupBoxApp.PerformLayout();
            this.groupBoxFahrplan.ResumeLayout(false);
            this.groupBoxFahrplan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFahrplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxVerbindungen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelNach2;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelVon2;
        private System.Windows.Forms.ListBox listBoxAbfahrt;
        private System.Windows.Forms.ListBox listBoxAnkunft;
        private System.Windows.Forms.ListBox listBoxDauer;
        private System.Windows.Forms.TextBox textBoxVon;
        private System.Windows.Forms.TextBox textBoxNach;
        private System.Windows.Forms.RadioButton radioButtonAnkunft;
        private System.Windows.Forms.RadioButton radioButtonAbfahrt;
        private System.Windows.Forms.ListBox listBoxDropDownVon;
        private System.Windows.Forms.ListBox listBoxDropDownNach;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.Button buttonDarkMode;
        private System.Windows.Forms.Button buttonPinkMode;
        private System.Windows.Forms.Button buttonNormalMode;
        private System.Windows.Forms.Label labelVon;
        private System.Windows.Forms.Label labelNach;
        private System.Windows.Forms.Label labelDatumUhrzeit;
        private System.Windows.Forms.Label labelDesign;
        private System.Windows.Forms.GroupBox groupBoxApp;
        private System.Windows.Forms.GroupBox groupBoxFahrplan;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.Label labelStationName;
        private System.Windows.Forms.DateTimePicker dateTimePickerUhrzeit;
        private System.Windows.Forms.DataGridView dataGridViewFahrplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
    }
}

