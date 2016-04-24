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
    public partial class Sonder : Form
    {
        public Sonder()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Standard Steuerung VW Komplettunterlagen Bemaßung und Schaltpläne":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/VW Standard/VW Schaltschrank Standard gesamt mit Schaltplänen.pdf");
                        break;
                    }
                case "531125 VW Baunatal Kunde Tor an Handges. Tore 1,2,3,4-Pos.10,20":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/531125/531125_VW Kassel_B.Hahn.pdf");
                        break;
                    }
                case "571653 VW Erweiterung OTC-4,Kunde EBULUM GmbH Schaltschrank Steuerung Tore 1,3,5,6,7":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571653/571653 SteuerungSchrank NEU -(nach -304nderung-)Tor 1,3,5,6,7.pdf");
                        break;
                    }
                case "571653 VW Erweiterung OTC-4,Kunde EBULUM GmbH Zusatzschrank, Tore 1,3,5,6,7":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571653/Zusatz Schaltschrank 571653 NEU -(nach -304nderung-) Tor 1, 3, 5, 6, 7.pdf");
                        break;
                    }
                case "571653 VW Erweiterung OTC-4,Kunde EBULUM GmbH Schaltschrank Steuerung Tore 8,9,10,11":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571653/571653 SteuerungSchrank NEU -(nach -304nderung-) Tor 8,9,10,11.pdf");
                        break;
                    }
                case "571653 VW Erweiterung OTC-4,Kunde EBULUM GmbH Schaltschrank Steuerung Tore 12,13":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571653/571653 SteuerungSchrank NEU -(nach -304nderung-) Tor 12,13.SKF.pdf");
                        break;
                    }
                case "571654 VW OTC-4 Kunde EBULUM GmbH Schaltschrank Steuerung Tore 1,18":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571654/Schrank Steuerung TX2  571654 Tor 1,18.pdf");
                        break;
                    }
                case "571654 VW OTC-4 Kunde EBULUM GmbH Zusatzschrank, Tore 1,18":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571654/Zusatz Schaltschrank 571654 Tor 1, 18.pdf");
                        break;
                    }
                case "571654 VW OTC-4 Kunde EBULUM GmbH Schaltschrank Steuerung Tore 3-15":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571654/TX2  571654 Tor 3 - 15.pdf");
                        break;
                    }
                case "571654 VW OTC-4 Kunde EBULUM GmbH Schaltschrank Steuerung Tore 16,17":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571654/NEU 5KW-FU  571654 Tor 16, 17.pdf");
                        break;
                    }
                case "571843 VW Baunatal OTC-3 Schaltschrank Steuerung,Tor 1":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571843/Schrank Steuerung TX2  571843 Tor 1.pdf");
                        break;
                    }
                case "571843 VW Baunatal OTC-3 Zusatzschrank, Tor 1":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571843/Zusatz Schaltschrank 571843, Tor 1.pdf");
                        break;
                    }
                case "571865 VW Baunatal Halle 1C, Tor 1":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571865/Schaltschrank 571865 Tor 1.pdf");
                        break;
                    }
                case "571908 Volkswagen AG Kunde VW Wolfsburg, Tor 1":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571908/Zusatz Schaltschrank 571908 Tor 1.pdf");
                        break;
                    }
                case "571927 Volkswagen AG Kunde VW Baunatal Tor 1/Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571927/571927 Digital TX2_2,4 GHz_1.1.pdf");
                        break;
                    }
                case "571927 Volkswagen AG Kunde VW Baunatal Tor 1/Zuschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571927/571927 Zusatzschaltplan.pdf");
                        break;
                    }
                case "571934 Volkswagen AG Kunde VW Baunatal Tor 1/Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571934/Hauptschaltplan 571934 Tor1 Digital TX2_2,4 GHz_1.1.pdf");
                        break;
                    }
                case "571934 Volkswagen AG Kunde VW Baunatal Tor 1/Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571934/Zusatzschaltplan Schaltschrank 571934, Tor 1.pdf");
                        break;
                    }
                case "571934 Volkswagen AG Kunde VW Baunatal Tor 2/Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571934/Hauptschaltplan 571934 Tor2 Digital TX2_Kabel_1.1.pdf");
                        break;
                    }
                case "571934 Volkswagen AG Kunde VW Baunatal Tor 2/Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571934/Zusatzschaltplan Schaltschrank 571934, Tor 2.pdf");
                        break;
                    }
                case "571956 Volkswagen AG Kunde VW Baunatal Tor 1/Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571956/Hauptschaltplan 571956 Tor1 Digital TX2_2,4 GHz_1.1.pdf");
                        break;
                    }
                case "571956 Volkswagen AG Kunde VW Baunatal Tor 1/Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571956/Zusatzschaltplan Schaltschrank 571956, Tor 1.pdf");
                        break;
                    }
                case "571957 Volkswagen AG Kunde VW Baunatal Tor 1/Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571957/Hauptschaltplan 571957 Tor1 Digital TX2_2,4 GHz_1.1.pdf");
                        break;
                    }
                case "571957 Volkswagen AG Kunde VW Baunatal Tor 1/Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571957/Zusatzschaltplan Schaltschrank 571957, Tor 1.pdf");
                        break;
                    }
                case "571982 Volkswagen AG Kunde VW Baunatal Tor 1-7/Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571982/Hauptschaltplan 571982 Tor1-7 Digital TX2_2,4 GHz_1.1Hauptschaltplan 571982 Tor1-7 Digital TX2_2,4 GHz_1.1.pdf");
                        break;
                    }
                case "571982 Volkswagen AG Kunde VW Baunatal Tor 1-7/Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/571982/Zusatzschaltplan Schaltschrank 571982, Tor 1-7.pdf");
                        break;
                    }
                case "572015 Volkswagen AG Kunde VW Baunatal Tor 1/Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/572015/Hauptschaltplan 572015 Tor1 Digital TX2_Kabel_1.1.pdf");
                        break;
                    }
                case "572015 Volkswagen AG Kunde VW Baunatal Tor 1/Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/572015/Zusatzschaltplan Schaltschrank 572015, Tor 1.pdf");
                        break;
                    }
                case "573002 VW Baunatal":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/573002/573002 VW Haupt und Zusatzschaltplan.pdf");
                        break;
                    }
                case "573061 VW Baunatal Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/573061/Hauptschaltplan Digital TX2_Kabel_1.1 VW 573061_Tor1.pdf");
                        break;
                    }
                case "573061 VW Baunatal Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV//573061/Zusatzschaltplan Schaltschrank VW 573061_Tor1.pdf");
                        break;
                    }
                case "721266 VW Baunatal Tor 1,2,3":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/721266/721266.pdf");
                        break;
                    }
                case "790524 VW Baunatal Kunde PEM/Österreich Tor 1-5":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/VW Schränke diverse BV/790524/Schaltschrank 790524, Tor 1 - 5.pdf");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Standard Steuerung Porsche Komplettunterlagen Bemaßung und Schaltpläne":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/Porsche Pläne gesamt NEU mit Wartungs LED.pdf");
                        break;
                    }
                case "790584 Porsche 4+5kW FU Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/4und5kWFU Hauptschaltplan.pdf");
                        break;
                    }
                case "790584 Porsche 4+5kW FU Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/4und5kW FU Porsche Zusatzplan NEU.pdf");
                        break;
                    }
                case "790584 Porsche 4+5kW FU Sonderplan Zusatz elektrische Leiste an Omega-Profil":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/4und5kWFU Porsche Hauptschaltplan mit  el. ZusatzUK an Omega-Profil über SURA.pdf");
                        break;
                    }
                case "790584 Porsche 1,5kW FU Kunststoffgehäuse Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/1,5kW Kunststoff Porsche Hauptschaltplan.pdf");
                        break;
                    }
                case "790584 Porsche 1,5kW FU Kunststoffgehäuse Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/1,5kW FU Porsche Zusatzplan.pdf");
                        break;
                    }
                case "790584 Porsche TX2 Hauptschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/TX2 Porsche Hauptschaltplan.pdf");
                        break;
                    }
                case "790584 Porsche TX2 Zusatzschaltplan":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/TX2  Porsche Zusatzplan.pdf");
                        break;
                    }
                case "790584 Porsche - Tor 15 TX2 Erweiterungsplatine für Tor AUF PKW/LKW":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/TX2 Porsche Zusatzplatine Tor 15 Pos.70 mit Parametrierung.pdf");
                        break;
                    }
                //Platzhalter
                //case "790584 Porsche Bemassungszeichnung Schaltschrank 4+5kW FU":
                //  {
                //    Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/Schaltschrank Bemaßung 4kW FU Stahl Schranktür");
                //  break;
                //}
                case "790584 Porsche Bebilderungen Schaltschränke":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790584 Porsche/Bilder");
                        break;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Schleusensteuerung Klartextbeschreibung Parametrierungen bei FUS und FU3E":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Schleusen und Schleifensteuerungen/Schleusensteuerung FUS mit FU3E Klartextbeschreibung.pdf");
                        break;
                    }
                case "Schleusensteuerung zw. 2x FU3E (4kWFU) BV751003/Tor 1 und 2 Blatt 1 (Schleuse)":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Schleusen und Schleifensteuerungen/Schleusensteuerung Blatt 1 FU Steuerungen Stahl Verbindungen Steuerungen.pdf");
                        break;
                    }
                case "Schleusensteuerung zw. 2x FU3E (4kWFU) BV751003/Tor 1 und 2 Blatt 2 (Lichtgitter)":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Schleusen und Schleifensteuerungen/Schleusensteuerung Blatt 2 Fu Steuerungen Stahl Anschluss Lichtgitter.pdf");
                        break;
                    }
                case "Schleifensteuerung mit Zeitverzögerung 1,5kW FU Stahl BV751003/Tor 3":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Schleusen und Schleifensteuerungen/Schleifen mit Zeitverz-366gerung FUE 1,5kW Stahl.pdf");
                        break;
                    }
                case "Querverkehrserkennung mit VEK M2E":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Schleusen und Schleifensteuerungen/Querverkehrerkennung VEK M2E.pdf");
                        break;
                    }
                case "Verkehrsdetektor VEK M1E1 Schleifendetektor 1-fach":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Schleusen und Schleifensteuerungen/1fach Schleifendetektor BES_M1E1.pdf");
                        break;
                    }
                case "Verkehrsdetektor VEK M2E2 Schleifendetektor 2-fach":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Schleusen und Schleifensteuerungen/2fach Schleifendetektor BES_M2E2.pdf");
                        break;
                    }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedItem.ToString())
            {
                case "Sonderparametrierungen alle Steuerungen":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Parametrierung divers/Parametrierungen diverse.pdf");
                        break;
                    }
                case "Einstellungsparameter TX2":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Parametrierung divers/Parametrierungen TX2.pdf");
                        break;
                    }
                case "Paramter 4kW FU Reihenfolge":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Parametrierung divers/Parametrierung 4kW FU.pdf");
                        break;
                    }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedItem.ToString())
            {
                case "Gruppensteuerung für 3 Tore an TX2 AUF-STOP-ZU":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Gruppensteuerung 3Tore AufStopZu.pdf");
                        break;
                    }
                case "Sondertaster an TX2 mit Zwischenhalttaster":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Sondertaster mit Zwischenhalttaster an TX2.pdf");
                        break;
                    }
                case "TM1 Rolltor(gitter) mit Zusatz-Rollenendschalter":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Digital TM1_RolltorRollgitter mit Zusatzendschalter mechansich.pdf");
                        break;
                    }
                case "TM1 Rolltor mit Steuerung Ein/Aus Zusatzplatine elektrische Verriegelung":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Digital TM1_Rolltor_Rollgitter mit 230V Verriegelung_komplett.pdf");
                        break;
                    }
                case "TX2 Feig GHz Rolltor mit Sondertaster Zwischenhalt Steuerung Ein/Aus Zusatzplatine, Zeitschaltuhr elektrische Verriegelung":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/TX2 GHz Rolltor mit SondertasterZwischenhalt EinAus Schalter Zeitschaltuhr elektrischeVerriegelung.pdf");
                        break;
                    }
                case "1,5kW FU Kunststoff mit Zwischenhalt und Unterbrechung Zeitschließung":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/1,5 KW Kunststoffgeh.Kabel_8k2 NEUE Schlupftür mit SommerWinter und Abbruch Offenhalt bei Kontakt.pdf");
                        break;
                    }
                case "Dateien zu Auftrag 770811 BASF SE":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/770811 BASF SE");
                        break;
                    }
                case "Dateien zu Auftrag 771036 BASF Gebäude W305":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/771036 BASF Gebäude W 305");
                        break;
                    }
                case "Dateien zu Auftrag 790570 Eisen-Fischer":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790570 Eisen-Fischer Sondertaster");
                        break;
                    }
                case "Dateien zu Auftrag 531105 und 531106 Siemens Toul und Hürth":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/531106 Toul SIEMENS 531105 Köln");
                        break;
                    }
                case "Dateien zu Auftrag 258633 Bäumer Eurospuma":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/258633 Bäumer Eurospuma");
                        break;
                    }
                case "Sonderplan TX2 Zeitschließung über Lichtschranke 730808-AVIA Tankstelle":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/730808 Sonderschaltplan Kabel 1.1_ISchleife plus ext Kontakt unterbrechung Schleife Ampel Rot Grün.pdf");
                        break;
                    }
                case "Sonderplan TX2 Kabel 1.1 mit Schlüsselschalter extern Abschaltung Folientastatur":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/OBI Kabel 1.1_mit Schlüsselschalter Folientastatur EINAUS.pdf");
                        break;
                    }
                case "Sondertaster an GfA TS 970 Steuerung Ein/Aus Schlüsselschalter +AUF/STOP/ZU 770850 BASF":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/770850_1 BASF Sondertaster/770850_1 Sondertaster.pdf");
                        break;
                    }
                case "Verriegelung von 2 Toren Feig zu Feig":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Zusatzplan Verriegelung 2 Tore.pdf");
                        break;
                    }
                case "Verriegelung von 2 Toren GfA TS981 zu Feig TX2":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Zusatzplan Verriegelung 2 Tore TS981 zu TX2.pdf");
                        break;
                    }
                case "Verriegelung von 4 Toren 2 gegenübeliegende verriegelt div. Steuerungen":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Zusatzplan Verriegelung 4Tore_2gegenüberliegende verriegelt.pdf");
                        break;
                    }
                case "Verriegelung Tore gegen fahrbare Stütze bei TM1/TX2 790374 Kloiber":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790374 Kloiber/Kloiber Zusatzplan Verriegelung Tore Stuetze.pdf");
                        break;
                    }
                case "Eltako Funksender mit Grobhandtaster Mercedes Hamburg":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Mercedes Hamburg Eltako Funk/Eltako Funk Sender mit Grobhandtaster.pdf");
                        break;
                    }
                case "Eltako Funkempfänger Mercedes Hamburg":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Mercedes Hamburg Eltako Funk/Eltako Funk Empfänger.pdf");
                        break;
                    }
                case "Sonderplan TX2 Kabel 1.1 Induktionsschleife EIN/AUS mit Lichtschranke ZU Berlin Gatow/Feuerwehr ":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Feuerwehr Berlin Gatow/Kabel 1.1_Ind.Schleife EIN AUS mit Lichtschranke zu.pdf");
                        break;
                    }
                case "Digitaler TX AV2.0 mit LS28":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Schaltplan Digital-TX  AV2.0 mit LS28.pdf");
                        break;
                    }
                case "Digital TX Nock 0.1":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Schaltplan zu Einlegeschild Komforttronik Digital-TX  Nock.0.1.pdf");
                        break;
                    }
                case "Digital TX Nock 0.1 Fingerklemmschutz Keyence Einzugssicherung SG15 Lichtgitter":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Kabel 1.1 Nocke TX2_mit Fingerklemmschutz und Einzugssicherung mit Lichtgitter SG15.pdf");
                        break;
                    }
                case "Digital TX Nock 0.1 Fingerklemmschutz Keyence Einzugssicherung Witt voreilende LS":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Kabel 1.1 Nocke TX2_mit Fingerklemmschutz und Einzugssicherung_Witt voreilende Lichtschranke.pdf");
                        break;
                    }
                case "Dateien zu Auftrag 730832 Systembau":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/730832 Systeambau");
                        break;
                    }
                case "Dateien zu Auftrag 770855 Krankenhaus Mayen":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/770855 Krankenhaus Mayen");
                        break;
                    }
                case "Dateien zu Auftrag FireDos":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/FireDos");
                        break;
                    }
                case "Sonderplan 1,5kW FU Kunststoff Ampel an K1; Tor ZU an K2 Tor AUF an K3 770783-FW Groß-Gerau":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/770783 FW GroßGerau/1,5 KW Kunststoffgeh.Kabel_8k2 NEUE Schlupftür FWGrossGerau_K1Rotampel_K2LüftungTorZu_K3TorAuf.pdf");
                        break;
                    }
                case "Dateien zu Auftrag 751043 und 751043.1 HansenHallenbau/Momentive":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/751043 Momentive");
                        break;
                    }
                case "Dateien zu Auftrag 751153 Berufs FW Hamburg IMPF":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/751153 Berufsfeuerwehr Hamburg IMPF");
                        break;
                    }
                case "Dateien zu Auftrag 531364 Ostwall Carree - Krefeld":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/531364 Ostwall Carree - Krefeld");
                        break;
                    }
                case "Dateien zu Auftrag 542328 Aug. Hedinger":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/542328 AugHedinger");
                        break;
                    }
                case "Dateien zu Auftrag 790744 Feuerwehr Amberg":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790744 Feuerwehr Amberg");
                        break;
                    }
                case "Dateien zu Auftrag 790775 Bay. Rotes Kreuz Ansbach":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790775 Rotes Kreuz Ansbach");
                        break;
                    }
                case "Dateien zu Auftrag 771092 Tiefgarage Rheydt":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/771092 Tiefgarage Rheydt");
                        break;
                    }
                case "790709 Ziegelwerk 4kW FU mit Zusatzplatine ohne Sicherheiten Automatik":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/TST FU3E-C_4 KW, Stahlgeh_Kabel_Zusatzplatine_Rolltor_ Automatik zu ohne Sicherheiten_Kundengefahr.pdf");
                        break;
                    }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.SelectedItem.ToString())
            {
                case "Verdrahtungsplan Elektrische Verriegelung 230Volt Rolltore an TX2 oder TM1":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/230Volt Verriegelung Verdrahtungsplan.pdf");
                        break;
                    }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.SelectedItem.ToString())
            {
                case "Dateien zu Auftrag 573067 Safetec":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/573067 Safetec");
                        break;
                    }
                case "Dateien zu Auftrag 731095 Wohnen am Eichenberg":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/731095 Wohnen am Eichenberg");
                        break;
                    }
                case "Dateien zu Auftrag 732012 Wohnen am Eichenberg":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/732012 Wohnen am Eichenberg");
                        break;
                    }
                case "Dateien zu Auftrag 770984 Feuerwehr Krefeld-Hüls":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/770984 Feuerwehr Krefeld-Hüls");
                        break;
                    }
                case "Dateien zu Auftrag 771003 Feuerwehr Kleinostheim":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/771003 Feuerwehr Kleinostheim");
                        break;
                    }
                case "Dateien zu Auftrag 771036 BASF":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/771036 BASF");
                        break;
                    }
                case "Dateien zu Auftrag 771113 Biogasanlage Wicker":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/771113 Biogas Wicker");
                        break;
                    }
                case "Dateien zu Auftrag 771121 Feuerwehr Roßbach":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/771121 Feuerwehr Roßbach");
                        break;
                    }
                case "Dateien zu Auftrag 790741 Audi Heilbronn":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790741 Audi Heilbronn");
                        break;
                    }
                case "Dateien zu Auftrag 790778 Fabco":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790778 FABCO");
                        break;
                    }
                case "Dateien zu Auftrag 771129 Parkhaus Bad Homburg":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/771129 Parkhaus Bad Homburg");
                        break;
                    }
                case "Dateien zu Auftrag 573187 Wieland Werke Vöhringen":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/573187 Wieland Werke Vöhringen");
                        break;
                    }
                case "Dateien zu Auftrag 542393 Bosch":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/542393 Bosch");
                        break;
                    }
                case "Dateien zu Auftrag 790812 Carmen und Thomas Jürs":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790812 Carmen und Thomas Jürs");
                        break;
                    }
                case "Dateien zu Auftrag 790831 Helmut Lempert":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/790831 Helmut Lempert");
                        break;
                    }
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.SelectedItem.ToString())
            {
                case "Fremdanschlußbox":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Anschlußbox Fremdfirmen Schaltplan.pdf");
                        break;
                    }
                case "Induktionsschleifendetektor Bircher":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Anschlußbox Bircher Induktionsschleifendetektor.pdf");
                        break;
                    }
                case "LED - Flashlight Anschlußbox":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/LED Flashlight Anschlußbox.pdf");
                        break;
                    }
                case "Cedes TOF/Taxi Anschlußbox":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Anschlußbox TOF TAXI.pdf");
                        break;
                    }
                case "Grünampel an WSA Anschlußbox":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/Zusatzschaltpläne divers/Anschlußbox WSA Grünampel.pdf");
                        break;
                    }
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.SelectedItem.ToString())
            {
                case "LIGI OSE an GfA TS971 mit Spiralkabel plus Fingerklemmschutz Keyence":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/WITT Lichtgitter/GFA TS 971 mit Lichtgitter WITT LIGI OSE und FKS.pdf");
                        break;
                    }
                case "LIGI PNP an TX2 Nocke ohne Torfunktion vor und hinter Tor verbaut":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/WITT Lichtgitter/Kabel 1.1 Nocke TX2_mit Witt Lichtgitter ohne Torfunktion_vor und hinter Torblatt.pdf");
                        break;
                    }
                case "LIGI OSE an MfZ CS310 mit/ohne Torfunktion":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/WITT Lichtgitter/CS 310 mit Witt LIGI OSE.pdf");
                        break;
                    }
                case "LIGI OSE an Feig 4kW FU Spika mit Bircher Radar und Zeitschließung mit/ohne Torfunktion":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/WITT Lichtgitter/TST FU3E-C_4 KW, Stahlgeh_Kabel_Lichtgitter Witt OSE_Schlaffs.8K2_Zeitschl_BircherRadar.pdf");
                        break;
                    }
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox10.SelectedItem.ToString())
            {
                case "MfZ CS310 Spika ohne Schlupftür":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/WM Tore mit MfZ Komponenten/WM Tor Zusatzplan ohne Schlupftür.pdf");
                        break;
                    }
                case "MfZ CS310 Spika mit Schlupftür":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/WM Tore mit MfZ Komponenten/WM Tor Zusatzplan mit Schlupftür.pdf");
                        break;
                    }
                case "MfZ CS310 Spika  Niedrigschwelle mit Lichtgitter SG15":
                    {
                        Process.Start(@"C:/Index/Sonderpläne/WM Tore mit MfZ Komponenten/WM Tor Zusatzplan ohne Schlupftür.pdf");
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
