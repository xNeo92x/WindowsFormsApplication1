using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TM1 : Form
    {
        public TM1()
        {
            InitializeComponent();
        }

        private void TM1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/TM 1/TM1 allgemein/Comforttronic Digital TM1_09.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/TM 1/TM1 allgemein/Comforttronic_Digital_TM1_09_englisch GB.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/TM 1/TM1 NEU 010415/Rückseite Schaltplan TM1 allgemein.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/TM 1/TM1 NEU 010415/Erweiterungsplatine pur.pdf");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Kabel A1.0 V2_GfA":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TM 1/TM1 NEU 010415/TM1 A1.0_GfA.pdf");
                        break;
                    }
                case "Kabel A1.0 V2_Rolltor Rollgitter_Einzugssicherung_GfA":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TM 1/TM1 NEU 010415/TM1 A1.0_RolltorGitter_Einzugssicherung_Opto_GfA.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "2,4 GHz A1.0 V2_GfA":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TM 1/TM1 NEU 010415/TM1 2,4GHz A1.0_GfA.pdf");
                        break;
                    }
                case "2,4GHz A1.0 V2_Rolltor Rollgitter_Einzugssicherung_GfA":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TM 1/TM1 NEU 010415/TM1 2,4GHz_RolltorGitter_Einzugssicherung_GfA.pdf");
                        break;
                    }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Übersicht();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}