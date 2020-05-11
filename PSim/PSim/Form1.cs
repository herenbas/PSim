using bvys_onay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var client = new B_Kayit.MernisIslemleriWSIntClient();

            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(new
                   SecurityHeader("UsernameToken-49", "mernis", "Test1234"));
                B_Kayit.tckkBasvuru tckkBasvuru = new B_Kayit.tckkBasvuru();
                tckkBasvuru.adi = "TEST";
                tckkBasvuru.soyadi = "TEST";
                tckkBasvuru.tckNoSpecified = true;
                tckkBasvuru.tckNo = 68716029166;
                tckkBasvuru.aliciMernisBirimKodu = 1690;
                tckkBasvuru.aliciMernisBirimKoduSpecified = true;
                tckkBasvuru.basvuruPostaTakipKod = 9240000011899;
                tckkBasvuru.bvysOnayMuafSpecified = true;
                tckkBasvuru.bvysOnayMuaf = true;
                tckkBasvuru.cepTelefonNumarasi = "05065986762";
                tckkBasvuru.cinsiyetSpecified = true;
                tckkBasvuru.cinsiyet = B_Kayit.cinsiyet.ERKEK;
                tckkBasvuru.dogumAySpecified = true;
                tckkBasvuru.dogumAy = 12;
                tckkBasvuru.dogumGunSpecified = true;
                tckkBasvuru.dogumGun = 14;
                tckkBasvuru.dogumYeri = "TEST";
                tckkBasvuru.dogumYilSpecified = true;
                tckkBasvuru.dogumYil = 1944;
                tckkBasvuru.duzenlenmeTarihiAySpecified = true;
                tckkBasvuru.duzenlenmeTarihiAy = 12;
                tckkBasvuru.duzenlenmeTarihiGunSpecified = true;
                tckkBasvuru.duzenlenmeTarihiGun = 15;
                tckkBasvuru.duzenlenmeTarihiYilSpecified = true;
                tckkBasvuru.duzenlenmeTarihiYil = 2020;
                tckkBasvuru.formatlanmisDogumTarihi = "24-DEC-1984";
                tckkBasvuru.formatlanmisDuzenlenmeTarihi = "24-DEC-1984";
                tckkBasvuru.formatlanmisSonGecerlilikTarihi = "24-DEC-1984";
                tckkBasvuru.formatlanmisSonGecerlilikTarihi = "24-DEC-1984";
                tckkBasvuru.fotograf = ImageToByteArray(pictureBox1.Image);
                tckkBasvuru.fotografIcaoTokenImage = ImageToByteArray(pictureBox2.Image);
                tckkBasvuru.iadeMernisBirimKoduSpecified = true;
                tckkBasvuru.iadeMernisBirimKodu = 1910;
                tckkBasvuru.icaoTokenImageType = "JPEG2000";
                tckkBasvuru.islakImza = ImageToByteArray(pictureBox3.Image);
                tckkBasvuru.kpsAdres = "TEST";
                tckkBasvuru.mernisAciklama = "TEST";
               
                tckkBasvuru.mernisIslemId = Guid.NewGuid().ToString();
                tckkBasvuru.meslek = "TEST";
                tckkBasvuru.mrzLine = "AKISIK<<EDA<<<<<<<<<<<<<<<<<<<<<<<<<<<<";
                tckkBasvuru.oncelikSpecified = true;
                tckkBasvuru.oncelik = B_Kayit.basvuruOncelik.NORMAL;
                tckkBasvuru.pasaportTuruSpecified = true;
                tckkBasvuru.pasaportTuru = B_Kayit.pasaportTuru.BORDO_PASAPORT;
                tckkBasvuru.sonGecerlilikTarihiAySpecified = true;
                tckkBasvuru.sonGecerlilikTarihiAy = 12;
                tckkBasvuru.sonGecerlilikTarihiGunSpecified = true;
                tckkBasvuru.sonGecerlilikTarihiGun = 15;
                tckkBasvuru.sonGecerlilikTarihiYilSpecified = true;
                tckkBasvuru.sonGecerlilikTarihiYil = 2020;
                tckkBasvuru.tckNo = 68716029166;
                tckkBasvuru.telefonNumarasi = "05065986762";
                tckkBasvuru.teslimAliciAdresiSatir1 = "adres";
                tckkBasvuru.teslimAliciAdresiSatir2 = "adres";
                tckkBasvuru.teslimAliciAdresiSatir3 = "adres";
                tckkBasvuru.teslimAliciAdresiSatir4 = "adres";
                tckkBasvuru.teslimKisi2Ad = "ad2";
                tckkBasvuru.teslimKisi2Soyad = "soyad2";
                tckkBasvuru.teslimKisiAd = "test";
                tckkBasvuru.teslimKisiSoyad = "test";
                tckkBasvuru.teslimSekliSpecified = true;
                tckkBasvuru.teslimSekli = B_Kayit.teslimSekli.PTT_ILE_TESLIM;
                tckkBasvuru.title = "test";
                tckkBasvuru.unvan = "test";
                tckkBasvuru.uyrugu = "test";
                tckkBasvuru.verenMakam = "test";
                tckkBasvuru.vizAdi = "test";
                tckkBasvuru.vizSoyadi = "test";
                

                
            
                B_Kayit.standartWSSonuc sonuc = new B_Kayit.standartWSSonuc();
                
                sonuc = client.basvuruKaydet(tckkBasvuru);
                MessageBox.Show(sonuc.basarili.ToString()+" - "+sonuc.hataAciklama.ToString());
                add_fp(tckkBasvuru.mernisIslemId.ToString());
                dATA aTA = new dATA();
                

            }


           
           




        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string veri;
        public string random_soyad()
        {
            string[] ff = File.ReadAllLines(@"C:\Users\Eren BAŞ\Desktop\wssim_\DUMMY_DATA\isimler.txt");
            

         
                Random rnd = new Random();
                int a= rnd.Next(1, ff.Length);
                return ff[a].ToString();

            

           

        }
        public void add_fp(string m_id)
        {
            var client = new BVYS_Ser.BvysIslemleriWSIntClient();
            var sonuc = new BVYS_Ser.standartWSSonuc();

            using (new OperationContextScope(client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(
                    new SecurityHeader("UsernameToken-49", "BVYS", "Test1234"));

                // BvysSer.BvysIslemleriWSIntClient cl = new BvysSer.BvysIslemleriWSIntClient();
                //  BvysSer.standartWSSonuc sonuc = new BvysSer.standartWSSonuc();
                //byte[] veri = System.Convert.FromBase64String(convert_to_DG3(@"C:\Users\Eren BAŞ\Desktop\wssim_\DUMMY_DATA\EG_DG3_New.xml"));

                sonuc = client.bvysOnayBildir(m_id, convert_to_DG3(@"C:\Users\Eren BAŞ\Desktop\wssim_\DUMMY_DATA\EF_DG3_New.xml"));

                if (sonuc.basarili == true)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show(sonuc.hataAciklama + "  " + sonuc.hataKodu);
                }
            }


        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public byte[] convert_to_DG3(string path)
        {
            
            FileStream stream = File.OpenRead(path);
            byte[] fileBytes = new byte[stream.Length];

            stream.Read(fileBytes, 0, fileBytes.Length);
            return fileBytes;
          

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //add_fp("660cfb23-7c0b-499c-82e7-79ed44e5b604");
            MessageBox.Show(random_soyad());

        }
        public string random_image()
        {
            var rand = new Random();
            var files = Directory.GetFiles(@"C:\Users\Eren BAŞ\Desktop\wssim_\DUMMY_DATA\Images", "*.jpg");
            return files[rand.Next(files.Length)];

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = random_image();
        }
    }
}
