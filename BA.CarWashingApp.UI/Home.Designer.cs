namespace BA.CarWashingApp.UI
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            panelMenu = new Panel();
            Ayarlar = new Button();
            Bordro = new Button();
            Avans = new Button();
            Maas = new Button();
            Izin = new Button();
            Egitim = new Button();
            Ozluk = new Button();
            Kayıt = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            label1 = new Label();
            panelCenter = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 55, 76);
            panelMenu.Controls.Add(Ayarlar);
            panelMenu.Controls.Add(Bordro);
            panelMenu.Controls.Add(Avans);
            panelMenu.Controls.Add(Maas);
            panelMenu.Controls.Add(Izin);
            panelMenu.Controls.Add(Egitim);
            panelMenu.Controls.Add(Ozluk);
            panelMenu.Controls.Add(Kayıt);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 765);
            panelMenu.TabIndex = 0;
            // 
            // Ayarlar
            // 
            Ayarlar.Dock = DockStyle.Top;
            Ayarlar.FlatAppearance.BorderSize = 0;
            Ayarlar.FlatStyle = FlatStyle.Flat;
            Ayarlar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Ayarlar.ForeColor = Color.White;
            Ayarlar.Image = (Image)resources.GetObject("Ayarlar.Image");
            Ayarlar.ImageAlign = ContentAlignment.MiddleLeft;
            Ayarlar.Location = new Point(0, 640);
            Ayarlar.Margin = new Padding(3, 4, 3, 4);
            Ayarlar.Name = "Ayarlar";
            Ayarlar.Size = new Size(251, 80);
            Ayarlar.TabIndex = 8;
            Ayarlar.Text = "Ayarlar";
            Ayarlar.UseVisualStyleBackColor = true;
            Ayarlar.Click += Ayarlar_Click;
            // 
            // Bordro
            // 
            Bordro.Dock = DockStyle.Top;
            Bordro.FlatAppearance.BorderSize = 0;
            Bordro.FlatStyle = FlatStyle.Flat;
            Bordro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Bordro.ForeColor = Color.White;
            Bordro.Image = (Image)resources.GetObject("Bordro.Image");
            Bordro.ImageAlign = ContentAlignment.MiddleLeft;
            Bordro.Location = new Point(0, 560);
            Bordro.Margin = new Padding(3, 4, 3, 4);
            Bordro.Name = "Bordro";
            Bordro.Size = new Size(251, 80);
            Bordro.TabIndex = 7;
            Bordro.Text = "Personel Bordro";
            Bordro.UseVisualStyleBackColor = true;
            Bordro.Click += Bordro_Click;
            // 
            // Avans
            // 
            Avans.Dock = DockStyle.Top;
            Avans.FlatAppearance.BorderSize = 0;
            Avans.FlatStyle = FlatStyle.Flat;
            Avans.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Avans.ForeColor = Color.White;
            Avans.Image = (Image)resources.GetObject("Avans.Image");
            Avans.ImageAlign = ContentAlignment.MiddleLeft;
            Avans.Location = new Point(0, 480);
            Avans.Margin = new Padding(3, 4, 3, 4);
            Avans.Name = "Avans";
            Avans.Size = new Size(251, 80);
            Avans.TabIndex = 6;
            Avans.Text = "Personel Avans";
            Avans.UseVisualStyleBackColor = true;
            Avans.Click += Avans_Click;
            // 
            // Maas
            // 
            Maas.Dock = DockStyle.Top;
            Maas.FlatAppearance.BorderSize = 0;
            Maas.FlatStyle = FlatStyle.Flat;
            Maas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Maas.ForeColor = Color.White;
            Maas.Image = (Image)resources.GetObject("Maas.Image");
            Maas.ImageAlign = ContentAlignment.MiddleLeft;
            Maas.Location = new Point(0, 400);
            Maas.Margin = new Padding(3, 4, 3, 4);
            Maas.Name = "Maas";
            Maas.Size = new Size(251, 80);
            Maas.TabIndex = 5;
            Maas.Text = "Personel Maas";
            Maas.UseVisualStyleBackColor = true;
            Maas.Click += Maas_Click;
            // 
            // Izin
            // 
            Izin.Dock = DockStyle.Top;
            Izin.FlatAppearance.BorderSize = 0;
            Izin.FlatStyle = FlatStyle.Flat;
            Izin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Izin.ForeColor = Color.White;
            Izin.Image = (Image)resources.GetObject("Izin.Image");
            Izin.ImageAlign = ContentAlignment.MiddleLeft;
            Izin.Location = new Point(0, 320);
            Izin.Margin = new Padding(3, 4, 3, 4);
            Izin.Name = "Izin";
            Izin.Size = new Size(251, 80);
            Izin.TabIndex = 4;
            Izin.Text = "Persone İzin";
            Izin.UseVisualStyleBackColor = true;
            Izin.Click += Izin_Click;
            // 
            // Egitim
            // 
            Egitim.Dock = DockStyle.Top;
            Egitim.FlatAppearance.BorderSize = 0;
            Egitim.FlatStyle = FlatStyle.Flat;
            Egitim.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Egitim.ForeColor = Color.White;
            Egitim.Image = (Image)resources.GetObject("Egitim.Image");
            Egitim.ImageAlign = ContentAlignment.MiddleLeft;
            Egitim.Location = new Point(0, 240);
            Egitim.Margin = new Padding(3, 4, 3, 4);
            Egitim.Name = "Egitim";
            Egitim.Size = new Size(251, 80);
            Egitim.TabIndex = 3;
            Egitim.Text = "Eğitim Bilgileri";
            Egitim.UseVisualStyleBackColor = true;
            Egitim.Click += Egitim_Click;
            // 
            // Ozluk
            // 
            Ozluk.Dock = DockStyle.Top;
            Ozluk.FlatAppearance.BorderSize = 0;
            Ozluk.FlatStyle = FlatStyle.Flat;
            Ozluk.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Ozluk.ForeColor = Color.White;
            Ozluk.Image = (Image)resources.GetObject("Ozluk.Image");
            Ozluk.ImageAlign = ContentAlignment.MiddleLeft;
            Ozluk.Location = new Point(0, 160);
            Ozluk.Margin = new Padding(3, 4, 3, 4);
            Ozluk.Name = "Ozluk";
            Ozluk.Size = new Size(251, 80);
            Ozluk.TabIndex = 2;
            Ozluk.Text = "Özlük Bilgileri";
            Ozluk.UseVisualStyleBackColor = true;
            Ozluk.Click += Ozluk_Click;
            // 
            // Kayıt
            // 
            Kayıt.Dock = DockStyle.Top;
            Kayıt.FlatAppearance.BorderSize = 0;
            Kayıt.FlatStyle = FlatStyle.Flat;
            Kayıt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Kayıt.ForeColor = Color.White;
            Kayıt.Image = (Image)resources.GetObject("Kayıt.Image");
            Kayıt.ImageAlign = ContentAlignment.MiddleLeft;
            Kayıt.Location = new Point(0, 80);
            Kayıt.Margin = new Padding(3, 4, 3, 4);
            Kayıt.Name = "Kayıt";
            Kayıt.Size = new Size(251, 80);
            Kayıt.TabIndex = 1;
            Kayıt.Text = "Personel Kayıt";
            Kayıt.UseVisualStyleBackColor = true;
            Kayıt.Click += Kayıt_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 43, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(251, 80);
            panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.InactiveCaption;
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(251, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(797, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(359, 22);
            label1.Name = "label1";
            label1.Size = new Size(115, 35);
            label1.TabIndex = 0;
            label1.Text = "Anasayfa";
            // 
            // panelCenter
            // 
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(251, 80);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(797, 685);
            panelCenter.TabIndex = 2;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 765);
            Controls.Add(panelCenter);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Anasayfa";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button Kayıt;
        private Button Avans;
        private Button Maas;
        private Button Izin;
        private Button Egitim;
        private Button Ozluk;
        private Button Ayarlar;
        private Button Bordro;
        private Panel panelTitleBar;
        private Label label1;
        private Panel panelCenter;
    }
}