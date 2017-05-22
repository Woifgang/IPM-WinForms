using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace IPM_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int ZeilenNrStart { get; set; }
        public int ZeilenNrEnde { get; set; }

        private void buttonOeffnen_Click(object sender, EventArgs e)
        {
            string pfad = " ";
            OpenFileDialog Import = new OpenFileDialog();
            Import.Filter = "Excel-Arbeitsmappe (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            if (Import.ShowDialog() == DialogResult.OK )
            {
                pfad = Import.FileName;
            }

           // int zeileNrStart = pruefeZahlAusTextbox(textBoxZeileStart, labelZeilenNrStart);
           // int zeileNrEnde = pruefeZahlAusTextbox(textBoxZeileEnde, labelZeilenNrEnde);

            leseExceltabelleEin(pfad, ZeilenNrStart, ZeilenNrEnde);
        }

       

       private void leseExceltabelleEin(string pfad, int zeilenNrStart, int zeilenNrEnde)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = false;
            Excel.Workbook wb = null;

            
            int i;

            string datensatz,                   // Spalte B
                   arbeitsfolge,                // Spalte C
                   beschreibung,                // Spalte D
                   quelle,                      // Spalte E
                   wertebereich,                // Spalte F
                   aufloesung,                  // Spalte G
                   merkmalKennung,              // Spalte H
                   zusatzInfoMerkmal,           // Spalte I
                   merkmalNummer,               // Spalte J
                   merkmalTyp,                  // Spalte K
                   merkmalEinheit,              // Spalte L
                   statusKennung,               // Spalte M
                   einheit,                     // Spalte N
                   beispiel = "";               // Spalte O

            wb = excel.Workbooks.Open(pfad);

            Excel.Sheets sheets = wb.Worksheets;
            Excel.Worksheet ws = (Excel.Worksheet)sheets.get_Item("IPM_ML12");           

            try
            {
                //for (i = 6; i <= excel.get_Range("I" + excel.Rows.Count, "I" + excel.Rows.Count).get_End(Excel.XlDirection.xlUp).Row; i++)
                for (i = zeilenNrStart; i <= zeilenNrEnde; i++)
                
                {
                    Excel.Range datensatz_e = (Excel.Range)ws.get_Range("B" + i, "B" + i);
                    Excel.Range arbeitsfolge_e = (Excel.Range)ws.get_Range("C" + i, "C" + i);
                    Excel.Range beschreibung_e = (Excel.Range)ws.get_Range("D" + i, "D" + i);
                    Excel.Range quelle_e = (Excel.Range)ws.get_Range("E" + i, "E" + i);
                    Excel.Range wertebereich_e = (Excel.Range)ws.get_Range("F" + i, "F" + i);
                    Excel.Range aufloesung_e = (Excel.Range)ws.get_Range("G" + i, "G" + i);
                    Excel.Range merkmalKennung_e = (Excel.Range)ws.get_Range("H" + i, "H" + i);
                    Excel.Range zusatzInfoMerkmal_e = (Excel.Range)ws.get_Range("I" + i, "I" + i);
                    Excel.Range merkmalNummer_e = (Excel.Range)ws.get_Range("J" + i, "J" + i);
                    Excel.Range merkmalTyp_e = (Excel.Range)ws.get_Range("K" + i, "K" + i);
                    Excel.Range merkmalEinheit_e = (Excel.Range)ws.get_Range("L" + i, "L" + i);
                    Excel.Range satusKennung_e = (Excel.Range)ws.get_Range("M" + i, "M" + i);
                    Excel.Range einheit_e = (Excel.Range)ws.get_Range("N" + i, "N" + i);
                    Excel.Range beispiel_e = (Excel.Range)ws.get_Range("O" + i, "O" + i);

                    datensatz = pruefeExcelTabelleAufLeer(datensatz_e);                     // Spalte B
                    arbeitsfolge = pruefeExcelTabelleAufLeer(arbeitsfolge_e);               // Spalte C
                    beschreibung = pruefeExcelTabelleAufLeer(beschreibung_e);               // Spalte D
                    quelle = pruefeExcelTabelleAufLeer(quelle_e);                           // Spalte E
                    wertebereich = pruefeExcelTabelleAufLeer(wertebereich_e);               // Spalte F
                    aufloesung = pruefeExcelTabelleAufLeer(aufloesung_e);                   // Spalte G
                    merkmalKennung = pruefeExcelTabelleAufLeer(merkmalKennung_e);           // Spalte H
                    zusatzInfoMerkmal = pruefeExcelTabelleAufLeer(zusatzInfoMerkmal_e);     // Spalte I
                    merkmalNummer = pruefeExcelTabelleAufLeer(merkmalNummer_e);             // Spalte J
                    merkmalTyp = pruefeExcelTabelleAufLeer(merkmalTyp_e);                   // Spalte K
                    merkmalEinheit = pruefeExcelTabelleAufLeer(merkmalEinheit_e);           // Spalte L
                    statusKennung = pruefeExcelTabelleAufLeer(satusKennung_e);              // Spalte M
                    einheit = pruefeExcelTabelleAufLeer(einheit_e);                         // Spalte N
                    beispiel = pruefeExcelTabelleAufLeer(beispiel_e);                       // Spalte O


                    ListViewItem item1 = new ListViewItem();
                        
                    item1.SubItems.Add(datensatz);
                    item1.SubItems.Add(arbeitsfolge);
                    item1.SubItems.Add(beschreibung);
                    item1.SubItems.Add(quelle);
                    item1.SubItems.Add(wertebereich);
                    item1.SubItems.Add(aufloesung);
                    item1.SubItems.Add(merkmalKennung);
                    item1.SubItems.Add(zusatzInfoMerkmal);
                    item1.SubItems.Add(merkmalNummer);
                    item1.SubItems.Add(merkmalTyp);
                    item1.SubItems.Add(merkmalEinheit);
                    item1.SubItems.Add(statusKennung);
                    item1.SubItems.Add(einheit);
                    item1.SubItems.Add(beispiel);

                    exelListView.Items.AddRange(new ListViewItem[] { item1 });                    
                }

                // Add the ListView to the control collection.
                this.Controls.Add(exelListView);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            wb.Close();

        }  
        
        private string pruefeExcelTabelleAufLeer(Excel.Range tmp_e)
        {
            string tmp = "";

            if (tmp_e.Value2 != null)
            {

                tmp = tmp_e.Value2.ToString();
            }
            else
            {
                tmp = "  ";
            }
            return tmp;
        }


        private int pruefeZahlAusTextbox(TextBox tmpBox, Label tmpLabel)
        {
            int zahl;

            while (!int.TryParse(tmpBox.Text, out zahl))
            {
                tmpLabel.Text = "Ungültige Zahl";
                tmpBox.Text = "0";
            }

            zahl = Convert.ToInt16(tmpBox.Text);
            return zahl;
        }

        private void textBoxZeileStart_TextChanged(object sender, EventArgs e)
        {
            ZeilenNrStart = pruefeZahlAusTextbox(textBoxZeileStart, labelZeilenNrStart);

        }

        private void textBoxZeileEnde_TextChanged(object sender, EventArgs e)
        {
            ZeilenNrEnde = pruefeZahlAusTextbox(textBoxZeileEnde, labelZeilenNrEnde);
        }
    }
}
