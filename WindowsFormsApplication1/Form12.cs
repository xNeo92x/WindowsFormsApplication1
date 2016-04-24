using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ASFneu : Form
    {
        public ASFneu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Keyence/I ASF NEU Keyence Lichtschranke ohne Schlupftür Antrieb Außen Außenflügel.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Übersicht();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Keyence/II ASF NEU Keyence ohne Schlupftür Antrieb Außen Innenflügel.pdf");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Keyence/III ASF NEU Keyence ohne Schlupftür Antrieb Innen Innenflügel.pdf");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Keyence/IV- ASF NEU Keyence ohne Schlupftür Antrieb Innen Außenflügel.pdf");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Keyence/I-I ASF Keyence mit Schlupftür links Außenflügel Antrieb Außen Außenflügel.pdf");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Keyence/I-III ASF Keyence mit Schlupftür rechts Mittelflügel (von Innen gesehen) Antrieb Außen Außenflügel mit Einweglichtschranke.pdf");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Keyence/II-III ASF Keyence mit Schlupftür Innenflügel rechts  Antrieb Außen Innenflügel.pdf");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Keyence/IV-III ASF mit Schlupftür rechts Mittelflügel Antrieb Innen Außenflügel.pdf");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Keyence/II-IV ASF Keyence mit Schlupftür Außenflügel rechts  Antrieb Außen Innenflügel.pdf");
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/ASF I Bemassung A3.pdf");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Bedienugsanleitungen div/Comforttronic WS-AF.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/ASF Tore/Steuerung ASF Test Parameter.pdf");
        }
    }
}