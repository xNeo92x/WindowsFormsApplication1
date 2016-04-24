using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ASFsonder : Form
    {
        public ASFsonder()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Sondertore/I-I ASF Reflexionslichtschranke mit Schlupftür links Außenflügel Antrieb Außen Außenflügel.pdf");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Sondertore/II-I ASF mit Schlupftür Außenflügel rechts Antrieb Innenflügel mit Reflexionslichtschranke.pdf");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Sondertore/II-II ASF Tor mit Reflexionslichtschranke.pdf");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Sondertore/II-III ASF Tor mit Reflexionslichtschranke.pdf");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Sondertore/II-IV ASF mit Schlupftür Außenflügel rechts  Antrieb Außen Innenflügel_mit Reflexionslichtschranke.pdf");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Sondertore/Mit TOF Taxi IV- ASF NEU Keyence ohne Schlupftür Antrieb Innen Außenflügel.pdf");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Sondertore/I-I ASF Einzelflügel links mit Schlupftür Antriebe Außen Außenflügel mit ReflLS.pdf");
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
            Process.Start(@"C:/Index/Bedienugsanleitungen div/Comforttronic WS-AF.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Steuerung ASF Test Parameter.pdf");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "I":
                    {
                        Process.Start(@"C:/Index/ASF Tore/ASF I Bemassung A3.pdf");
                        break;
                    }
                case "II":
                    {
                        Process.Start(@"C:/Index/ASF Tore/ASF II Bemassung A3.pdf");
                        break;
                    }
                case "III":
                    {
                        Process.Start(@"C:/Index/ASF Tore/ASF III Bemassung A3.pdf");
                        break;
                    }
                case "IV":
                    {
                        Process.Start(@"C:/Index/ASF Tore/ASF IV Bemassung A3.pdf");
                        break;
                    }
            }
        }
    }
}