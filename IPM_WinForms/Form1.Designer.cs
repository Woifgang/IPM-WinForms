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
            this.columnHeaderLfdNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonOeffnen
            // 
            this.buttonOeffnen.Location = new System.Drawing.Point(12, 12);
            this.buttonOeffnen.Name = "buttonOeffnen";
            this.buttonOeffnen.Size = new System.Drawing.Size(75, 23);
            this.buttonOeffnen.TabIndex = 0;
            this.buttonOeffnen.Text = "Datei öffnen";
            this.buttonOeffnen.UseVisualStyleBackColor = true;
            this.buttonOeffnen.Click += new System.EventHandler(this.buttonOeffnen_Click);
            // 
            // buttonAWLQuellcodeErzeugen
            // 
            this.buttonAWLQuellcodeErzeugen.Location = new System.Drawing.Point(12, 402);
            this.buttonAWLQuellcodeErzeugen.Name = "buttonAWLQuellcodeErzeugen";
            this.buttonAWLQuellcodeErzeugen.Size = new System.Drawing.Size(148, 23);
            this.buttonAWLQuellcodeErzeugen.TabIndex = 2;
            this.buttonAWLQuellcodeErzeugen.Text = "AWL Quellcode erzeugen";
            this.buttonAWLQuellcodeErzeugen.UseVisualStyleBackColor = true;
            // 
            // exelListView
            // 
            this.exelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLfdNummer,
            this.columnHeaderDatensatz,
            this.columnHeaderArbeitsfolge,
            this.columnHeaderBeschreibung,
            this.columnHeaderAufloesung,
            this.columnHeaderMerkmalKennung,
            this.columnHeaderMerkmalTyp,
            this.columnHeaderMerkmalEinheit});
            this.exelListView.Location = new System.Drawing.Point(12, 41);
            this.exelListView.Name = "exelListView";
            this.exelListView.Size = new System.Drawing.Size(760, 355);
            this.exelListView.TabIndex = 3;
            this.exelListView.UseCompatibleStateImageBehavior = false;
            this.exelListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDatensatz
            // 
            this.columnHeaderDatensatz.DisplayIndex = 0;
            this.columnHeaderDatensatz.Text = "Datensatz";
            // 
            // columnHeaderArbeitsfolge
            // 
            this.columnHeaderArbeitsfolge.DisplayIndex = 1;
            this.columnHeaderArbeitsfolge.Text = "Arbeitsfolge";
            this.columnHeaderArbeitsfolge.Width = 130;
            // 
            // columnHeaderBeschreibung
            // 
            this.columnHeaderBeschreibung.DisplayIndex = 2;
            this.columnHeaderBeschreibung.Text = "Beschreibung";
            this.columnHeaderBeschreibung.Width = 200;
            // 
            // columnHeaderAufloesung
            // 
            this.columnHeaderAufloesung.DisplayIndex = 3;
            this.columnHeaderAufloesung.Text = "Auflösung (Float)";
            this.columnHeaderAufloesung.Width = 100;
            // 
            // columnHeaderMerkmalKennung
            // 
            this.columnHeaderMerkmalKennung.DisplayIndex = 4;
            this.columnHeaderMerkmalKennung.Text = "Merkmalkennung";
            this.columnHeaderMerkmalKennung.Width = 100;
            // 
            // columnHeaderMerkmalTyp
            // 
            this.columnHeaderMerkmalTyp.DisplayIndex = 5;
            this.columnHeaderMerkmalTyp.Text = "Typ";
            // 
            // columnHeaderMerkmalEinheit
            // 
            this.columnHeaderMerkmalEinheit.DisplayIndex = 6;
            this.columnHeaderMerkmalEinheit.Text = "Einheit";
            // 
            // columnHeaderLfdNummer
            // 
            this.columnHeaderLfdNummer.Text = "Lfd Nr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.exelListView);
            this.Controls.Add(this.buttonAWLQuellcodeErzeugen);
            this.Controls.Add(this.buttonOeffnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ColumnHeader columnHeaderLfdNummer;
    }
}

