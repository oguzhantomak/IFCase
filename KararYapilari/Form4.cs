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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            string username = txtGelenDeger.Text.ToLower();

            switch (username)
            {
                case "admin":
                    MessageBox.Show("Admin hoşgeldin");
                    break;
                case "ceo":
                    MessageBox.Show("CEO hoşgeldin");
                    break;
                case "user":
                    MessageBox.Show("User hoşgeldin");
                    break;
                default:
                    MessageBox.Show("Kullanıcı Bulunamadı !");
                    break;
            }
        }

        private void BtnOrnek2_Click(object sender, EventArgs e)
        {
            string girilenUname = txtGelenDeger.Text, girilenPass = txtGelenDeger2.Text;

            switch (girilenUname)
            {
                case "admin":
                    MessageBox.Show("Kullanıcı Adınız doğru, şifrenizi kontrol etmedim");
                    switch (girilenPass)
                    {
                        case "123":
                            MessageBox.Show("Tebrikler, kullanıcı adı ve şifreniz doğru");
                            break;
                        default:
                            MessageBox.Show("Kullanıcı adınız doğru, şifreniz yanlış !");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Kullanıcı adınız yanlış,şifrenizi kontrol etmedim");
                    break;
            }
        }

        private void BtnOrnek3_Click(object sender, EventArgs e)
        {
            string username = txtGelenDeger.Text.ToLower();

            switch (username)
            {
                case "admin":
                case "ceo":
                case "moderator":
                    MessageBox.Show("Yönetim Paneli");
                    break;
                case "user":
                    MessageBox.Show("Kullanıcı Paneli");
                    break;
                default:
                    MessageBox.Show("Yetki Hatası !");
                    break;
            }
        }
    }
}
