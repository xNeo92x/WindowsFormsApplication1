using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ASFalt : Form
    {
        public ASFalt()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/I ASF ohne Schlupftür Antrieb Außen Außenflügel.pdf");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/I-III ASF mit Schlupftür rechts Mittelflügel -(von Innen gesehen-) Antrieb Außen Außenflügel.pdf");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/IV-III ASF mit Schlupftür rechts Mittelflügel Antrieb Innen Außenflügel.pdf");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/II-IV ASF mit Schlupftür Außenflügel rechts  Antrieb Außen Innenflügel.pdf");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/II ASF ohne Schlupftür Antrieb Außen Innenflügel.pdf");
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/ASF I Bemassung A3.pdf");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/III ASF ohne Schlupftür Antrieb Innen Innenflügel.pdf");
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/ASF II Bemassung A3.pdf");
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/ASF III Bemassung A3.pdf");
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/ASF IV Bemassung A3.pdf");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/I-I ASF mit Schlupftür links Außenflügel Antrieb Außen Außenflügel.pdf");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/II-I ASF mit Schluptür links Außenflügel Antrieb Außen Innenflügel.pdf");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/I-II ASF mit Schlupftür links Innenflügel Antrieb Außen Außenflügel.pdf");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/II-II ASF mit Schlupftür links Mittelflügel Antrieb Außen Innenflügel.pdf");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/I-IV ASF mit Schlupftür rechts Außenflügel (von Innen gesehen) Antrieb Außen Außenflügel mit Einweglichtschranke.pdf");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/IV-IV ASF mit Schlupftür rechts Außenflügel Antrieb Innen Außenflügel.pdf");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/II-V ASF mit  Schlupftüren Außenflügel Antrieb Außen Innenflügel.pdf");
        }
    }
}