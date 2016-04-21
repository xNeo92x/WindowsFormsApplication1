namespace WindowsFormsApplication1
{
    partial class KunstAlt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "1,5kW FU Kunststoffgehäuse Bedienungsanleitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "1,5kW FU Parameterliste Ebene 4 (für Service)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "1,5kW FU Kunststoff Bedienungsanleitung Endkunde";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(672, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "1,5kW Kunstoff Anschlußplan Ein-/Ausgänge";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(390, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(278, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Montageanleitung FU Steuerung";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(203, 31);
            this.button6.TabIndex = 5;
            this.button6.Text = "Startseite";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "==Alte Schlupftür==",
            "↓ opt./el. UK ↓ ",
            "Kabel opt./el. UK",
            "Kabel Schlüpftür opt./el. UK",
            "Kabel opt./el. UK Lichthupe",
            "Kabel opt./el. UK Lichtupe+Zwischenhalt",
            "Kabel opt./el. UK Schlupftür+Bircher Radar",
            "Kabel opt./el. UK E-Verriegelung, Rotampel",
            "Kabel opt./el. UK E-Verr.+Rotampel+Schlupftür",
            "Kabel opt./el. UK Verriegelung 2 Tore",
            " ↓ Niedrigschwelle ↓ ",
            "Kabel Niedrigschwelle",
            "Kabel Niedrigschwelle Bircher Radar",
            "Niedrigschwelle-Fingerklemmschutz",
            "Niedrigschwelle-Rolltor Schleuse",
            "==8k2 Schlupftür==",
            " ↓ opt./el. UK ↓",
            "Kabel 8k2 Schlupftür",
            "Kabel 8k2 Schlupftür Zeitschließung+Zwischenhalt+Zugschalter+Lichthupe+NotAus ode" +
                "r Steuerung EIN/AUS",
            "Kabel 8k2 Schlupftür Bircher Radar+Lichthupe Zeitschließung+Zwischenhalt Zugschal" +
                "ter",
            "Kabel 8k2 Schlupftür Lichthupe+Zwischenhalt",
            "Kabel 8k2 Schlupftür Zwischenhalt+potentialfreier Kontakt an K2",
            "Kabel 8k2 Schlupftür Lichthupe+Zwischenhalt potentialfreier Kontakt an K2",
            " ↓ Niedrigschwelle ↓",
            "Kabel 8k2 Niedrigschwelle",
            "Kabel 8k2 Niedrigschwelle Zeitschließung+Zwischenhalt+Zugschalter+Lichthupe+NotAu" +
                "s oder Steuerung EIN/AUS",
            "Niedrigschwelle 8k2 Lichthupe+Zwischenhalt",
            "Niedrigschwelle 8k2 Zeitschließung+Zugschalter"});
            this.comboBox1.Location = new System.Drawing.Point(356, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(653, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Bitte wählen";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Spiralkabel";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kabel 8k2 Niedrigschwelle"});
            this.comboBox2.Location = new System.Drawing.Point(356, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(653, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "Bitte wählen";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Energiekette";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "==Alte Schlupftür==",
            "2,4GHz opt./el. UK",
            "2,4GHz opt./el. UK + E.-Verriegelung",
            "==8k2 Schlupftür==",
            "2,4GHz opt./el. UK 8k2",
            "2,4GHz Niedrigschwelle",
            "2,4GHz opt./el. UK, Ein/Aus-Schalter, Rot/Grün-Ampel, Radar, Zeitschließung",
            "2,4GHz Niedrigschwelle, Ein/Aus Schalter, Rot/Grün-Ampel, Radar, Zeitschließung",
            "2,4GHz opt./el. UK, Ein/Aus-Schalter, Rot/Grün-Ampel, Radar, Zeitschließung, Refl" +
                "exionslichtschranke, potentialfreier Kontakt an K3",
            "2,4GHz Niedrigschwelle, Ein/Aus-Schalter, Rot/Grün-Ampel, Radar, Zeitschließung, " +
                "Reflexionslichtschranke, potentialfreier Kontakt an K3",
            "2,4GHz opt./el. UK, Ein/Aus-Schalter, Rot/Grün-Ampel, Radar, Zeitschließung, Wasc" +
                "hhallenlichtschranke, potentialfreier Kontakt an K3"});
            this.comboBox3.Location = new System.Drawing.Point(356, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(653, 21);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.Text = "Bitte wählen";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "2,4GHz";
            // 
            // KunstAlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "KunstAlt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1,5 KW FU Kunststoffgehäuse \"ALT\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
    }
}