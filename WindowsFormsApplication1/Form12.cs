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
    }
}
