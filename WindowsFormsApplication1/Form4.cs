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
    public partial class FUZ2 : Form
    {
        public FUZ2()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/FUZ2 NEU 010315/FUZ2_Hild_Montageanleitung_1.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/FUZ2 NEU 010315/TST FUZ2p-HD V07-01-03EDBFT Deutsch_Ebene4_incl Anhänge.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/FUZ2 NEU 010315/FUZ2-A-B-C-CX_Montageanleitung_3_Englisch.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Platzhalter
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/FUZ2 NEU 010315/Rückseite Schaltplan FUZ-2 allgemein.pdf");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Platzhalter
        }

        private void button7_Click(object sender, EventArgs e)
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
                case "Kabel GfA V2_Opto":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/FUZ2 NEU 010315/FUZ2_Kabel GfA_Opto.pdf");
                        break;
                    }
                case "Kabel GfA V2_SG15 OSE":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/FUZ2 NEU 010315/FUZ2_Kabel GfA_SG15 OSE.pdf");
                        break;
                    }
                case "Kabel MfZ Antrieb_Opto":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/FUZ2 NEU 010315/FUZ2_Kabel MfZ_Opto.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "2,4 GHz GfA V2_Opto":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/FUZ2 NEU 010315/FUZ2_2,4GHz_GfA_Opto.pdf");
                        break;
                    }
                case "2,4 GHz GfA V2_SG15 OSE":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/FUZ2 NEU 010315/FUZ2_2,4GHz_GfA_SG15 OSE.pdf");
                        break;
                    }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/TX2/TX2 NEU 010415/GVK Erweiterungsplatine pur.pdf");
        }
    }
}
