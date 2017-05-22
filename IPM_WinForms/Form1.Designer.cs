namespace IPM_WinForms
{
    partial class Form1
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
            this.buttonOeffnen = new System.Windows.Forms.Button();
            this.buttonAWLQuellcodeErzeugen = new System.Windows.Forms.Button();
            this.exelListView = new System.Windows.Forms.ListView();
            this.columnHeaderDatensatz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArbeitsfolge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBeschreibung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAufloesung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMerkmalKennung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMerkmalTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMerkmalEinheit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxZeileStart = new System.Windows.Forms.TextBox();
            this.textBoxZeileEnde = new System.Windows.Forms.TextBox();
            this.columnHeaderQuelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWerteBereich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZusatzInfoMerkmal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMerkmalNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatusKennung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEinheit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBeispiel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZeilenNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelZeilenNrStart = new System.Windows.Forms.Label();
            this.labelZeilenNrEnde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOeffnen
            // 
            this.buttonOeffnen.Location = new System.Drawing.Point(12, 137);
            this.buttonOeffnen.Name = "buttonOeffnen";
            this.buttonOeffnen.Size = new System.Drawing.Size(75, 23);
            this.buttonOeffnen.TabIndex = 0;
            this.buttonOeffnen.Text = "Datei öffnen";
            this.buttonOeffnen.UseVisualStyleBackColor = true;
            this.buttonOeffnen.Click += new System.EventHandler(this.buttonOeffnen_Click);
            // 
            // buttonAWLQuellcodeErzeugen
            // 
            this.buttonAWLQuellcodeErzeugen.Location = new System.Drawing.Point(12, 527);
            this.buttonAWLQuellcodeErzeugen.Name = "buttonAWLQuellcodeErzeugen";
            this.buttonAWLQuellcodeErzeugen.Size = new System.Drawing.Size(148, 23);
            this.buttonAWLQuellcodeErzeugen.TabIndex = 2;
            this.buttonAWLQuellcodeErzeugen.Text = "AWL Quellcode erzeugen";
            this.buttonAWLQuellcodeErzeugen.UseVisualStyleBackColor = true;
            // 
            // exelListView
            // 
            this.exelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderZeilenNr,
            this.columnHeaderDatensatz,
            this.columnHeaderArbeitsfolge,
            this.columnHeaderBeschreibung,
            this.columnHeaderQuelle,
            this.columnHeaderWerteBereich,
            this.columnHeaderAufloesung,
            this.columnHeaderMerkmalKennung,
            this.columnHeaderZusatzInfoMerkmal,
            this.columnHeaderMerkmalNummer,
            this.columnHeaderMerkmalTyp,
            this.columnHeaderMerkmalEinheit,
            this.columnHeaderStatusKennung,
            this.columnHeaderEinheit,
            this.columnHeaderBeispiel});
            this.exelListView.Location = new System.Drawing.Point(12, 166);
            this.exelListView.Name = "exelListView";
            this.exelListView.Size = new System.Drawing.Size(1254, 355);
            this.exelListView.TabIndex = 3;
            this.exelListView.UseCompatibleStateImageBehavior = false;
            this.exelListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDatensatz
            // 
            this.columnHeaderDatensatz.Text = "Datensatz";
            // 
            // columnHeaderArbeitsfolge
            // 
            this.columnHeaderArbeitsfolge.Text = "Arbeitsfolge";
            this.columnHeaderArbeitsfolge.Width = 130;
            // 
            // columnHeaderBeschreibung
            // 
            this.columnHeaderBeschreibung.Text = "Beschreibung";
            this.columnHeaderBeschreibung.Width = 200;
            // 
            // columnHeaderAufloesung
            // 
            this.columnHeaderAufloesung.Text = "Auflösung (Float)";
            this.columnHeaderAufloesung.Width = 100;
            // 
            // columnHeaderMerkmalKennung
            // 
            this.columnHeaderMerkmalKennung.Text = "Merkmalkennung";
            this.columnHeaderMerkmalKennung.Width = 100;
            // 
            // columnHeaderMerkmalTyp
            // 
            this.columnHeaderMerkmalTyp.Text = "Typ";
            // 
            // columnHeaderMerkmalEinheit
            // 
            this.columnHeaderMerkmalEinheit.Text = "Einheit";
            // 
            // textBoxZeileStart
            // 
            this.textBoxZeileStart.Location = new System.Drawing.Point(12, 25);
            this.textBoxZeileStart.Name = "textBoxZeileStart";
            this.textBoxZeileStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxZeileStart.TabIndex = 4;
            this.textBoxZeileStart.TextChanged += new System.EventHandler(this.textBoxZeileStart_TextChanged);
            // 
            // textBoxZeileEnde
            // 
            this.textBoxZeileEnde.Location = new System.Drawing.Point(135, 25);
            this.textBoxZeileEnde.Name = "textBoxZeileEnde";
            this.textBoxZeileEnde.Size = new System.Drawing.Size(100, 20);
            this.textBoxZeileEnde.TabIndex = 5;
            this.textBoxZeileEnde.TextChanged += new System.EventHandler(this.textBoxZeileEnde_TextChanged);
            // 
            // columnHeaderQuelle
            // 
            this.columnHeaderQuelle.Text = "Quelle";
            // 
            // columnHeaderWerteBereich
            // 
            this.columnHeaderWerteBereich.Text = "Wertebereich";
            // 
            // columnHeaderZusatzInfoMerkmal
            // 
            this.columnHeaderZusatzInfoMerkmal.Text = "Zusatz Info Merkmal";
            // 
            // columnHeaderMerkmalNummer
            // 
            this.columnHeaderMerkmalNummer.Text = "Merkmal Nummer";
            // 
            // columnHeaderStatusKennung
            // 
            this.columnHeaderStatusKennung.Text = "Status Kennung";
            // 
            // columnHeaderEinheit
            // 
            this.columnHeaderEinheit.Text = "Einheit";
            // 
            // columnHeaderBeispiel
            // 
            this.columnHeaderBeispiel.Text = "Beispiel";
            // 
            // columnHeaderZeilenNr
            // 
            this.columnHeaderZeilenNr.Text = "Zeilen-Nr.";
            // 
            // labelZeilenNrStart
            // 
            this.labelZeilenNrStart.AutoSize = true;
            this.labelZeilenNrStart.Location = new System.Drawing.Point(12, 9);
            this.labelZeilenNrStart.Name = "labelZeilenNrStart";
            this.labelZeilenNrStart.Size = new System.Drawing.Size(103, 13);
            this.labelZeilenNrStart.TabIndex = 6;
            this.labelZeilenNrStart.Text = "Zeilen Nummer Start";
            // 
            // labelZeilenNrEnde
            // 
            this.labelZeilenNrEnde.AutoSize = true;
            this.labelZeilenNrEnde.Location = new System.Drawing.Point(132, 9);
            this.labelZeilenNrEnde.Name = "labelZeilenNrEnde";
            this.labelZeilenNrEnde.Size = new System.Drawing.Size(106, 13);
            this.labelZeilenNrEnde.TabIndex = 7;
            this.labelZeilenNrEnde.Text = "Zeilen Nummer Ende";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 562);
            this.Controls.Add(this.labelZeilenNrEnde);
            this.Controls.Add(this.labelZeilenNrStart);
            this.Controls.Add(this.textBoxZeileEnde);
            this.Controls.Add(this.textBoxZeileStart);
            this.Controls.Add(this.exelListView);
            this.Controls.Add(this.buttonAWLQuellcodeErzeugen);
            this.Controls.Add(this.buttonOeffnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOeffnen;
        private System.Windows.Forms.Button buttonAWLQuellcodeErzeugen;
        private System.Windows.Forms.ListView exelListView;
        private System.Windows.Forms.ColumnHeader columnHeaderDatensatz;
        private System.Windows.Forms.ColumnHeader columnHeaderArbeitsfolge;
        private System.Windows.Forms.ColumnHeader columnHeaderBeschreibung;
        private System.Windows.Forms.ColumnHeader columnHeaderAufloesung;
        private System.Windows.Forms.ColumnHeader columnHeaderMerkmalKennung;
        private System.Windows.Forms.ColumnHeader columnHeaderMerkmalTyp;
        private System.Windows.Forms.ColumnHeader columnHeaderMerkmalEinheit;
        private System.Windows.Forms.TextBox textBoxZeileStart;
        private System.Windows.Forms.TextBox textBoxZeileEnde;
        private System.Windows.Forms.ColumnHeader columnHeaderQuelle;
        private System.Windows.Forms.ColumnHeader columnHeaderWerteBereich;
        private System.Windows.Forms.ColumnHeader columnHeaderZusatzInfoMerkmal;
        private System.Windows.Forms.ColumnHeader columnHeaderMerkmalNummer;
        private System.Windows.Forms.ColumnHeader columnHeaderStatusKennung;
        private System.Windows.Forms.ColumnHeader columnHeaderEinheit;
        private System.Windows.Forms.ColumnHeader columnHeaderBeispiel;
        private System.Windows.Forms.ColumnHeader columnHeaderZeilenNr;
        private System.Windows.Forms.Label labelZeilenNrStart;
        private System.Windows.Forms.Label labelZeilenNrEnde;
    }
}

