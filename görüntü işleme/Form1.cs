using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görüntü_işleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbresimalGri.Image);
            Bitmap image1 = new Bitmap(pbresimalGri.Image);

            Bitmap gri1 = Grı1(image1);
            //Bitmap gri = Grı(image);
            pbGri.Image = gri1;
            //pictureBox2.Image = gri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbresimalGri.ImageLocation = sdf.FileName;
        }
        private Bitmap Grı1(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    double deger = (((bmp.GetPixel(j, i).R) * 0.299) + ((bmp.GetPixel(j, i).G) * 0.587) + ((bmp.GetPixel(j, i).B) * 0.114));

                    Convert.ToInt32(deger);

                    Color renk;
                    renk = Color.FromArgb(Convert.ToInt32(deger), Convert.ToInt32(deger), Convert.ToInt32(deger));
                    bmp.SetPixel(j, i, renk);

                }

            }
            return bmp;
        }
        private Bitmap parlaklıkarttır(Bitmap bmp,int a)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    double red = bmp.GetPixel( i, j).R;
                    double green = bmp.GetPixel(i, j).G;
                    double blue = bmp.GetPixel(i, j).B;
                    red = red + a;
                    green += a;
                    blue += a;
                    if (red >= 255)
                    {
                        red = 255;
                    }
                    if (green >= 255)
                    {
                        green = 255;
                    }
                    if (blue >= 255)
                    {
                        blue = 255;
                    }
                    if (red <= 0)
                    {
                        red = 0;
                    }
                    if (green <= 0)
                    {
                        green = 0;
                    }
                    if (blue <= 0)
                    {
                        blue = 0;
                    }
                    Color renk = Color.FromArgb(Convert.ToInt32(red), Convert.ToInt32(green), Convert.ToInt32(blue));
                    bmp.SetPixel(i, j, renk);

                }
            }
            return bmp;
        }
        //private Bitmap parlaklıkazalt(Bitmap bmp)
        //{
           // for (int i = 0; i < bmp.Height; i++)
           // {
               // for (int j = 0; j < bmp.Width; j++)
               // {
                   // double red = bmp.GetPixel(i, j).R;
                  //  double green = bmp.GetPixel(i, j).G;
                  //  double blue = bmp.GetPixel(i, j).B;
                   // red = red - 100;
                   // green -= 100;
                  //  blue -= 100;
                   // if (red <= 0)
                  //  {
                   //     red = 0;
                  //  }
                  //  if (green <= 0)
                  //  {
                 //       green = 0;
                   // }
                  //  if (blue <= 0)
                 //   {
                 //       blue = 0;
                  //  }
                 //   Color renk = Color.FromArgb(Convert.ToInt32(red), Convert.ToInt32(green), Convert.ToInt32(blue));
                  //  bmp.SetPixel(i, j, renk);

               // }
          //  }
         //   return bmp;
      //  }
        private Bitmap negatıfı2(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    double red = bmp.GetPixel(i, j).R;
                    double green = bmp.GetPixel(i, j).G;
                    double blue = bmp.GetPixel(i, j).B;
                    red = 255 - red;
                    green = 255 - green;
                    blue = 255 - blue;
                    Color renk = Color.FromArgb(Convert.ToInt32(red), Convert.ToInt32(green), Convert.ToInt32(blue));
                    bmp.SetPixel(i, j, renk);

                }
            }
            return bmp;
        }
        private Bitmap siyahbeyazyap(Bitmap bmp)
        {
            int esıkdeger = 100;
            double deger;
            Color renk;
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    deger = (((bmp.GetPixel(j, i).R) * 0.299) + ((bmp.GetPixel(j, i).G) * 0.587) + ((bmp.GetPixel(j, i).B) * 0.114));
                    if (deger < esıkdeger)
                    {
                        renk = Color.FromArgb(0, 0, 0);
                        bmp.SetPixel(j, i, renk);
                    }
                    else
                    {
                        renk = Color.FromArgb(255, 255, 255);
                        bmp.SetPixel(j, i, renk);
                    }
                }
            }
            return bmp;
        }
        private Bitmap esıkle(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    double red = bmp.GetPixel(i, j).R;
                    double green = bmp.GetPixel(i, j).G;
                    double blue = bmp.GetPixel(i, j).B;
                    if (red >= 128)
                    {
                        red = 255;
                    }
                    else
                    {
                        red = 0;
                    }
                    if (green >= 128)
                    {
                        green = 255;
                    }
                    else
                    {
                        green = 0;
                    }
                    if (blue >= 128)
                    {
                        blue = 255;
                    }
                    else
                    {
                        blue = 0;
                    }
                    Color renk = Color.FromArgb(Convert.ToInt32(red), Convert.ToInt32(green), Convert.ToInt32(blue));
                    bmp.SetPixel(i, j, renk);
                }
            }
            return bmp;
        }
        private Bitmap kontras(Bitmap bmp)
        {
            double kontrasdeger = Convert.ToDouble(txkontras.Text);
            //double kontrasdeger = 128;
            double KontrastFaktoru = (259 * (kontrasdeger + 255)) / (255 * (259 - kontrasdeger));
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    double red = bmp.GetPixel(i, j).R;
                    double green = bmp.GetPixel(i, j).G;
                    double blue = bmp.GetPixel(i, j).B;
                    red = (KontrastFaktoru * (red - 128)) + 128;
                    green = (KontrastFaktoru * (green - 128)) + 128;
                    blue = (KontrastFaktoru * (blue - 128)) + 128;
                    if (red > 255) red = 255;
                    if (green > 255) green = 255;
                    if (blue > 255) blue = 255;
                    if (red < 0) red = 0;
                    if (green < 0) green = 0;
                    if (blue < 0) blue = 0;
                    Color renk = Color.FromArgb(Convert.ToInt32(red), Convert.ToInt32(green), Convert.ToInt32(blue));
                    bmp.SetPixel(i, j, renk);
                }
            }
            return bmp;
        }
        private void ab2(Bitmap bmp)
        {
            ArrayList pıkseller = new ArrayList();
            double deger;
            int with = bmp.Width;
            int height = bmp.Height;
            for (int i = 0; i < with ; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    deger = (((bmp.GetPixel(j, i).R) * 0.299) + ((bmp.GetPixel(j, i).G) * 0.587) + ((bmp.GetPixel(j, i).B) * 0.114));
                    //deger = (bmp.GetPixel(j, i).R) +(bmp.GetPixel(j, i).G) + (bmp.GetPixel(j, i).B)/3;

                    pıkseller.Add(Convert.ToInt16(deger));
                }
            }
            int[] DiziPikselSayilari = new int[256];
            for (int i = 0; i < 255; i++)
            {
                int pıkselsayı = 0;
                for (int j = 0; j < pıkseller.Count; j++)
                {
                    if (i == Convert.ToInt16(pıkseller[j]))
                    {
                        pıkselsayı++;
                    }
                }
                DiziPikselSayilari[i] = pıkselsayı;
            }
            int RenkMaksPikselSayisi = 0;
            for (int i = 0; i < 255; i++)
            {
                lbxhistogram.Items.Add("Renk:" + i + "=" + DiziPikselSayilari[i]);
                if (DiziPikselSayilari[i] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[i];
                }
            }
            Graphics cızım;
            Pen kalem1 = new Pen(System.Drawing.Color.Yellow, 1);
            Pen kalem2 = new Pen(System.Drawing.Color.Red, 1);
            cızım = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();
            int grafikyuksek = 400;
            double Olceky = RenkMaksPikselSayisi / grafikyuksek, Olcekx = 1.6;
            for (int i = 0; i < 255; i++)
            {
                cızım.DrawLine(kalem1, (int)(20 + i * Olcekx), grafikyuksek, (int)(20 + i * Olcekx), (grafikyuksek - (int)(DiziPikselSayilari[i] / Olceky)));
                if (i % 50 == 0)
                {
                    cızım.DrawLine(kalem2, (int)(20 + i * Olcekx), grafikyuksek, (int)(20 + i * Olcekx), 0);
                }
            }
        }
        private Bitmap kontrasgerme_ (Bitmap bmp)
        {
            int X1 = Convert.ToInt16(txbX1.Text);
            int X2 = Convert.ToInt16(txbX2.Text);
            int Y1 = 0;
            int Y2 = 255;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    double deger = (((bmp.GetPixel(j, i).R) * 0.299) + ((bmp.GetPixel(j, i).G) * 0.587) + ((bmp.GetPixel(j, i).B) * 0.114));


                    Color renk;
                    
                   
                    int X = Convert.ToInt32(deger);
                    int Y = ((((X - X1) * Y2 - Y1)) / (X2 - X1)) + Y1;
                    if (Y > 255) Y = 255;
                    if (Y < 0) Y = 0;
                    renk = Color.FromArgb(Y,Y,Y);
                    bmp.SetPixel(j, i, renk);

                }
            }

            return bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnparlaklıkart_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxparlaklıkeski.Image);
            int a = Convert.ToInt32(txbparlaklık.Text);

            Bitmap parlaklık = parlaklıkarttır(image,a);

            pbxparlaklıkyeni.Image = parlaklık;
        }

        private void btnresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxparlaklıkeski.ImageLocation = sdf.FileName;



        }

        private void btnparlaklıkazlt_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxparlaklıkeski.Image);

            Bitmap parlaklık = parlaklıkazalt(image);

            pbxparlaklıkyeni.Image = parlaklık;
        }

        private void btnnegatifresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxnegatifeski.ImageLocation = sdf.FileName;
        }

        private void negatıfı_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxnegatifeski.Image);

            Bitmap negatıfı1 = negatıfı2(image);

            pbxnegatifyeni.Image = negatıfı1;
        }

        private void btnsbresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxsiyahbeyazeski.ImageLocation = sdf.FileName;
        }

        private void btnsiyahbeyaz_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxsiyahbeyazeski.Image);

            Bitmap sıyahbeyaz = siyahbeyazyap(image);

            pbxsiyahbeyazyeni.Image = sıyahbeyaz;
        }

        private void btnesıkleme_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxesıkleeskı.ImageLocation = sdf.FileName;
        }

        private void btnesıkle_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxesıkleeskı.Image);

            //Bitmap sıyahbeyaz = esıkle(image);

            pbxesıkleyenı.Image = esıkle(image);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxkontraseskı.ImageLocation = sdf.FileName;
        }

        private void btnkontras_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxkontraseskı.Image);

            pbxkontrasyenı.Image = kontras(image);
        }

        private void btnhistogramresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxhistogrameskı.ImageLocation = sdf.FileName;
        }

        private void histogramal_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pbxhistogrameskı.Image);
            ab2(bmp);
        }

        private void btnkontrasgerme_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxkontasgermeeski.ImageLocation = sdf.FileName;
        }

        private void btnkonrtasgerme_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxkontasgermeeski.Image);

            pbxkontrasgermeyenı.Image = kontrasgerme_(image);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsSymbol(e.KeyChar);
        }
    }
}

