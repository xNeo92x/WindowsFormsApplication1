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
    public partial class Becker : Form
    {
        public Becker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Kabel 1.1":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TX2/BeckerAntriebe/Optisch oderElektrische  UK/Digital TX2_Kabel_1.1_Becker.pdf");
                        break;
                    }
                case "Kabel 2.1":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TX2/BeckerAntriebe/Optisch oderElektrische  UK/Digital TX2_Kabel_2.1_Becker.pdf");
                        break;
                    }
                case "Kabel 3.1":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TX2/BeckerAntriebe/Optisch oderElektrische  UK/Digital TX2_Kabel_3.1_Becker.pdf");
                        break;
                    }
                case "Kabel Hubstaffel":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TX2/BeckerAntriebe/Optisch oderElektrische  UK/TX2_Kabel_Hubstaffel_1.1_Becker.pdf");
                        break;
                    }
                case "Kabel GVK 1.1":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TX2/BeckerAntriebe/Optisch oderElektrische  UK/TX2_Kabel_GVK_1.1_Becker.pdf");
                        break;
                    }
                case "Kabel 1.1 Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TX2/BeckerAntriebe/Niedrigschwelle/TX2_Kabel_1.1_Becker_Niedrigschwelle.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Kabel 1.1":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TM 1/Becker Antriebe/Digital TM1_Kabel_A 1.1_Becker.pdf");
                        break;
                    }
                case "Kabel Hubstaffel":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/TM 1/Becker Antriebe/Digital TM1_Kabel_Hubst. Becker.pdf");
                        break;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Kabel opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Becker Antriebe/Kabel/1,5 KW,Kunststoffgeh_Kabel_alte Schlupftür.pdf");
                        break;
                    }
                case "Kabel Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Becker Antriebe/Kabel/1,5 KW,Kunststoffgeh_Kabel_Niedrigschwelle_Becker_alter Schlaffseilsch.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Becker Antriebe/2,4GHz/TST FUS-1-CX_1,5 KW, Kunststoffgeh_2,4 GHz_mechan. Schlaffseilsch. Becker.pdf");
                        break;
                    }
                case "2,4GHz Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Kunststoffgehäuse/Becker Antriebe/2,4GHz/1,5 KW, Kunststoffgeh_2,4 GHz_mechan. Schlaffs._Niedrigschw. Becker.pdf");
                        break;
                    }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedItem.ToString())
            {
                case "Kabel opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Becker Antriebe/Kabel/TST FUE-2-C_1,5 KW, Stahlgeh_Kabel_mechan.Schlaffs. Becker.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Becker Antriebe/2,4GHz/TST FUE-2-C_1,5 KW, Stahlgeh_2,4 GHz_mechan.Schlaffseil. Becker.pdf");
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
    }
}
