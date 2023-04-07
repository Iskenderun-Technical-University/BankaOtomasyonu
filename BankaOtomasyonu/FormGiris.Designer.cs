namespace BankaOtomasyonu
{
    partial class FormGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textKullanıcıAdı = new TextBox();
            textŞifre = new TextBox();
            groupBox1 = new GroupBox();
            btnMusteriGiris = new Button();
            txtPersonelGiris = new Button();
            btnYoneticiGiris = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı/Müşteri No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9.163636F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(215, 162);
            label2.Name = "label2";
            label2.Size = new Size(0, 35);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 83);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // textKullanıcıAdı
            // 
            textKullanıcıAdı.Location = new Point(222, 30);
            textKullanıcıAdı.Name = "textKullanıcıAdı";
            textKullanıcıAdı.Size = new Size(115, 26);
            textKullanıcıAdı.TabIndex = 3;
            // 
            // textŞifre
            // 
            textŞifre.Location = new Point(222, 83);
            textŞifre.Name = "textŞifre";
            textŞifre.Size = new Size(115, 26);
            textŞifre.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textKullanıcıAdı);
            groupBox1.Controls.Add(textŞifre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(141, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 154);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş Bilgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnMusteriGiris
            // 
            btnMusteriGiris.Image = (Image)resources.GetObject("btnMusteriGiris.Image");
            btnMusteriGiris.ImageAlign = ContentAlignment.MiddleLeft;
            btnMusteriGiris.Location = new Point(159, 356);
            btnMusteriGiris.Name = "btnMusteriGiris";
            btnMusteriGiris.Size = new Size(136, 44);
            btnMusteriGiris.TabIndex = 6;
            btnMusteriGiris.Text = "Müşteri Giriş";
            btnMusteriGiris.TextAlign = ContentAlignment.MiddleRight;
            btnMusteriGiris.UseVisualStyleBackColor = true;
            // 
            // txtPersonelGiris
            // 
            txtPersonelGiris.Image = (Image)resources.GetObject("txtPersonelGiris.Image");
            txtPersonelGiris.ImageAlign = ContentAlignment.MiddleLeft;
            txtPersonelGiris.Location = new Point(187, 23);
            txtPersonelGiris.Name = "txtPersonelGiris";
            txtPersonelGiris.Size = new Size(135, 44);
            txtPersonelGiris.TabIndex = 7;
            txtPersonelGiris.Text = "Personel Giriş";
            txtPersonelGiris.TextAlign = ContentAlignment.MiddleRight;
            txtPersonelGiris.UseVisualStyleBackColor = true;
            // 
            // btnYoneticiGiris
            // 
            btnYoneticiGiris.Image = (Image)resources.GetObject("btnYoneticiGiris.Image");
            btnYoneticiGiris.ImageAlign = ContentAlignment.MiddleLeft;
            btnYoneticiGiris.Location = new Point(491, 356);
            btnYoneticiGiris.Name = "btnYoneticiGiris";
            btnYoneticiGiris.Size = new Size(135, 44);
            btnYoneticiGiris.TabIndex = 8;
            btnYoneticiGiris.Text = "Yönetici Giriş";
            btnYoneticiGiris.TextAlign = ContentAlignment.MiddleRight;
            btnYoneticiGiris.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtPersonelGiris);
            groupBox2.Location = new Point(141, 333);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(505, 86);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giriş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 9.163636F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(215, 162);
            label5.Name = "label5";
            label5.Size = new Size(0, 35);
            label5.TabIndex = 1;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 514);
            Controls.Add(btnYoneticiGiris);
            Controls.Add(btnMusteriGiris);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGiris";
            Text = "FormGiris";
            Load += FormGiris_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textKullanıcıAdı;
        private TextBox textŞifre;
        private GroupBox groupBox1;
        private Button btnMusteriGiris;
        private Button txtPersonelGiris;
        private Button btnYoneticiGiris;
        private GroupBox groupBox2;
        private Label label5;
    }
}