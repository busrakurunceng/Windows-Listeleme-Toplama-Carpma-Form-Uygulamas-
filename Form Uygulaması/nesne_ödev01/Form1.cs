using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace nesne_ödev01
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
            
            //NotifyIcon Kullanımı

            notify_icon.BalloonTipIcon=ToolTipIcon.Info;
            notify_icon.BalloonTipText = "Nesne Yönelimli Programlama Ödevi01";
            notify_icon.BalloonTipTitle = "Programa Hoş Geldiniz";
            notify_icon.ShowBalloonTip(5000);  

        }

        private Boolean Dogrula(int baslangic , int bitis)
        {
          
            return ((bitis <= 10000) && (baslangic < bitis)) ? true : false;
        }

        private void tek_cift_listele(int baslangic , int bitis)
        {
            for (int i = baslangic; i <= bitis; i++)
            {
                if ((i % 2) == 0)
                {
                    listView_cift_sayilar.Items.Add(i.ToString());
                }
                else
                    listView_tek_sayilar.Items.Add(i.ToString());
            }
        }
       
        int tek_toplam_sonuc_don(int baslangic , int bitis)
        {
            int  tek_toplam = 0;

            for (int i = baslangic; i <= bitis; i++)
            {
                if ((i % 2) != 0)
                {
                    tek_toplam += i;
                }   
            }
            return tek_toplam;
        }

        int cift_toplam_sonuc_don(int baslangic, int bitis)
        {
            int cift_toplam = 0;

            for (int i = baslangic; i <= bitis; i++)
            {
                if ((i % 2) == 0)
                {
                    cift_toplam += i;
                }
            }
            return cift_toplam;
        }

        double tek_carpim_sonuc_don(int baslangic, int bitis)
        {
            double tek_carpim = 1;

            for (int i = baslangic; i <= bitis; i++)
            {
                if ((i % 2) != 0)
                {
                    tek_carpim *= i;
                }
            }
            return (double)tek_carpim;
        }

        double cift_carpim_sonuc_don(int baslangic, int bitis)
        {
            double cift_carpim = 1;

            for (int i = baslangic; i <= bitis; i++)
            {
                if ((i % 2) == 0)
                {
                    cift_carpim *= i;
                }
            }
            return (double)cift_carpim;
        }


        private static bool Asal_sayi_listeleme(int sayi)
        {
            bool asal_sayi_bul = true;
            for (int i = 2; i < (sayi-1); i++)
            {
                if (sayi % i == 0)
                {
                    asal_sayi_bul=false;
                    i=sayi;
                }
            }
            if(sayi < 2)
            {
                asal_sayi_bul = false;
            }
            return asal_sayi_bul;
        }
 
        private bool Mukemmel_sayi_listeleme(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam == sayi)
            {
                return true;
            }
            else
                return false;
        }


        private void btn_calistir_Click(object sender, EventArgs e)
        {
            //toplam ve çarpım tanımlamaları
            int cift_toplam = 0, tek_toplam = 0 , asal_toplam = 0 , mukemmel_toplam=0;
            double cift_carpim = 1, tek_carpim = 1 , asal_carpim=1 , mukemmel_carpim=1;
            
            //txt_baslangic'e ve txt_bitis'e girilen sayıları "baslangic" ve "bitis" adlı değişkenlere atıyarak kullanım kolaylığı sağlıyorum. 
            
            int baslangic=Convert.ToInt32(txt_baslangic.Text);
            int bitis=Convert.ToInt32(txt_bitis.Text);

            txt_baslangic.Clear();
            txt_bitis.Clear();

            if (Dogrula(baslangic, bitis))
            {
                // Tek ve çift sayılarda TOPLAMA İŞLEMİ

                tek_toplam = tek_toplam_sonuc_don( baslangic, bitis);
                cift_toplam = cift_toplam_sonuc_don(baslangic, bitis);

                txt_tek_toplam.Clear();
                txt_cift_toplam.Clear();

                txt_tek_toplam.Text = tek_toplam.ToString();
                txt_cift_toplam.Text = cift_toplam.ToString();


                //Tek ve çift sayılarda ÇARPMA İŞLEMİ


                tek_carpim = tek_carpim_sonuc_don(baslangic, bitis);
                cift_carpim = cift_carpim_sonuc_don(baslangic, bitis);

                txt_tek_carpim.Clear();
                txt_cift_carpim.Clear();

                txt_tek_carpim.Text = tek_carpim.ToString();
                txt_cift_carpim.Text = cift_carpim.ToString();

                // Tek ve çift sayıları Listeleme

                listView_tek_sayilar.Items.Clear();
                listView_cift_sayilar.Items.Clear();

                tek_cift_listele(baslangic, bitis);


                //Asal Sayı Listeleme

                listView_asal_sayilar.Clear();

                for(int i = baslangic; i < bitis; i++)
                {
                    if (Asal_sayi_listeleme(i) == true)
                    {
                        listView_asal_sayilar.Items.Add(i.ToString());
                        asal_toplam += i;
                        asal_carpim *= i;
                    }
                }
                
                // Asal Sayılarda Toplama ve Çarpma
              
                 txt_asal_toplam.Clear();
                 txt_asal_toplam.Text= asal_toplam.ToString();

                 txt_asal_carpim.Clear();
                 txt_asal_carpim.Text= asal_carpim.ToString();


                //Mükemmel Sayılar

                listView_mukemmel_sayilar.Clear();

                for (int i = baslangic; i < bitis; i++)
                {
                    if (Mukemmel_sayi_listeleme(i) == true)
                    {
                        listView_mukemmel_sayilar.Items.Add(i.ToString());
                        mukemmel_toplam += i;
                        mukemmel_carpim *= i;
                    }
                }

                //Mükemmel Sayılarda Toplama ve Çıkarma

                txt_mukemmel_toplam.Clear();
                txt_mukemmel_toplam.Text = mukemmel_toplam.ToString();

                txt_mukemmel_carpim.Clear();
                txt_mukemmel_carpim.Text = mukemmel_carpim.ToString();

            }

            else MessageBox.Show("Hata! Lütfen belirtilen aralıkta değer giriniz...");
        }
    }
}
