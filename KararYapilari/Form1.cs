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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text=="admin")
            {
                MessageBox.Show("Tebrikler Giriş Yaptınız");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Girişi");
            }
            txtDeger.Clear();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(txtDeger.Text);
            if (not<0)
            {
                MessageBox.Show("0'dan küçük bir not girişi yapamazsınız !");
            }
            else if (not>100)
            {
                MessageBox.Show("100'den büyük bir not girişi yapamazsınız! ");
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            int tekCift = Convert.ToInt32(txtDeger.Text);
            if (tekCift%2==0)
            {
                MessageBox.Show("Sayı Çifttir");
            }
            else
            {
                MessageBox.Show("Sayı Tektir!");
            }
            txtDeger.Clear();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(txtDeger.TextLength);
            if (deger>=8)
            {
                MessageBox.Show("Kayıt Onaylandı");
            }
            else
            {
                MessageBox.Show("Daha uzun bir şifre giriniz");
            }
            txtDeger.Clear();
        }
    }
}
