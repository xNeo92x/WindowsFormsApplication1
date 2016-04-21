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
    public partial class KunstAlt : Form
    {
        public KunstAlt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/1,5kW Kunststoffgehäuse allgemein/FUS-A_Inbetriebnahme9.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/1,5kW Kunststoffgehäuse allgemein/TST FUS-HD V07-03 05EDIBF_Deutsch_Ebene4.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/1,5kW Kunststoffgehäuse allgemein/FUS_Endkunde6.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/1,5kW Kunststoffgehäuse allgemein/FUS_Anschlussplan_3.pdf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/1,5kW Kunststoffgehäuse allgemein/FUS-HD_Montageanleitung_1.pdf");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Übersicht();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Kabel opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh_Kabel_alter Schlaffs.pdf");
                        break;
                    }
                case "Kabel Schlüpftür opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh.Kabel_alte Schlupftür.pdf");
                        break;
                    }
                case "Kabel opt./el. UK Lichthupe":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh.Kabel_alte Schlupftür mit Lichthupe.pdf");
                        break;
                    }
                case "Kabel opt./el. UK Lichtupe+Zwischenhalt":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh.Kabel_alte Schlupftür mit Lichthupe und SommerWinter.pdf");
                        break;
                    }
                case "Kabel opt./el. UK Schlupftür+Bircher Radar":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh.Kabel_alte Schlupftür mit Bircher Radar.pdf");
                        break;
                    }
                case "Kabel opt./el. UK E-Verriegelung, Rotampel":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh_Kabel_Rotampel_E.Verriegelung.pdf");
                        break;
                    }
                case "Kabel opt./el. UK E-Verr.+Rotampel+Schlupftür":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh_Kabel_Rotampel_E.Verriegelung_alter Schlupftürschalter.pdf");
                        break;
                    }
                case "Kabel opt./el. UK Verriegelung 2 Tore":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh_Kabel_Verriegelung 2 Tore..pdf");
                        break;
                    }
                case "Kabel Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh.Kabel_alte Schlupftür_Niedrigschwelle.pdf");
                        break;
                    }
                case "Kabel Niedrigschwelle Bircher Radar":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW Kugeh.Kabel_alte Schlupftür_Niedrigschwelle mit Bircher Radar.pdf");
                        break;
                    }
                case "Niedrigschwelle-Fingerklemmschutz":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5 KW,Kugeh_Kabel_Niedrigschwelle_Fingerklemmschutz.pdf");
                        break;
                    }
                case "Niedrigschwelle-Rolltor Schleuse":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/alte Schlupftür/1,5kW,Kugeh_Kabel_mech.Schlaffs_Rolltor Schleuse und Niedrigschwelle.pdf");
                        break;
                    }
                case "Kabel 8k2 Schlupftür":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/TST FUS-1-CX_1,5 KW,Kunststoffgeh_Kabel_8K2 Schlupftür.pdf");
                        break;
                    }
                case "Kabel 8k2 Schlupftür Zeitschließung+Zwischenhalt+Zugschalter+Lichthupe+NotAus oder Steuerung EIN/AUS":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/1,5 KW Kunststoffgeh.Kabel_8k2 NEUE Schlupftür Lichthupe SommerWinter Zeitschließung Zugschalter.pdf");
                        break;
                    }
                case "Kabel 8k2 Schlupftür Bircher Radar+Lichthupe Zeitschließung+Zwischenhalt Zugschalter":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/1,5 KW Kunststoffgeh.Kabel_8k2 NEUE Schlupftür Bircher Radar Lichthupe SommerWinter Zeitschließung Zugschalter.pdf");
                        break;
                    }
                case "Kabel 8k2 Schlupftür Lichthupe+Zwischenhalt":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/1,5 KW Kunststoffgeh.Kabel_8k2 NEUE Schlupftür mit Lichthupe und SommerWinter.pdf");
                        break;
                    }
                case "Kabel 8k2 Schlupftür Zwischenhalt+potentialfreier Kontakt an K2":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/1,5 KW Kunststoffgeh.Kabel_8k2 NEUE Schlupftür mit SommerWinter und potfreierKontakt Ausgang K2.pdf");
                        break;
                    }
                case "Kabel 8k2 Schlupftür Lichthupe+Zwischenhalt potentialfreier Kontakt an K2":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/TST FUS-1-CX_1,5 KW,Kunststoffgeh_Kabel_8K2 Schlupftür.pdf");
                        break;
                    }
                case "Kabel 8k2 Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/TST FUS-1-CX_1,5 KW,Kunststoffgeh_Kabel_Niedrigschwelle_8K2 Schlupftür.pdf");
                        break;
                    }
                case "Kabel 8k2 Niedrigschwelle Zeitschließung+Zwischenhalt+Zugschalter+Lichthupe+NotAus oder Steuerung EIN/AUS":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/1,5 KW Kunststoffgeh.Niedrigschwelle 8k2 NEUE Schlupftür Lichthupe SommerWinter Zeitschließung Zugschalter.pdf");
                        break;
                    }
                case "Niedrigschwelle 8k2 Lichthupe+Zwischenhalt":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/1,5 KW Kunststoffgeh.Niedrigschwelle 8k2 NEUE Schlupftür mit Lichthupe und SommerWinter.pdf");
                        break;
                    }
                case "Niedrigschwelle 8k2 Zeitschließung+Zugschalter":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Spiralkabel/8k2 Schlupftür/1,5 KW Kunststoffgeh.Niedrigschwelle 8k2 NEUE Schlupftür  Zeitschließung Zugschalter Innen und Aussen.SKF.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Kabel 8k2 Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Energiekette/8k2 Schlupftür/TST FUS-1-CX_1,5 KW,Kunststoffgeh_Kabel_8K2 Schlupftür_Energiekette.pdf");
                        break;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "2,4GHz opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/2,4GHz/alte Schlupftür/TST FUS-1-CX_1,5 KW, Kunststoffgeh_2,4 GHz_mechan. Schlaffseilschalter2.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK + E.-Verriegelung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/2,4GHz/alte Schlupftür/1,5 KW, 2,4 GHz, E.-Verriegelung.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK 8k2":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/2,4GHz/8k2 Schlupftür/TST FUS-1-CX_1,5 KW, Kunststoffgeh_2,4 GHz_Schlaffs.8K2.pdf");
                        break;
                    }
                case "2,4GHz Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/2,4GHz/8k2 Schlupftür/1,5 KW, Kunststoffgeh_2,4 GHz_mechan. Schlaffseilsch. Niedrischwelle.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK, Ein/Aus-Schalter, Rot/Grün-Ampel, Radar, Zeitschließung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/2,4GHz/8k2 Schlupftür/TST FUS-1-CX_1,5 KW, Kunststoffgeh_2,4 GHz_mechSchlaffs_RotGrünAmpel_Radar_Zeitschl.pdf");
                        break;
                    }
                case "2,4GHz Niedrigschwelle, Ein/Aus Schalter, Rot/Grün-Ampel, Radar, Zeitschließung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/2,4GHz/8k2 Schlupftür/TST FUS-1-CX_1,5 KW, Kunststoffgeh_2,4 GHz_Niedrigschw_mechSchlaffs_RotGrünAmpel_Radar_Zeitschl.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK, Ein/Aus-Schalter, Rot/Grün-Ampel, Radar, Zeitschließung, Reflexionslichtschranke, potentialfreier Kontakt an K3":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/2,4GHz/8k2 Schlupftür/TST FUS-1-CX_1,5 KW, Kunststoffgeh_2,4 GHz_mechSchlaffs_RotGr-374nAmpel_Radar_Zeitschl._Refl.Lichtschranke.pdf");
                        break;
                    }
                case "2,4GHz Niedrigschwelle, Ein/Aus-Schalter, Rot/Grün-Ampel, Radar, Zeitschließung, Reflexionslichtschranke, potentialfreier Kontakt an K3":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/2,4GHz/8k2 Schlupftür/TST FUS-1-CX_1,5 KW, Kunststoffgeh_2,4 GHz_Niedrigschw_mechSchlaffs_RotGr-374nAmpel_Radar_Zeitschl_Refl.Lichtschranke.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK, Ein/Aus-Schalter, Rot/Grün-Ampel, Radar, Zeitschließung, Waschhallenlichtschranke, potentialfreier Kontakt an K3":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/2,4GHz/8k2 Schlupftür/TST FUS-1-CX_1,5 KW, Kunststoffgeh_2,4 GHz_mechSchlaffs_RotGrünAmpel_Radar_Zeitschl._Einweglichtschranke WaschhalleSKF.pdf");
                        break;
                    }
            }
        }
    }
}
