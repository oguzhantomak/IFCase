using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form3 : Form
    {
        public void randomDeger()
        {
            Random rnd = new Random();
            int rastgele = rnd.Next(10000000, 100000000);
            lblRastgeleGelenDeger.Text = rastgele.ToString();
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            randomDeger(); 
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            int kalan = Convert.ToInt32(lblKalanHak.Text);
            if (txt1.Text == lblRastgeleGelenDeger.Text)
            {
                MessageBox.Show("Tebrikler, doğrulamayı geçtiniz !");
                txt1.Clear();
                txt1.Focus();
            }
            else
            {
                randomDeger();
                
                txt1.Clear();
                txt1.Focus();
                MessageBox.Show("Doğrulama kodu hatalı, tekrar deneyiniz.\n Hakkınız 1 azaldı !");
                kalan--;
                lblKalanHak.Text = kalan.ToString();
                if (kalan == 0)
                {
                    MessageBox.Show("Deneme hakkınız kalmadı. \nLütfen Daha Sonra Tekrar Deneyiniz. !");
                    btnGirisYap.Enabled = false;
                }
            }
        }
    }
}
