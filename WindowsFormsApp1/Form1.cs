using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        // Yeni Oyun butonuna bastığımızda temizlenmesi gereken yerler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            txtSayi_bir.Clear();
            txtSayi_iki.Clear();
            txtSayi_uc.Clear();
            txtSayi_dort.Clear();
            txtSayi_bes.Clear();
            txtSayi_alti.Clear();
            txtHedef_sayi.Clear();
            listBox1.Items.Clear();
            label6.Text = "";
            
        }
        
        // Oyun Kuralları adlı butona bastığımızda ekranda gözükmesini istediğim yazı.
        private void btnKural_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir işlem oyununda amaç; 5 tane tek basamaklı ve 1 tane 10'un katı 2 basamaklı sayıyla 4 işlem yaparak hedef sayıya ulaşmaktır. Bu sayılar yalnızca bir kere kullanılmalıdır. Sonuç bulunurken +9/-9 fark olabilir.", "Oyun Kuralları", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sağ üstteki çarpı işaretine bastğımda uygulamanın kapanmasını sağlayan kod.
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        

        // Kod ilk çalıştığında groupBox'ı gizliyorum.
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

      
        //Kullanıcı butonuna bastığımda textbox'lara girmiş olduğumuz sayıları numbers adlı dizime atıyor. Böylece ayrı bir hesaplama kodu yazmıyorum.
        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {

            numbers[0] = Convert.ToInt32(txtSayi_bir.Text);
            numbers[1] = Convert.ToInt32(txtSayi_iki.Text);
            numbers[2] = Convert.ToInt32(txtSayi_uc.Text);
            numbers[3] = Convert.ToInt32(txtSayi_dort.Text);
            numbers[4] = Convert.ToInt32(txtSayi_bes.Text);
            numbers[5] = Convert.ToInt32(txtSayi_alti.Text);
            expected = Convert.ToInt32(txtHedef_sayi.Text);

        }

        // Kullanıcı girişini kontrol etmek için radiobutton koydum radiobutton seçili ise textboxların enable özelliğini true yapıyoruz ve kullanıcı sayı girebiliyor.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Lütfen 5 adet tek basamaklı, 1 adet iki basamaklı sayı ve bir de hedef sayınızı giriniz.");
            }

            txtHedef_sayi.Enabled = true;
            txtSayi_alti.Enabled = true;
            txtSayi_bes.Enabled = true;
            txtSayi_dort.Enabled = true;
            txtSayi_uc.Enabled = true;
            txtSayi_iki.Enabled = true;
            txtSayi_bir.Enabled = true;
        }
        // Başlat butonuna basılınca groupbox'ın gözükmesini sağlıyor.
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
 
        }
        // Tanımlamalarımı yapıyorum.
        Random random = new Random();
        int[] numbers = new int[6];
        int ikibsmk, onunkati, expected;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Random sayılar üretip diziye atıyorum ve dizideki değerleri textboxlara yazdırıyorum enable özelliğini de false yaparak kullanıcı girişini engelliyorum.
        private void btnSayi_uret_Click(object sender, EventArgs e)
        {
            expected = random.Next(100, 1000);
            txtHedef_sayi.Text=expected.ToString();
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = random.Next(1, 10);
            }
            ikibsmk = random.Next(10, 100);
            onunkati = ikibsmk - ikibsmk % 10;
            numbers[5] = onunkati;
            txtSayi_bir.Text = numbers[0].ToString();
            txtSayi_iki.Text = numbers[1].ToString();
            txtSayi_uc.Text = numbers[2].ToString();
            txtSayi_dort.Text = numbers[3].ToString();
            txtSayi_bes.Text = numbers[4].ToString();
            txtSayi_alti.Text = numbers[5].ToString();

            txtHedef_sayi.Enabled = false;
            txtSayi_alti.Enabled = false;
            txtSayi_bes.Enabled = false;
            txtSayi_dort.Enabled = false;
            txtSayi_uc.Enabled = false;
            txtSayi_iki.Enabled = false;
            txtSayi_bir.Enabled = false;



        }
        
        private void btnCozum_Click(object sender, EventArgs e)
        {
            int puan = 0;   // Bulunan sonuca göre puanlama yapılıyor 
            int result; 
            while (true)
            {
                int index = random.Next(6); // Döngü her başladığında 6'ya kadar random bir sayı üretiyorum. 6 dahil değil
                int temp = numbers[index];  //Ardından bu değeri numbers dizimin indexine atıyorum ve onu da temp adlı bir değişkende tutuyorum
                numbers[index] = numbers[0];
                numbers[0] = temp;
                result = numbers[0];   //numbers[0] değerini result değişkenime atıyorum
                string operationStr = numbers[0].ToString();
                int kullanilacaksayi = random.Next(1, 7);  // Kullanılacak sayı adedimi random olarak tutuyorum.
                for (int i = 1; i < kullanilacaksayi; i++)   
                {
                    int calculationType = random.Next(4);  // 4 işlemleri random olarak seçiyorum ve işlemleri yaptırıp result değerine sonucu operationStr'ye ise işlemleri yazdırıyorum
                    if (calculationType == 0)  
                    {
                        result += numbers[i];
                        operationStr = "(" + operationStr + "+" + numbers[i] + ")";
                    }
                    else if (calculationType == 1)
                    {
                        result -= numbers[i];
                        operationStr = "(" + operationStr + "-" + numbers[i] + ")";
                    }
                    else if (calculationType == 2)
                    {
                        result *= numbers[i];
                        operationStr = "(" + operationStr + "*" + numbers[i] + ")";
                    }
                    else if (calculationType == 3)
                    {
                        if (result != 0 && numbers[i] != 0)
                        {
                            result /= numbers[i];
                            operationStr = "(" + operationStr + "/" + numbers[i] + ")";
                        }
                    }
                }

                operationStr += "=" + result;

               

                if (expected==result || result-9==expected || result+9==expected)  // result değişkenimiz hedef sayımıza eşitse veya -9/+9 ise if bloğuna giriyor
                {
                    listBox1.Items.Add(operationStr);   // Bulduğu sonucu listboxa yazıyor
                    
                    if (expected == result)
                    {
                        puan = 15;
                        label6.Text = puan.ToString();
                    }
                    else if (Math.Abs(expected - result) == 1)
                    {
                        puan = 11;
                        label6.Text = puan.ToString();
                    }
                    else if (Math.Abs(expected - result) == 2)
                    {
                        puan = 9;
                        label6.Text = puan.ToString();
                    }
                    else if (Math.Abs(expected - result) == 3)
                    {
                        puan = 7;
                        label6.Text = puan.ToString();
                    }
                    else if (Math.Abs(expected - result) == 4)
                    {
                        puan = 6;
                        label6.Text = puan.ToString();
                    }
                    else if (Math.Abs(expected - result) == 5)
                    {
                        puan = 5;
                        label6.Text = puan.ToString();
                    }
                    else if (Math.Abs(expected - result) == 6)
                    {
                        puan = 4;
                        label6.Text = puan.ToString();
                    }
                    else if (Math.Abs(expected - result) == 7)
                    {
                        puan = 3;
                        label6.Text = puan.ToString();
                    }
                    else if (Math.Abs(expected - result) == 8)
                    {
                        puan = 2;
                        label6.Text = puan.ToString();
                    }
                    else if (Math.Abs(expected - result) == 9)
                    {
                        puan = 1;
                        label6.Text = puan.ToString();
                    }

                    break;   // Sonsuz döngüye girmesin diye sonucu bulduğunda döngü burada bitiyor

                }


            }
           

        }
    }
}
