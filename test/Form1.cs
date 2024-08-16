using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar;

namespace test
{
   
    public partial class Form1 : Form
    {
        
        private bool calisiyormu = false;
        private Thread gondermeThread;
        private Thread alanThread;
        private SerialPort SerialPort;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var port in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(port);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
                if (comboBoxPorts.SelectedIndex < 0)
                {
                    MessageBox.Show("COM port bulunamadi");
                    return;
                }

                // Port zaten açıksa, kapat ve çık
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    calisiyormu = false;
                    buttonConnect.Text = "Bağlan"; // Butonun metnini değiştir
                    MessageBox.Show("Port kapatıldı.");
                    return;
                }

                // Port kapalıysa, aç ve yapılandır
                serialPort.PortName = comboBoxPorts.Text;
                serialPort.BaudRate = 115200;
                serialPort.Parity = Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;

                try
                {
                    serialPort.Open();
                    calisiyormu = true;
                    buttonConnect.Text = "Kapat"; // Butonun metnini değiştir
                    MessageBox.Show("Bağlantı Başarılı!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bağlantı Hatası: {ex.Message}");
                }

        }


        private void BaslatButonu_Click(object sender, EventArgs e)
        {
            if (!calisiyormu)
            {
                calisiyormu = true;
                BaslatButonu.Text = "Durdur";

                gondermeThread = new Thread(GondermeDongusu);
                alanThread = new Thread(gelenVerileriDondur);

                gondermeThread.Start();
                alanThread.Start();

            }
            else
            {
                calisiyormu = false;
                BaslatButonu.Text = "Başlat";
                //durdurma kısmı burada
                if (gondermeThread != null && gondermeThread.IsAlive) gondermeThread.Join();
                if (alanThread != null && alanThread.IsAlive) alanThread.Join();
            }
        }
        private void GondermeDongusu()
        {
            byte[] mesaj;
            while (calisiyormu)
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    mesaj = MesajOlustur();
                    serialPort.Write(mesaj, 0, mesaj.Length);
                    Thread.Sleep(50);
                }
            }
        }
        private byte[] MesajOlustur()
        {
            byte header = 0xAD;
            byte muhimmat = 0x00;
            byte aksiyon = 0x00;

            switch (true)
            {
                case bool _ when heRadio.Checked:
                    muhimmat = 0x10;
                    break;
                case bool _ when nRadio.Checked:
                    muhimmat = 0x20;
                    break;
                case bool _ when lmfRadio.Checked:
                    muhimmat = 0x40;
                    break;
                case bool _ when mermiRadio.Checked:
                    muhimmat = 0x80;
                    break;
            }

            // Aksiyon seçimi 
            switch (true)
            {
                case bool _ when atesEtRadio.Checked:
                    aksiyon = 0x80;
                    break;
                case bool _ when bekleRadio.Checked:
                    aksiyon = 0x40;
                    break;
                case bool _ when nisanAlRadio.Checked:
                    aksiyon = 0x20;
                    break;
                case bool _ when izinVerRadio.Checked:
                    aksiyon = 0x10;
                    break;
            }

            
      //    float hedefx = float.Parse(hedefXTextBox.Text);
            float hedefx = (float)Convert.ToDouble(hedefXNum.Value);
            float hedefy = (float)Convert.ToDouble(hedefYNum.Value);

            int TargetX = (int)((hedefx + 100.0) * 100.0);
            int TargetY= (int)((hedefy + 100.0) * 100.0);
            byte[] HedefX = new byte[2];
            byte[] HedefY = new byte[2];
            HedefX[0] = (byte)(TargetX & 0xff);
            HedefX[1] = (byte)((TargetX >> 8) & 0xff);
            HedefY[0] = (byte)(TargetY & 0xff);
            HedefY[1] = (byte)((TargetY >> 8) & 0xff);
            byte checksum = (byte)(header + muhimmat + aksiyon + HedefX[0] + HedefX[1] + HedefY[0] + HedefY[1]);
            checksum= (byte)(0x100-(checksum & 0xFF));
            byte [] mesajDon = { header, muhimmat, aksiyon, HedefX[0], HedefX[1], HedefY[0], HedefY[1], checksum };
            return mesajDon;
        }
        private void gelenVerileriDondur()
        {
            while (calisiyormu)
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    if (serialPort.BytesToRead > 0)
                    {
                        byte muhimmatsayısı;
                        byte muhimmat;
                        byte aksiyon;
                        byte headerdon;
                        byte[] okunacakVeri = new byte[9];
                        byte[] HedefX = new byte[2];
                        byte[] HedefY = new byte[2];
                        byte checksum;
                        byte sonbyte;

                        serialPort.Read(okunacakVeri, 0, okunacakVeri.Length);
                        if (okunacakVeri.Length == 9)
                        {
                            // do
                            {

                                headerdon = okunacakVeri[0];
                                muhimmat = okunacakVeri[1];
                                aksiyon = okunacakVeri[2];
                                HedefX[0] = okunacakVeri[3];
                                HedefX[1] = okunacakVeri[4];
                                HedefY[0] = okunacakVeri[5];
                                HedefY[1] = okunacakVeri[6];
                                muhimmatsayısı = okunacakVeri[7];
                                sonbyte = okunacakVeri[8];
                                checksum = (byte)(headerdon + muhimmat + aksiyon + HedefX[0] + HedefX[1] + HedefY[0] + HedefY[1] + muhimmatsayısı);
                                checksum = (byte)(0x100 - (checksum & 0xFF));

                            }// while (headerdon == 0xCB && checksum == sonbyte);
                            if (headerdon == 0xCB && checksum == sonbyte)
                            {
                                Invoke(new Action(() =>
                                {
                                    headerTextBox.Text = headerdon.ToString("X2");
                                    muhimmatTextBox.Text = muhimmat.ToString("X2");
                                    ActionTextBox.Text = aksiyon.ToString("X2");
                                    // HedefX ve HedefY değerlerini ekrana yazdırma
                                    short hedefX = (short)BitConverter.ToUInt16(HedefX, 0);
                                    short hedefY = (short)BitConverter.ToUInt16(HedefY, 0);
                                    hedefXTextBox.Text = hedefX.ToString("X2"); // İster "X4" formatıyla hexadecimal olarak da gösterebilirsin
                                    hedefYTextBox.Text = hedefY.ToString("X2");
                                    muhimmatSayısıtxtbox.Text = muhimmatsayısı.ToString("X2");
                                    csumTxtBox.Text = checksum.ToString("X2");
                                }));
                            }
                        }
                    }
                }                
                Thread.Sleep(10);//cpu kullanımını azaltmak için bekleme ekledim.
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rslt = MessageBox.Show("Uygulamayı kapatmak üzeresiniz. Emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rslt == DialogResult.Yes)
            {
                // Seri port açık ise
                if (serialPort != null && serialPort.IsOpen)
                {
                    try
                    {
                        // Bağlantıyı kesme fonksiyonunu çağır
                        serialPort.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bağlantıyı keserken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Eğer kullanıcı 'Hayır'ı seçerse form kapanmasını engelle
                e.Cancel = true;
            }
        }
    }
}
