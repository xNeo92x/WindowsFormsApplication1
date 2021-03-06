﻿using System;
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
    public partial class DiverseAn : Form
    {
        public DiverseAn()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Vitector Fraba Schaltleistenkatalog":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/VITECTOR_GeneralCatalog_DataContent.pdf");
                        break;
                    }
                case "BVT Schulungsheft":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/BVT Schulungsheft.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Theben Zeitschaltuhr TR 610, 612 top2":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Bedienungsanleitung_TR610top2_TR612top2_de.pdf");
                        break;
                    }
                case "Theben Zeitschaltuhr TR 611, 622 top2":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Bedienungsanleitung_TR611top2_TR622top2_de.pdf");
                        break;
                    }
                case "Theben Zeitschaltuhr TR 641, 642, 644 top2 (RC)":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Bedienungsanleitung_BA_TR641_644_top2_de.pdf");
                        break;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Anschlußbox Fremdfirmen Schaltplan":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Waschhallenkonzept/Anschlußbox Fremdfirmen Schaltplan.pdf");
                        break;
                    }
                case "Arbeitschrittanweisung für Umbau der Waschhallentore auf IP68 für Endkunden":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Waschhallenkonzept/Endkunden-Arbeitschrittanweisung für Umbau der Waschhallentore auf IP68.pdf");
                        break;
                    }
                case "Fremdbox Aufkleber":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Waschhallenkonzept/Fremdbox Aufkleber.pdf");
                        break;
                    }
                case "Garantiesiegel":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Waschhallenkonzept/Garantiesiegel.pdf");
                        break;
                    }
                case "MFZ CS300 Zusatzplan Lichtschranke Waschhalle":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Waschhallenkonzept/MFZ CS300 Zusatzplan Lichtschranke Waschhalle.pdf");
                        break;
                    }
                case "Waschhallenlichtschranke NEU Komplett":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Waschhallenkonzept/Waschhallenlichtschranke NEU Komplett.pdf");
                        break;
                    }
                case "Waschhallenlichtschranke an TS971XL mit Nockenendschalter-Antrieb":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/TS971 Zusatzplan Lichtschranke Waschhalle Nockenendschalter.pdf");
                        break;
                    }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedItem.ToString())
            {
                case "Sprint 550S, 550SL, Duo 500S, 650SL,Marathon 550-,800-,100SL":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Marathon Bedienungsanleitung.pdf");
                        break;
                    }
                case "Deckenantriebe Allgemeine Angaben Montagehinweise":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Deckenantriebe.pdf");
                        break;
                    }
                case "Rolltorsteuerung RDC 800":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Sommer RDC-800 Rolltorsteuerung.pdf");
                        break;
                    }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedItem.ToString())
            {
                case "CS 310":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/MfZ CS310_RevC_01_1_D.pdf");
                        break;
                    }
                case "CS 300":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/MFZ CS300_RevA_05_5_D.pdf");
                        break;
                    }
                case "Zusatz zu CS 300 AE-LE Einzugslichtschranke":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/MFZ AE-LE_mit_einer_Einzuglichtschranke.pdf");
                        break;
                    }
                case "CS 300 ME":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/MFZ CS300ME_RevA_05_5_D.pdf");
                        break;
                    }
                case "MS 400 AWG":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/MFZ MS400AWG--D--Rev01-3.pdf");
                        break;
                    }
                case "AS 1":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Torsteuerung AS 1_D_Rev01.pdf");
                        break;
                    }
                case "MfZ Spiralkabeldose":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Mfz Spikadose.pdf");
                        break;
                    }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.SelectedItem.ToString())
            {
                case "Comforttronic WS-A":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Comforttronic WS-A.pdf");
                        break;
                    }
                case "Comforttronic WS-T":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Comforttronic WS-T.pdf");
                        break;
                    }
                case "Comforttronic WS-AF (ASF Tore)":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Comforttronic WS-AF.pdf");
                        break;
                    }
                case "Ditec Antrieb DOR1BHS für ASF-Tore":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Ditec ASF-Tor Antrieb DOR1BHS.pdf");
                        break;
                    }
                case "Logico 2 Rolltorsteuerung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Logico-2-Betriebsanleitung Rolltorsteuerung.pdf");
                        break;
                    }
                case "BFT Steuerung Rigel 4":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/BFT Steuerung Rigel4.pdf");
                        break;
                    }
                case "Marantec Control 70":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Marantec Control 70.pdf");
                        break;
                    }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.SelectedItem.ToString())
            {
                case "Übersicht eingesetzte Batteriearten":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Batterien für Elektrokomponenten.pdf");
                        break;
                    }
                case "Infoblatt zu Batterie Feig 2,4GHz Dose":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/Feig GHz Dose 3,6V Batterie Xeno XL-205F.pdf");
                        break;
                    }
                case "Infoblatt zu Batterie GfA WSD Dose":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Diverse Infos/GfA WSD Dose 3,6V Batterie EEMB ER26500 Size C.pdf");
                        break;
                    }
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.SelectedItem.ToString())
            {
                case "Comforttronic Digital TX2 Anleitung Endkunde":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Feig Comforttronic Digital TX2.pdf");
                        break;
                    }
                case "Comforttronic Digital TX Anleitung Endkunde alte Steuerung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Feig Komforttronic Digital TX.pdf");
                        break;
                    }
                case "Comforttronic Digital TM Anleitung Endkunde":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Feig Comforttronic Digital TM1.pdf");
                        break;
                    }
                case "1,5kW FU Kunststoff Anleitung Endkunde":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Feig 1,5kW FU Kunststoff Endkunde.pdf");
                        break;
                    }
                case "1,5kW; 4kW; 5kW FU Stahl Anleitung Endkunde":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Feig 1,5kW 4kW 5kW FU Stahl Endkunde.pdf");
                        break;
                    }
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.SelectedItem.ToString())
            {
                case "Feig 2,4GHz Funkdose TST FSBM":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/2,4GHZ Funkdose TST FSBM_Montageanleitung_3.pdf");
                        break;
                    }
                case "Feig 2,4GHz digitaler Endschalter TST PE FSBS":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/2,4 GHZ digitaler Endschalter TST PE_FSBS_Montageanleitung_2.pdf");
                        break;
                    }
                case "Feig Verkehrsdetektor VEK Schleifendetektor 1-fach":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/1fach Schleifendetektor BES_M1E1.pdf");
                        break;
                    }
                case "Feig Verkehrsdetektor VEK Schleifendetektor 2-fach":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/2fach Schleifendetektor BES_M2E2.pdf");
                        break;
                    }
                case "Feig Verkehrsdetektor SVEKx-1 steckbarer Schleifendetektor 1/2-fach":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/TST_SVEKx-1.pdf");
                        break;
                    }
                case "Feig MWD BP Radar Betriebsanleitung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/MWD BP Radarmelder Feig Handbuch_mehrsprachig_8.pdf");
                        break;
                    }
                case "TX2 Umbau auf 230Volt Anschl.sym.-/assymetrisch":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/TX2 mit 230Volt.pdf");
                        break;
                    }
                case "Verkehrszählgerät Feig VEK CN1":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Feig VEK CN1-1.pdf");
                        break;
                    }
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox10.SelectedItem.ToString())
            {
                case "GfA TS 400 Schiebetorsteuerung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Schiebetorsteuerung TS 400.pdf");
                        break;
                    }
                case "GfA TS 902":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/TS902 Torsteuerung.pdf");
                        break;
                    }
                case "GfA TS 910":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Torsteuerung 910.pdf");
                        break;
                    }
                case "GfA TS 913":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Torsteuerung 913.pdf");
                        break;
                    }
                case "GfA TS 958":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Ecotronic TS 958.pdf");
                        break;
                    }
                case "GfA TS 959":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA TS 959.pdf");
                        break;
                    }
                case "GfA TS 960":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Torsteuerung_TS_960.pdf");
                        break;
                    }
                case "GfA TS 961":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Torsteuerung_TS_961_Software_2_6.pdf");
                        break;
                    }
                case "GfA TS 970":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GFA TS 970 BDA.pdf");
                        break;
                    }
                case "GfA TS 970 Stückliste mit Hauptschalter":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Stückliste TS970 mit Hauptschalter.pdf");
                        break;
                    }
                case "GfA TS 971":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Montageanleitung TS 971 Stand Januar 2015.pdf");
                        break;
                    }
                case "GfA TS 971 Montageanleitung Englisch":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung englisch TS 971.pdf");
                        break;
                    }
                case "GfA TS 971 Kurzanleitung Englisch":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Kurzanleitung englisch TS 971.pdf");
                        break;
                    }
                case "GfA TS 971 mit Spiralkabel-Anschlußdose Bothe-Hild":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/GfA/Zusatzplan Bothe-Hild Torblattdosen mit SpikaEnergiekette an TS971.pdf");
                        break;
                    }
                case "GfA TS 971 mit Spiralkabel-Anschlußdose Bothe-Hild und Waschhallenlichtschranke":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/GfA/TS971 Zusatzplan Lichtschranke Waschhalle +Bothe Hild Anschlußdose.pdf");
                        break;
                    }
                case "Info WSD Dose Batteriehinweis":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA WSD Dose Inbetriebnahme Batteriehinweis.pdf");
                        break;
                    }
                case "Info TS971 Neuerungen in SW-Version 1.6":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA TS 971 Neuerungen in SW 1.6.pdf");
                        break;
                    }
                case "Info TS971 Neuerungen in SW-Version 1.7":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA TS 971 Neuerungen in SW 1.7.pdf");
                        break;
                    }
                case "GfA TS 980":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Torsteuerung_TS_980.pdf");
                        break;
                    }
                case "GfA TS 981":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Montageanleitung TS 981.pdf");
                        break;
                    }
                case "GfA TS 981 Zusatzmodul SMF Statusmeldemodul":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Status Meldemodul SMF für TS 981.pdf");
                        break;
                    }
                case "GfA TS 981 Zusatzmodul SLF Schleusenfunktion":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Schleusenfunktion SLF für TS 981.pdf");
                        break;
                    }
                case "GfA TS 981 Ergänzugsmodul zu SLF Panikmodul Schleuse":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Panikmodul mit Aus-bzw. wiedereinschalten der Schleusenfunktion für TS 981 Zusatzmodul zum SLF-Modul.pdf");
                        break;
                    }
                case "GfA TS 981 / 970 Radio-Safe Modul ext. GHz Anschluß für TS 981 und 970":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA GHz extern Montageanleitung Radio Safe.pdf");
                        break;
                    }
                case "GfA HT 01":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/HT01 GfA.pdf");
                        break;
                    }
                case "GfA ST5/ST6":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/ST_ST6 GfA.pdf");
                        break;
                    }
                case "Umschlüsselungsplan alte GfA Antriebe":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Umschlüsselplan_alte_GfA_Antriebe.pdf");
                        break;
                    }
                case "GfA Doppelantriebssystem Steuerung DKE Schaltplan":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Steuerung Doppelantriebssystem_Überwachung_der Bremsen_für_Kettenrad_ELEKTROMATEN.pdf");
                        break;
                    }
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox11.SelectedItem.ToString())
            {
                case "GfA Technische Daten SE Elektromaten 5.24WS , 9.24WS, 9.15 , 9.20, 9.24 , 9.30 ,14.15 , 14.21":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Technische Daten SE 5.24 9.24 9.30 usw._ELEKTROMATEN.pdf");
                        break;
                    }
                case "GfA Montageanleitung SE 9.24-25,40":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SE 9.24-25,40.pdf");
                        break;
                    }
                case "GfA Montageanleitung SE 9.30-25,40":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SE 9.30-25,40.pdf");
                        break;
                    }
                case "GfA Montageanleitung SW 9.30-25,00 Deckenantrieb":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SW 9.30-25,00 Deckenantrieb.pdf");
                        break;
                    }
                case "GfA Montageanleitung SE 6.60-25,40":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SE 6.60-25,40.pdf");
                        break;
                    }
                case "GfA Montageanleitung SE 6.60-25,40 ER":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SE 6.60-25,40.pdf");
                        break;
                    }
                case "GfA Montageanleitung SE 6.80-25,40 ER FU":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SE 6.80 FU-25,40 ER.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 12.90-40 FU":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 12.90-40 FU.pdf");
                        break;
                    }
                case "GfA Montageanleitung SE 14.80-25,40 ER FU":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SE 14.80 FU-25,40 ER.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 10.160-40,00 FU":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 10.160 FU-40,00.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 25.15 WS-31,00":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 25.15 WS-30,00.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 25.24-31,75":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GFA Montageanleitung SI 25.24-31,75.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 15.46-31,75 FU":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 15.46-31,75.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 25.46-31,75 FU":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 25.46-31,75.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 40.10-40 IP65i":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 40.10-40 IP65i.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 60.46-55 FU":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 60.46-55 FU.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 75.24-55 FU":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 75.24-55 FU.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 100.10-55":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 100.10-55,00.pdf");
                        break;
                    }
                case "GfA Montageanleitung KE 120.24-55":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung KE 120.24-55.pdf");
                        break;
                    }
                case "GfA Montageanleitung SI 140.12-55":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung SI 140.12-55.pdf");
                        break;
                    }
                case "GfA Montagezeichnung Kettenothand":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montagezeichnung Kettenothand.pdf");
                        break;
                    }
                case "GfA Montageanleitung Waschhallenantrieb NEU abges. Nockenendschalter":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Anschlussplan Antrieb Waschhalle Nockenendschalter abgesetzt.pdf");
                        break;
                    }
                case "Waschhallenlichtschrankean TS971XL mit Nockenendschalter-Antrieb":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/TS971 Zusatzplan Lichtschranke Waschhalle Nockenendschalter.pdf");
                        break;
                    }
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox12.SelectedItem.ToString())
            {
                case "GfA Montageanleitung USV 0,85kW / 1,5kW":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA Montageanleitung USV - 0,85 kW  1,5 kW.pdf");
                        break;
                    }
                case "GfA Montageanleitung ATEX EX-Schutz Anschlußplan Barrieren für Lichtschranke etc.":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/GfA ATEX Anschluß Lichtschranken Schlaffseilschalter TS_961_Ex_Torsteuerung_außerhalb_des_Ex-Bereiches.pdf");
                        break;
                    }
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox13.SelectedItem.ToString())
            {
                case "GfA Verdrahtungen div. Lichtgitter SG15 eigene Handsender anlernen Spiralkabel an TS971 WaschhallenLS an TS971 Waschhallenantriebset":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/GfA/Sonderverkabelungen an TS971 WSD Lichtgitter SpikaBotheHild WaschhallenLS.pdf");
                        break;
                    }
                case "TS971 mit Laserscanner BEA":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/GfA/GFA TS 971 mit BEA Laserscanner.pdf");
                        break;
                    }
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox14.SelectedItem.ToString())
            {
                case "Handsender Bemassungen mit VK Preis":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Microsoft PowerPoint - Handsender Bemassungen mit VK Preis.pdf");
                        break;
                    }
                case "Neues Konzept Handsender Tedsen":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Neues Konzept Handsender Tedsen.pdf");
                        break;
                    }
                case "Tedsen Produktpalette":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Tedsen neuer Funksstandard Bebilderung.pdf");
                        break;
                    }
                case "Anlernen von Handsender Bothe-Hild bei GfA TS971":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Zusatz zu Handsendern Tedsen bei GfA TS971.pdf");
                        break;
                    }
                case "Standard Handsender 4-Kanal":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Tedsen SKR1-4MD.pdf");
                        break;
                    }
                case "Mini Handsender 2-Kanal":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Tedsen SKRJ.pdf");
                        break;
                    }
                case "Wandempfänger 4-Kanal":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Tedsen EKR1-4M.pdf");
                        break;
                    }
                case "Info einlernen des Steckempfängers 2-Kanal EKR2GAB (für Feig Steuerung)":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Tedsen Steckempfänger für Feig Steuerungen Anlernen Handsender.pdf");
                        break;
                    }
                case "Info einlernen des Steckempfängers 2-Kanal EKR2FTB (für ASF Steuerung)":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Tedsen Steckempfänger für ASF Steuerungen Anlernen Handsender.pdf");
                        break;
                    }
                case "Info einlernen des Wandempfänger 4-Kanal EKR4MDEM":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Tedsen 4Kanal Wandempfänger extern Anlernen Handsender.pdf");
                        break;
                    }
                case "Funk-Codetaster 4-Kanal SKR4CB":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Handsender NEUER STANDARD/Tedsen FunkcodeSchloss SKR4CB.pdf");
                        break;
                    }
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox15.SelectedItem.ToString())
            {
                case "Lichthupensteuerung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Lichthupensteuerung Anleitung.pdf");
                        break;
                    }
                case "Sommer 868,8 MHz Funk Wandempfänger 2-/4-Kanal":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Sommer Wand Funkempfaenger-2-4-Kanal_46358V000_MBA_latest-version.pdf");
                        break;
                    }
                case "Sommer 868,8 MHz Funk Handsender 4 Befehl":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Handsender SOMMER 868 4-Bef..pdf");
                        break;
                    }
                case "SMD Handsender 1-4 Befehl Industrie 1-100k":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/SMD Anleitung Handsender Industrie 1bis4Befehl 1bis100K.pdf");
                        break;
                    }
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox16.SelectedItem.ToString())
            {
                case "Telco Lichtgitter SG 15 Komplettschutz Zargeneinbau":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/SG_15_Lichtgitter_Prospekt_mit_OSE_2014-10.pdf");
                        break;
                    }
                case "Telco Lichtgitter SG 14 Objektschutz Zargeneinbau":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Telco SG14_Lichtgitter.pdf");
                        break;
                    }
                case "Telco Lichtgitter SG 10 Objektschutz Vorbau":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Telco SG10 Lichtgitter.pdf");
                        break;
                    }
                case "Telco Lichtgitterkatalog SG10 / SG14":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Telco-Sitron Katalog Lichtgitter SG1014.pdf");
                        break;
                    }
                case "Keyence GL-R 20 H Fingerklemmschutz Lichtgitter neue Version":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Keyence FKS GL-R 20H Anleitung.pdf");
                        break;
                    }
                case "SICK C2000 Fingerklemmschutz Lichtgitter alte Version":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Sick C2000 FKS Anleitung.pdf");
                        break;
                    }
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox17.SelectedItem.ToString())
            {
                case "SICK Einweglichtschranke WS WE 250":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Sick Einweglichtschranke SENSICK WS_WE250.pdf");
                        break;
                    }
                case "SICK Reflexionslichtschranke WL 250":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Sick Reflexionslichtschranke WL250-2R1531.pdf");
                        break;
                    }
                case "SICK Lichtschranke Einzugssicherung L28 S/E":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Sick L28S L28E.pdf");
                        break;
                    }
                case "SICK Lichtschranke Einbau in Zarge GRSE18S-P2336":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Sick Einweglichtschranke Einbau GRSE18S-P2336.pdf");
                        break;
                    }
                case "Keyence Einweglichtschranke Zargeneinbau möglich für Waschhallen mit Verstärker PX-10CP und EinwegLS PX-H72":
                    {
                        Process.Start(@"C:/Index/Schaltpläne/Waschhallenkonzept/Waschhallenlichtschranke NEU Komplett.pdf");
                        break;
                    }
                case "Carlo Cavazzi Verstärker für alte Lichtschranke Waschhalle S142ARNN924":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Lichtschranken-Waschhallenverstärker S142ARNN924_040705_ger.pdf");
                        break;
                    }
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox18.SelectedItem.ToString())
            {
                case "SICK Lichtschranke Einbau in Zarge GRSE18S-P2336":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Sick Einweglichtschranke Einbau GRSE18S-P2336.pdf");
                        break;
                    }
                case "GRSE Lichtschranke an Feig Steuerungen":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Anschluß Sick Einbau Einweg Lichtschranken FEIGSteuerungen.pdf");
                        break;
                    }
                case "GRSE Lichtschranke an GfA TS971":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Anschluß Sick Einbau Einweg Lichtschranken an TS971.pdf");
                        break;
                    }
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox19.SelectedItem.ToString())
            {
                case "WITT NOCON voreilende Lichtschranke für Schließkantensicherung Sektional - und Rolltore bis 8m Breite nur mit Spiralkabel oder Energiekette":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Witt NOCON voreilende Schliesskantensicherung Sektionaltor und Rolltor.pdf");
                        break;
                    }
                case "WITT NOCON Montageanleitung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/WITT Montageanleitung komplett für voreilende Lichtschranke.pdf");
                        break;
                    }
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox20.SelectedItem.ToString())
            {
                case "Bircher Radar Herkules Dokumentation":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Bircher Radar Herkules Dokumentation.pdf");
                        break;
                    }
                case "Bircher Radar Herkules Betriebsanleitung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Bircher Radar Herkules_2_Betriebsanleitung_d_e_f.pdf");
                        break;
                    }
                case "Bircher Radar Herkules Einstellungen":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Bircher Radar Herkules Einstellungen_d.pdf");
                        break;
                    }
                case "BEA Condor Radar Betriebsanleitung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/BEA Condor_de_v2.pdf");
                        break;
                    }
                case "BEA Milan Anwesenheitssensor Betriebsanleitung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/BEA Milan Anleitung.pdf");
                        break;
                    }
                case "BEA LZR l100/l110 Laserscanner/Anleitung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/BEA LZR100 LaserScanner.pdf");
                        break;
                    }
                case "Feig MWD BP Radar Betriebsanleitung":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/MWD BP Radarmelder Feig Handbuch_mehrsprachig_8.pdf");
                        break;
                    }
                case "Cedes TOF/TAXI Absicherung Türblatt":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Cedes TOF TAXI.pdf");
                        break;
                    }
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox21.SelectedItem.ToString())
            {
                case "Bircher ProLoop2 (NEU) Induktionsschleifendetektor 1-fach und 2-fach":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Bircher Schleifendetektor 24Volt ProLoop2 1und2Kanal_de.pdf");
                        break;
                    }
                case "Feig Verkehrsdetektor VEK Schleifendetektor 1-fach":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/1fach Schleifendetektor BES_M1E1.pdf");
                        break;
                    }
                case "Feig Verkehrsdetektor VEK Schleifendetektor 2-fach":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/2fach Schleifendetektor BES_M2E2.pdf");
                        break;
                    }
                case "Feig Verkehrsdetektor SVEKx-1 steckbarer Schleifendetektor 1/2-fach":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/TST_SVEKx-1.pdf");
                        break;
                    }
                case "Anleitung Schleifenverlegung Induktionsschleifen":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Induktionsschleife Schleifenverlegung Anleitung.pdf");
                        break;
                    }
                case "Montageanleitung Fertig-Induktionsschleife":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Fertiginduktionsschleife.pdf");
                        break;
                    }
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox22.SelectedItem.ToString())
            {
                case "IFM Magnetsensor MS5011":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/IFM MS5011 Magnetsensor.pdf");
                        break;
                    }
                case "VDS-C Magnetkontakt Einbau Tür (Honeywell)":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/VDS C Magnetkontakt Honeywell.pdf");
                        break;
                    }
                case "VDS-C Riegelschaltkontakt Honeywell":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Honeywell Riegelschaltkontakt VDS-C 0.08-031308.pdf");
                        break;
                    }
                case "VDS-C Magnetkontakt (Boden) ABUS":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/ABUS MK4100 VDS-C Rolltorbodenkontakt.pdf");
                        break;
                    }
                case "Bircher RF Gate Funkauswerter":
                    {
                        Process.Start(@"C:/Index/Bedienugsanleitungen div/Bircher RF Gate");
                        break;
                    }
            }
        }
    }
}
