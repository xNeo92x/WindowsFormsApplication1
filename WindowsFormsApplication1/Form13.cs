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
    public partial class DiverseBe : Form
    {
        public DiverseBe()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "'VW' Schaltschrank Schranktür":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Schaltschrank Bemassung VW Schaltschrank Schranktür.pdf");
                        break;
                    }
                case "'VW' Schaltschrank Schrank Innen":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Schaltschrank Bemassung VW Schaltschrank innen.pdf");
                        break;
                    }
                case "'VW' Schaltschrank Bohrungen Einführungsblech (von Innen gesehen)":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Schaltschrank Bemassung VW Bohrung Einführungsblech Ansicht von innen für Bohrung.pdf");
                        break;
                    }
                case "Schaltschrank AE1045 Einbau TX2/TM (mit 3-fach Drucktaster)":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Bemassung TX2 in Rittalschrank AE1045.pdf");
                        break;
                    }
                case "4kW FU Schaltschrank Einbau opt. Zusatzschalter bei 2 Schaltern":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Schaltschrank Bemassung 4kW FU Stahl 2 Zusatzschalter Schranktür.pdf");
                        break;
                    }
                case "4kW FU Schaltschrank Einbau opt. Zusatzschalter bei 3 Schaltern":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Schaltschrank Bemaßung 4kW FU Stahl 3 Zusatzschalter Schranktür.pdf");
                        break;
                    }
                case "4kW FU Schaltschrank Einbau opt. Zusatzschalter bei 4 Schaltern":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Schaltschrank Bemassung 4kW FU Stahl 4 Zusatzschalter Schranktür.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Kabelübergänge divers Kunststoff Neue Ausführung":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Kabelübergänge Kunststoff Divers.pdf");
                        break;
                    }
                case "WSD-Dose GfA normaler SH Beschlag Maße optische Kontaktleiste":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Schaltleistenvorbereitung GfA normaler SH Beschlag.pdf");
                        break;
                    }
                case "WSD-Dose GfA SSH Beschlag Maße optische Kontaktleiste":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Schaltleistenvorbereitung GfA SSH Beschlag.pdf");
                        break;
                    }
                case "Torblatt 2,4GHz mit Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Bemassung 2,4GHZ mit Niedrigschwelle.pdf");
                        break;
                    }
                case "Torblatt Flashlight mit 1 Meter LED-Leiste":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Bemassung LED Flash Light 1m auf Bodensektion Torblatt.pdf");
                        break;
                    }
                case "Torblatt Flashlight mit 2 Meter LED-Leiste":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Bemassung LED Flash Light 2m auf Bodensektion Torblatt.pdf");
                        break;
                    }
                case "'Sehon'-Tür mit Rollenschalter und Kabelübergang Alte Ausführung":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Bemassung SEHON Tür mit Rollenschalter Metallübergang.pdf");
                        break;
                    }
                case "VDS Leitungen auf Torblatt Abgang immer entgegengesetzt der Anschlußseite":
                    {
                        Process.Start(@"C:/Index/Bemassungen/VDS Kabel auf Torblatt.pdf");
                        break;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Dosen für Klimatore (Maße)":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Bemassung Dosen Klimator.pdf");
                        break;
                    }
                case "Einbau Foto Sick Lichtschranke Einzugssicherung L28 S/E":
                    {
                        Process.Start(@"C:/Index/Bemassungen/Einbau-Foto Lichtschranke Sick L28.pdf");
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
