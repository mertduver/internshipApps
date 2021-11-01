using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzmirimKartProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            btnOgrenci.Tag = ogr;
            btnOgretmen.Tag = ogrt;
            btnTam.Tag = tam;
            
            cardBtnControls.Add(btnTam);
            cardBtnControls.Add(btnOgretmen);
            cardBtnControls.Add(btnOgrenci);

            lblKalanBakiye.Text = "Kart seçiniz";
        }
        List<Control> cardBtnControls = new List<Control>();
        IzmirimKart tam = new IzmirimKart();
        Ogrenci ogr = new Ogrenci();
        Ogretmen ogrt = new Ogretmen();
        
        
        private void btnYukle_Click(object sender, EventArgs e)
        {
            bool _any = false;
            foreach (var item in cardBtnControls)
            {
                if(item.BackColor.Equals(Color.LightGreen))
                {
                    _any = true;
                    IzmirimKart temp = (IzmirimKart)item.Tag;
                    temp.Bakiye += Convert.ToDecimal(txtBakiye.Text);
                    temp.BakiyeYazdir(lblKalanBakiye);
                }
            }
            if (!_any)
            {
                MessageBox.Show("Lütfen bir kart seçiniz");
            }
        }

        private void btnTam_Click(object sender, EventArgs e)
        {
            tam.BakiyeYazdir(lblKalanBakiye);
            if (btnTam.BackColor != Color.LightGreen)
            {
                btnTam.BackColor = Color.LightGreen;
                btnOgrenci.BackColor = SystemColors.Control;
                btnOgretmen.BackColor = SystemColors.Control;
            }
            else
            {
                btnTam.BackColor = SystemColors.Control;
                lblKalanBakiye.Text = "Kart seçiniz";
            }

            //tam.Okut();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            ogr.BakiyeYazdir(lblKalanBakiye);
            if (btnOgrenci.BackColor != Color.LightGreen)
            {
                btnOgrenci.BackColor = Color.LightGreen;
                btnTam.BackColor = SystemColors.Control;
                btnOgretmen.BackColor = SystemColors.Control;
            }
            else
            {
                btnOgrenci.BackColor = SystemColors.Control;
                lblKalanBakiye.Text = "Kart seçiniz";
            }

            //ogr.Okut();
            //ogr.BakiyeYazdir(lblKalanBakiye);
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            ogrt.BakiyeYazdir(lblKalanBakiye);
            if (btnOgretmen.BackColor != Color.LightGreen)
            {
                btnOgretmen.BackColor = Color.LightGreen;
                btnTam.BackColor = SystemColors.Control;
                btnOgrenci.BackColor = SystemColors.Control;
            }
            else
            {
                btnOgretmen.BackColor = SystemColors.Control;
                lblKalanBakiye.Text = "Kart seçiniz";
            }
            //ogrt.Okut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool _any = false;
            foreach (var item in cardBtnControls)
            {
                if (item.BackColor.Equals(Color.LightGreen))
                {
                    _any = true;
                    IzmirimKart temp = (IzmirimKart)item.Tag;
                    temp.Okut();
                    temp.BakiyeYazdir(lblKalanBakiye);
                }
            }
            if (!_any)
            {
                MessageBox.Show("Lütfen bir kart seçiniz");
            }
        }
    }
}
