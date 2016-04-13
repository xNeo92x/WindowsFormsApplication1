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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\neue website\Index\Schaltpläne\TX2\TX2 allgemein\Comforttronic Digital TX2_09.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\neue website\Index\Schaltpläne\TX2\TX2 allgemein\Digital TX2 Französisch.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\neue website\Index\Schaltpläne\TX2\TX2 allgemein\Comforttronic_Digital_TX2_07_ENG-NEU.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\neue website\Index\Schaltpläne\TX2\TX2 allgemein\Parameterliste TST WU2-HD V07-02-24EDBF Deutsch_Ebene4.pdf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\neue website\Index\Schaltpläne\TX2\TX2 NEU 010415/Rückseite Schaltplan TX2 allgemein.pdf");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\neue website\Index\Schaltpläne\TX2\TX2 NEU 010415\GVK Erweiterungsplatine NEU.pdf");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form form = new Übersicht();
            form.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {

                case "Kabel 1.0 V2_Opto_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel 1.0_Opto_GfA.pdf");
                        break;
                    }
                case "Kabel 1.0_Opto_MfZ Antrieb":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel 1.0_Opto_MfZ.pdf");
                        break;
                    }
                case "Kabel 1.0 V2_SG15 OSE_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel 1.0_SG15OSE_GfA.pdf");
                        break;
                    }
                case "Kabel 2.0 V2_Opto_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel 2.0_Einzugssicherung_Opto_GfA.pdf");
                        break;
                    }
                case "Kabel 2.0 V2_Rolltor/Rollgitter (MfZ-Dose)_Opto_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel 2.0_Einzugssicherung_Opto(MfZ Dose)_ GfA.pdf");
                        break;
                    }
                case "Kabel 3.0 V2_Fingerklemmschutz_Opto_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel 3.0_Fingerklemmschutz_Opto_ GfA.pdf");
                        break;
                    }
                case "Kabel 3.0 V2_Fingerklemmschutz und Einzugssicherung_Opto_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel 3.0_Fingerklemmschutz und Einzugssicherung_Opto_ GfA.pdf");
                        break;
                    }
                case "Kabel 3.0 V2_Fingerklemmschutz_SG15 OSE_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel 3.0_Fingerklemmschutz_SG15OSE_ GfA.pdf");
                        break;
                    }
                case "Kabel Hubstaffeltor V2_Opto_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel Hubstaffel_Opto_ GfA.pdf");
                        break;
                    }
                case "Kabel GVK V2_Opto_GfA mit Erweiterungsplatine":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel GVK_Opto_ GfA_incl Erweiterungsplatine.pdf");
                        break;
                    }
                case "Kabel Nocke V2_Opto_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel Nocke_Opto_ GfA.pdf");
                        break;
                    }
                case "Kabel Nocke V2_SG15 OSE_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 Kabel Nocke_SG15OSE_ GfA.pdf");
                        break;
                    }
                case "Zusatzplan TX2 mit Laserscanner LZR an Rollgitter_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/LZR mit Überwachung Öffnung TX2_Rollgitter_GVK V2_BEA Laserscanner_GfA Antrieb.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {

                case "2,4 GHz 1.0 V2_Opto_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 2,4GHz 1.0_Opto_GfA.pdf");
                        break;
                    }
                case "2,4 GHz 1.0 V2_SG15 OSE_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 2,4GHz 1.0_SG15OSE_GfA.pdf");
                        break;
                    }
                case "2,4 GHz 1.0 V2_Opto_GfA_el.Verriegelung EffEff 1841":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 2,4GHz 1.0_Opto_GfA_ElVerriegelungEffEff1841.pdf");
                        break;
                    }
                case "2,4 GHz 1.0_Master Slave Opto Klimator_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 2,4GHz 1.0_Master Slave Opto_Klimator_GfA.pdf");
                        break;
                    }
                case "2,4 GHz 3.0_Fingerklemmschutz_SG15OSE_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 2,4GHz 3.0_Fingerklemmschutz_SG15OSE_GfA.pdf");
                        break;
                    }
                case "2,4 GHz Hubstaffel_Opto_GfA":
                    {
                        Process.Start(@"C:/neue website/Index/Schaltpläne/TX2/TX2 NEU 010415/TX2 2,4GHz Hubstaffel_Opto_GfA.pdf");
                        break;
                    }
            }
        }
    }
}
