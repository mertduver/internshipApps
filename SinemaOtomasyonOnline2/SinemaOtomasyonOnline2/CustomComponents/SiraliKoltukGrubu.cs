using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonOnline2
{
    public class SiraliKoltukGrubu : UserControl
    {
        public SiraliKoltukGrubu()
        {
            this.Size = new Size(36, 50);
            this.AutoSize = true;
        }

        private List<int> siraListesi = new List<int>();

        public List<int> SiraListesi
        {
            get { return siraListesi; }
            set
            {
                siraListesi = value;

                this.Controls.Clear();
                this.koltuklar.Clear();

                if (siraListesi.Count > 0)
                {
                    for (int i = 0; i < siraListesi.Count; i++)
                    {
                        SiraliKoltuk siraliKoltuk = new SiraliKoltuk();
                        siraliKoltuk.KoltukSayisi = siraListesi[i];
                        siraliKoltuk.Location = new Point(0, i * 50);
                        this.Controls.Add(siraliKoltuk);
                        this.koltuklar.AddRange(siraliKoltuk.Koltuklar);
                    }
                }
            }
        }

        private List<Koltuk> koltuklar = new List<Koltuk>();
        public List<Koltuk> Koltuklar
        {
            get
            {
                return this.koltuklar;
            }
        }

    }
}
