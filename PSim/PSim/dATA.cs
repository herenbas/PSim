using bvys_onay;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PSim
{
    class dATA
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
        public long tckn { get; set; }
        public int alici_mernis_birim_kodu { get; set; }
        public long pots_taki_kodu { get; set; }
        public B_Kayit.cinsiyet cinsiyet { get; set; }
        public int dogum_ay { get; set; }
        public int dogum_gun { get; set; }
        public int dogum_yil { get; set; }
        public int duzenlenme_tarih_ay { get; set; }
        public int duzenlenme_tarih_gun { get; set; }
        public int duzenleme_tarih_yil { get; set; }
        public string formatlanmıs_dogum_t { get; set; }
        public string formatlanmis_duzenlenme_tarihi { get; set; }
        public string formatlanmis_son_gec_tarihi { get; set; }
        public byte[] fotograf { get; set; }
        public byte[] tooken_image { get; set; }
        public int iade_mern_birm_kodu { get; set; }
        public string icao_token_image_type { get; set; }
        public byte[] islak_imza { get; set; }
        public string kps_adres { get; set; }
        public B_Kayit.basvuruOncelik mernis_oncelik { get; set; }
        public string islem_id { get; set; }
        public string meslek { get; set; }
        public string mrz_line_1 { get; set; }
        public string aciklama { get; set; }
        public B_Kayit.pasaportTuru pas_turu { get; set; }
        public string son_gecerliik_tarihi { get; set; }
        public int son_gecerlilik_taih_gun { get; set; }
        public int son_gecerlilik_tarih_ay { get; set; }
        public int son_gecerlilik_tarih_yil { get; set; }
        public string tel_no { get; set; }
        public string teslim_alici_adres_sat_1 { get; set; }
        public string teslim_alici_adres_sat_2 { get; set; }
        public string teslim_alici_adres_sat_3 { get; set; }
        public string teslim_alici_adres_sat_4 { get; set; }
        public string teslim_kisi_ad { get; set; }
        public string teslim_kisi_soyad { get; set; }
        public B_Kayit.teslimSekli teslim_Sekli { get; set; }
        public string titile { get; set; }
        public string unvan { get; set; }
        public string uyrugu { get; set; }
        public string veren_makam { get; set; }
        public string viz_Ad { get; set; }
        public string viz_soyad { get; set; }
        public string dogum_yeri { get; set; }
        public bool is_bvys_muaf { get; set; }
        public long ptt_barkod { get; set; }
        public List<string> iller { get; set; }

        public B_Kayit.standartWSSonuc basvuru_kayit()
        {
        
            var tckk_client = new B_Kayit.MernisIslemleriWSIntClient();

            var sonuc = new B_Kayit.standartWSSonuc();
            using (new OperationContextScope(tckk_client.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(
                    new SecurityHeader("UsernameToken-49", "mernis", "Test1234"));
                var tckkBasvuru = new B_Kayit.tckkBasvuru();
                tckkBasvuru.adi = adi;
                tckkBasvuru.soyadi = soyadi;
                tckkBasvuru.tckNoSpecified = true;
                tckkBasvuru.tckNo = tckn;
                tckkBasvuru.aliciMernisBirimKodu = alici_mernis_birim_kodu;
                tckkBasvuru.aliciMernisBirimKoduSpecified = true;
                tckkBasvuru.basvuruPostaTakipKod = pots_taki_kodu;
                tckkBasvuru.bvysOnayMuafSpecified = true;
                tckkBasvuru.bvysOnayMuaf = is_bvys_muaf;
                tckkBasvuru.cepTelefonNumarasi = tel_no;
                tckkBasvuru.cinsiyetSpecified = true;
                tckkBasvuru.cinsiyet = cinsiyet;
                tckkBasvuru.dogumAySpecified = true;
                tckkBasvuru.dogumAy = dogum_ay;
                tckkBasvuru.dogumGunSpecified = true;
                tckkBasvuru.dogumGun = dogum_gun;
                tckkBasvuru.dogumYeri = dogum_yeri;
                tckkBasvuru.dogumYilSpecified = true;
                tckkBasvuru.dogumYil = dogum_yil;
                tckkBasvuru.duzenlenmeTarihiAySpecified = true;
                tckkBasvuru.duzenlenmeTarihiAy = duzenlenme_tarih_ay;
                tckkBasvuru.duzenlenmeTarihiGunSpecified = true;
                tckkBasvuru.duzenlenmeTarihiGun = duzenlenme_tarih_gun;
                tckkBasvuru.duzenlenmeTarihiYilSpecified = true;
                tckkBasvuru.duzenlenmeTarihiYil = duzenleme_tarih_yil;
                tckkBasvuru.formatlanmisDogumTarihi = formatlanmıs_dogum_t;
                tckkBasvuru.formatlanmisDuzenlenmeTarihi = formatlanmis_duzenlenme_tarihi;
                tckkBasvuru.formatlanmisSonGecerlilikTarihi = formatlanmis_son_gec_tarihi;

                tckkBasvuru.fotograf = fotograf;
                tckkBasvuru.fotografIcaoTokenImage = tooken_image;
                tckkBasvuru.iadeMernisBirimKoduSpecified = true;
                tckkBasvuru.iadeMernisBirimKodu = iade_mern_birm_kodu;
                tckkBasvuru.icaoTokenImageType = "JPEG";
                tckkBasvuru.islakImza = islak_imza;
                tckkBasvuru.kpsAdres = kps_adres;
                tckkBasvuru.mernisAciklama = aciklama;
                tckkBasvuru.basvuruPostaTakipKodSpecified = true;
                tckkBasvuru.basvuruPostaTakipKod = ptt_barkod;
                tckkBasvuru.mernisIslemId = islem_id;
                tckkBasvuru.meslek = meslek;
                tckkBasvuru.mrzLine = mrz_line_1;
                tckkBasvuru.oncelikSpecified = true;
                tckkBasvuru.oncelik = mernis_oncelik;
                tckkBasvuru.pasaportTuruSpecified = true;
                tckkBasvuru.pasaportTuru = pas_turu;
                tckkBasvuru.sonGecerlilikTarihiAySpecified = true;
                tckkBasvuru.sonGecerlilikTarihiAy = son_gecerlilik_tarih_ay;
                tckkBasvuru.sonGecerlilikTarihiGunSpecified = true;
                tckkBasvuru.sonGecerlilikTarihiGun = son_gecerlilik_taih_gun;
                tckkBasvuru.sonGecerlilikTarihiYilSpecified = true;
                tckkBasvuru.sonGecerlilikTarihiYil = son_gecerlilik_tarih_yil;
                tckkBasvuru.tckNo = tckn; ;
                tckkBasvuru.telefonNumarasi = tel_no;
                tckkBasvuru.teslimAliciAdresiSatir1 = teslim_alici_adres_sat_1;
                tckkBasvuru.teslimAliciAdresiSatir2 = teslim_alici_adres_sat_2;
                tckkBasvuru.teslimAliciAdresiSatir3 = teslim_alici_adres_sat_3;
                tckkBasvuru.teslimAliciAdresiSatir4 = teslim_alici_adres_sat_4;
                tckkBasvuru.teslimKisi2Ad = teslim_kisi_ad;
                tckkBasvuru.teslimKisi2Soyad = teslim_kisi_soyad;
                tckkBasvuru.teslimKisiAd = teslim_kisi_ad;
                tckkBasvuru.teslimKisiSoyad = teslim_kisi_soyad;
                tckkBasvuru.teslimSekliSpecified = true;
                tckkBasvuru.teslimSekli = teslim_Sekli;
                tckkBasvuru.title = titile;
                tckkBasvuru.unvan = unvan;
                tckkBasvuru.uyrugu = uyrugu;
                tckkBasvuru.verenMakam = veren_makam;
                tckkBasvuru.vizAdi = viz_Ad;
                tckkBasvuru.vizSoyadi = viz_soyad;



                sonuc = tckk_client.basvuruKaydet(tckkBasvuru);

            }


            return sonuc;
        }

        public BVYS_Ser.standartWSSonuc fp_kayit (string m_id)
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

                sonuc = client.bvysOnayBildir(m_id, convert_to_DG3(Application.StartupPath+ "/Data/EF_DG3_New.xml"));
                return sonuc;

                
            }





        }
        public byte[] convert_to_DG3(string path)
        {

            FileStream stream = File.OpenRead(path);
            byte[] fileBytes = new byte[stream.Length];

            stream.Read(fileBytes, 0, fileBytes.Length);
            return fileBytes;


        }
        public List<string> datas()
        {
            iller = new List<string>();

            SqliteConnection con = new SqliteConnection(@"DataSource = " + Application.StartupPath + "/MNS.db");

            SqliteCommand com = new SqliteCommand("select * from MRNSBR", con);
            con.Open();
            SqliteDataReader rdr = com.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    iller.Add(rdr["BIRIM_KOD"].ToString() + " -" + rdr["BIRIM_AD"].ToString());

                }
            }
            rdr.Close();
            con.Close();
            return iller;
        }
        public static void LoadJson()
        {
            using (StreamReader r = new StreamReader(Application.StartupPath+@"\Data\mernis.json"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }

        public class Item
        {
            public string ıd { get; set; }
            public string bırım_kod { get; set; }
            public string bırım_ad { get; set; }
            public string durum { get; set; }
            public string tıp { get; set; }
            public string adres { get; set; }
            public string ıl { get; set; }
            public string manuel { get; set; }
            public string ulke { get; set; }

        }
    }
    class confs
    {
        public static string isim_path { get; set; }
        public static string soyisim_path { get; set; }
        public static string sehir_path { get; set; }
        public static string meslek_path { get; set; }
        public static string resim_path { get; set; }
        public static string imza_path { get; set; }
        public static string parmak_path { get; set; }
      
     

        public static void load_xml()
        {
            XDocument doc = XDocument.Load(Application.StartupPath + "/Paths.xml");
            isim_path = doc.Root.Element("Isim").Value;
            soyisim_path = doc.Root.Element("Soyisim").Value;
            sehir_path = doc.Root.Element("Sehir").Value;
            meslek_path = doc.Root.Element("Meslek").Value;
            resim_path = doc.Root.Element("Resim").Value;
            imza_path = doc.Root.Element("Imza").Value;
            parmak_path = doc.Root.Element("Parmak").Value;


        }


    }
}
