namespace nesne_ödev01
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.group_Box1 = new System.Windows.Forms.GroupBox();
            this.txt_bitis = new System.Windows.Forms.MaskedTextBox();
            this.txt_baslangic = new System.Windows.Forms.MaskedTextBox();
            this.btn_calistir = new System.Windows.Forms.Button();
            this.label_bitis = new System.Windows.Forms.Label();
            this.label_baslangic = new System.Windows.Forms.Label();
            this.txt_tek_toplam = new System.Windows.Forms.TextBox();
            this.lbl_tek_toplam = new System.Windows.Forms.Label();
            this.lbl_cift_toplam = new System.Windows.Forms.Label();
            this.txt_cift_toplam = new System.Windows.Forms.TextBox();
            this.lbl_tek_carpim = new System.Windows.Forms.Label();
            this.txt_tek_carpim = new System.Windows.Forms.TextBox();
            this.lbl_cift_carpim = new System.Windows.Forms.Label();
            this.txt_cift_carpim = new System.Windows.Forms.TextBox();
            this.tabcntrl = new System.Windows.Forms.TabControl();
            this.tabPage_tek_sayilar = new System.Windows.Forms.TabPage();
            this.listView_tek_sayilar = new System.Windows.Forms.ListView();
            this.tabPage_cift_sayilar = new System.Windows.Forms.TabPage();
            this.listView_cift_sayilar = new System.Windows.Forms.ListView();
            this.tabPage_asal_sayilar = new System.Windows.Forms.TabPage();
            this.lbl_asal_carpim = new System.Windows.Forms.Label();
            this.listView_asal_sayilar = new System.Windows.Forms.ListView();
            this.lbl_asal_toplam = new System.Windows.Forms.Label();
            this.txt_asal_toplam = new System.Windows.Forms.TextBox();
            this.txt_asal_carpim = new System.Windows.Forms.TextBox();
            this.tabPage_mukemmel_sayilar = new System.Windows.Forms.TabPage();
            this.lbl_mukemmel_carpim = new System.Windows.Forms.Label();
            this.listView_mukemmel_sayilar = new System.Windows.Forms.ListView();
            this.lbl_mukemmel_toplam = new System.Windows.Forms.Label();
            this.txt_mukemmel_carpim = new System.Windows.Forms.TextBox();
            this.txt_mukemmel_toplam = new System.Windows.Forms.TextBox();
            this.notify_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.group_Box1.SuspendLayout();
            this.tabcntrl.SuspendLayout();
            this.tabPage_tek_sayilar.SuspendLayout();
            this.tabPage_cift_sayilar.SuspendLayout();
            this.tabPage_asal_sayilar.SuspendLayout();
            this.tabPage_mukemmel_sayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_Box1
            // 
            this.group_Box1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.group_Box1.Controls.Add(this.txt_bitis);
            this.group_Box1.Controls.Add(this.txt_baslangic);
            this.group_Box1.Controls.Add(this.btn_calistir);
            this.group_Box1.Controls.Add(this.label_bitis);
            this.group_Box1.Controls.Add(this.label_baslangic);
            this.group_Box1.Location = new System.Drawing.Point(71, 32);
            this.group_Box1.Name = "group_Box1";
            this.group_Box1.Size = new System.Drawing.Size(503, 105);
            this.group_Box1.TabIndex = 0;
            this.group_Box1.TabStop = false;
            this.group_Box1.Text = "Giriş Bilgileri";
            // 
            // txt_bitis
            // 
            this.txt_bitis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_bitis.Location = new System.Drawing.Point(305, 32);
            this.txt_bitis.Mask = "00000";
            this.txt_bitis.Name = "txt_bitis";
            this.txt_bitis.Size = new System.Drawing.Size(100, 22);
            this.txt_bitis.TabIndex = 16;
            this.txt_bitis.ValidatingType = typeof(int);
            // 
            // txt_baslangic
            // 
            this.txt_baslangic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_baslangic.Location = new System.Drawing.Point(144, 33);
            this.txt_baslangic.Mask = "00000";
            this.txt_baslangic.Name = "txt_baslangic";
            this.txt_baslangic.Size = new System.Drawing.Size(100, 22);
            this.txt_baslangic.TabIndex = 15;
            this.txt_baslangic.ValidatingType = typeof(int);
            // 
            // btn_calistir
            // 
            this.btn_calistir.Location = new System.Drawing.Point(381, 60);
            this.btn_calistir.Name = "btn_calistir";
            this.btn_calistir.Size = new System.Drawing.Size(89, 31);
            this.btn_calistir.TabIndex = 4;
            this.btn_calistir.Text = "Çalıştır";
            this.btn_calistir.UseVisualStyleBackColor = true;
            this.btn_calistir.Click += new System.EventHandler(this.btn_calistir_Click);
            // 
            // label_bitis
            // 
            this.label_bitis.AutoSize = true;
            this.label_bitis.Location = new System.Drawing.Point(264, 33);
            this.label_bitis.Name = "label_bitis";
            this.label_bitis.Size = new System.Drawing.Size(35, 16);
            this.label_bitis.TabIndex = 1;
            this.label_bitis.Text = "Bitiş:";
            // 
            // label_baslangic
            // 
            this.label_baslangic.AutoSize = true;
            this.label_baslangic.Location = new System.Drawing.Point(56, 33);
            this.label_baslangic.Name = "label_baslangic";
            this.label_baslangic.Size = new System.Drawing.Size(70, 16);
            this.label_baslangic.TabIndex = 0;
            this.label_baslangic.Text = "Başlangıç:";
            // 
            // txt_tek_toplam
            // 
            this.txt_tek_toplam.Enabled = false;
            this.txt_tek_toplam.Location = new System.Drawing.Point(340, 92);
            this.txt_tek_toplam.Name = "txt_tek_toplam";
            this.txt_tek_toplam.Size = new System.Drawing.Size(125, 22);
            this.txt_tek_toplam.TabIndex = 1;
            // 
            // lbl_tek_toplam
            // 
            this.lbl_tek_toplam.AutoSize = true;
            this.lbl_tek_toplam.Location = new System.Drawing.Point(352, 73);
            this.lbl_tek_toplam.Name = "lbl_tek_toplam";
            this.lbl_tek_toplam.Size = new System.Drawing.Size(81, 16);
            this.lbl_tek_toplam.TabIndex = 5;
            this.lbl_tek_toplam.Text = "Tek Toplam";
            // 
            // lbl_cift_toplam
            // 
            this.lbl_cift_toplam.AutoSize = true;
            this.lbl_cift_toplam.Location = new System.Drawing.Point(352, 73);
            this.lbl_cift_toplam.Name = "lbl_cift_toplam";
            this.lbl_cift_toplam.Size = new System.Drawing.Size(75, 16);
            this.lbl_cift_toplam.TabIndex = 7;
            this.lbl_cift_toplam.Text = "Çift Toplam";
            // 
            // txt_cift_toplam
            // 
            this.txt_cift_toplam.Enabled = false;
            this.txt_cift_toplam.Location = new System.Drawing.Point(340, 92);
            this.txt_cift_toplam.Name = "txt_cift_toplam";
            this.txt_cift_toplam.Size = new System.Drawing.Size(125, 22);
            this.txt_cift_toplam.TabIndex = 6;
            // 
            // lbl_tek_carpim
            // 
            this.lbl_tek_carpim.AutoSize = true;
            this.lbl_tek_carpim.Location = new System.Drawing.Point(352, 132);
            this.lbl_tek_carpim.Name = "lbl_tek_carpim";
            this.lbl_tek_carpim.Size = new System.Drawing.Size(77, 16);
            this.lbl_tek_carpim.TabIndex = 9;
            this.lbl_tek_carpim.Text = "Tek Çarpım";
            // 
            // txt_tek_carpim
            // 
            this.txt_tek_carpim.Enabled = false;
            this.txt_tek_carpim.Location = new System.Drawing.Point(295, 151);
            this.txt_tek_carpim.Name = "txt_tek_carpim";
            this.txt_tek_carpim.Size = new System.Drawing.Size(220, 22);
            this.txt_tek_carpim.TabIndex = 8;
            // 
            // lbl_cift_carpim
            // 
            this.lbl_cift_carpim.AutoSize = true;
            this.lbl_cift_carpim.Location = new System.Drawing.Point(352, 132);
            this.lbl_cift_carpim.Name = "lbl_cift_carpim";
            this.lbl_cift_carpim.Size = new System.Drawing.Size(71, 16);
            this.lbl_cift_carpim.TabIndex = 11;
            this.lbl_cift_carpim.Text = "Çift Çarpım";
            // 
            // txt_cift_carpim
            // 
            this.txt_cift_carpim.Enabled = false;
            this.txt_cift_carpim.Location = new System.Drawing.Point(295, 151);
            this.txt_cift_carpim.Name = "txt_cift_carpim";
            this.txt_cift_carpim.Size = new System.Drawing.Size(220, 22);
            this.txt_cift_carpim.TabIndex = 10;
            // 
            // tabcntrl
            // 
            this.tabcntrl.Controls.Add(this.tabPage_tek_sayilar);
            this.tabcntrl.Controls.Add(this.tabPage_cift_sayilar);
            this.tabcntrl.Controls.Add(this.tabPage_asal_sayilar);
            this.tabcntrl.Controls.Add(this.tabPage_mukemmel_sayilar);
            this.tabcntrl.Location = new System.Drawing.Point(39, 174);
            this.tabcntrl.Name = "tabcntrl";
            this.tabcntrl.SelectedIndex = 0;
            this.tabcntrl.Size = new System.Drawing.Size(569, 300);
            this.tabcntrl.TabIndex = 14;
            // 
            // tabPage_tek_sayilar
            // 
            this.tabPage_tek_sayilar.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage_tek_sayilar.Controls.Add(this.listView_tek_sayilar);
            this.tabPage_tek_sayilar.Controls.Add(this.lbl_tek_toplam);
            this.tabPage_tek_sayilar.Controls.Add(this.txt_tek_toplam);
            this.tabPage_tek_sayilar.Controls.Add(this.lbl_tek_carpim);
            this.tabPage_tek_sayilar.Controls.Add(this.txt_tek_carpim);
            this.tabPage_tek_sayilar.Location = new System.Drawing.Point(4, 25);
            this.tabPage_tek_sayilar.Name = "tabPage_tek_sayilar";
            this.tabPage_tek_sayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tek_sayilar.Size = new System.Drawing.Size(561, 271);
            this.tabPage_tek_sayilar.TabIndex = 0;
            this.tabPage_tek_sayilar.Text = "Tek Sayılar";
            // 
            // listView_tek_sayilar
            // 
            this.listView_tek_sayilar.HideSelection = false;
            this.listView_tek_sayilar.Location = new System.Drawing.Point(26, 15);
            this.listView_tek_sayilar.Name = "listView_tek_sayilar";
            this.listView_tek_sayilar.Size = new System.Drawing.Size(232, 238);
            this.listView_tek_sayilar.TabIndex = 15;
            this.listView_tek_sayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage_cift_sayilar
            // 
            this.tabPage_cift_sayilar.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage_cift_sayilar.Controls.Add(this.listView_cift_sayilar);
            this.tabPage_cift_sayilar.Controls.Add(this.lbl_cift_carpim);
            this.tabPage_cift_sayilar.Controls.Add(this.lbl_cift_toplam);
            this.tabPage_cift_sayilar.Controls.Add(this.txt_cift_carpim);
            this.tabPage_cift_sayilar.Controls.Add(this.txt_cift_toplam);
            this.tabPage_cift_sayilar.Location = new System.Drawing.Point(4, 25);
            this.tabPage_cift_sayilar.Name = "tabPage_cift_sayilar";
            this.tabPage_cift_sayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_cift_sayilar.Size = new System.Drawing.Size(561, 271);
            this.tabPage_cift_sayilar.TabIndex = 1;
            this.tabPage_cift_sayilar.Text = "Çift Sayılar";
            // 
            // listView_cift_sayilar
            // 
            this.listView_cift_sayilar.HideSelection = false;
            this.listView_cift_sayilar.Location = new System.Drawing.Point(26, 15);
            this.listView_cift_sayilar.Name = "listView_cift_sayilar";
            this.listView_cift_sayilar.Size = new System.Drawing.Size(232, 238);
            this.listView_cift_sayilar.TabIndex = 16;
            this.listView_cift_sayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage_asal_sayilar
            // 
            this.tabPage_asal_sayilar.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage_asal_sayilar.Controls.Add(this.lbl_asal_carpim);
            this.tabPage_asal_sayilar.Controls.Add(this.listView_asal_sayilar);
            this.tabPage_asal_sayilar.Controls.Add(this.lbl_asal_toplam);
            this.tabPage_asal_sayilar.Controls.Add(this.txt_asal_toplam);
            this.tabPage_asal_sayilar.Controls.Add(this.txt_asal_carpim);
            this.tabPage_asal_sayilar.Location = new System.Drawing.Point(4, 25);
            this.tabPage_asal_sayilar.Name = "tabPage_asal_sayilar";
            this.tabPage_asal_sayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_asal_sayilar.Size = new System.Drawing.Size(561, 271);
            this.tabPage_asal_sayilar.TabIndex = 2;
            this.tabPage_asal_sayilar.Text = "Asal Sayılar";
            // 
            // lbl_asal_carpim
            // 
            this.lbl_asal_carpim.AutoSize = true;
            this.lbl_asal_carpim.Location = new System.Drawing.Point(352, 131);
            this.lbl_asal_carpim.Name = "lbl_asal_carpim";
            this.lbl_asal_carpim.Size = new System.Drawing.Size(80, 16);
            this.lbl_asal_carpim.TabIndex = 20;
            this.lbl_asal_carpim.Text = "Asal Çarpım";
            // 
            // listView_asal_sayilar
            // 
            this.listView_asal_sayilar.HideSelection = false;
            this.listView_asal_sayilar.Location = new System.Drawing.Point(26, 15);
            this.listView_asal_sayilar.Name = "listView_asal_sayilar";
            this.listView_asal_sayilar.Size = new System.Drawing.Size(232, 238);
            this.listView_asal_sayilar.TabIndex = 16;
            this.listView_asal_sayilar.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_asal_toplam
            // 
            this.lbl_asal_toplam.AutoSize = true;
            this.lbl_asal_toplam.Location = new System.Drawing.Point(352, 73);
            this.lbl_asal_toplam.Name = "lbl_asal_toplam";
            this.lbl_asal_toplam.Size = new System.Drawing.Size(84, 16);
            this.lbl_asal_toplam.TabIndex = 18;
            this.lbl_asal_toplam.Text = "Asal Toplam";
            // 
            // txt_asal_toplam
            // 
            this.txt_asal_toplam.Enabled = false;
            this.txt_asal_toplam.Location = new System.Drawing.Point(340, 92);
            this.txt_asal_toplam.Name = "txt_asal_toplam";
            this.txt_asal_toplam.Size = new System.Drawing.Size(125, 22);
            this.txt_asal_toplam.TabIndex = 17;
            // 
            // txt_asal_carpim
            // 
            this.txt_asal_carpim.Enabled = false;
            this.txt_asal_carpim.Location = new System.Drawing.Point(295, 151);
            this.txt_asal_carpim.Name = "txt_asal_carpim";
            this.txt_asal_carpim.Size = new System.Drawing.Size(220, 22);
            this.txt_asal_carpim.TabIndex = 19;
            // 
            // tabPage_mukemmel_sayilar
            // 
            this.tabPage_mukemmel_sayilar.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage_mukemmel_sayilar.Controls.Add(this.lbl_mukemmel_carpim);
            this.tabPage_mukemmel_sayilar.Controls.Add(this.listView_mukemmel_sayilar);
            this.tabPage_mukemmel_sayilar.Controls.Add(this.lbl_mukemmel_toplam);
            this.tabPage_mukemmel_sayilar.Controls.Add(this.txt_mukemmel_carpim);
            this.tabPage_mukemmel_sayilar.Controls.Add(this.txt_mukemmel_toplam);
            this.tabPage_mukemmel_sayilar.Location = new System.Drawing.Point(4, 25);
            this.tabPage_mukemmel_sayilar.Name = "tabPage_mukemmel_sayilar";
            this.tabPage_mukemmel_sayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mukemmel_sayilar.Size = new System.Drawing.Size(561, 271);
            this.tabPage_mukemmel_sayilar.TabIndex = 3;
            this.tabPage_mukemmel_sayilar.Text = "Mükemmel Sayılar";
            // 
            // lbl_mukemmel_carpim
            // 
            this.lbl_mukemmel_carpim.AutoSize = true;
            this.lbl_mukemmel_carpim.Location = new System.Drawing.Point(352, 131);
            this.lbl_mukemmel_carpim.Name = "lbl_mukemmel_carpim";
            this.lbl_mukemmel_carpim.Size = new System.Drawing.Size(119, 16);
            this.lbl_mukemmel_carpim.TabIndex = 24;
            this.lbl_mukemmel_carpim.Text = "Mükemmel Çarpım";
            // 
            // listView_mukemmel_sayilar
            // 
            this.listView_mukemmel_sayilar.HideSelection = false;
            this.listView_mukemmel_sayilar.Location = new System.Drawing.Point(26, 15);
            this.listView_mukemmel_sayilar.Name = "listView_mukemmel_sayilar";
            this.listView_mukemmel_sayilar.Size = new System.Drawing.Size(232, 238);
            this.listView_mukemmel_sayilar.TabIndex = 17;
            this.listView_mukemmel_sayilar.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_mukemmel_toplam
            // 
            this.lbl_mukemmel_toplam.AutoSize = true;
            this.lbl_mukemmel_toplam.Location = new System.Drawing.Point(352, 73);
            this.lbl_mukemmel_toplam.Name = "lbl_mukemmel_toplam";
            this.lbl_mukemmel_toplam.Size = new System.Drawing.Size(123, 16);
            this.lbl_mukemmel_toplam.TabIndex = 22;
            this.lbl_mukemmel_toplam.Text = "Mükemmel Toplam";
            // 
            // txt_mukemmel_carpim
            // 
            this.txt_mukemmel_carpim.Enabled = false;
            this.txt_mukemmel_carpim.Location = new System.Drawing.Point(295, 151);
            this.txt_mukemmel_carpim.Name = "txt_mukemmel_carpim";
            this.txt_mukemmel_carpim.Size = new System.Drawing.Size(220, 22);
            this.txt_mukemmel_carpim.TabIndex = 23;
            // 
            // txt_mukemmel_toplam
            // 
            this.txt_mukemmel_toplam.Enabled = false;
            this.txt_mukemmel_toplam.Location = new System.Drawing.Point(343, 92);
            this.txt_mukemmel_toplam.Name = "txt_mukemmel_toplam";
            this.txt_mukemmel_toplam.Size = new System.Drawing.Size(125, 22);
            this.txt_mukemmel_toplam.TabIndex = 21;
            // 
            // notify_icon
            // 
            this.notify_icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify_icon.BalloonTipText = "Programa Hoşgeldiniz!";
            this.notify_icon.Icon = ((System.Drawing.Icon)(resources.GetObject("notify_icon.Icon")));
            this.notify_icon.Text = "notifyIcon1";
            this.notify_icon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 484);
            this.Controls.Add(this.tabcntrl);
            this.Controls.Add(this.group_Box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_Box1.ResumeLayout(false);
            this.group_Box1.PerformLayout();
            this.tabcntrl.ResumeLayout(false);
            this.tabPage_tek_sayilar.ResumeLayout(false);
            this.tabPage_tek_sayilar.PerformLayout();
            this.tabPage_cift_sayilar.ResumeLayout(false);
            this.tabPage_cift_sayilar.PerformLayout();
            this.tabPage_asal_sayilar.ResumeLayout(false);
            this.tabPage_asal_sayilar.PerformLayout();
            this.tabPage_mukemmel_sayilar.ResumeLayout(false);
            this.tabPage_mukemmel_sayilar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Box1;
        private System.Windows.Forms.Label label_baslangic;
        private System.Windows.Forms.Label label_bitis;
        private System.Windows.Forms.Button btn_calistir;
        private System.Windows.Forms.TextBox txt_tek_toplam;
        private System.Windows.Forms.Label lbl_tek_toplam;
        private System.Windows.Forms.Label lbl_cift_toplam;
        private System.Windows.Forms.TextBox txt_cift_toplam;
        private System.Windows.Forms.Label lbl_tek_carpim;
        private System.Windows.Forms.TextBox txt_tek_carpim;
        private System.Windows.Forms.Label lbl_cift_carpim;
        private System.Windows.Forms.TextBox txt_cift_carpim;
        private System.Windows.Forms.TabControl tabcntrl;
        private System.Windows.Forms.TabPage tabPage_tek_sayilar;
        private System.Windows.Forms.TabPage tabPage_cift_sayilar;
        private System.Windows.Forms.TabPage tabPage_asal_sayilar;
        private System.Windows.Forms.TabPage tabPage_mukemmel_sayilar;
        private System.Windows.Forms.ListView listView_tek_sayilar;
        private System.Windows.Forms.ListView listView_cift_sayilar;
        private System.Windows.Forms.ListView listView_asal_sayilar;
        private System.Windows.Forms.ListView listView_mukemmel_sayilar;
        private System.Windows.Forms.Label lbl_asal_carpim;
        private System.Windows.Forms.Label lbl_asal_toplam;
        private System.Windows.Forms.TextBox txt_asal_toplam;
        private System.Windows.Forms.TextBox txt_asal_carpim;
        private System.Windows.Forms.MaskedTextBox txt_bitis;
        private System.Windows.Forms.MaskedTextBox txt_baslangic;
        private System.Windows.Forms.NotifyIcon notify_icon;
        private System.Windows.Forms.Label lbl_mukemmel_carpim;
        private System.Windows.Forms.Label lbl_mukemmel_toplam;
        private System.Windows.Forms.TextBox txt_mukemmel_carpim;
        private System.Windows.Forms.TextBox txt_mukemmel_toplam;
    }
}

