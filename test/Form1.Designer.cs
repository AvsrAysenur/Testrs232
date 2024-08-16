namespace test
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.BaslatButonu = new System.Windows.Forms.Button();
            this.heRadio = new System.Windows.Forms.RadioButton();
            this.nRadio = new System.Windows.Forms.RadioButton();
            this.lmfRadio = new System.Windows.Forms.RadioButton();
            this.mermiRadio = new System.Windows.Forms.RadioButton();
            this.atesEtRadio = new System.Windows.Forms.RadioButton();
            this.bekleRadio = new System.Windows.Forms.RadioButton();
            this.nisanAlRadio = new System.Windows.Forms.RadioButton();
            this.izinVerRadio = new System.Windows.Forms.RadioButton();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.csumTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.muhimmatTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ActionTextBox = new System.Windows.Forms.MaskedTextBox();
            this.hedefXTextBox = new System.Windows.Forms.MaskedTextBox();
            this.hedefYTextBox = new System.Windows.Forms.MaskedTextBox();
            this.muhimmatSayısıtxtbox = new System.Windows.Forms.MaskedTextBox();
            this.headerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.hedefXNum = new System.Windows.Forms.NumericUpDown();
            this.hedefYNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hedefXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedefYNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seri Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mühimmat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Action:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hedef X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hedef Y:";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(139, 37);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(187, 28);
            this.comboBoxPorts.TabIndex = 5;
            this.comboBoxPorts.Text = "Port Seçiniz...";
            // 
            // BaslatButonu
            // 
            this.BaslatButonu.Location = new System.Drawing.Point(345, 397);
            this.BaslatButonu.Name = "BaslatButonu";
            this.BaslatButonu.Size = new System.Drawing.Size(232, 46);
            this.BaslatButonu.TabIndex = 6;
            this.BaslatButonu.Text = "Başlat";
            this.BaslatButonu.UseVisualStyleBackColor = true;
            this.BaslatButonu.Click += new System.EventHandler(this.BaslatButonu_Click);
            // 
            // heRadio
            // 
            this.heRadio.AutoSize = true;
            this.heRadio.Location = new System.Drawing.Point(20, 13);
            this.heRadio.Name = "heRadio";
            this.heRadio.Size = new System.Drawing.Size(57, 24);
            this.heRadio.TabIndex = 8;
            this.heRadio.TabStop = true;
            this.heRadio.Text = "HE";
            this.heRadio.UseVisualStyleBackColor = true;
            // 
            // nRadio
            // 
            this.nRadio.AutoSize = true;
            this.nRadio.Location = new System.Drawing.Point(20, 60);
            this.nRadio.Name = "nRadio";
            this.nRadio.Size = new System.Drawing.Size(45, 24);
            this.nRadio.TabIndex = 9;
            this.nRadio.TabStop = true;
            this.nRadio.Text = "N";
            this.nRadio.UseVisualStyleBackColor = true;
            // 
            // lmfRadio
            // 
            this.lmfRadio.AutoSize = true;
            this.lmfRadio.Location = new System.Drawing.Point(20, 113);
            this.lmfRadio.Name = "lmfRadio";
            this.lmfRadio.Size = new System.Drawing.Size(66, 24);
            this.lmfRadio.TabIndex = 10;
            this.lmfRadio.TabStop = true;
            this.lmfRadio.Text = "LMF";
            this.lmfRadio.UseVisualStyleBackColor = true;
            // 
            // mermiRadio
            // 
            this.mermiRadio.AutoSize = true;
            this.mermiRadio.Location = new System.Drawing.Point(20, 164);
            this.mermiRadio.Name = "mermiRadio";
            this.mermiRadio.Size = new System.Drawing.Size(95, 24);
            this.mermiRadio.TabIndex = 11;
            this.mermiRadio.TabStop = true;
            this.mermiRadio.Text = "BULLET";
            this.mermiRadio.UseVisualStyleBackColor = true;
            // 
            // atesEtRadio
            // 
            this.atesEtRadio.AutoSize = true;
            this.atesEtRadio.Location = new System.Drawing.Point(26, 24);
            this.atesEtRadio.Name = "atesEtRadio";
            this.atesEtRadio.Size = new System.Drawing.Size(87, 24);
            this.atesEtRadio.TabIndex = 12;
            this.atesEtRadio.TabStop = true;
            this.atesEtRadio.Text = "Ateş Et";
            this.atesEtRadio.UseVisualStyleBackColor = true;
            // 
            // bekleRadio
            // 
            this.bekleRadio.AutoSize = true;
            this.bekleRadio.Location = new System.Drawing.Point(26, 73);
            this.bekleRadio.Name = "bekleRadio";
            this.bekleRadio.Size = new System.Drawing.Size(74, 24);
            this.bekleRadio.TabIndex = 13;
            this.bekleRadio.TabStop = true;
            this.bekleRadio.Text = "Bekle";
            this.bekleRadio.UseVisualStyleBackColor = true;
            // 
            // nisanAlRadio
            // 
            this.nisanAlRadio.AutoSize = true;
            this.nisanAlRadio.Location = new System.Drawing.Point(26, 124);
            this.nisanAlRadio.Name = "nisanAlRadio";
            this.nisanAlRadio.Size = new System.Drawing.Size(92, 24);
            this.nisanAlRadio.TabIndex = 14;
            this.nisanAlRadio.TabStop = true;
            this.nisanAlRadio.Text = "Nişan Al";
            this.nisanAlRadio.UseVisualStyleBackColor = true;
            // 
            // izinVerRadio
            // 
            this.izinVerRadio.AutoSize = true;
            this.izinVerRadio.Location = new System.Drawing.Point(26, 164);
            this.izinVerRadio.Name = "izinVerRadio";
            this.izinVerRadio.Size = new System.Drawing.Size(88, 24);
            this.izinVerRadio.TabIndex = 15;
            this.izinVerRadio.TabStop = true;
            this.izinVerRadio.Text = "İzin Ver";
            this.izinVerRadio.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(345, 30);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(232, 47);
            this.buttonConnect.TabIndex = 19;
            this.buttonConnect.Text = "Bağlan";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(612, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 512);
            this.panel1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gelen Veriler:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Header:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(683, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mühimmat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Action:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(683, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Hedef X:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(683, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Hedef Y:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(683, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Mühimmat Sayısı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(683, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "CSUM:";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // csumTxtBox
            // 
            this.csumTxtBox.Location = new System.Drawing.Point(843, 397);
            this.csumTxtBox.Name = "csumTxtBox";
            this.csumTxtBox.Size = new System.Drawing.Size(123, 26);
            this.csumTxtBox.TabIndex = 35;
            // 
            // muhimmatTextBox
            // 
            this.muhimmatTextBox.Location = new System.Drawing.Point(843, 149);
            this.muhimmatTextBox.Name = "muhimmatTextBox";
            this.muhimmatTextBox.Size = new System.Drawing.Size(123, 26);
            this.muhimmatTextBox.TabIndex = 30;
            // 
            // ActionTextBox
            // 
            this.ActionTextBox.Location = new System.Drawing.Point(843, 202);
            this.ActionTextBox.Name = "ActionTextBox";
            this.ActionTextBox.Size = new System.Drawing.Size(123, 26);
            this.ActionTextBox.TabIndex = 31;
            // 
            // hedefXTextBox
            // 
            this.hedefXTextBox.Location = new System.Drawing.Point(843, 255);
            this.hedefXTextBox.Name = "hedefXTextBox";
            this.hedefXTextBox.Size = new System.Drawing.Size(123, 26);
            this.hedefXTextBox.TabIndex = 32;
            // 
            // hedefYTextBox
            // 
            this.hedefYTextBox.Location = new System.Drawing.Point(843, 301);
            this.hedefYTextBox.Name = "hedefYTextBox";
            this.hedefYTextBox.Size = new System.Drawing.Size(123, 26);
            this.hedefYTextBox.TabIndex = 33;
            // 
            // muhimmatSayısıtxtbox
            // 
            this.muhimmatSayısıtxtbox.Location = new System.Drawing.Point(843, 354);
            this.muhimmatSayısıtxtbox.Name = "muhimmatSayısıtxtbox";
            this.muhimmatSayısıtxtbox.Size = new System.Drawing.Size(123, 26);
            this.muhimmatSayısıtxtbox.TabIndex = 34;
            // 
            // headerTextBox
            // 
            this.headerTextBox.Location = new System.Drawing.Point(843, 102);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(123, 26);
            this.headerTextBox.TabIndex = 29;
            // 
            // hedefXNum
            // 
            this.hedefXNum.DecimalPlaces = 2;
            this.hedefXNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.hedefXNum.Location = new System.Drawing.Point(139, 358);
            this.hedefXNum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.hedefXNum.Name = "hedefXNum";
            this.hedefXNum.Size = new System.Drawing.Size(120, 26);
            this.hedefXNum.TabIndex = 36;
            // 
            // hedefYNum
            // 
            this.hedefYNum.Location = new System.Drawing.Point(139, 417);
            this.hedefYNum.Name = "hedefYNum";
            this.hedefYNum.Size = new System.Drawing.Size(120, 26);
            this.hedefYNum.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nRadio);
            this.groupBox1.Controls.Add(this.heRadio);
            this.groupBox1.Controls.Add(this.lmfRadio);
            this.groupBox1.Controls.Add(this.mermiRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 197);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.izinVerRadio);
            this.groupBox2.Controls.Add(this.atesEtRadio);
            this.groupBox2.Controls.Add(this.bekleRadio);
            this.groupBox2.Controls.Add(this.nisanAlRadio);
            this.groupBox2.Location = new System.Drawing.Point(208, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 197);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hedefYNum);
            this.Controls.Add(this.hedefXNum);
            this.Controls.Add(this.csumTxtBox);
            this.Controls.Add(this.muhimmatSayısıtxtbox);
            this.Controls.Add(this.hedefYTextBox);
            this.Controls.Add(this.hedefXTextBox);
            this.Controls.Add(this.ActionTextBox);
            this.Controls.Add(this.muhimmatTextBox);
            this.Controls.Add(this.headerTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.BaslatButonu);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TEST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hedefXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedefYNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button BaslatButonu;
        private System.Windows.Forms.RadioButton heRadio;
        private System.Windows.Forms.RadioButton nRadio;
        private System.Windows.Forms.RadioButton lmfRadio;
        private System.Windows.Forms.RadioButton mermiRadio;
        private System.Windows.Forms.RadioButton atesEtRadio;
        private System.Windows.Forms.RadioButton bekleRadio;
        private System.Windows.Forms.RadioButton nisanAlRadio;
        private System.Windows.Forms.RadioButton izinVerRadio;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.MaskedTextBox csumTxtBox;
        private System.Windows.Forms.MaskedTextBox muhimmatTextBox;
        private System.Windows.Forms.MaskedTextBox ActionTextBox;
        private System.Windows.Forms.MaskedTextBox hedefXTextBox;
        private System.Windows.Forms.MaskedTextBox hedefYTextBox;
        private System.Windows.Forms.MaskedTextBox muhimmatSayısıtxtbox;
        private System.Windows.Forms.MaskedTextBox headerTextBox;
        private System.Windows.Forms.NumericUpDown hedefXNum;
        private System.Windows.Forms.NumericUpDown hedefYNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

