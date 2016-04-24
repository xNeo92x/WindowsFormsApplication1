using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class vierkW : Form
    {
        public vierkW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/4Kw FU allgemein/FU3E_Systemhandbuch.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/4Kw FU allgemein/FUxE_Endkunde6.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/4Kw FU allgemein/FU3E_Anschlussplan1.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/4Kw FU allgemein/FUxE_Montageanleitung_5.pdf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/4Kw FU allgemein/RFUxE_Montage_Anleitung_4.pdf");
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
                case "Kabel opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/alte Schlupftür/TST FU3E-C_4 KW, Stahlgeh_Kabel_mechan. Schlaffseilschalter.pdf");
                        break;
                    }
                case "Kabel Schlupftür opt./el. UK":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/alte Schlupftür/FU3E-C_4 KW, Kabel_2 Schlupftürschalter Spiralkabel.pdf");
                        break;
                    }
                case "Kabel Niedrigschwelle alte Schlupftür mit 2 Magnetkontakten":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/alte Schlupftür/4 KW, Stahlgeh_Kabel_alter Schlupftürschalter_ Niedrigschwelle.pdf");
                        break;
                    }
                case "Kabel Rolltor":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/alte Schlupftür/TST FU3E-C_4 KW, Stahlgeh_Kabel_Rolltor.pdf");
                        break;
                    }
                case "Kabel 8k2 Schlupftür":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/8k2 Schlupftür/TST FU3E-C_4 KW, Stahlgeh_Kabel_Schlaffs.8K2.pdf");
                        break;
                    }
                case "Kabel 8k2 Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/8k2 Schlupftür/4 KW, Stahlgeh_Kabel_mechan. Schlaffseilsch.8k2 Niedrigschwelle.pdf");
                        break;
                    }
                case "Kabel 8k2 Spiralkabel mit Ölflexkabel verlängert":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/8k2 Schlupftür/TST FU3E-C_4 KW, Stahlgeh_Kabel_Schlaffs.8K2 mit VerlängerungÖlflexkabel.pdf");
                        break;
                    }
                case "Kabel 8k2 Spiralkabel Zeitschließung, Zwischenhalt, Induktionsschleife, Lichtgitter, Lichtschranke":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/8k2 Schlupftür/TST FU3E-C_4 KW, Stahlgeh_Kabel_Schlaffs.8K2_Zeitschl_IndSchleife_Lichtgitter_Lichtschranke.pdf");
                        break;
                    }
                case "Kabel 8k2 Spiralkabel Opto Zeitschließung, Zwischenhalt, Bircher Radar, Lichthupe, Zusatzplatine":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/8k2 Schlupftür/4 KW, Stahlgeh_Spiralkabel_Lichthupe_Zusatzplatine_Schlupft.8K2_Zeitschl_Zwischenhalt_Bircher Radar_Optosensor.pdf");
                        break;
                    }
                case "FlashLight + Lichtgitter 8k2":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/8k2 Schlupftür/FU3E-C_4 KW, 8k2_Spiralkabel_FlashLight_Lichtgitter.pdf");
                        break;
                    }
                case "Spiralkabel 8k2 Schlupftür Einzugssicherung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Spiralkabel/8k2 Schlupftür/TST FU3E-C_4 KW, Stahlgeh_Kabel_Einzugssicherung_Schlaffs.8K2.pdf");
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
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/alte Schlupftür/FU3E-C_4 KW, Energiekette.pdf");
                        break;
                    }
                case "Niedrigschwelle Energiekette":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/alte Schlupftür/4 KW, Stahlgeh_Energiekette_mechan. Schlaffseilsch. Niedrigschwelle.pdf");
                        break;
                    }
                case "FlashLight (LED) Energiekette":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/alte Schlupftür/FU3E-C_4 KW, Energiekette_2x Flash-Lights.pdf");
                        break;
                    }
                case "FlashLight + Lichtgitter":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/alte Schlupftür/FU3E-C_4 KW, Energiek._1 FlashLight_Lichtgitter.pdf");
                        break;
                    }
                case "Energiekette 8k2":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/FU3E-C_4 KW, 8k2_Energiekette.pdf");
                        break;
                    }
                case "Niedrigschwelle 8k2 Schlupftür Energiektte":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/4 KW, Stahlgeh_Energiekette_mechan. Schlaffseilsch8k2. Niedrigschwelle.pdf");
                        break;
                    }
                case "Lichtgitter 8k2 Energiekette":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/FU3E-C_4 KW, 8k2_Energiek._Lichtgitter.pdf");
                        break;
                    }
                case "FlashLight + Lichtgitter 8k2":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/FU3E-C_4 KW, 8k2_Energiek._FlashLight_Lichtgitter.pdf");
                        break;
                    }
                case "Energiekette + Zeitschließung Zwischenhalt +Induktionsschleife":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/FU3E-C_4 KW, 8k2_Energiekette_Zeitschließung_SommerWinter_IndSchleife.pdf");
                        break;
                    }
                case "Niedrigschwelle + Energiekette Zeitschließung+Zwischenhalt+Induktionsschleife":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/4 KW, Stahlgeh_Energiek_mechanSchlaffs_8k2_Niedrigschw_SommerWinter_Zeitschl_IndSchleife optional.pdf");
                        break;
                    }
                case "Energiekette+Zeitschließung Zwischenhalt+Induktionsschleife+Lichtgitter (Telco)":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/FU3E-C_4 KW, 8k2_Energiekette_Zeitschlie-337ung_SommerWinter_IndSchleife_LichtgitterTelco.pdf");
                        break;
                    }
                case "Energiekette+Zeitschließung Zwischenhalt+Induktionsschleife+Lichtgitter (Sick/Telco)+Flashlight":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/FU3E-C_4 KW, 8k2_Energiekette_Zeitschließung_SommerWinter_IndSchleife_LichtgitterTelco_FlashLight.pdf");
                        break;
                    }
                case "Energiekette+Erweiterungsplatine+Zeitschließung+Induktionsschleife+RWA Lichtgitter (Sick/Telco)+FlashLight+Zugschalter":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/FU3E-C_4 KW, 8k2_Energiekette_Erweiterungsplatine_Zeitschließung_RWA_Zugschalter_IndSchleife_LichtgitterTelcoElg_FlashLight.pdf");
                        break;
                    }
                case "Energiekette+Erweiterungsplatine+Zeitschließung+Induktionsschleife+Lichthupe Lichtgitter (Sick/Telco)+FlashLight+Zugschalter":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/Energiekette/8k2 Schlupftür/FU3E-C_4 KW, 8k2_Energiekette_Lichtgitter SG15_Lichthupe_Erweiterungsplatine_Zeitschließung_Zugschalter_IndSchleife_FlashLi.pdf");
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
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/2,4GHz/alte Schlupftür/TST FU3E-C_4 KW, Stahlgeh_2,4 GHz_mechan. Schlaffsseilschalter.pdf");
                        break;
                    }
                case "2,4GHz Niedrigschwelle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/2,4GHz/alte Schlupftür/4 KW, Stahlgeh_2,4 GHz_mechan. Schlaffsseilsch. Niedrigschwelle.pdf");
                        break;
                    }
                case "2,4GHz Niedrigschwelle + E.-Verriegelung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/2,4GHz/alte Schlupftür/4 KW, Stahlgeh_2,4 GHz_mechan. Schlaffsseilsch. Niedrigschwelle_E.-Verriegelung.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK 8k2":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/2,4GHz/8k2 Schlupftür/TST FU3E-C_4 KW, Stahlgeh_2,4 GHz_Schlaffs.8K2.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK 8k2 Zwischenhalt und Zeitschließung":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/2,4GHz/8k2 Schlupftür/TST FU3E-C_4 KW, Stahlgeh_2,4 GHz_Schlaffs.8K2_Zwischenhalt_Zeitschließung.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK 8k2 FlashLight über zusätzliches Spiralkabel+Lichtgitter":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/2,4GHz/8k2 Schlupftür/TST FU3E-C_4 KW, Stahlgeh_2,4 GHz_Schlaffs.8K2_FlashLight-überzusSpika_LichtgitterSchlaffs.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK 8k2 Fingerklemmschutz +FlashLight über zusätzliches Spiralkabel+Lichtgitter":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/2,4GHz/8k2 Schlupftür/TST FU3E-C_4 KW, Stahlgeh_2,4 GHz_Schlaffs.8K2_Fingerklemmschutz_FlashLight-überzusSpika_Lichtgitter.pdf");
                        break;
                    }
                case "2,4GHz opt./el. UK 8k2 Lichtschranke Sick GRSE18S für Zargeneinbau":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/4kW Stahlschrank/2,4GHz/8k2 Schlupftür/TST FU3E-C_4 KW, Stahlgeh_2,4 GHz_Schlaffs.8K2_mit Sick Lichtschranke GRSE18S.pdf");
                        break;
                    }
            }
        }
    }
}