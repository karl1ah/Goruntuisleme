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
        private Bitmap parlaklıkarttır(Bitmap bmp, int a)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    double red = bmp.GetPixel(i, j).R;
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
        private Bitmap parlaklıkazalt(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    double red = bmp.GetPixel(i, j).R;
                    double green = bmp.GetPixel(i, j).G;
                    double blue = bmp.GetPixel(i, j).B;
                    red = red - 100;
                    green -= 100;
                    blue -= 100;
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
        private void hıstogram_yap(Bitmap bmp)
        {
            ArrayList pıkseller = new ArrayList();
            double deger;
            int with = bmp.Width;
            int height = bmp.Height;
            for (int i = 0; i < with; i++)
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
        private Bitmap kontrasgerme_(Bitmap bmp)
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
                    renk = Color.FromArgb(Y, Y, Y);
                    bmp.SetPixel(j, i, renk);

                }
            }

            return bmp;
        }

        private Bitmap hıstogramesıtleme_(Bitmap bmp)
        {
            int[] HistogramRed = new int[256];
            int[] HistogramGreen = new int[256];
            int[] HistogramBlue = new int[256];
            int[] HistogramRedK = new int[256];
            int[] HistogramGreenK = new int[256];
            int[] HistogramBlueK = new int[256];
            int[] YüzdelikRed = new int[256];
            int[] YüzdelikGreen = new int[256];
            int[] YüzdelikBlue = new int[256];
            //int Çözünürlük;

            //String a = "";
            //Bitmap renderedImage = KaynakResim;

            uint pixels = (uint)bmp.Height * (uint)bmp.Width;
            decimal Const = 255 / (decimal)pixels;

            int x, y, R, G, B;


            int[] HistogramRed2 = new int[256];
            int[] HistogramGreen2 = new int[256];
            int[] HistogramBlue2 = new int[256];


            for (var i = 0; i < bmp.Width; i++)
            {
                for (var j = 0; j < bmp.Height; j++)
                {
                    var piksel = bmp.GetPixel(i, j);

                    HistogramRed2[(int)piksel.R]++;
                    HistogramGreen2[(int)piksel.G]++;
                    HistogramBlue2[(int)piksel.B]++;

                }
            }

            int[] cdfR = HistogramRed2;
            int[] cdfG = HistogramGreen2;
            int[] cdfB = HistogramBlue2;

            for (int r = 1; r <= 255; r++)
            {
                cdfR[r] = cdfR[r] + cdfR[r - 1];
                cdfG[r] = cdfG[r] + cdfG[r - 1];
                cdfB[r] = cdfB[r] + cdfB[r - 1];
            }

            for (y = 0; y < bmp.Height; y++)
            {
                for (x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);

                    R = (int)((decimal)cdfR[pixelColor.R] * Const);
                    G = (int)((decimal)cdfG[pixelColor.G] * Const);
                    B = (int)((decimal)cdfB[pixelColor.B] * Const);

                    Color newColor = Color.FromArgb(R, G, B);
                    bmp.SetPixel(x, y, newColor);
                }
            }

            return bmp;
        }
        private Bitmap Mean_(Bitmap bmp)
        {
            Color renk;
            int sablonboyu = Convert.ToInt32(txbmean.Text);
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
            for (x = (sablonboyu - 1) / 2; x < bmp.Width - (sablonboyu - 1) / 2; x++)
            {
                for (y = (sablonboyu - 1) / 2; y < bmp.Height - (sablonboyu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;
                    for (i = -((sablonboyu - 1) / 2); i <= (sablonboyu - 1) / 2; i++)
                    {
                        for (j = -((sablonboyu - 1) / 2); j <= (sablonboyu - 1) / 2; j++)
                        {
                            renk = bmp.GetPixel(x + i, y + j);
                            toplamR = toplamR + renk.R;
                            toplamG = toplamG + renk.G;
                            toplamB = toplamB + renk.B;
                        }
                    }
                    ortalamaR = toplamR / (sablonboyu * sablonboyu);
                    ortalamaG = toplamG / (sablonboyu * sablonboyu);
                    ortalamaB = toplamB / (sablonboyu * sablonboyu);


                    bmp.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                }
            }


            return bmp;

        }
        private Bitmap medyan_(Bitmap bmp)
        {
            Color OkunanRenk;


            int ResimGenisligi = bmp.Width;
            int ResimYuksekligi = bmp.Height;
            int SablonBoyutu = Convert.ToInt32(txbmedyan.Text); //şablon boyutu 3 den büyük tek rakam olmalıdır(3, 5, 7 gibi).
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int[] R = new int[ElemanSayisi];
            int[] G = new int[ElemanSayisi];
            int[] B = new int[ElemanSayisi];
            int[] Gri = new int[ElemanSayisi];
            int x, y, i, j;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0;
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = bmp.GetPixel(x + i, y + j);
                            R[k] = OkunanRenk.R;
                            G[k] = OkunanRenk.G;
                            B[k] = OkunanRenk.B;
                            Gri[k] = Convert.ToInt16(R[k] * 0.299 + G[k] * 0.587 + B[k] * 0.114); //Gri ton formülü

                            k++;
                        }
                    }
                    //Gri tona göre sıralama yapıyor. Aynı anda üç rengide değiştiriyor.
                    int GeciciSayi = 0;
                    for (i = 0; i < ElemanSayisi; i++)
                    {
                        for (j = i + 1; j < ElemanSayisi; j++)
                        {
                            if (Gri[j] < Gri[i])
                            {
                                GeciciSayi = Gri[i];
                                Gri[i] = Gri[j];
                                Gri[j] = GeciciSayi;
                                GeciciSayi = R[i];
                                R[i] = R[j];
                                R[j] = GeciciSayi;
                                GeciciSayi = G[i];
                                G[i] = G[j];
                                G[j] = GeciciSayi;
                                GeciciSayi = B[i];
                                B[i] = B[j];
                                B[j] = GeciciSayi;
                            }
                        }
                    }
                    //Sıralama sonrası ortadaki değeri çıkış resminin piksel değeri olarak atıyor.
                    bmp.SetPixel(x, y, Color.FromArgb(R[(ElemanSayisi - 1) / 2], G[(ElemanSayisi - 1) /
                   2], B[(ElemanSayisi - 1) / 2]));
                }
            }


            return bmp;

        }
        private Bitmap gauss_(Bitmap bmp)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = bmp;
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = 5; //Çekirdek matrisin boyutu
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
            int[] Matris = { 1, 4, 7, 4, 1, 4, 20, 33, 20, 4, 7, 33, 55, 33, 7, 4, 20, 33, 20, 4, 1, 4, 7, 4, 1 };
            int MatrisToplami = 1 + 4 + 7 + 4 + 1 + 4 + 20 + 33 + 20 + 4 + 7 + 33 + 55 + 33 + 7 + 4 + 20 + 33 + 20 + 4 + 1 + 4 + 7 + 4 + 1;


            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmitaramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;
                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0; //matris içindeki elemanları sırayla okurken kullanılacak.
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                            toplamR = toplamR + OkunanRenk.R * Matris[k];
                            toplamG = toplamG + OkunanRenk.G * Matris[k];
                            toplamB = toplamB + OkunanRenk.B * Matris[k];
                            k++;
                        }
                        ortalamaR = toplamR / MatrisToplami;
                        ortalamaG = toplamG / MatrisToplami;
                        ortalamaB = toplamB / MatrisToplami;
                        CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                    }
                }
            }


            return CikisResmi;

        }
        private Bitmap laplacıan_(Bitmap bmp)
        {
            Bitmap bm1 = new Bitmap(bmp.Width, bmp.Height);
            Bitmap cıktıresmi = new Bitmap(bmp.Width, bmp.Height);
            int width = bmp.Width - 1;
            int height = bmp.Height - 1;
            for (int i = 1; i < width; i++)
            {
                for (int j = 1; j < height; j++)
                {
                    Color renk2, renk4, renk5, renk6, renk8;
                    renk2 = bmp.GetPixel(i, j - 1);
                    renk4 = bmp.GetPixel(i - 1, j);
                    renk5 = bmp.GetPixel(i, j);
                    renk6 = bmp.GetPixel(i + 1, j);
                    renk8 = bmp.GetPixel(i, j + 1);
                    int colorred = renk2.R + renk4.R + renk5.R * (-4) + renk6.R + renk8.R;
                    int colorgreen = renk2.G + renk4.G + renk5.G * (-4) + renk6.G + renk8.G;
                    int colorblue = renk2.B + renk4.B + renk5.B * (-4) + renk6.B + renk8.B;
                    int ort = ((colorred + colorgreen + colorblue) / 3);
                    if (ort > 255)
                    {
                        ort = 255;
                    }
                    if (ort < 0)
                    {
                        ort = 0;
                    }
                    bm1.SetPixel(i, j, Color.FromArgb(ort, ort, ort));
                }
            }
            int R, G, B;
            Color OkunanRenk1, OkunanRenk2, DonusenRenk;
            for (int x = 1; x < width; x++)
            {
                for (int y = 1; y < height; y++)
                {
                    OkunanRenk1 = bmp.GetPixel(x, y);
                    OkunanRenk2 = bm1.GetPixel(x, y);
                    R = OkunanRenk1.R + OkunanRenk2.R;
                    G = OkunanRenk1.G + OkunanRenk2.G;
                    B = OkunanRenk1.B + OkunanRenk2.B;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    cıktıresmi.SetPixel(x, y, DonusenRenk);
                }
            }



            return bm1;
        }
        private Bitmap Sobel_(Bitmap bmp)
        {
            Bitmap CikisResmiXY, CikisResmiX, CikisResmiY;
            int ResimGenisligi = bmp.Width;
            int ResimYuksekligi = bmp.Height;
            CikisResmiX = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiY = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiXY = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y;
            Color Renk;
            int P1, P2, P3, P4, P5, P6, P7, P8, P9;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {

                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    Renk = bmp.GetPixel(x - 1, y - 1);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = bmp.GetPixel(x, y - 1);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = bmp.GetPixel(x + 1, y - 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = bmp.GetPixel(x - 1, y);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = bmp.GetPixel(x, y);
                    P5 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = bmp.GetPixel(x + 1, y);
                    P6 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = bmp.GetPixel(x - 1, y + 1);
                    P7 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = bmp.GetPixel(x, y + 1);
                    P8 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = bmp.GetPixel(x + 1, y + 1);
                    P9 = (Renk.R + Renk.G + Renk.B) / 3;

                    int Gx = Math.Abs(-P1 + P3 - 2 * P4 + 2 * P6 - P7 + P9);
                    int Gy = Math.Abs(P1 + 2 * P2 + P3 - P7 - 2 * P8 - P9);

                    int Gxy = Gx + Gy;
                    if (Gx > 255) Gx = 255;
                    if (Gy > 255) Gy = 255;
                    if (Gxy > 255) Gxy = 255;
                    CikisResmiX.SetPixel(x, y, Color.FromArgb(Gx, Gx, Gx));
                    CikisResmiY.SetPixel(x, y, Color.FromArgb(Gy, Gy, Gy));
                    CikisResmiXY.SetPixel(x, y, Color.FromArgb(Gxy, Gxy, Gxy));



                }
            }





            return CikisResmiXY;
        }
        private Bitmap Prewitt_(Bitmap bmp)
        {


            Bitmap GirisResmi, CikisResmi;
            GirisResmi = bmp;
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y;
            Color Renk;
            int P1, P2, P3, P4, P5, P6, P7, P8, P9;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    Renk = GirisResmi.GetPixel(x - 1, y - 1);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y - 1);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y - 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y);
                    P5 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y);
                    P6 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y + 1);
                    P7 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y + 1);
                    P8 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y + 1);
                    P9 = (Renk.R + Renk.G + Renk.B) / 3;
                    int Gx = Math.Abs(-P1 + P3 - P4 + P6 - P7 + P9); //Dikey çizgileri Bulur
                    int Gy = Math.Abs(P1 + P2 + P3 - P7 - P8 - P9); //Yatay Çizgileri Bulur.
                    int PrewittDegeri = 0;
                    PrewittDegeri = Gx;
                    PrewittDegeri = Gy;
                    PrewittDegeri = Gx + Gy; //1. Formül
                                             //PrewittDegeri = Convert.ToInt16(Math.Sqrt(Gx * Gx + Gy * Gy)); //2.Formül
                                             //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (PrewittDegeri > 255) PrewittDegeri = 255;
                    //Eşikleme: Örnek olarak 100 değeri kullanıldı.
                    //if (PrewittDegeri > 100)
                    //PrewittDegeri = 255;
                    //else
                    //PrewittDegeri = 0;
                    CikisResmi.SetPixel(x, y, Color.FromArgb(PrewittDegeri, PrewittDegeri, PrewittDegeri));
                }
            }
            return CikisResmi;

        }
        public void PerspektifDuzelt(double a00, double a01, double a02, double a10, double a11, double a12, double a20, double a21, double a22)
        {
            Bitmap GirisResmi, CikisResmi;
            Color OkunanRenk;
            GirisResmi = new Bitmap(pbxpersfektifeski.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            double X, Y, z;
            for (int x = 0; x < (ResimGenisligi); x++)
            {
                for (int y = 0; y < (ResimYuksekligi); y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    z = a20 * x + a21 * y + 1;
                    X = (a00 * x + a01 * y + a02) / z;
                    Y = (a10 * x + a11 * y + a12) / z;
                    if (X > 0 && X < ResimGenisligi && Y > 0 && Y < ResimYuksekligi)
                        //Picturebox ın dışına çıkan kısımlar oluşturulmayacak.
                        CikisResmi.SetPixel((int)X, (int)Y, OkunanRenk);
                }
            }
            pbxpersfektifyeni.Image = CikisResmi;
        }
        public double[,] MatrisTersiniAl(double[,] GirisMatrisi)
        {
            int MatrisBoyutu = Convert.ToInt16(Math.Sqrt(GirisMatrisi.Length)); //matris boyutu içindeki

            double[,] CikisMatrisi = new double[MatrisBoyutu, MatrisBoyutu]; //A nın tersi alındığında bu

            //--I Birim matrisin içeriğini dolduruyor
            for (int i = 0; i < MatrisBoyutu; i++)
            {
                for (int j = 0; j < MatrisBoyutu; j++)
                {
                    if (i == j)
                        CikisMatrisi[i, j] = 1;
                    else
                        CikisMatrisi[i, j] = 0;
                }
            }
            //--Matris Tersini alma işlemi---------
            double d, k;
            for (int i = 0; i < MatrisBoyutu; i++)
            {
                d = GirisMatrisi[i, i];
                for (int j = 0; j < MatrisBoyutu; j++)
                {
                    if (d == 0)
                    {
                        d = 0.0001; //0 bölme hata veriyordu.
                    }
                    GirisMatrisi[i, j] = GirisMatrisi[i, j] / d;
                    CikisMatrisi[i, j] = CikisMatrisi[i, j] / d;
                }
                for (int x = 0; x < MatrisBoyutu; x++)
                {
                    if (x != i)
                    {
                        k = GirisMatrisi[x, i];
                        for (int j = 0; j < MatrisBoyutu; j++)
                        {
                            GirisMatrisi[x, j] = GirisMatrisi[x, j] - GirisMatrisi[i, j] * k;
                            CikisMatrisi[x, j] = CikisMatrisi[x, j] - CikisMatrisi[i, j] * k;
                        }
                    }
                }
            }
            return CikisMatrisi;
        }


        public void GetSimilarityScore(double[,] p, double[,] q)
        {
            int Width = p.GetLength(0);
            int Height = p.GetLength(1);
            int Width1 = q.GetLength(0);
            int Height1 = q.GetLength(1);

            //if (Width != q.GetLength(0) || Height != q.GetLength(1))
            //{
            //    throw new ArgumentException("Input vectors must be of the same dimension.");
            //}

            //double pSum = 0, qSum = 0, pSumSq = 0, qSumSq = 0, productSum = 0;
            //double pValue, qValue;


            for (int i = 0; i < Width; i += Width1)
            {
                for (int j = 0; j < Height; j += Height1)
                {
                    double xtoplam = 0;
                    double ytoplam = 0;

                    double xkaretoplam = 0;
                    double ykaretoplam = 0;

                    double xycarpimlartoplami = 0;
                    for (int y = 0; y < Width1; y++)
                    {
                        for (int x = 0; x < Height1; x++)
                        {
                            //pValue = p[y, x];
                            //qValue = q[y, x];

                            //pSum += pValue;
                            //qSum += qValue;
                            //pSumSq += pValue * pValue;
                            //qSumSq += qValue * qValue;
                            //productSum += pValue * qValue;


                            xycarpimlartoplami += p[i, j] * q[y, x];
                            xtoplam += p[y, x];
                            ytoplam += q[y, x];
                            xkaretoplam += Math.Pow(p[y, x], 2);
                            ykaretoplam += Math.Pow(q[y, x], 2);
                        }
                    }
                    double n = ((double)Width) * Height;
                    double korelasyon = (n * xycarpimlartoplami - xtoplam * ytoplam) / Math.Sqrt((n * xkaretoplam - Math.Pow(xtoplam, 2)) * (n * ykaretoplam - Math.Pow(ytoplam, 2)));

                    if (0.99 < korelasyon)
                    {
                        Graphics cızım;
                        Pen kalem2 = new Pen(System.Drawing.Color.Red, 1);
                        cızım = pbxprewitteski.CreateGraphics();
                        cızım.DrawLine(kalem2, i, j, i + Height1, j + Width1);
                        MessageBox.Show("bulundu");

                    }
                }
            }



            //double numerator = productSum - ((pSum * qSum) / (double)Height);
            //double denominator = Math.Sqrt((pSumSq - (pSum * pSum) / (double)Height) * (qSumSq - (qSum * qSum) / (double)Height));




            //double numerator = productSum - ((pSum * qSum) / n);
            //double denominator =Math.Sqrt((pSumSq - (pSum * pSum) / n) * (qSumSq - (qSum * qSum) / n));

            //return (denominator == 0) ? 0 : numerator / denominator;
            // return (n * xycarpimlartoplami - xtoplam * ytoplam)
            ///
            //Math.Sqrt((n * xkaretoplam - Math.Pow(xtoplam, 2)) *
            //          (n * ykaretoplam - Math.Pow(ytoplam, 2)));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnparlaklıkart_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxparlaklıkeski.Image);
            int a = Convert.ToInt32(txbparlaklık.Text);

            Bitmap parlaklık = parlaklıkarttır(image, a);

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
            hıstogram_yap(bmp);
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

        private void btnhıstogramesıtlemeresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxhıstogramesıtleeskı.ImageLocation = sdf.FileName;
        }

        private void btnhıstogramesıtle_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxhıstogramesıtleeskı.Image);

            pbxhıstogramesıtleyenı.Image = hıstogramesıtleme_(image);
        }

        private void btnmeanresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxmeaneski.ImageLocation = sdf.FileName;
        }

        private void btnmean_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxmeaneski.Image);

            pbxmeanyeni.Image = Mean_(image);
        }

        private void btnmedyan_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxmedyaneski.Image);

            pbxmedyanyeni.Image = medyan_(image);
        }

        private void btnmedyanresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxmedyaneski.ImageLocation = sdf.FileName;
        }

        private void btngaussresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxgausseski.ImageLocation = sdf.FileName;
        }

        private void btngauss_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxgausseski.Image);

            pbxgaussyeni.Image = gauss_(image);
        }

        private void bynlaplacianresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxlaplacianeski.ImageLocation = sdf.FileName;
        }

        private void btnlaplacian_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxlaplacianeski.Image);

            pbxlaplacianyeni.Image = laplacıan_(image);
        }

        private void btnsobelresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxsobeleski.ImageLocation = sdf.FileName;
        }

        private void btnsobel_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbxsobeleski.Image);

            pbxsobelyeni.Image = Sobel_(image);
        }

        private void btnprewittresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxprewitteski.ImageLocation = sdf.FileName;
        }

        private void btnprewitt_Click(object sender, EventArgs e)
        {

            //Bitmap image = new Bitmap(pbxprewitteski.Image);

            //pbxprewittyeni.Image = Prewitt_(image);
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pbxprewitteski.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y, i, j, toplamR, toplamG, toplamB;
            int R, G, B;
            int[] Matris = { 0, -2, 0, -2, 11, -2, 0, -2, 0 };
            int MatrisToplami = 0 + -2 + 0 + -2 + 11 + -2 + 0 + -2 + 0;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi

            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;
                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0; //matris içindeki elemanları sırayla okurken kullanılacak.
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                            toplamR = toplamR + OkunanRenk.R * Matris[k];
                            toplamG = toplamG + OkunanRenk.G * Matris[k];
                            toplamB = toplamB + OkunanRenk.B * Matris[k];
                            k++;
                        }
                    }
                    R = toplamR / MatrisToplami;
                    G = toplamG / MatrisToplami;
                    B = toplamB / MatrisToplami;
                    //====================================================
                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    //====================================================
                    CikisResmi.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }
            pbxprewittyeni.Image = CikisResmi;


            //Bitmap image = new Bitmap(pbxprewitteski.Image);
            //Bitmap image2 = new Bitmap(pbxsobeleski.Image);
            //int witdh = image.Width;
            //int height = image.Height;
            //int witdh1 = image2.Width;
            //int height1 = image2.Height;

            //double[,] p = new double[height, witdh];
            //double[,] q = new double[height1, witdh1];
            //for (int i = 0; i < image.Height; i++)
            //{
            //    for (int j = 0; j < image.Width; j++)
            //    {
            //        double deger = (((image.GetPixel(j, i).R) * 0.299) + ((image.GetPixel(j, i).G) * 0.587) + ((image.GetPixel(j, i).B) * 0.114));
            //        p[i, j] = deger;
            //    }
            //}
            //for (int i = 0; i < image2.Height; i++)
            //{
            //    for (int j = 0; j < image2.Width; j++)
            //    {
            //        double deger1 = (((image2.GetPixel(j, i).R) * 0.299) + ((image2.GetPixel(j, i).G) * 0.587) + ((image2.GetPixel(j, i).B) * 0.114));
            //        q[i, j] = deger1;
            //    }
            //}
            //GetSimilarityScore(p, q);

        }

        private void btnpersfektif_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(txtPerspektif1.Text);
            double y1 = Convert.ToDouble(txtPerspektif2.Text);
            double x2 = Convert.ToDouble(txtPerspektif3.Text);
            double y2 = Convert.ToDouble(txtPerspektif4.Text);
            double x3 = Convert.ToDouble(txtPerspektif5.Text);
            double y3 = Convert.ToDouble(txtPerspektif6.Text);
            double x4 = Convert.ToDouble(txtPerspektif7.Text);
            double y4 = Convert.ToDouble(txtPerspektif8.Text);
            double X1 = Convert.ToDouble(txtPerspektif9.Text);
            double Y1 = Convert.ToDouble(txtPerspektif10.Text);
            double X2 = Convert.ToDouble(txtPerspektif11.Text);
            double Y2 = Convert.ToDouble(txtPerspektif12.Text);
            double X3 = Convert.ToDouble(txtPerspektif13.Text);
            double Y3 = Convert.ToDouble(txtPerspektif14.Text);
            double X4 = Convert.ToDouble(txtPerspektif15.Text);
            double Y4 = Convert.ToDouble(txtPerspektif16.Text);
            double[,] GirisMatrisi = new double[8, 8];
            // { x1, y1, 1, 0, 0, 0, -x1 * X1, -y1 * X1 }
            GirisMatrisi[0, 0] = x1;
            GirisMatrisi[0, 1] = y1;
            GirisMatrisi[0, 2] = 1;
            GirisMatrisi[0, 3] = 0;
            GirisMatrisi[0, 4] = 0;
            GirisMatrisi[0, 5] = 0;
            GirisMatrisi[0, 6] = -x1 * X1;
            GirisMatrisi[0, 7] = -y1 * X1;
            //{ 0, 0, 0, x1, y1, 1, -x1 * Y1, -y1 * Y1 }
            GirisMatrisi[1, 0] = 0;
            GirisMatrisi[1, 1] = 0;
            GirisMatrisi[1, 2] = 0;
            GirisMatrisi[1, 3] = x1;
            GirisMatrisi[1, 4] = y1;
            GirisMatrisi[1, 5] = 1;
            GirisMatrisi[1, 6] = -x1 * Y1;
            GirisMatrisi[1, 7] = -y1 * Y1;
            //{ x2, y2, 1, 0, 0, 0, -x2 * X2, -y2 * X2 }
            GirisMatrisi[2, 0] = x2;
            GirisMatrisi[2, 1] = y2;
            GirisMatrisi[2, 2] = 1;
            GirisMatrisi[2, 3] = 0;
            GirisMatrisi[2, 4] = 0;
            GirisMatrisi[2, 5] = 0;
            GirisMatrisi[2, 6] = -x2 * X2;
            GirisMatrisi[2, 7] = -y2 * X2;
            //{ 0, 0, 0, x2, y2, 1, -x2 * Y2, -y2 * Y2 }
            GirisMatrisi[3, 0] = 0;
            GirisMatrisi[3, 1] = 0;
            GirisMatrisi[3, 2] = 0;
            GirisMatrisi[3, 3] = x2;
            GirisMatrisi[3, 4] = y2;
            GirisMatrisi[3, 5] = 1;
            GirisMatrisi[3, 6] = -x2 * Y2;
            GirisMatrisi[3, 7] = -y2 * Y2;
            //{ x3, y3, 1, 0, 0, 0, -x3 * X3, -y3 * X3 }
            GirisMatrisi[4, 0] = x3;
            GirisMatrisi[4, 1] = y3;
            GirisMatrisi[4, 2] = 1;
            GirisMatrisi[4, 3] = 0;
            GirisMatrisi[4, 4] = 0;
            GirisMatrisi[4, 5] = 0;
            GirisMatrisi[4, 6] = -x3 * X3;
            GirisMatrisi[4, 7] = -y3 * X3;
            //{ 0, 0, 0, x3, y3, 1, -x3 * Y3, -y3 * Y3 }
            GirisMatrisi[5, 0] = 0;
            GirisMatrisi[5, 1] = 0;
            GirisMatrisi[5, 2] = 0;
            GirisMatrisi[5, 3] = x3;
            GirisMatrisi[5, 4] = y3;
            GirisMatrisi[5, 5] = 1;
            GirisMatrisi[5, 6] = -x3 * Y3;
            GirisMatrisi[5, 7] = -y3 * Y3;
            //{ x4, y4, 1, 0, 0, 0, -x4 * X4, -y4 * X4 }
            GirisMatrisi[6, 0] = x4;
            GirisMatrisi[6, 1] = y4;
            GirisMatrisi[6, 2] = 1;
            GirisMatrisi[6, 3] = 0;
            GirisMatrisi[6, 4] = 0;
            GirisMatrisi[6, 5] = 0;
            GirisMatrisi[6, 6] = -x4 * X4;
            GirisMatrisi[6, 7] = -y4 * X4;
            //{ 0, 0, 0, x4, y4, 1, -x4 * Y4, -y4 * Y4 }
            GirisMatrisi[7, 0] = 0;
            GirisMatrisi[7, 1] = 0;
            GirisMatrisi[7, 2] = 0;
            GirisMatrisi[7, 3] = x4;
            GirisMatrisi[7, 4] = y4;
            GirisMatrisi[7, 5] = 1;
            GirisMatrisi[7, 6] = -x4 * Y4;
            GirisMatrisi[7, 7] = -y4 * Y4;
            //-------------------------------------------------------
            double[,] matrisBTersi = MatrisTersiniAl(GirisMatrisi);
            double a00 = 0, a01 = 0, a02 = 0, a10 = 0, a11 = 0, a12 = 0, a20 = 0, a21 = 0, a22 = 0;
            a00 = matrisBTersi[0, 0] * X1 + matrisBTersi[0, 1] * Y1 + matrisBTersi[0, 2] *
            X2 + matrisBTersi[0, 3] * Y2 + matrisBTersi[0, 4] * X3 + matrisBTersi[0, 5] * Y3 +
            matrisBTersi[0, 6] * X4 + matrisBTersi[0, 7] * Y4;
            a01 = matrisBTersi[1, 0] * X1 + matrisBTersi[1, 1] * Y1 + matrisBTersi[1, 2] *
            X2 + matrisBTersi[1, 3] * Y2 + matrisBTersi[1, 4] * X3 + matrisBTersi[1, 5] * Y3 +
            matrisBTersi[1, 6] * X4 + matrisBTersi[1, 7] * Y4;
            a02 = matrisBTersi[2, 0] * X1 + matrisBTersi[2, 1] * Y1 + matrisBTersi[2, 2] *
            X2 + matrisBTersi[2, 3] * Y2 + matrisBTersi[2, 4] * X3 + matrisBTersi[2, 5] * Y3 +
            matrisBTersi[2, 6] * X4 + matrisBTersi[2, 7] * Y4;
            a10 = matrisBTersi[3, 0] * X1 + matrisBTersi[3, 1] * Y1 + matrisBTersi[3, 2] *
            X2 + matrisBTersi[3, 3] * Y2 + matrisBTersi[3, 4] * X3 + matrisBTersi[3, 5] * Y3 +
            matrisBTersi[3, 6] * X4 + matrisBTersi[3, 7] * Y4;
            a11 = matrisBTersi[4, 0] * X1 + matrisBTersi[4, 1] * Y1 + matrisBTersi[4, 2] *
            X2 + matrisBTersi[4, 3] * Y2 + matrisBTersi[4, 4] * X3 + matrisBTersi[4, 5] * Y3 +
            matrisBTersi[4, 6] * X4 + matrisBTersi[4, 7] * Y4;
            a12 = matrisBTersi[5, 0] * X1 + matrisBTersi[5, 1] * Y1 + matrisBTersi[5, 2] *
            X2 + matrisBTersi[5, 3] * Y2 + matrisBTersi[5, 4] * X3 + matrisBTersi[5, 5] * Y3 +
            matrisBTersi[5, 6] * X4 + matrisBTersi[5, 7] * Y4;
            a20 = matrisBTersi[6, 0] * X1 + matrisBTersi[6, 1] * Y1 + matrisBTersi[6, 2] *
            X2 + matrisBTersi[6, 3] * Y2 + matrisBTersi[6, 4] * X3 + matrisBTersi[6, 5] * Y3 +
            matrisBTersi[6, 6] * X4 + matrisBTersi[6, 7] * Y4;
            a21 = matrisBTersi[7, 0] * X1 + matrisBTersi[7, 1] * Y1 + matrisBTersi[7, 2] *
          X2 + matrisBTersi[7, 3] * Y2 + matrisBTersi[7, 4] * X3 + matrisBTersi[7, 5] * Y3 + matrisBTersi[7, 6] * X4 + matrisBTersi[7, 7] * Y4;
            a22 = 1;
            PerspektifDuzelt(a00, a01, a02, a10, a11, a12, a20, a21, a22);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpersfektifresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxpersfektifeski.ImageLocation = sdf.FileName;
        }

        private void btnaynalamaresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxaynalamaeski.ImageLocation = sdf.FileName;
        }

        private void btnaynalama_Click(object sender, EventArgs e)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pbxaynalamaeski.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            double Aci = Convert.ToDouble(txtaynalama.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;
            double x2 = 0, y2 = 0;
            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    //----A-Orta dikey eksen etrafında aynalama ----------------
                    //x2 = Convert.ToInt16(-x1 + 2 * x0); 
                    //y2 = Convert.ToInt16(y1);
                    //----B-Orta yatay eksen etrafında aynalama ----------------
                    //x2 = Convert.ToInt16(x1);
                    //y2 = Convert.ToInt16(-y1 + 2 *y0);

                    //----C-Ortadan geçen 45 açılı çizgi etrafında aynalama----------
                    double Delta = (x1 - x0) * Math.Sin(RadyanAci) - (y1 - y0) * Math.Cos(RadyanAci);
                    x2 = Convert.ToInt16(x1 + 2 * Delta * (-Math.Sin(RadyanAci)));
                    y2 = Convert.ToInt16(y1 + 2 * Delta * (Math.Cos(RadyanAci)));
                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            pbxaynalamayeni.Image = CikisResmi;
        }

        private void btndöndürmeresimal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sdf = new OpenFileDialog();
            sdf.Filter = "resimler|*.bmp|All Files|*.*";
            if (sdf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
            pbxdöndürmeeski.ImageLocation = sdf.FileName;
        }

        private void btndöndürme_Click(object sender, EventArgs e)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pbxdöndürmeeski.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int Aci = Convert.ToInt16(txtdöndürme.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;
            double x2 = 0, y2 = 0;
            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    //Döndürme Formülleri
                    x2 = Math.Cos(RadyanAci) * (x1 - x0) - Math.Sin(RadyanAci) * (y1 - y0) + x0;
                    y2 = Math.Sin(RadyanAci) * (x1 - x0) + Math.Cos(RadyanAci) * (y1 - y0) + y0;
                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            pbxdöndürmeyeni.Image = CikisResmi;
        }
    }
}

