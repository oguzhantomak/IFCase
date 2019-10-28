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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void BtnOrnek_Click(object sender, EventArgs e)
        {
            //Ternary Operatörü Örneği ?:

            //bool result = 10 > 2;
            //MessageBox.Show(result?"Doğrudur":"Yanlıştır");

            MessageBox.Show((txtGelenDeger.Text.Length < 0 && string.IsNullOrEmpty(txtGelenDeger.Text)) ? txtGelenDeger.Text : "Değer girilmemiştir!");
            MessageBox.Show(!string.IsNullOrWhiteSpace(txtGelenDeger.Text) ? txtGelenDeger.Text : "Değer girilmemiştir");
        }
    }
}
