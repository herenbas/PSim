using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSim
{
    public partial class c_form : Form
    {
        public c_form()
        {
            InitializeComponent();
        }
        int count = 0;
        dATA data = new dATA();
        
        private void C_form_Load(object sender, EventArgs e)
        {
          
            CheckForIllegalCrossThreadCalls = false;
            comboBox1.DataSource = Enum.GetValues(typeof(B_Kayit.pasaportTuru));

            comboBox2.DataSource = Enum.GetValues(typeof(B_Kayit.basvuruOncelik));
            //dATA.LoadJson();
            comboBox3.DataSource = Enum.GetValues(typeof(B_Kayit.teslimSekli));
           
            pictureBox1.ImageLocation = random_image();
            pictureBox2.ImageLocation = random_imza();
           

          


      


            foreach (var item in data.datas())
            {
                comboBox4.Items.Add(item);
            }

        }

    

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        public void yolla()
        {

            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                b_kaydet();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            count = 0;
            listBox1.Items.Clear();

            Task t = new Task(() =>
             {
                 for (int i = 0; i < numericUpDown2.Value; i++)
                 {
                     b_kaydet();
                     count++;
                     label6.Text = "Gönderilen Başvuru Adeti:"+" \n"+ count.ToString();
                   
                 }



             });
            t.Start();
            //if (t.Status==TaskStatus.Running)
            //{

            //}
            //else
            //{
            //    random_isler();
            //}
           
            
            

         
            
        }
        public void b_kaydet()
        {
          

            try
            {
                data.aciklama = "Başvuru Açıklama";
                data.adi = random_Ad();
                data.soyadi = random_soyAd();
              //  data.alici_mernis_birim_kodu = Convert.ToInt32(numericUpDown1.Value);
                data.cinsiyet = B_Kayit.cinsiyet.ERKEK;
                data.dogum_ay = 08;
                data.dogum_gun = 14;
                data.dogum_yeri = il();
                data.dogum_yil = 1984;
                data.duzenleme_tarih_yil = DateTime.Today.Year;
                data.duzenlenme_tarih_ay = DateTime.Today.Month;
                data.duzenlenme_tarih_gun = DateTime.Today.Day;
                data.islem_id = new Guid().ToString();

                data.formatlanmis_duzenlenme_tarihi = "09 MAR/MAR 2020";
                data.formatlanmis_son_gec_tarihi = "09 MAR/MAR 2030";
                data.formatlanmıs_dogum_t = "09 MAR/MAR 2020";
                data.fotograf = converterDemo(pictureBox1.Image);
               // data.iade_mern_birm_kodu = Convert.ToInt32(numericUpDown1.Value);
                data.icao_token_image_type = "JPEG";
                data.islak_imza = converterDemo(pictureBox2.Image);
                data.islem_id = Guid.NewGuid().ToString();
                data.unvan = random_meslek();
                data.uyrugu = "T.C.";
                data.veren_makam = "ANKARA";
                data.viz_Ad = data.adi;
                data.viz_soyad = data.soyadi;
                data.kps_adres = "AÇIK ADRES";
                //data.mernis_oncelik = B_Kayit.basvuruOncelik.NORMAL;
                data.mrz_line_1 = mrz1(data.soyadi, data.adi);
                // data.pas_turu = B_Kayit.pasaportTuru.BORDO_PASAPORT;

                data.ptt_barkod = Convert.ToInt64(("160600" + new Random().Next(1000000, 9999999)));
                data.pots_taki_kodu = Convert.ToInt64(("260600" + new Random().Next(1000000, 9999999)));
                data.son_gecerliik_tarihi = DateTime.Now.AddYears(10).ToShortDateString();
                data.son_gecerlilik_taih_gun = DateTime.Now.Day;
                data.son_gecerlilik_tarih_ay = DateTime.Now.Month;
                data.son_gecerlilik_tarih_yil = DateTime.Now.AddYears(10).Year;
                data.tckn = Convert.ToInt64("687" + new Random().Next(10000000, 99999999));
                // data.teslim_Sekli = B_Kayit.teslimSekli.PTT_ILE_TESLIM;
                data.tel_no = "BOŞ";
                data.teslim_alici_adres_sat_1 = "ADRES1";
                data.teslim_alici_adres_sat_2 = "ADRS2";
                data.teslim_alici_adres_sat_3 = "ADRES3";
                data.teslim_alici_adres_sat_4 = "ADRES4";
                data.teslim_kisi_ad = random_Ad();
                data.teslim_kisi_soyad = random_soyAd();

                data.titile = random_meslek();
                data.tooken_image = converterDemo(ResizeImage(pictureBox1.Image,240,320));
                data.unvan = "BOŞ";
                B_Kayit.standartWSSonuc d_sonuc = data.basvuru_kayit();
                
                if (d_sonuc.basarili == true)
                {
                    listBox1.Items.Add(data.tckn + " TCKN Başvuru Kayıt edildi");


                }
                else
                {
                    listBox1.Items.Add("HATA!" + " - " + d_sonuc.hataAciklama);
                }
                Thread.Sleep(50);
                BVYS_Ser.standartWSSonuc fpsonuc = data.fp_kayit(data.islem_id);
                if (fpsonuc.basarili == true)
                {
                    listBox1.Items.Add(data.tckn + " FP bilgisi Gönderildi");
                    Thread.Sleep(100);
                    pictureBox1.ImageLocation = random_image();
                    Thread.Sleep(100);
                    pictureBox2.ImageLocation = random_imza();
                    Thread.Sleep(100);





                }
                else
                {
                    listBox1.Items.Add(fpsonuc.hataAciklama);
                   
                }
              
                
               

               // return true;

        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
             
            }

            //pictureBox1.ImageLocation = random_image();
            //pictureBox2.ImageLocation = random_imza();




}
        public static byte[] converterDemo(Image img)
        {
          
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(img, typeof(byte[]));
            return xByte;
        }
        private string random_Ad()
        {
            string[] ff = File.ReadAllLines(  Application.StartupPath+"/"+confs.isim_path);



            Random rnd = new Random();
            int a = rnd.Next(1, ff.Length);
            return ff[a].ToString();
        }

        private long LongRandom(long min, long max)
        {
            Random rand = new Random();

            long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
            result = (result << 32);
            result = result | (long)rand.Next((Int32)min, (Int32)max);
            return result;



        }
        private string mrz1(string ad, string soyad)
        {
            string aa = soyad + "<<" + ad;
            StringBuilder builder = new StringBuilder(39);
            int rakam = aa.Length;
            int uzunluk = 39 - rakam;

            return aa + builder.Append('<', uzunluk);





        }
    
        private string random_soyAd()
        {
            string[] ff = File.ReadAllLines(  Application.StartupPath+"/"+confs.soyisim_path);



            Random rnd = new Random();
            int a = rnd.Next(1, ff.Length);
            return ff[a].ToString();
        }
        private string random_meslek()
        {
            string[] ff = File.ReadAllLines(  Application.StartupPath+"/"+confs.meslek_path);



            Random rnd = new Random();
            int a = rnd.Next(1, ff.Length);
            return ff[a].ToString();


        }
        public string random_image()
        {
            var rand = new Random();
            var files = Directory.GetFiles( Application.StartupPath+"/"+confs.resim_path,"*jpg");
          
            return files[rand.Next(files.Length)];

        }
        public string random_imza()
        {
            var rand = new Random();
            var files = Directory.GetFiles(  Application.StartupPath+"/"+confs.imza_path,"*.jpg");
            return files[rand.Next(files.Length)];
          //  Application.StartupPath+  Application.StartupPath+"/"+confs.
        }
       
       
        private string il()
        {
            string[] ff = File.ReadAllLines(  Application.StartupPath+"/"+confs.sehir_path);



            Random rnd = new Random();
            int a = rnd.Next(1, ff.Length);
            return ff[a].ToString();


        }
    

        public  Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var d_im = new Bitmap(width, height);

            d_im.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(d_im))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
           //d_im.Save("chip.bmp");
            return d_im;
          
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

       
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                data.pas_turu = B_Kayit.pasaportTuru.BORDO_PASAPORT;
            }
            else if (comboBox1.SelectedIndex==1)
            {
                data.pas_turu = B_Kayit.pasaportTuru.YESIL_PASAPORT;
            }
            else if (comboBox1.SelectedIndex==2)
            {
                data.pas_turu = B_Kayit.pasaportTuru.GRI_PASAPORT;
            }
            else if (comboBox1.SelectedIndex==3)
            {
                MessageBox.Show("DIPLOMATIK GONDERİLMEZ");
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex==0)
            {
                data.mernis_oncelik = B_Kayit.basvuruOncelik.NORMAL;
            }
            else if (comboBox2.SelectedIndex==1)
            {
                data.mernis_oncelik = B_Kayit.basvuruOncelik.TEKRAR_BASIM;
            }
            else if (comboBox2.SelectedIndex==2)
            {
                data.mernis_oncelik = B_Kayit.basvuruOncelik.ACIL;
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex==0)
            {
                data.teslim_Sekli = B_Kayit.teslimSekli.PTT_ILE_TESLIM;
            }
            else if (comboBox3.SelectedIndex==1)
            {
                data.teslim_Sekli = B_Kayit.teslimSekli.ELDEN_YURTDISINA_TESLIM;
            }
            else if (comboBox3.SelectedIndex==2)
            {
                data.teslim_Sekli = B_Kayit.teslimSekli.ELDEN_TESLIM;
            }
        }
        public void random_isler()
        {
            pictureBox1.ImageLocation = random_image();
            pictureBox2.ImageLocation = random_imza();
          
       

         

         

        }
        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                b_kaydet();
            }
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string [] fulld = comboBox4.SelectedItem.ToString().Split('-');
            data.alici_mernis_birim_kodu = Convert.ToInt32(fulld[0].ToString());
            data.iade_mern_birm_kodu = Convert.ToInt32(fulld[0].ToString());
        }

        private void backgroundWorker2_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
          
        }
    }
}
