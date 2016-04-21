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
    public partial class FuStahl : Form
    {
        public FuStahl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/1,5kW Stahlgehäuse allgemein/FUE_Systemhandbuch.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/1,5kW Stahlgehäuse allgemein/FUxE_Endkunde6-1.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/1,5kW Stahlgehäuse allgemein/FUE_Anschlussplan1.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/1,5kW Stahlgehäuse allgemein/FUxE_Montageanleitung_5.pdf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/1,5kW Stahlgehäuse allgemein/RFUxE_Montage_Anleitung_4.pdf");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/4Kw FU allgemein/Parameterliste FU4_5kW neu TST FUxE-HD V07-02-07EDIPBFT Deutsch_Ebene4x.pdf");
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
                case "Kabel Schlupftür opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Spiralkabel/alte Schlupftür/TST FUE-2-C_1,5 KW, Stahlgeh_Kabel_alter Schlupftürschalter.pdf");
                        break;
                    }
                case "Kabel Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Spiralkabel/alte Schlupftür/1,5 KW, Stahlgeh_Kabel_mechan.Schlaffs. Niedrigschwelle.pdf");
                        break;
                    }
                case "Kabel opt./el. UK E.-Verriegelung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Spiralkabel/alte Schlupftür/TST FUE-2-C_1,5 KW, Stahlgeh_Kabel_E.Verriegelung.pdf");
                        break;
                    }
                case "Kabel opt./el. UK E.-Verrigelung+Rotampel":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Spiralkabel/alte Schlupftür/1,5 KW, Stahlgeh_Kabel_E.Verriegelung. Rotampel.pdf");
                        break;
                    }
                case "Kabel 8k2 Schlupftür":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Spiralkabel/8k2 Schlupftür/TST FUE-2-C_1,5 KW, Stahlgeh_Kabel_8K2 Schlupftür.pdf");
                        break;
                    }
                case "Kabel 8k2 Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Spiralkabel/8k2 Schlupftür/TST FUE-2-C_1,5 KW, Stahlgeh_Kabel_8K2 Schlupftür_Niedrigschwelle.pdf");
                        break;
                    }
                case "Kabel 8k2 Erweiterungskarte (RFUxE) RotGrün-Ampel":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Spiralkabel/8k2 Schlupftür/TST FUE-2-C_1,5 KW, Stahlgeh_Kabel_8K2 Schlupftür Erweiterungsplatine NEU Rot Grün Ampel.pdf");
                        break;
                    }
                case "Kabel 8k2 Niedrigschwelle Erweiterungskarte Rot/Grün Ampel":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Spiralkabel/8k2 Schlupftür/TST FUE-2-C_1,5 KW, Stahlgeh_Kabel_8K2 Niedrigschwelle_Schlupftür Erweiterungsplatine NEU Rot Grün Ampel.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Energiekette opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/Energiekette/alte Schlupftür/TST FUE-2-C_1,5 KW, Stahlgeh_Energiekette_mechan.Schlaffs.pdf");
                        break;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "2,4GHz opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/2,4GHz/alte Schlupftür/TST FUE-2-C_1,5 KW, Stahlgeh_2,4 GHz_mechan.Schlaffseilschalter.pdf");
                        break;
                    }
                case "2,4GHz Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/2,4GHz/alte Schlupftür/1,5 KW, Stahlgeh_2,4 GHz_mechan.Schlaffseilsch. Niedrigschwelle.pdf");
                        break;
                    }
                case "2,4GHz E.-Verriegelung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/2,4GHz/alte Schlupftür/1,5 KW, Stahlgeh_2,4 GHz_mechan.Schlaffseilsch. E.-Verriegelung.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK 8k2":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/1,5kW Stahlschrank/2,4GHz/8k2 Schlupftür/TST FUE-2-C_1,5 KW, Stahlgeh_2,4 GHz_Schlaffs.8K2.pdf");
                        break;
                    }
            }
        }
    }
}