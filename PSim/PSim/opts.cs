using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace PSim
{
    public partial class opts : Form
    {
        public opts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(Application.StartupPath + "/Paths.xml");
            string Isim = doc.Root.Element("Isim").Value;
            string Soyisim = doc.Root.Element("Soyisim").Value;
            string Sehir = doc.Root.Element("Sehir").Value;
            string Meslek = doc.Root.Element("Meslek").Value;
            string Resim = doc.Root.Element("Resim").Value;
            string Imza = doc.Root.Element("Imza").Value;
            string Parmak = doc.Root.Element("Parmak").Value;
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
