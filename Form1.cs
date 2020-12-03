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

        void Hesapla()
        {

            if (cbxNereden.Text == "Istanbul" && cbxNereye.Text == "Boston" && checkBoxEko.Checked)
            {
                Bilet bilet = new Bilet(50, 100, 10);
                bilet.AdSoyad = tbxAdSoyad.Text;
                bilet.adet = Convert.ToInt32(tbxAdet.Text);
                bilet.fiyat = (bilet.TabanFiyat + bilet.EkonomikFiyat)*bilet.adet;
                lblFiyat.Text = bilet.fiyat.ToString();
            }
            else if (cbxNereden.Text == "Istanbul" && cbxNereye.Text == "Boston" && checkBoxBusiness.Checked)
            {
                Bilet bilet = new Bilet(50,100,10);
                bilet.AdSoyad = tbxAdSoyad.Text;
                bilet.adet = Convert.ToInt32(tbxAdet.Text);
                bilet.fiyat = (bilet.TabanFiyat + bilet.BusinessFiyat) * bilet.adet;
                lblFiyat.Text = bilet.fiyat.ToString();

            }
            else if (cbxNereden.Text == "Istanbul" && cbxNereye.Text == "Londra" && checkBoxEko.Checked)
            {
                Bilet bilet = new Bilet(60, 120,10);
                bilet.AdSoyad = tbxAdSoyad.Text;
                bilet.adet = Convert.ToInt32(tbxAdet.Text);
                bilet.fiyat = (bilet.TabanFiyat + bilet.EkonomikFiyat) * bilet.adet;
                lblFiyat.Text = bilet.fiyat.ToString();
            }
            else if (cbxNereden.Text == "Istanbul" && cbxNereye.Text == "Londra" && checkBoxBusiness.Checked)
            {
                Bilet bilet = new Bilet(60, 120,10);
                bilet.AdSoyad = tbxAdSoyad.Text;
                bilet.adet = Convert.ToInt32(tbxAdet.Text);
                bilet.fiyat = (bilet.TabanFiyat + bilet.BusinessFiyat) * bilet.adet;
                lblFiyat.Text = bilet.fiyat.ToString();
            }
            else if (cbxNereden.Text == "Istanbul" && cbxNereye.Text == "NewYork" && checkBoxEko.Checked)
            {
                Bilet bilet = new Bilet(80, 160,10);
                bilet.AdSoyad = tbxAdSoyad.Text;
                bilet.adet = Convert.ToInt32(tbxAdet.Text);
                bilet.fiyat = (bilet.TabanFiyat + bilet.EkonomikFiyat) * bilet.adet;
                lblFiyat.Text = bilet.fiyat.ToString();
            }
            else if (cbxNereden.Text == "Istanbul" && cbxNereye.Text == "NewYork" && checkBoxBusiness.Checked)
            {
                Bilet bilet = new Bilet(80, 160,10);
                bilet.AdSoyad = tbxAdSoyad.Text;
                bilet.adet = Convert.ToInt32(tbxAdet.Text);
                bilet.fiyat = (bilet.TabanFiyat + bilet.BusinessFiyat) * bilet.adet;
                lblFiyat.Text = bilet.fiyat.ToString();
            }
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            Hesapla();
        }
    }
}
