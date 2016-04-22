using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Intern : Form
    {
        public Intern()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "VDS (Alarm) Kontakt für Tore Montagehinweis":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/VDS Kabel auf Torblatt.pdf");
                        break;
                    }
                case "VDS-C Magnetkontakt für Schlupftür":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/VDS C Kontakt Honeywell.pdf");
                        break;
                    }
                case "VDS-C Riegelschaltkontakt":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Riegelschaltkontakt VDS-C 0.08-031308.pdf");
                        break;
                    }
                case "Anweisung Fertigung Benutzung Schlupftürschalter ENS-1000 oder ENS-8201":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Anweisung Schlupftürschalter Fertigung.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Info´s zu Handsender, neue Steuerungen, Lichtgitter SG15, Garantiesiegel, Fremdanschlußbox (Mail vom 27.08.2013)":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Infoschreiben/Infoschreiben an ADM und Alle Handsender_InfoSteuerungen_LichtgitterSG15_Garantiesiegel_Fremdanschlußbox vom 27_08_2013.pdf");
                        break;
                    }
                case "Anschlußmöglichkeiten div. Steuerungen Kompatibilitätsübersicht":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Infoschreiben/Anschlußmöglichkeiten Steuerungen.pdf");
                        break;
                    }
                case "Info´s und Begrenzungen Standard Steuerung GfA TS971":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Info Standard Steuerung TS971.pdf");
                        break;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Info Telco SG15 OSE Lichtgitter mit OSE Anschluß (Mail vom 18.02.2015)":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Infoschreiben/Infoschreiben Monteure zu Telco SG15 LIGI OSE.pdf");
                        break;
                    }
                case "Hinweis Befähigung Stromanschluß Monteure (Mail vom 29.08.2013)":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Infoschreiben/Infoschreiben Stromanschluß Monteure vom 29_08_2013.pdf");
                        break;
                    }
                case "Hinweis Befähigung BG Broschüre Elektrofachkraft für festgelegte Tätigkeiten":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/BG_95.12.pdf");
                        break;
                    }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedItem.ToString())
            {
                case "Induktionsschleifen Richtungserkennung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Klarstellungen/Klarstellung Richtungserkennende Induktionsschleife.pdf");
                        break;
                    }
                case "Induktionsschleifen Querverkehrserkennung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Klarstellungen/Klarstellung Querverkehrerkennende Induktionsschleife.pdf");
                        break;
                    }
                case "Gegenseitige Verriegelung Steuerungen":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Klarstellungen/Klarstellung Gegenseitige Verriegelung.pdf");
                        break;
                    }
                case "Ampelfunktionen":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Klarstellungen/Klarstellung Ampelfunktion.pdf");
                        break;
                    }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedItem.ToString())
            {
                case "Lichtgitter SG15 Einbauanleitung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Montageanleitungen/a Montageanleitung Lichtgitter SG15.pdf");
                        break;
                    }
                case "Lichtgitter SG15 Ersatz- Ausweichprofil Einbauanleitung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Montageanleitungen/SG15 Ersatzprofil Montageanleitung.pdf");
                        break;
                    }
                case "WITT voreilende Lichtschranke":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Montageanleitungen/b Montageanleitung Witt voreilende Lichtschranke.pdf");
                        break;
                    }
                case "Garantiesiegel anbringen auf Steuerungen":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Montageanleitungen/c Montage Bothe-Hild Garantiesiegel.pdf");
                        break;
                    }
                case "Anbringung Logo Bothe-Hild auf GfA TS971":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Montageanleitungen/d Montage Bothe-Hild Aufkleber auf TS971.pdf");
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Übersicht();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}
