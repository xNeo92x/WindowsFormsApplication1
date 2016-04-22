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
    public partial class SG15 : Form
    {
        public SG15()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "TX2 1.1 LG SG15 Spiralkabel":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/TX2 Spiralkabel 1.1 Lichtgitter SG15.pdf");
                        break;
                    }
                case "TX2 1.1 LG SG15 Spiralkabel mit Bircher Radarmelder":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/Kabel 1.1 Lichtgitter SG15_BircherRadar.pdf");
                        break;
                    }
                case "TX2 1.1 LG SG15 Spiralkabel mit Fingerklemmschutz Keyence":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/TX2 Spiralkabel 1.1 Lichtgitter SG15_mit Fingerklemmschutz.pdf");
                        break;
                    }
                case "TX2 1.1 LG SG15 Spiralkabel mit Lichthupensteuerung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/TX2 Spiralkabel 1.1 Lichtgitter SG15_Lichthupe.pdf");
                        break;
                    }
                case "TX2 1.1 LG SG15 Spiralkabel + FlashLight":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/TX2 Spiralkabel 1.1 Lichtgitter SG15_FlashLight.pdf");
                        break;
                    }
                case "TX2 1.1 LG SG15 Energiekette":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/TX2 Energiekette 1.1 Lichtgitter SG15.pdf");
                        break;
                    }
                case "TX2 1.1 LG SG15 2,4GHz":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/TX2 2,4 GHz 1.1 LichtgitterSG15.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "1,5kW FU Kunstst. LG SG15 Spiralkabel mit Lichthupe und Sommer/Winter":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/1,5 KW Kunststoffgeh.Lichtgitter SG15_8k2Schlupftür mit Lichthupe und SommerWinter.pdf");
                        break;
                    }
                case "1,5kW FU Kunstst. LG SG15 Energiekette mit Lichthupe und Sommer/Winter":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/1,5 KW Kunststoffgeh_Energiekette_Lichtgitter SG15_8k2Schlupftür mit Lichthupe und SommerWinter.pdf");
                        break;
                    }
                case "1,5kW FU Kunstst. LG SG15 2,4GHz mit Rot/Grün-Ampel und Radar Zeitschl.":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/1,5 KW, Kunststoffgeh_2,4 GHz_Lichtgitter SG15_mechSchlaffs_RotGrünAmpel_Radar_Zeitschl.pdf");
                        break;
                    }
                case "1,5kW FU Kunstst. LG SG15 2,4GHz mit Rot/Grün-Ampel über K3 Radar Zeitschl.":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/1,5 KW, Kunststoffgeh_2,4 GHz_LichtgitterSG15_Niedrigschw_UK_RotGrünAmpel über K3_Radar_Zeitschl.pdf");
                        break;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "4kW FU Stahl LG SG15 Spiralkabel mit Zeitschließung und Bircher Radar":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/4 KW Spiralkabel_Lichtgitter SG15_Schlaffs.8K2_Zeitschl_BircherRadar.pdf");
                        break;
                    }
                case "4kW FU Stahl LG SG15 Spiralkabel mit Zeitschließung und Induktionsschleife":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/4 KW Spiralkabel_Lichtgitter SG15_Schlaffs.8K2_Zeitschl_IndSchleife.pdf");
                        break;
                    }
                case "4kW FU Stahl LG SG15 Spiralkabel mit Zeitschließung, Bircher Radar + Optosensor":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/4 KW Spiralkabel_Schlaffs.8K2_Zeitschl_Lichtgitter SG15_Bircher Radar_plus Optosensor.pdf");
                        break;
                    }
                case "4kW FU Stahl LG SG15 Spiralkabel mit Zeitschließung, Bircher Radar + Optosensor und Erweiterungsplatine":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/4 KW, Spiralkabel_Lichtgitter SG15_Zusatzplatine_Schlaffs.8K2_Zeitschl_IndSchleife_Bircher Radar_plus Optosensor.pdf");
                        break;
                    }
                case "4kW FU Stahl LG SG15 Spiralkabel mit Zeitschl., Induktionsschleife, RWA, Zugschalter, LED-FlashLight +Erweiterungsplatine":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/4 KW, Spiralkabel_Lichtgitter SG15_Zusatzplatine_Schlaffs.8K2_Zeitschl_IndSchleife_Bircher Radar_plus Optosensor.pdf");
                        break;
                    }
                case "4kW FU Stahl LG SG15 Energiekette mit Zeitschl.":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/FU3E-C_4 KW, 8k2_Energiekette_Lichtgitter SG15_Zeitschließung.pdf");
                        break;
                    }
                case "4kW FU Stahl LG SG15 Energiekette mit Zeitschl., Bircher Induktionsschleife":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/FU3E-C_4 KW, 8k2_Energiekette_Lichtgitter SG15_Zeitschließung_Induktionsschleife Bircher.pdf");
                        break;
                    }
                case "4kW FU Stahl LG SG15 Energiekette mit Zeitschl., Bircher Induktionsschleife Zugschalter, LED-FlashLight +Erweiterungsplatine":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/4 KW, 8k2_Energiekette_Lichtgitter SG15_Erweiterungsplatine_Zeitschließung_Bircher IndSchleife_FlashLight.pdf");
                        break;
                    }
                case "4kW FU Stahl LG SG15 2,4GHz mit opt. Anschlussmöglichkeiten":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/4 KW 2,4 GHz_LichtgitterSG15_Schlaffs.8K2_optionale Anschlussmöglichkeiten.pdf");
                        break;
                    }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedItem.ToString())
            {
                case "GfA TS 971 mit LG SG15 Schaltplan":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/GFA TS 971 mit Lichtgitter SG15.pdf");
                        break;
                    }
                case "GfA TS 971 mit 2 Lichtgittern SG15 Schaltplan":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/GFA TS 971 mit 2 Lichtgittern SG15.pdf");
                        break;
                    }
                case "GfA TS 971 WSD Dose mit Lichtgitter SG15 Anleitung komplett mit Anlerninfo WSD Dose und Handsender NEU":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/GfA TS971 WSD Dose mit Lichtgitter SG15 Anleitung komplett mit Anlerninfo WSD Dose und Handsender NEU.pdf");
                        break;
                    }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedItem.ToString())
            {
                case "MfZ CS300 mit LG SG15 Schaltplan":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/MfZ CS300 Aderbelegung Lichtgitter Sitron SG15.pdf");
                        break;
                    }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.SelectedItem.ToString())
            {
                case "Montageinfo SG15 OSE Beiblatt Elektro":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/MontageSchaltplan SG15 OSE.pdf");
                        break;
                    }
                case "SG15 OSE diverse Steuerungen NEU":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/Lichtgitter SG15 OSE Steuerung divers.pdf");
                        break;
                    }
                case "SG15 OSE WS-A Steuerung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/WS-A Lichtgitter Telco LIGI OSE.pdf");
                        break;
                    }
                case "SG15 OSE BDA Datenblatt":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Schaltpläne divers Lichtgitter SG15/SG 15 Lichtgitter OSE BDA Datenbaltt.pdf");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/Lichtgitter SG15 (neues Niedrigschwellenkonzept)/Lichtgitter SG15 komplett.pdf");
        }
    }
}
