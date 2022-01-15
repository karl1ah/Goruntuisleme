
namespace görüntü_işleme
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
            this.pbresimalGri = new System.Windows.Forms.PictureBox();
            this.pbGri = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGri = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbparlaklık = new System.Windows.Forms.TextBox();
            this.pbxparlaklıkeski = new System.Windows.Forms.PictureBox();
            this.btnresimal = new System.Windows.Forms.Button();
            this.btnparlaklıkart = new System.Windows.Forms.Button();
            this.pbxparlaklıkyeni = new System.Windows.Forms.PictureBox();
            this.negatifi = new System.Windows.Forms.TabPage();
            this.pbxnegatifeski = new System.Windows.Forms.PictureBox();
            this.btnnegatifresimal = new System.Windows.Forms.Button();
            this.negatıfı = new System.Windows.Forms.Button();
            this.pbxnegatifyeni = new System.Windows.Forms.PictureBox();
            this.sihaybeyaz = new System.Windows.Forms.TabPage();
            this.pbxsiyahbeyazeski = new System.Windows.Forms.PictureBox();
            this.btnsbresimal = new System.Windows.Forms.Button();
            this.btnsiyahbeyaz = new System.Windows.Forms.Button();
            this.pbxsiyahbeyazyeni = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbxesıkleeskı = new System.Windows.Forms.PictureBox();
            this.btnesıkleme = new System.Windows.Forms.Button();
            this.btnesıkle = new System.Windows.Forms.Button();
            this.pbxesıkleyenı = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txkontras = new System.Windows.Forms.TextBox();
            this.pbxkontraseskı = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnkontras = new System.Windows.Forms.Button();
            this.pbxkontrasyenı = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbxhistogram = new System.Windows.Forms.ListBox();
            this.pbxhistogrameskı = new System.Windows.Forms.PictureBox();
            this.btnhistogramresimal = new System.Windows.Forms.Button();
            this.histogramal = new System.Windows.Forms.Button();
            this.tabpagekontrasgerme = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbX2 = new System.Windows.Forms.TextBox();
            this.txbX1 = new System.Windows.Forms.TextBox();
            this.pbxkontasgermeeski = new System.Windows.Forms.PictureBox();
            this.btnkontrasgermeresimal = new System.Windows.Forms.Button();
            this.btnkonrtasgerme = new System.Windows.Forms.Button();
            this.pbxkontrasgermeyenı = new System.Windows.Forms.PictureBox();
            this.hıstogramesıtleme = new System.Windows.Forms.TabPage();
            this.pbxhıstogramesıtleeskı = new System.Windows.Forms.PictureBox();
            this.btnhıstogramesıtlemeresimal = new System.Windows.Forms.Button();
            this.btnhıstogramesıtle = new System.Windows.Forms.Button();
            this.pbxhıstogramesıtleyenı = new System.Windows.Forms.PictureBox();
            this.mean = new System.Windows.Forms.TabPage();
            this.txbmean = new System.Windows.Forms.TextBox();
            this.pbxmeaneski = new System.Windows.Forms.PictureBox();
            this.btnmeanresimal = new System.Windows.Forms.Button();
            this.btnmean = new System.Windows.Forms.Button();
            this.pbxmeanyeni = new System.Windows.Forms.PictureBox();
            this.Medayan = new System.Windows.Forms.TabPage();
            this.txbmedyan = new System.Windows.Forms.TextBox();
            this.pbxmedyaneski = new System.Windows.Forms.PictureBox();
            this.btnmedyanresimal = new System.Windows.Forms.Button();
            this.btnmedyan = new System.Windows.Forms.Button();
            this.pbxmedyanyeni = new System.Windows.Forms.PictureBox();
            this.gauss = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbxgausseski = new System.Windows.Forms.PictureBox();
            this.btngaussresimal = new System.Windows.Forms.Button();
            this.btngauss = new System.Windows.Forms.Button();
            this.pbxgaussyeni = new System.Windows.Forms.PictureBox();
            this.laplacian = new System.Windows.Forms.TabPage();
            this.pbxlaplacianeski = new System.Windows.Forms.PictureBox();
            this.bynlaplacianresimal = new System.Windows.Forms.Button();
            this.btnlaplacian = new System.Windows.Forms.Button();
            this.pbxlaplacianyeni = new System.Windows.Forms.PictureBox();
            this.sobel = new System.Windows.Forms.TabPage();
            this.btnsobel = new System.Windows.Forms.Button();
            this.pbxsobeleski = new System.Windows.Forms.PictureBox();
            this.btnsobelresimal = new System.Windows.Forms.Button();
            this.pbxsobelyeni = new System.Windows.Forms.PictureBox();
            this.Prewitt = new System.Windows.Forms.TabPage();
            this.btnprewitt = new System.Windows.Forms.Button();
            this.pbxprewitteski = new System.Windows.Forms.PictureBox();
            this.btnprewittresimal = new System.Windows.Forms.Button();
            this.pbxprewittyeni = new System.Windows.Forms.PictureBox();
            this.persfektif = new System.Windows.Forms.TabPage();
            this.btnpersfektif = new System.Windows.Forms.Button();
            this.pbxpersfektifeski = new System.Windows.Forms.PictureBox();
            this.btnpersfektifresimal = new System.Windows.Forms.Button();
            this.pbxpersfektifyeni = new System.Windows.Forms.PictureBox();
            this.txtPerspektif1 = new System.Windows.Forms.TextBox();
            this.txtPerspektif2 = new System.Windows.Forms.TextBox();
            this.txtPerspektif3 = new System.Windows.Forms.TextBox();
            this.txtPerspektif4 = new System.Windows.Forms.TextBox();
            this.txtPerspektif5 = new System.Windows.Forms.TextBox();
            this.txtPerspektif6 = new System.Windows.Forms.TextBox();
            this.txtPerspektif7 = new System.Windows.Forms.TextBox();
            this.txtPerspektif8 = new System.Windows.Forms.TextBox();
            this.txtPerspektif9 = new System.Windows.Forms.TextBox();
            this.txtPerspektif10 = new System.Windows.Forms.TextBox();
            this.txtPerspektif11 = new System.Windows.Forms.TextBox();
            this.txtPerspektif12 = new System.Windows.Forms.TextBox();
            this.txtPerspektif13 = new System.Windows.Forms.TextBox();
            this.txtPerspektif14 = new System.Windows.Forms.TextBox();
            this.txtPerspektif15 = new System.Windows.Forms.TextBox();
            this.txtPerspektif16 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Aynalama = new System.Windows.Forms.TabPage();
            this.btnaynalama = new System.Windows.Forms.Button();
            this.pbxaynalamaeski = new System.Windows.Forms.PictureBox();
            this.btnaynalamaresimal = new System.Windows.Forms.Button();
            this.pbxaynalamayeni = new System.Windows.Forms.PictureBox();
            this.txtaynalama = new System.Windows.Forms.TextBox();
            this.döndürme = new System.Windows.Forms.TabPage();
            this.btndöndürme = new System.Windows.Forms.Button();
            this.pbxdöndürmeeski = new System.Windows.Forms.PictureBox();
            this.btndöndürmeresimal = new System.Windows.Forms.Button();
            this.pbxdöndürmeyeni = new System.Windows.Forms.PictureBox();
            this.txtdöndürme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbresimalGri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGri)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxparlaklıkeski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxparlaklıkyeni)).BeginInit();
            this.negatifi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxnegatifeski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxnegatifyeni)).BeginInit();
            this.sihaybeyaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxsiyahbeyazeski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxsiyahbeyazyeni)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxesıkleeskı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxesıkleyenı)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxkontraseskı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxkontrasyenı)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxhistogrameskı)).BeginInit();
            this.tabpagekontrasgerme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxkontasgermeeski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxkontrasgermeyenı)).BeginInit();
            this.hıstogramesıtleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxhıstogramesıtleeskı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxhıstogramesıtleyenı)).BeginInit();
            this.mean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmeaneski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmeanyeni)).BeginInit();
            this.Medayan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmedyaneski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmedyanyeni)).BeginInit();
            this.gauss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxgausseski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxgaussyeni)).BeginInit();
            this.laplacian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlaplacianeski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlaplacianyeni)).BeginInit();
            this.sobel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxsobeleski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxsobelyeni)).BeginInit();
            this.Prewitt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxprewitteski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxprewittyeni)).BeginInit();
            this.persfektif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpersfektifeski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpersfektifyeni)).BeginInit();
            this.Aynalama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxaynalamaeski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxaynalamayeni)).BeginInit();
            this.döndürme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxdöndürmeeski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxdöndürmeyeni)).BeginInit();
            this.SuspendLayout();
            // 
            // pbresimalGri
            // 
            this.pbresimalGri.Location = new System.Drawing.Point(52, 81);
            this.pbresimalGri.Name = "pbresimalGri";
            this.pbresimalGri.Size = new System.Drawing.Size(895, 710);
            this.pbresimalGri.TabIndex = 0;
            this.pbresimalGri.TabStop = false;
            // 
            // pbGri
            // 
            this.pbGri.Location = new System.Drawing.Point(953, 81);
            this.pbGri.Name = "pbGri";
            this.pbGri.Size = new System.Drawing.Size(895, 710);
            this.pbGri.TabIndex = 1;
            this.pbGri.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "resim al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGri
            // 
            this.btnGri.Location = new System.Drawing.Point(953, 30);
            this.btnGri.Name = "btnGri";
            this.btnGri.Size = new System.Drawing.Size(75, 23);
            this.btnGri.TabIndex = 3;
            this.btnGri.Text = "gri yap";
            this.btnGri.UseVisualStyleBackColor = true;
            this.btnGri.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.negatifi);
            this.tabControl1.Controls.Add(this.sihaybeyaz);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabpagekontrasgerme);
            this.tabControl1.Controls.Add(this.hıstogramesıtleme);
            this.tabControl1.Controls.Add(this.mean);
            this.tabControl1.Controls.Add(this.Medayan);
            this.tabControl1.Controls.Add(this.gauss);
            this.tabControl1.Controls.Add(this.laplacian);
            this.tabControl1.Controls.Add(this.sobel);
            this.tabControl1.Controls.Add(this.Prewitt);
            this.tabControl1.Controls.Add(this.persfektif);
            this.tabControl1.Controls.Add(this.Aynalama);
            this.tabControl1.Controls.Add(this.döndürme);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1888, 1034);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbresimalGri);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnGri);
            this.tabPage1.Controls.Add(this.pbGri);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1880, 1008);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gri yap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txbparlaklık);
            this.tabPage2.Controls.Add(this.pbxparlaklıkeski);
            this.tabPage2.Controls.Add(this.btnresimal);
            this.tabPage2.Controls.Add(this.btnparlaklıkart);
            this.tabPage2.Controls.Add(this.pbxparlaklıkyeni);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1880, 1008);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "parlaklık";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txbparlaklık
            // 
            this.txbparlaklık.Location = new System.Drawing.Point(1083, 30);
            this.txbparlaklık.Name = "txbparlaklık";
            this.txbparlaklık.Size = new System.Drawing.Size(100, 20);
            this.txbparlaklık.TabIndex = 8;
            this.txbparlaklık.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pbxparlaklıkeski
            // 
            this.pbxparlaklıkeski.Location = new System.Drawing.Point(43, 79);
            this.pbxparlaklıkeski.Name = "pbxparlaklıkeski";
            this.pbxparlaklıkeski.Size = new System.Drawing.Size(895, 710);
            this.pbxparlaklıkeski.TabIndex = 4;
            this.pbxparlaklıkeski.TabStop = false;
            // 
            // btnresimal
            // 
            this.btnresimal.Location = new System.Drawing.Point(43, 28);
            this.btnresimal.Name = "btnresimal";
            this.btnresimal.Size = new System.Drawing.Size(75, 23);
            this.btnresimal.TabIndex = 6;
            this.btnresimal.Text = "resim al";
            this.btnresimal.UseVisualStyleBackColor = true;
            this.btnresimal.Click += new System.EventHandler(this.btnresimal_Click);
            // 
            // btnparlaklıkart
            // 
            this.btnparlaklıkart.Location = new System.Drawing.Point(944, 28);
            this.btnparlaklıkart.Name = "btnparlaklıkart";
            this.btnparlaklıkart.Size = new System.Drawing.Size(113, 23);
            this.btnparlaklıkart.TabIndex = 7;
            this.btnparlaklıkart.Text = "Parlaklığı artır";
            this.btnparlaklıkart.UseVisualStyleBackColor = true;
            this.btnparlaklıkart.Click += new System.EventHandler(this.btnparlaklıkart_Click);
            // 
            // pbxparlaklıkyeni
            // 
            this.pbxparlaklıkyeni.Location = new System.Drawing.Point(944, 79);
            this.pbxparlaklıkyeni.Name = "pbxparlaklıkyeni";
            this.pbxparlaklıkyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxparlaklıkyeni.TabIndex = 5;
            this.pbxparlaklıkyeni.TabStop = false;
            // 
            // negatifi
            // 
            this.negatifi.Controls.Add(this.pbxnegatifeski);
            this.negatifi.Controls.Add(this.btnnegatifresimal);
            this.negatifi.Controls.Add(this.negatıfı);
            this.negatifi.Controls.Add(this.pbxnegatifyeni);
            this.negatifi.Location = new System.Drawing.Point(4, 22);
            this.negatifi.Name = "negatifi";
            this.negatifi.Padding = new System.Windows.Forms.Padding(3);
            this.negatifi.Size = new System.Drawing.Size(1880, 1008);
            this.negatifi.TabIndex = 2;
            this.negatifi.Text = "negatifi";
            this.negatifi.UseVisualStyleBackColor = true;
            // 
            // pbxnegatifeski
            // 
            this.pbxnegatifeski.Location = new System.Drawing.Point(43, 79);
            this.pbxnegatifeski.Name = "pbxnegatifeski";
            this.pbxnegatifeski.Size = new System.Drawing.Size(895, 710);
            this.pbxnegatifeski.TabIndex = 9;
            this.pbxnegatifeski.TabStop = false;
            // 
            // btnnegatifresimal
            // 
            this.btnnegatifresimal.Location = new System.Drawing.Point(43, 28);
            this.btnnegatifresimal.Name = "btnnegatifresimal";
            this.btnnegatifresimal.Size = new System.Drawing.Size(75, 23);
            this.btnnegatifresimal.TabIndex = 11;
            this.btnnegatifresimal.Text = "resim al";
            this.btnnegatifresimal.UseVisualStyleBackColor = true;
            this.btnnegatifresimal.Click += new System.EventHandler(this.btnnegatifresimal_Click);
            // 
            // negatıfı
            // 
            this.negatıfı.Location = new System.Drawing.Point(993, 28);
            this.negatıfı.Name = "negatıfı";
            this.negatıfı.Size = new System.Drawing.Size(113, 23);
            this.negatıfı.TabIndex = 12;
            this.negatıfı.Text = "negatifi";
            this.negatıfı.UseVisualStyleBackColor = true;
            this.negatıfı.Click += new System.EventHandler(this.negatıfı_Click);
            // 
            // pbxnegatifyeni
            // 
            this.pbxnegatifyeni.Location = new System.Drawing.Point(944, 79);
            this.pbxnegatifyeni.Name = "pbxnegatifyeni";
            this.pbxnegatifyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxnegatifyeni.TabIndex = 10;
            this.pbxnegatifyeni.TabStop = false;
            // 
            // sihaybeyaz
            // 
            this.sihaybeyaz.Controls.Add(this.pbxsiyahbeyazeski);
            this.sihaybeyaz.Controls.Add(this.btnsbresimal);
            this.sihaybeyaz.Controls.Add(this.btnsiyahbeyaz);
            this.sihaybeyaz.Controls.Add(this.pbxsiyahbeyazyeni);
            this.sihaybeyaz.Location = new System.Drawing.Point(4, 22);
            this.sihaybeyaz.Name = "sihaybeyaz";
            this.sihaybeyaz.Padding = new System.Windows.Forms.Padding(3);
            this.sihaybeyaz.Size = new System.Drawing.Size(1880, 1008);
            this.sihaybeyaz.TabIndex = 3;
            this.sihaybeyaz.Text = "siyahbeyaz ";
            this.sihaybeyaz.UseVisualStyleBackColor = true;
            // 
            // pbxsiyahbeyazeski
            // 
            this.pbxsiyahbeyazeski.Location = new System.Drawing.Point(43, 87);
            this.pbxsiyahbeyazeski.Name = "pbxsiyahbeyazeski";
            this.pbxsiyahbeyazeski.Size = new System.Drawing.Size(895, 710);
            this.pbxsiyahbeyazeski.TabIndex = 13;
            this.pbxsiyahbeyazeski.TabStop = false;
            // 
            // btnsbresimal
            // 
            this.btnsbresimal.Location = new System.Drawing.Point(43, 36);
            this.btnsbresimal.Name = "btnsbresimal";
            this.btnsbresimal.Size = new System.Drawing.Size(75, 23);
            this.btnsbresimal.TabIndex = 15;
            this.btnsbresimal.Text = "resim al";
            this.btnsbresimal.UseVisualStyleBackColor = true;
            this.btnsbresimal.Click += new System.EventHandler(this.btnsbresimal_Click);
            // 
            // btnsiyahbeyaz
            // 
            this.btnsiyahbeyaz.Location = new System.Drawing.Point(962, 36);
            this.btnsiyahbeyaz.Name = "btnsiyahbeyaz";
            this.btnsiyahbeyaz.Size = new System.Drawing.Size(113, 23);
            this.btnsiyahbeyaz.TabIndex = 16;
            this.btnsiyahbeyaz.Text = "siyah beyaz yap";
            this.btnsiyahbeyaz.UseVisualStyleBackColor = true;
            this.btnsiyahbeyaz.Click += new System.EventHandler(this.btnsiyahbeyaz_Click);
            // 
            // pbxsiyahbeyazyeni
            // 
            this.pbxsiyahbeyazyeni.Location = new System.Drawing.Point(944, 87);
            this.pbxsiyahbeyazyeni.Name = "pbxsiyahbeyazyeni";
            this.pbxsiyahbeyazyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxsiyahbeyazyeni.TabIndex = 14;
            this.pbxsiyahbeyazyeni.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pbxesıkleeskı);
            this.tabPage3.Controls.Add(this.btnesıkleme);
            this.tabPage3.Controls.Add(this.btnesıkle);
            this.tabPage3.Controls.Add(this.pbxesıkleyenı);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1880, 1008);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "eşikleme";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbxesıkleeskı
            // 
            this.pbxesıkleeskı.Location = new System.Drawing.Point(41, 89);
            this.pbxesıkleeskı.Name = "pbxesıkleeskı";
            this.pbxesıkleeskı.Size = new System.Drawing.Size(895, 710);
            this.pbxesıkleeskı.TabIndex = 17;
            this.pbxesıkleeskı.TabStop = false;
            // 
            // btnesıkleme
            // 
            this.btnesıkleme.Location = new System.Drawing.Point(41, 38);
            this.btnesıkleme.Name = "btnesıkleme";
            this.btnesıkleme.Size = new System.Drawing.Size(75, 23);
            this.btnesıkleme.TabIndex = 19;
            this.btnesıkleme.Text = "resim al";
            this.btnesıkleme.UseVisualStyleBackColor = true;
            this.btnesıkleme.Click += new System.EventHandler(this.btnesıkleme_Click);
            // 
            // btnesıkle
            // 
            this.btnesıkle.Location = new System.Drawing.Point(960, 38);
            this.btnesıkle.Name = "btnesıkle";
            this.btnesıkle.Size = new System.Drawing.Size(113, 23);
            this.btnesıkle.TabIndex = 20;
            this.btnesıkle.Text = "eşikle";
            this.btnesıkle.UseVisualStyleBackColor = true;
            this.btnesıkle.Click += new System.EventHandler(this.btnesıkle_Click);
            // 
            // pbxesıkleyenı
            // 
            this.pbxesıkleyenı.Location = new System.Drawing.Point(942, 89);
            this.pbxesıkleyenı.Name = "pbxesıkleyenı";
            this.pbxesıkleyenı.Size = new System.Drawing.Size(895, 710);
            this.pbxesıkleyenı.TabIndex = 18;
            this.pbxesıkleyenı.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txkontras);
            this.tabPage4.Controls.Add(this.pbxkontraseskı);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.btnkontras);
            this.tabPage4.Controls.Add(this.pbxkontrasyenı);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1880, 1008);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "kontras";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txkontras
            // 
            this.txkontras.Location = new System.Drawing.Point(947, 40);
            this.txkontras.Name = "txkontras";
            this.txkontras.Size = new System.Drawing.Size(100, 20);
            this.txkontras.TabIndex = 25;
            // 
            // pbxkontraseskı
            // 
            this.pbxkontraseskı.Location = new System.Drawing.Point(46, 88);
            this.pbxkontraseskı.Name = "pbxkontraseskı";
            this.pbxkontraseskı.Size = new System.Drawing.Size(895, 710);
            this.pbxkontraseskı.TabIndex = 21;
            this.pbxkontraseskı.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "resim al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnkontras
            // 
            this.btnkontras.Location = new System.Drawing.Point(1171, 37);
            this.btnkontras.Name = "btnkontras";
            this.btnkontras.Size = new System.Drawing.Size(113, 23);
            this.btnkontras.TabIndex = 24;
            this.btnkontras.Text = "kontas";
            this.btnkontras.UseVisualStyleBackColor = true;
            this.btnkontras.Click += new System.EventHandler(this.btnkontras_Click);
            // 
            // pbxkontrasyenı
            // 
            this.pbxkontrasyenı.Location = new System.Drawing.Point(947, 88);
            this.pbxkontrasyenı.Name = "pbxkontrasyenı";
            this.pbxkontrasyenı.Size = new System.Drawing.Size(895, 710);
            this.pbxkontrasyenı.TabIndex = 22;
            this.pbxkontrasyenı.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Controls.Add(this.lbxhistogram);
            this.tabPage5.Controls.Add(this.pbxhistogrameskı);
            this.tabPage5.Controls.Add(this.btnhistogramresimal);
            this.tabPage5.Controls.Add(this.histogramal);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1880, 1008);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "histogram";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1224, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 634);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lbxhistogram
            // 
            this.lbxhistogram.FormattingEnabled = true;
            this.lbxhistogram.Location = new System.Drawing.Point(866, 86);
            this.lbxhistogram.Name = "lbxhistogram";
            this.lbxhistogram.Size = new System.Drawing.Size(352, 706);
            this.lbxhistogram.TabIndex = 31;
            // 
            // pbxhistogrameskı
            // 
            this.pbxhistogrameskı.Location = new System.Drawing.Point(40, 82);
            this.pbxhistogrameskı.Name = "pbxhistogrameskı";
            this.pbxhistogrameskı.Size = new System.Drawing.Size(729, 710);
            this.pbxhistogrameskı.TabIndex = 26;
            this.pbxhistogrameskı.TabStop = false;
            // 
            // btnhistogramresimal
            // 
            this.btnhistogramresimal.Location = new System.Drawing.Point(40, 31);
            this.btnhistogramresimal.Name = "btnhistogramresimal";
            this.btnhistogramresimal.Size = new System.Drawing.Size(75, 23);
            this.btnhistogramresimal.TabIndex = 28;
            this.btnhistogramresimal.Text = "resim al";
            this.btnhistogramresimal.UseVisualStyleBackColor = true;
            this.btnhistogramresimal.Click += new System.EventHandler(this.btnhistogramresimal_Click);
            // 
            // histogramal
            // 
            this.histogramal.Location = new System.Drawing.Point(866, 31);
            this.histogramal.Name = "histogramal";
            this.histogramal.Size = new System.Drawing.Size(113, 23);
            this.histogramal.TabIndex = 29;
            this.histogramal.Text = "histohram";
            this.histogramal.UseVisualStyleBackColor = true;
            this.histogramal.Click += new System.EventHandler(this.histogramal_Click);
            // 
            // tabpagekontrasgerme
            // 
            this.tabpagekontrasgerme.Controls.Add(this.label2);
            this.tabpagekontrasgerme.Controls.Add(this.label1);
            this.tabpagekontrasgerme.Controls.Add(this.txbX2);
            this.tabpagekontrasgerme.Controls.Add(this.txbX1);
            this.tabpagekontrasgerme.Controls.Add(this.pbxkontasgermeeski);
            this.tabpagekontrasgerme.Controls.Add(this.btnkontrasgermeresimal);
            this.tabpagekontrasgerme.Controls.Add(this.btnkonrtasgerme);
            this.tabpagekontrasgerme.Controls.Add(this.pbxkontrasgermeyenı);
            this.tabpagekontrasgerme.Location = new System.Drawing.Point(4, 22);
            this.tabpagekontrasgerme.Name = "tabpagekontrasgerme";
            this.tabpagekontrasgerme.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagekontrasgerme.Size = new System.Drawing.Size(1880, 1008);
            this.tabpagekontrasgerme.TabIndex = 7;
            this.tabpagekontrasgerme.Text = "Kontras Germe";
            this.tabpagekontrasgerme.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1216, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "X2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1110, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "X1";
            // 
            // txbX2
            // 
            this.txbX2.Location = new System.Drawing.Point(1219, 39);
            this.txbX2.Name = "txbX2";
            this.txbX2.Size = new System.Drawing.Size(100, 20);
            this.txbX2.TabIndex = 27;
            // 
            // txbX1
            // 
            this.txbX1.Location = new System.Drawing.Point(1113, 39);
            this.txbX1.Name = "txbX1";
            this.txbX1.Size = new System.Drawing.Size(100, 20);
            this.txbX1.TabIndex = 26;
            // 
            // pbxkontasgermeeski
            // 
            this.pbxkontasgermeeski.Location = new System.Drawing.Point(43, 88);
            this.pbxkontasgermeeski.Name = "pbxkontasgermeeski";
            this.pbxkontasgermeeski.Size = new System.Drawing.Size(895, 710);
            this.pbxkontasgermeeski.TabIndex = 21;
            this.pbxkontasgermeeski.TabStop = false;
            // 
            // btnkontrasgermeresimal
            // 
            this.btnkontrasgermeresimal.Location = new System.Drawing.Point(43, 37);
            this.btnkontrasgermeresimal.Name = "btnkontrasgermeresimal";
            this.btnkontrasgermeresimal.Size = new System.Drawing.Size(75, 23);
            this.btnkontrasgermeresimal.TabIndex = 23;
            this.btnkontrasgermeresimal.Text = "resim al";
            this.btnkontrasgermeresimal.UseVisualStyleBackColor = true;
            this.btnkontrasgermeresimal.Click += new System.EventHandler(this.btnkontrasgerme_Click);
            // 
            // btnkonrtasgerme
            // 
            this.btnkonrtasgerme.Location = new System.Drawing.Point(962, 37);
            this.btnkonrtasgerme.Name = "btnkonrtasgerme";
            this.btnkonrtasgerme.Size = new System.Drawing.Size(113, 23);
            this.btnkonrtasgerme.TabIndex = 24;
            this.btnkonrtasgerme.Text = "Kontras Germe";
            this.btnkonrtasgerme.UseVisualStyleBackColor = true;
            this.btnkonrtasgerme.Click += new System.EventHandler(this.btnkonrtasgerme_Click);
            // 
            // pbxkontrasgermeyenı
            // 
            this.pbxkontrasgermeyenı.Location = new System.Drawing.Point(944, 88);
            this.pbxkontrasgermeyenı.Name = "pbxkontrasgermeyenı";
            this.pbxkontrasgermeyenı.Size = new System.Drawing.Size(895, 710);
            this.pbxkontrasgermeyenı.TabIndex = 22;
            this.pbxkontrasgermeyenı.TabStop = false;
            // 
            // hıstogramesıtleme
            // 
            this.hıstogramesıtleme.Controls.Add(this.pbxhıstogramesıtleeskı);
            this.hıstogramesıtleme.Controls.Add(this.btnhıstogramesıtlemeresimal);
            this.hıstogramesıtleme.Controls.Add(this.btnhıstogramesıtle);
            this.hıstogramesıtleme.Controls.Add(this.pbxhıstogramesıtleyenı);
            this.hıstogramesıtleme.Location = new System.Drawing.Point(4, 22);
            this.hıstogramesıtleme.Name = "hıstogramesıtleme";
            this.hıstogramesıtleme.Padding = new System.Windows.Forms.Padding(3);
            this.hıstogramesıtleme.Size = new System.Drawing.Size(1880, 1008);
            this.hıstogramesıtleme.TabIndex = 8;
            this.hıstogramesıtleme.Text = "Histogram eşitleme";
            this.hıstogramesıtleme.UseVisualStyleBackColor = true;
            // 
            // pbxhıstogramesıtleeskı
            // 
            this.pbxhıstogramesıtleeskı.Location = new System.Drawing.Point(46, 91);
            this.pbxhıstogramesıtleeskı.Name = "pbxhıstogramesıtleeskı";
            this.pbxhıstogramesıtleeskı.Size = new System.Drawing.Size(895, 710);
            this.pbxhıstogramesıtleeskı.TabIndex = 21;
            this.pbxhıstogramesıtleeskı.TabStop = false;
            // 
            // btnhıstogramesıtlemeresimal
            // 
            this.btnhıstogramesıtlemeresimal.Location = new System.Drawing.Point(46, 40);
            this.btnhıstogramesıtlemeresimal.Name = "btnhıstogramesıtlemeresimal";
            this.btnhıstogramesıtlemeresimal.Size = new System.Drawing.Size(75, 23);
            this.btnhıstogramesıtlemeresimal.TabIndex = 23;
            this.btnhıstogramesıtlemeresimal.Text = "resim al";
            this.btnhıstogramesıtlemeresimal.UseVisualStyleBackColor = true;
            this.btnhıstogramesıtlemeresimal.Click += new System.EventHandler(this.btnhıstogramesıtlemeresimal_Click);
            // 
            // btnhıstogramesıtle
            // 
            this.btnhıstogramesıtle.Location = new System.Drawing.Point(965, 40);
            this.btnhıstogramesıtle.Name = "btnhıstogramesıtle";
            this.btnhıstogramesıtle.Size = new System.Drawing.Size(113, 23);
            this.btnhıstogramesıtle.TabIndex = 24;
            this.btnhıstogramesıtle.Text = "Histogram eşitle";
            this.btnhıstogramesıtle.UseVisualStyleBackColor = true;
            this.btnhıstogramesıtle.Click += new System.EventHandler(this.btnhıstogramesıtle_Click);
            // 
            // pbxhıstogramesıtleyenı
            // 
            this.pbxhıstogramesıtleyenı.Location = new System.Drawing.Point(947, 91);
            this.pbxhıstogramesıtleyenı.Name = "pbxhıstogramesıtleyenı";
            this.pbxhıstogramesıtleyenı.Size = new System.Drawing.Size(895, 710);
            this.pbxhıstogramesıtleyenı.TabIndex = 22;
            this.pbxhıstogramesıtleyenı.TabStop = false;
            // 
            // mean
            // 
            this.mean.Controls.Add(this.txbmean);
            this.mean.Controls.Add(this.pbxmeaneski);
            this.mean.Controls.Add(this.btnmeanresimal);
            this.mean.Controls.Add(this.btnmean);
            this.mean.Controls.Add(this.pbxmeanyeni);
            this.mean.Location = new System.Drawing.Point(4, 22);
            this.mean.Name = "mean";
            this.mean.Padding = new System.Windows.Forms.Padding(3);
            this.mean.Size = new System.Drawing.Size(1880, 1008);
            this.mean.TabIndex = 9;
            this.mean.Text = "Mean";
            this.mean.UseVisualStyleBackColor = true;
            // 
            // txbmean
            // 
            this.txbmean.Location = new System.Drawing.Point(943, 33);
            this.txbmean.Name = "txbmean";
            this.txbmean.Size = new System.Drawing.Size(100, 20);
            this.txbmean.TabIndex = 30;
            // 
            // pbxmeaneski
            // 
            this.pbxmeaneski.Location = new System.Drawing.Point(42, 81);
            this.pbxmeaneski.Name = "pbxmeaneski";
            this.pbxmeaneski.Size = new System.Drawing.Size(895, 710);
            this.pbxmeaneski.TabIndex = 26;
            this.pbxmeaneski.TabStop = false;
            // 
            // btnmeanresimal
            // 
            this.btnmeanresimal.Location = new System.Drawing.Point(42, 30);
            this.btnmeanresimal.Name = "btnmeanresimal";
            this.btnmeanresimal.Size = new System.Drawing.Size(75, 23);
            this.btnmeanresimal.TabIndex = 28;
            this.btnmeanresimal.Text = "resim al";
            this.btnmeanresimal.UseVisualStyleBackColor = true;
            this.btnmeanresimal.Click += new System.EventHandler(this.btnmeanresimal_Click);
            // 
            // btnmean
            // 
            this.btnmean.Location = new System.Drawing.Point(1128, 30);
            this.btnmean.Name = "btnmean";
            this.btnmean.Size = new System.Drawing.Size(113, 23);
            this.btnmean.TabIndex = 29;
            this.btnmean.Text = "Mean";
            this.btnmean.UseVisualStyleBackColor = true;
            this.btnmean.Click += new System.EventHandler(this.btnmean_Click);
            // 
            // pbxmeanyeni
            // 
            this.pbxmeanyeni.Location = new System.Drawing.Point(943, 81);
            this.pbxmeanyeni.Name = "pbxmeanyeni";
            this.pbxmeanyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxmeanyeni.TabIndex = 27;
            this.pbxmeanyeni.TabStop = false;
            // 
            // Medayan
            // 
            this.Medayan.Controls.Add(this.txbmedyan);
            this.Medayan.Controls.Add(this.pbxmedyaneski);
            this.Medayan.Controls.Add(this.btnmedyanresimal);
            this.Medayan.Controls.Add(this.btnmedyan);
            this.Medayan.Controls.Add(this.pbxmedyanyeni);
            this.Medayan.Location = new System.Drawing.Point(4, 22);
            this.Medayan.Name = "Medayan";
            this.Medayan.Padding = new System.Windows.Forms.Padding(3);
            this.Medayan.Size = new System.Drawing.Size(1880, 1008);
            this.Medayan.TabIndex = 10;
            this.Medayan.Text = "Medyan";
            this.Medayan.UseVisualStyleBackColor = true;
            // 
            // txbmedyan
            // 
            this.txbmedyan.Location = new System.Drawing.Point(938, 36);
            this.txbmedyan.Name = "txbmedyan";
            this.txbmedyan.Size = new System.Drawing.Size(100, 20);
            this.txbmedyan.TabIndex = 35;
            // 
            // pbxmedyaneski
            // 
            this.pbxmedyaneski.Location = new System.Drawing.Point(37, 84);
            this.pbxmedyaneski.Name = "pbxmedyaneski";
            this.pbxmedyaneski.Size = new System.Drawing.Size(895, 710);
            this.pbxmedyaneski.TabIndex = 31;
            this.pbxmedyaneski.TabStop = false;
            // 
            // btnmedyanresimal
            // 
            this.btnmedyanresimal.Location = new System.Drawing.Point(37, 33);
            this.btnmedyanresimal.Name = "btnmedyanresimal";
            this.btnmedyanresimal.Size = new System.Drawing.Size(75, 23);
            this.btnmedyanresimal.TabIndex = 33;
            this.btnmedyanresimal.Text = "resim al";
            this.btnmedyanresimal.UseVisualStyleBackColor = true;
            this.btnmedyanresimal.Click += new System.EventHandler(this.btnmedyanresimal_Click);
            // 
            // btnmedyan
            // 
            this.btnmedyan.Location = new System.Drawing.Point(1086, 33);
            this.btnmedyan.Name = "btnmedyan";
            this.btnmedyan.Size = new System.Drawing.Size(113, 23);
            this.btnmedyan.TabIndex = 34;
            this.btnmedyan.Text = "Medyan";
            this.btnmedyan.UseVisualStyleBackColor = true;
            this.btnmedyan.Click += new System.EventHandler(this.btnmedyan_Click);
            // 
            // pbxmedyanyeni
            // 
            this.pbxmedyanyeni.Location = new System.Drawing.Point(938, 84);
            this.pbxmedyanyeni.Name = "pbxmedyanyeni";
            this.pbxmedyanyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxmedyanyeni.TabIndex = 32;
            this.pbxmedyanyeni.TabStop = false;
            // 
            // gauss
            // 
            this.gauss.Controls.Add(this.textBox1);
            this.gauss.Controls.Add(this.pbxgausseski);
            this.gauss.Controls.Add(this.btngaussresimal);
            this.gauss.Controls.Add(this.btngauss);
            this.gauss.Controls.Add(this.pbxgaussyeni);
            this.gauss.Location = new System.Drawing.Point(4, 22);
            this.gauss.Name = "gauss";
            this.gauss.Padding = new System.Windows.Forms.Padding(3);
            this.gauss.Size = new System.Drawing.Size(1880, 1008);
            this.gauss.TabIndex = 11;
            this.gauss.Text = "Gauss";
            this.gauss.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(940, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 40;
            // 
            // pbxgausseski
            // 
            this.pbxgausseski.Location = new System.Drawing.Point(39, 90);
            this.pbxgausseski.Name = "pbxgausseski";
            this.pbxgausseski.Size = new System.Drawing.Size(895, 710);
            this.pbxgausseski.TabIndex = 36;
            this.pbxgausseski.TabStop = false;
            // 
            // btngaussresimal
            // 
            this.btngaussresimal.Location = new System.Drawing.Point(39, 39);
            this.btngaussresimal.Name = "btngaussresimal";
            this.btngaussresimal.Size = new System.Drawing.Size(75, 23);
            this.btngaussresimal.TabIndex = 38;
            this.btngaussresimal.Text = "resim al";
            this.btngaussresimal.UseVisualStyleBackColor = true;
            this.btngaussresimal.Click += new System.EventHandler(this.btngaussresimal_Click);
            // 
            // btngauss
            // 
            this.btngauss.Location = new System.Drawing.Point(1088, 39);
            this.btngauss.Name = "btngauss";
            this.btngauss.Size = new System.Drawing.Size(113, 23);
            this.btngauss.TabIndex = 39;
            this.btngauss.Text = "Gauss";
            this.btngauss.UseVisualStyleBackColor = true;
            this.btngauss.Click += new System.EventHandler(this.btngauss_Click);
            // 
            // pbxgaussyeni
            // 
            this.pbxgaussyeni.Location = new System.Drawing.Point(940, 90);
            this.pbxgaussyeni.Name = "pbxgaussyeni";
            this.pbxgaussyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxgaussyeni.TabIndex = 37;
            this.pbxgaussyeni.TabStop = false;
            // 
            // laplacian
            // 
            this.laplacian.Controls.Add(this.pbxlaplacianeski);
            this.laplacian.Controls.Add(this.bynlaplacianresimal);
            this.laplacian.Controls.Add(this.btnlaplacian);
            this.laplacian.Controls.Add(this.pbxlaplacianyeni);
            this.laplacian.Location = new System.Drawing.Point(4, 22);
            this.laplacian.Name = "laplacian";
            this.laplacian.Padding = new System.Windows.Forms.Padding(3);
            this.laplacian.Size = new System.Drawing.Size(1880, 1008);
            this.laplacian.TabIndex = 12;
            this.laplacian.Text = "laplacian";
            this.laplacian.UseVisualStyleBackColor = true;
            // 
            // pbxlaplacianeski
            // 
            this.pbxlaplacianeski.Location = new System.Drawing.Point(43, 83);
            this.pbxlaplacianeski.Name = "pbxlaplacianeski";
            this.pbxlaplacianeski.Size = new System.Drawing.Size(895, 710);
            this.pbxlaplacianeski.TabIndex = 41;
            this.pbxlaplacianeski.TabStop = false;
            // 
            // bynlaplacianresimal
            // 
            this.bynlaplacianresimal.Location = new System.Drawing.Point(43, 32);
            this.bynlaplacianresimal.Name = "bynlaplacianresimal";
            this.bynlaplacianresimal.Size = new System.Drawing.Size(75, 23);
            this.bynlaplacianresimal.TabIndex = 43;
            this.bynlaplacianresimal.Text = "resim al";
            this.bynlaplacianresimal.UseVisualStyleBackColor = true;
            this.bynlaplacianresimal.Click += new System.EventHandler(this.bynlaplacianresimal_Click);
            // 
            // btnlaplacian
            // 
            this.btnlaplacian.Location = new System.Drawing.Point(1092, 32);
            this.btnlaplacian.Name = "btnlaplacian";
            this.btnlaplacian.Size = new System.Drawing.Size(113, 23);
            this.btnlaplacian.TabIndex = 44;
            this.btnlaplacian.Text = "Laplacian";
            this.btnlaplacian.UseVisualStyleBackColor = true;
            this.btnlaplacian.Click += new System.EventHandler(this.btnlaplacian_Click);
            // 
            // pbxlaplacianyeni
            // 
            this.pbxlaplacianyeni.Location = new System.Drawing.Point(944, 83);
            this.pbxlaplacianyeni.Name = "pbxlaplacianyeni";
            this.pbxlaplacianyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxlaplacianyeni.TabIndex = 42;
            this.pbxlaplacianyeni.TabStop = false;
            // 
            // sobel
            // 
            this.sobel.Controls.Add(this.btnsobel);
            this.sobel.Controls.Add(this.pbxsobeleski);
            this.sobel.Controls.Add(this.btnsobelresimal);
            this.sobel.Controls.Add(this.pbxsobelyeni);
            this.sobel.Location = new System.Drawing.Point(4, 22);
            this.sobel.Name = "sobel";
            this.sobel.Padding = new System.Windows.Forms.Padding(3);
            this.sobel.Size = new System.Drawing.Size(1880, 1008);
            this.sobel.TabIndex = 13;
            this.sobel.Text = "Sobel";
            this.sobel.UseVisualStyleBackColor = true;
            // 
            // btnsobel
            // 
            this.btnsobel.Location = new System.Drawing.Point(1020, 32);
            this.btnsobel.Name = "btnsobel";
            this.btnsobel.Size = new System.Drawing.Size(75, 23);
            this.btnsobel.TabIndex = 47;
            this.btnsobel.Text = "Sobel";
            this.btnsobel.UseVisualStyleBackColor = true;
            this.btnsobel.Click += new System.EventHandler(this.btnsobel_Click);
            // 
            // pbxsobeleski
            // 
            this.pbxsobeleski.Location = new System.Drawing.Point(41, 83);
            this.pbxsobeleski.Name = "pbxsobeleski";
            this.pbxsobeleski.Size = new System.Drawing.Size(895, 710);
            this.pbxsobeleski.TabIndex = 44;
            this.pbxsobeleski.TabStop = false;
            // 
            // btnsobelresimal
            // 
            this.btnsobelresimal.Location = new System.Drawing.Point(41, 32);
            this.btnsobelresimal.Name = "btnsobelresimal";
            this.btnsobelresimal.Size = new System.Drawing.Size(75, 23);
            this.btnsobelresimal.TabIndex = 46;
            this.btnsobelresimal.Text = "resim al";
            this.btnsobelresimal.UseVisualStyleBackColor = true;
            this.btnsobelresimal.Click += new System.EventHandler(this.btnsobelresimal_Click);
            // 
            // pbxsobelyeni
            // 
            this.pbxsobelyeni.Location = new System.Drawing.Point(942, 83);
            this.pbxsobelyeni.Name = "pbxsobelyeni";
            this.pbxsobelyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxsobelyeni.TabIndex = 45;
            this.pbxsobelyeni.TabStop = false;
            // 
            // Prewitt
            // 
            this.Prewitt.Controls.Add(this.btnprewitt);
            this.Prewitt.Controls.Add(this.pbxprewitteski);
            this.Prewitt.Controls.Add(this.btnprewittresimal);
            this.Prewitt.Controls.Add(this.pbxprewittyeni);
            this.Prewitt.Location = new System.Drawing.Point(4, 22);
            this.Prewitt.Name = "Prewitt";
            this.Prewitt.Padding = new System.Windows.Forms.Padding(3);
            this.Prewitt.Size = new System.Drawing.Size(1880, 1008);
            this.Prewitt.TabIndex = 14;
            this.Prewitt.Text = "Prewitt";
            this.Prewitt.UseVisualStyleBackColor = true;
            // 
            // btnprewitt
            // 
            this.btnprewitt.Location = new System.Drawing.Point(1025, 29);
            this.btnprewitt.Name = "btnprewitt";
            this.btnprewitt.Size = new System.Drawing.Size(75, 23);
            this.btnprewitt.TabIndex = 51;
            this.btnprewitt.Text = "Prewitt";
            this.btnprewitt.UseVisualStyleBackColor = true;
            this.btnprewitt.Click += new System.EventHandler(this.btnprewitt_Click);
            // 
            // pbxprewitteski
            // 
            this.pbxprewitteski.Location = new System.Drawing.Point(46, 80);
            this.pbxprewitteski.Name = "pbxprewitteski";
            this.pbxprewitteski.Size = new System.Drawing.Size(895, 710);
            this.pbxprewitteski.TabIndex = 48;
            this.pbxprewitteski.TabStop = false;
            // 
            // btnprewittresimal
            // 
            this.btnprewittresimal.Location = new System.Drawing.Point(46, 29);
            this.btnprewittresimal.Name = "btnprewittresimal";
            this.btnprewittresimal.Size = new System.Drawing.Size(75, 23);
            this.btnprewittresimal.TabIndex = 50;
            this.btnprewittresimal.Text = "resim al";
            this.btnprewittresimal.UseVisualStyleBackColor = true;
            this.btnprewittresimal.Click += new System.EventHandler(this.btnprewittresimal_Click);
            // 
            // pbxprewittyeni
            // 
            this.pbxprewittyeni.Location = new System.Drawing.Point(947, 80);
            this.pbxprewittyeni.Name = "pbxprewittyeni";
            this.pbxprewittyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxprewittyeni.TabIndex = 49;
            this.pbxprewittyeni.TabStop = false;
            // 
            // persfektif
            // 
            this.persfektif.Controls.Add(this.label18);
            this.persfektif.Controls.Add(this.label17);
            this.persfektif.Controls.Add(this.label16);
            this.persfektif.Controls.Add(this.label15);
            this.persfektif.Controls.Add(this.label14);
            this.persfektif.Controls.Add(this.label13);
            this.persfektif.Controls.Add(this.label12);
            this.persfektif.Controls.Add(this.label11);
            this.persfektif.Controls.Add(this.label10);
            this.persfektif.Controls.Add(this.label9);
            this.persfektif.Controls.Add(this.label8);
            this.persfektif.Controls.Add(this.label7);
            this.persfektif.Controls.Add(this.label6);
            this.persfektif.Controls.Add(this.label5);
            this.persfektif.Controls.Add(this.label4);
            this.persfektif.Controls.Add(this.label3);
            this.persfektif.Controls.Add(this.txtPerspektif16);
            this.persfektif.Controls.Add(this.txtPerspektif15);
            this.persfektif.Controls.Add(this.txtPerspektif14);
            this.persfektif.Controls.Add(this.txtPerspektif13);
            this.persfektif.Controls.Add(this.txtPerspektif12);
            this.persfektif.Controls.Add(this.txtPerspektif11);
            this.persfektif.Controls.Add(this.txtPerspektif10);
            this.persfektif.Controls.Add(this.txtPerspektif9);
            this.persfektif.Controls.Add(this.txtPerspektif8);
            this.persfektif.Controls.Add(this.txtPerspektif7);
            this.persfektif.Controls.Add(this.txtPerspektif6);
            this.persfektif.Controls.Add(this.txtPerspektif5);
            this.persfektif.Controls.Add(this.txtPerspektif4);
            this.persfektif.Controls.Add(this.txtPerspektif3);
            this.persfektif.Controls.Add(this.txtPerspektif2);
            this.persfektif.Controls.Add(this.txtPerspektif1);
            this.persfektif.Controls.Add(this.btnpersfektif);
            this.persfektif.Controls.Add(this.pbxpersfektifeski);
            this.persfektif.Controls.Add(this.btnpersfektifresimal);
            this.persfektif.Controls.Add(this.pbxpersfektifyeni);
            this.persfektif.Location = new System.Drawing.Point(4, 22);
            this.persfektif.Name = "persfektif";
            this.persfektif.Padding = new System.Windows.Forms.Padding(3);
            this.persfektif.Size = new System.Drawing.Size(1880, 1008);
            this.persfektif.TabIndex = 15;
            this.persfektif.Text = "Persfektif";
            this.persfektif.UseVisualStyleBackColor = true;
            // 
            // btnpersfektif
            // 
            this.btnpersfektif.Location = new System.Drawing.Point(942, 66);
            this.btnpersfektif.Name = "btnpersfektif";
            this.btnpersfektif.Size = new System.Drawing.Size(75, 23);
            this.btnpersfektif.TabIndex = 55;
            this.btnpersfektif.Text = "Persfektif";
            this.btnpersfektif.UseVisualStyleBackColor = true;
            this.btnpersfektif.Click += new System.EventHandler(this.btnpersfektif_Click);
            // 
            // pbxpersfektifeski
            // 
            this.pbxpersfektifeski.Location = new System.Drawing.Point(40, 88);
            this.pbxpersfektifeski.Name = "pbxpersfektifeski";
            this.pbxpersfektifeski.Size = new System.Drawing.Size(895, 710);
            this.pbxpersfektifeski.TabIndex = 52;
            this.pbxpersfektifeski.TabStop = false;
            // 
            // btnpersfektifresimal
            // 
            this.btnpersfektifresimal.Location = new System.Drawing.Point(40, 37);
            this.btnpersfektifresimal.Name = "btnpersfektifresimal";
            this.btnpersfektifresimal.Size = new System.Drawing.Size(75, 23);
            this.btnpersfektifresimal.TabIndex = 54;
            this.btnpersfektifresimal.Text = "resim al";
            this.btnpersfektifresimal.UseVisualStyleBackColor = true;
            this.btnpersfektifresimal.Click += new System.EventHandler(this.btnpersfektifresimal_Click);
            // 
            // pbxpersfektifyeni
            // 
            this.pbxpersfektifyeni.Location = new System.Drawing.Point(958, 88);
            this.pbxpersfektifyeni.Name = "pbxpersfektifyeni";
            this.pbxpersfektifyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxpersfektifyeni.TabIndex = 53;
            this.pbxpersfektifyeni.TabStop = false;
            // 
            // txtPerspektif1
            // 
            this.txtPerspektif1.Location = new System.Drawing.Point(188, 40);
            this.txtPerspektif1.Name = "txtPerspektif1";
            this.txtPerspektif1.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif1.TabIndex = 56;
            this.txtPerspektif1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPerspektif2
            // 
            this.txtPerspektif2.Location = new System.Drawing.Point(294, 40);
            this.txtPerspektif2.Name = "txtPerspektif2";
            this.txtPerspektif2.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif2.TabIndex = 57;
            // 
            // txtPerspektif3
            // 
            this.txtPerspektif3.Location = new System.Drawing.Point(400, 40);
            this.txtPerspektif3.Name = "txtPerspektif3";
            this.txtPerspektif3.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif3.TabIndex = 58;
            // 
            // txtPerspektif4
            // 
            this.txtPerspektif4.Location = new System.Drawing.Point(506, 40);
            this.txtPerspektif4.Name = "txtPerspektif4";
            this.txtPerspektif4.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif4.TabIndex = 59;
            // 
            // txtPerspektif5
            // 
            this.txtPerspektif5.Location = new System.Drawing.Point(612, 40);
            this.txtPerspektif5.Name = "txtPerspektif5";
            this.txtPerspektif5.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif5.TabIndex = 60;
            // 
            // txtPerspektif6
            // 
            this.txtPerspektif6.Location = new System.Drawing.Point(718, 40);
            this.txtPerspektif6.Name = "txtPerspektif6";
            this.txtPerspektif6.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif6.TabIndex = 61;
            this.txtPerspektif6.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtPerspektif7
            // 
            this.txtPerspektif7.Location = new System.Drawing.Point(824, 40);
            this.txtPerspektif7.Name = "txtPerspektif7";
            this.txtPerspektif7.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif7.TabIndex = 62;
            // 
            // txtPerspektif8
            // 
            this.txtPerspektif8.Location = new System.Drawing.Point(930, 40);
            this.txtPerspektif8.Name = "txtPerspektif8";
            this.txtPerspektif8.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif8.TabIndex = 63;
            // 
            // txtPerspektif9
            // 
            this.txtPerspektif9.Location = new System.Drawing.Point(1036, 40);
            this.txtPerspektif9.Name = "txtPerspektif9";
            this.txtPerspektif9.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif9.TabIndex = 64;
            // 
            // txtPerspektif10
            // 
            this.txtPerspektif10.Location = new System.Drawing.Point(1142, 40);
            this.txtPerspektif10.Name = "txtPerspektif10";
            this.txtPerspektif10.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif10.TabIndex = 65;
            // 
            // txtPerspektif11
            // 
            this.txtPerspektif11.Location = new System.Drawing.Point(1248, 40);
            this.txtPerspektif11.Name = "txtPerspektif11";
            this.txtPerspektif11.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif11.TabIndex = 66;
            // 
            // txtPerspektif12
            // 
            this.txtPerspektif12.Location = new System.Drawing.Point(1354, 40);
            this.txtPerspektif12.Name = "txtPerspektif12";
            this.txtPerspektif12.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif12.TabIndex = 67;
            // 
            // txtPerspektif13
            // 
            this.txtPerspektif13.Location = new System.Drawing.Point(1460, 40);
            this.txtPerspektif13.Name = "txtPerspektif13";
            this.txtPerspektif13.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif13.TabIndex = 68;
            // 
            // txtPerspektif14
            // 
            this.txtPerspektif14.Location = new System.Drawing.Point(1566, 40);
            this.txtPerspektif14.Name = "txtPerspektif14";
            this.txtPerspektif14.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif14.TabIndex = 69;
            // 
            // txtPerspektif15
            // 
            this.txtPerspektif15.Location = new System.Drawing.Point(1672, 40);
            this.txtPerspektif15.Name = "txtPerspektif15";
            this.txtPerspektif15.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif15.TabIndex = 70;
            // 
            // txtPerspektif16
            // 
            this.txtPerspektif16.Location = new System.Drawing.Point(1778, 40);
            this.txtPerspektif16.Name = "txtPerspektif16";
            this.txtPerspektif16.Size = new System.Drawing.Size(100, 20);
            this.txtPerspektif16.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "x1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "x2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "y2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "X1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Y1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(821, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "X2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(927, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "Y2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1033, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "x3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1139, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "y3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1245, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "x4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1351, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "y4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1457, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 84;
            this.label15.Text = "X3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1563, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 85;
            this.label16.Text = "Y3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1669, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 86;
            this.label17.Text = "X4";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1775, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 13);
            this.label18.TabIndex = 87;
            this.label18.Text = "Y4";
            // 
            // Aynalama
            // 
            this.Aynalama.Controls.Add(this.txtaynalama);
            this.Aynalama.Controls.Add(this.btnaynalama);
            this.Aynalama.Controls.Add(this.pbxaynalamaeski);
            this.Aynalama.Controls.Add(this.btnaynalamaresimal);
            this.Aynalama.Controls.Add(this.pbxaynalamayeni);
            this.Aynalama.Location = new System.Drawing.Point(4, 22);
            this.Aynalama.Name = "Aynalama";
            this.Aynalama.Padding = new System.Windows.Forms.Padding(3);
            this.Aynalama.Size = new System.Drawing.Size(1880, 1008);
            this.Aynalama.TabIndex = 16;
            this.Aynalama.Text = "Aynalama";
            this.Aynalama.UseVisualStyleBackColor = true;
            // 
            // btnaynalama
            // 
            this.btnaynalama.Location = new System.Drawing.Point(1021, 18);
            this.btnaynalama.Name = "btnaynalama";
            this.btnaynalama.Size = new System.Drawing.Size(75, 23);
            this.btnaynalama.TabIndex = 55;
            this.btnaynalama.Text = "Aynalama";
            this.btnaynalama.UseVisualStyleBackColor = true;
            this.btnaynalama.Click += new System.EventHandler(this.btnaynalama_Click);
            // 
            // pbxaynalamaeski
            // 
            this.pbxaynalamaeski.Location = new System.Drawing.Point(42, 69);
            this.pbxaynalamaeski.Name = "pbxaynalamaeski";
            this.pbxaynalamaeski.Size = new System.Drawing.Size(895, 710);
            this.pbxaynalamaeski.TabIndex = 52;
            this.pbxaynalamaeski.TabStop = false;
            // 
            // btnaynalamaresimal
            // 
            this.btnaynalamaresimal.Location = new System.Drawing.Point(42, 18);
            this.btnaynalamaresimal.Name = "btnaynalamaresimal";
            this.btnaynalamaresimal.Size = new System.Drawing.Size(75, 23);
            this.btnaynalamaresimal.TabIndex = 54;
            this.btnaynalamaresimal.Text = "resim al";
            this.btnaynalamaresimal.UseVisualStyleBackColor = true;
            this.btnaynalamaresimal.Click += new System.EventHandler(this.btnaynalamaresimal_Click);
            // 
            // pbxaynalamayeni
            // 
            this.pbxaynalamayeni.Location = new System.Drawing.Point(943, 69);
            this.pbxaynalamayeni.Name = "pbxaynalamayeni";
            this.pbxaynalamayeni.Size = new System.Drawing.Size(895, 710);
            this.pbxaynalamayeni.TabIndex = 53;
            this.pbxaynalamayeni.TabStop = false;
            // 
            // txtaynalama
            // 
            this.txtaynalama.Location = new System.Drawing.Point(1141, 21);
            this.txtaynalama.Name = "txtaynalama";
            this.txtaynalama.Size = new System.Drawing.Size(100, 20);
            this.txtaynalama.TabIndex = 57;
            this.txtaynalama.Text = "90";
            // 
            // döndürme
            // 
            this.döndürme.Controls.Add(this.txtdöndürme);
            this.döndürme.Controls.Add(this.btndöndürme);
            this.döndürme.Controls.Add(this.pbxdöndürmeeski);
            this.döndürme.Controls.Add(this.btndöndürmeresimal);
            this.döndürme.Controls.Add(this.pbxdöndürmeyeni);
            this.döndürme.Location = new System.Drawing.Point(4, 22);
            this.döndürme.Name = "döndürme";
            this.döndürme.Padding = new System.Windows.Forms.Padding(3);
            this.döndürme.Size = new System.Drawing.Size(1880, 1008);
            this.döndürme.TabIndex = 17;
            this.döndürme.Text = "Döndürme";
            this.döndürme.UseVisualStyleBackColor = true;
            // 
            // btndöndürme
            // 
            this.btndöndürme.Location = new System.Drawing.Point(1022, 27);
            this.btndöndürme.Name = "btndöndürme";
            this.btndöndürme.Size = new System.Drawing.Size(75, 23);
            this.btndöndürme.TabIndex = 59;
            this.btndöndürme.Text = "Döndürme";
            this.btndöndürme.UseVisualStyleBackColor = true;
            this.btndöndürme.Click += new System.EventHandler(this.btndöndürme_Click);
            // 
            // pbxdöndürmeeski
            // 
            this.pbxdöndürmeeski.Location = new System.Drawing.Point(43, 78);
            this.pbxdöndürmeeski.Name = "pbxdöndürmeeski";
            this.pbxdöndürmeeski.Size = new System.Drawing.Size(895, 710);
            this.pbxdöndürmeeski.TabIndex = 56;
            this.pbxdöndürmeeski.TabStop = false;
            // 
            // btndöndürmeresimal
            // 
            this.btndöndürmeresimal.Location = new System.Drawing.Point(43, 27);
            this.btndöndürmeresimal.Name = "btndöndürmeresimal";
            this.btndöndürmeresimal.Size = new System.Drawing.Size(75, 23);
            this.btndöndürmeresimal.TabIndex = 58;
            this.btndöndürmeresimal.Text = "resim al";
            this.btndöndürmeresimal.UseVisualStyleBackColor = true;
            this.btndöndürmeresimal.Click += new System.EventHandler(this.btndöndürmeresimal_Click);
            // 
            // pbxdöndürmeyeni
            // 
            this.pbxdöndürmeyeni.Location = new System.Drawing.Point(944, 78);
            this.pbxdöndürmeyeni.Name = "pbxdöndürmeyeni";
            this.pbxdöndürmeyeni.Size = new System.Drawing.Size(895, 710);
            this.pbxdöndürmeyeni.TabIndex = 57;
            this.pbxdöndürmeyeni.TabStop = false;
            // 
            // txtdöndürme
            // 
            this.txtdöndürme.Location = new System.Drawing.Point(1122, 29);
            this.txtdöndürme.Name = "txtdöndürme";
            this.txtdöndürme.Size = new System.Drawing.Size(100, 20);
            this.txtdöndürme.TabIndex = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "a";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbresimalGri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGri)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxparlaklıkeski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxparlaklıkyeni)).EndInit();
            this.negatifi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxnegatifeski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxnegatifyeni)).EndInit();
            this.sihaybeyaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxsiyahbeyazeski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxsiyahbeyazyeni)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxesıkleeskı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxesıkleyenı)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxkontraseskı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxkontrasyenı)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxhistogrameskı)).EndInit();
            this.tabpagekontrasgerme.ResumeLayout(false);
            this.tabpagekontrasgerme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxkontasgermeeski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxkontrasgermeyenı)).EndInit();
            this.hıstogramesıtleme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxhıstogramesıtleeskı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxhıstogramesıtleyenı)).EndInit();
            this.mean.ResumeLayout(false);
            this.mean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmeaneski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmeanyeni)).EndInit();
            this.Medayan.ResumeLayout(false);
            this.Medayan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmedyaneski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmedyanyeni)).EndInit();
            this.gauss.ResumeLayout(false);
            this.gauss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxgausseski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxgaussyeni)).EndInit();
            this.laplacian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxlaplacianeski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlaplacianyeni)).EndInit();
            this.sobel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxsobeleski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxsobelyeni)).EndInit();
            this.Prewitt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxprewitteski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxprewittyeni)).EndInit();
            this.persfektif.ResumeLayout(false);
            this.persfektif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpersfektifeski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpersfektifyeni)).EndInit();
            this.Aynalama.ResumeLayout(false);
            this.Aynalama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxaynalamaeski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxaynalamayeni)).EndInit();
            this.döndürme.ResumeLayout(false);
            this.döndürme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxdöndürmeeski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxdöndürmeyeni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbresimalGri;
        private System.Windows.Forms.PictureBox pbGri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGri;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbxparlaklıkeski;
        private System.Windows.Forms.Button btnresimal;
        private System.Windows.Forms.Button btnparlaklıkart;
        private System.Windows.Forms.PictureBox pbxparlaklıkyeni;
        private System.Windows.Forms.TabPage negatifi;
        private System.Windows.Forms.PictureBox pbxnegatifeski;
        private System.Windows.Forms.Button btnnegatifresimal;
        private System.Windows.Forms.Button negatıfı;
        private System.Windows.Forms.PictureBox pbxnegatifyeni;
        private System.Windows.Forms.TabPage sihaybeyaz;
        private System.Windows.Forms.PictureBox pbxsiyahbeyazeski;
        private System.Windows.Forms.Button btnsbresimal;
        private System.Windows.Forms.Button btnsiyahbeyaz;
        private System.Windows.Forms.PictureBox pbxsiyahbeyazyeni;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pbxesıkleeskı;
        private System.Windows.Forms.Button btnesıkleme;
        private System.Windows.Forms.Button btnesıkle;
        private System.Windows.Forms.PictureBox pbxesıkleyenı;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pbxkontraseskı;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnkontras;
        private System.Windows.Forms.PictureBox pbxkontrasyenı;
        private System.Windows.Forms.TextBox txkontras;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pbxhistogrameskı;
        private System.Windows.Forms.Button btnhistogramresimal;
        private System.Windows.Forms.Button histogramal;
        private System.Windows.Forms.ListBox lbxhistogram;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabpagekontrasgerme;
        private System.Windows.Forms.PictureBox pbxkontasgermeeski;
        private System.Windows.Forms.Button btnkontrasgermeresimal;
        private System.Windows.Forms.Button btnkonrtasgerme;
        private System.Windows.Forms.PictureBox pbxkontrasgermeyenı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbX2;
        private System.Windows.Forms.TextBox txbX1;
        private System.Windows.Forms.TextBox txbparlaklık;
        private System.Windows.Forms.TabPage hıstogramesıtleme;
        private System.Windows.Forms.PictureBox pbxhıstogramesıtleeskı;
        private System.Windows.Forms.Button btnhıstogramesıtlemeresimal;
        private System.Windows.Forms.Button btnhıstogramesıtle;
        private System.Windows.Forms.PictureBox pbxhıstogramesıtleyenı;
        private System.Windows.Forms.TabPage mean;
        private System.Windows.Forms.TextBox txbmean;
        private System.Windows.Forms.PictureBox pbxmeaneski;
        private System.Windows.Forms.Button btnmeanresimal;
        private System.Windows.Forms.Button btnmean;
        private System.Windows.Forms.PictureBox pbxmeanyeni;
        private System.Windows.Forms.TabPage Medayan;
        private System.Windows.Forms.TextBox txbmedyan;
        private System.Windows.Forms.PictureBox pbxmedyaneski;
        private System.Windows.Forms.Button btnmedyanresimal;
        private System.Windows.Forms.Button btnmedyan;
        private System.Windows.Forms.PictureBox pbxmedyanyeni;
        private System.Windows.Forms.TabPage gauss;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbxgausseski;
        private System.Windows.Forms.Button btngaussresimal;
        private System.Windows.Forms.Button btngauss;
        private System.Windows.Forms.PictureBox pbxgaussyeni;
        private System.Windows.Forms.TabPage laplacian;
        private System.Windows.Forms.PictureBox pbxlaplacianeski;
        private System.Windows.Forms.Button bynlaplacianresimal;
        private System.Windows.Forms.Button btnlaplacian;
        private System.Windows.Forms.PictureBox pbxlaplacianyeni;
        private System.Windows.Forms.TabPage sobel;
        private System.Windows.Forms.Button btnsobel;
        private System.Windows.Forms.PictureBox pbxsobeleski;
        private System.Windows.Forms.Button btnsobelresimal;
        private System.Windows.Forms.PictureBox pbxsobelyeni;
        private System.Windows.Forms.TabPage Prewitt;
        private System.Windows.Forms.Button btnprewitt;
        private System.Windows.Forms.PictureBox pbxprewitteski;
        private System.Windows.Forms.Button btnprewittresimal;
        private System.Windows.Forms.PictureBox pbxprewittyeni;
        private System.Windows.Forms.TabPage persfektif;
        private System.Windows.Forms.Button btnpersfektif;
        private System.Windows.Forms.PictureBox pbxpersfektifeski;
        private System.Windows.Forms.Button btnpersfektifresimal;
        private System.Windows.Forms.PictureBox pbxpersfektifyeni;
        private System.Windows.Forms.TextBox txtPerspektif16;
        private System.Windows.Forms.TextBox txtPerspektif15;
        private System.Windows.Forms.TextBox txtPerspektif14;
        private System.Windows.Forms.TextBox txtPerspektif13;
        private System.Windows.Forms.TextBox txtPerspektif12;
        private System.Windows.Forms.TextBox txtPerspektif11;
        private System.Windows.Forms.TextBox txtPerspektif10;
        private System.Windows.Forms.TextBox txtPerspektif9;
        private System.Windows.Forms.TextBox txtPerspektif8;
        private System.Windows.Forms.TextBox txtPerspektif7;
        private System.Windows.Forms.TextBox txtPerspektif6;
        private System.Windows.Forms.TextBox txtPerspektif5;
        private System.Windows.Forms.TextBox txtPerspektif4;
        private System.Windows.Forms.TextBox txtPerspektif3;
        private System.Windows.Forms.TextBox txtPerspektif2;
        private System.Windows.Forms.TextBox txtPerspektif1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Aynalama;
        private System.Windows.Forms.Button btnaynalama;
        private System.Windows.Forms.PictureBox pbxaynalamaeski;
        private System.Windows.Forms.Button btnaynalamaresimal;
        private System.Windows.Forms.PictureBox pbxaynalamayeni;
        private System.Windows.Forms.TextBox txtaynalama;
        private System.Windows.Forms.TabPage döndürme;
        private System.Windows.Forms.TextBox txtdöndürme;
        private System.Windows.Forms.Button btndöndürme;
        private System.Windows.Forms.PictureBox pbxdöndürmeeski;
        private System.Windows.Forms.Button btndöndürmeresimal;
        private System.Windows.Forms.PictureBox pbxdöndürmeyeni;
    }
}

