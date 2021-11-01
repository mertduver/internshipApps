using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriRentACar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Arac> araclar = new List<Arac>();
        private void Form1_Load(object sender, EventArgs e)
        {
            AracTipiCMBDoldur();
        }

        private void AracTipiCMBDoldur()
        {
            AracTipi araba = new AracTipi();
            araba.Sinif = "Araba";
            araba.Aciklama = "hususi otomobil";
            cmbAracTipi.Items.Add(araba);

            AracTipi otobus = new AracTipi();
            otobus.Sinif = "Otobus";
            otobus.Aciklama = "Ticari amaçla yolcu taşımacılığı";
            cmbAracTipi.Items.Add(otobus);

            AracTipi kamyon = new AracTipi();
            kamyon.Sinif = "Kamyon";
            kamyon.Aciklama = "ticari amacla yolcu tasimaciligi";
            cmbAracTipi.Items.Add(kamyon);

            araclar.Add(new Arac(araba, "Mercedes", 100));
            araclar.Add(new Arac(otobus, "Man neo plann", 2000));
            araclar.Add(new Arac(kamyon, "FORD", 3000));
        }

        private void cmbAracTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (cmbAracTipi.SelectedItem != null)
            {
                AracTipi seciliAracTipi = (AracTipi)cmbAracTipi.SelectedItem;
                foreach (Arac item in araclar)
                {
                    if (item.AracTipi == seciliAracTipi)
                    {
                        ListViewItem li = new ListViewItem();
                        li.Tag = item;
                        li.Text = item.Marka;
                        li.SubItems.Add(item.GunlukKiraBedeli.ToString());
                        listView1.Items.Add(li);
                    }
                }
            }
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Arac seciliArac = (Arac)listView1.SelectedItems[0].Tag;
                seciliArac.KiralanmaGunu = Convert.ToInt32(txtGunSayisi.Text);
                lstArac.Items.Add(seciliArac);
            }
        }

        private void btnFiyat_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(lstArac);
            frm.ShowDialog();
        }
    }
}
