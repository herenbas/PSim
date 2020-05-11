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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(new ThreadStart(create_file));
            th.Start();
            //STAThreadAttribute.IsDefined = true;


        }

        [STAThread]
        public void create_file()
        {
            System.Threading.Thread.CurrentThread.ApartmentState = System.Threading.ApartmentState.STA;

            folderBrowserDialog1.ShowNewFolderButton = true;
            Invoke((Action)(() => { folderBrowserDialog1.ShowDialog(); }));
            DirectoryInfo d = new DirectoryInfo(folderBrowserDialog1.SelectedPath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles(); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                if (Directory.Exists(Application.StartupPath + "/ChipIMG"))
                {
                    Image img = Image.FromFile(file.FullName);
                    ResizeImage(img, 240, 320,file.Name);
                }
                else
                {
                    Directory.CreateDirectory(Application.StartupPath + "/ChipIMG");
                }
            }
        }
        public Image ResizeImage(Image image, int width, int height,string fn)
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
            d_im.Save(Application.StartupPath+"/Data/Images/"+"c_"+fn);
            return d_im;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = random_image();
        }
        public string random_image()
        {
            var rand = new Random();
            var files = Directory.GetFiles(System.Environment.CurrentDirectory + "/Data/Images", "*.jpg");

            return files[rand.Next(files.Length)];

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
