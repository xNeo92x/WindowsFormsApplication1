using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Übersicht : Form
    {
        public Übersicht()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new TX2();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new vierkW();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new FuStahl();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void Übersicht_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new TM1();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new FUZ2();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new KunstAlt();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Becker();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new SG15();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new DiverseAn();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new Intern();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form = new ASFneu();
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}