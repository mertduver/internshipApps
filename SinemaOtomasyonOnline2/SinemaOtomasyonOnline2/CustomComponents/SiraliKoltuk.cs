using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonOnline2
{
    public class SiraliKoltuk : UserControl
    {
        public SiraliKoltuk()
        {
            this.Size = new Size(36, 50);
            this.AutoSize = true;
        }

        private int koltukSayisi;

        public int KoltukSayisi
        {
            get { return koltukSayisi; }
            set
            {
                koltukSayisi = value;

                this.Controls.Clear();
                this.koltuklar.Clear();

                if (koltukSayisi > 0)
                {
                    for (int i = 0; i < koltukSayisi; i++)
                    {
                        Koltuk koltuk = new Koltuk();
                        koltuk.Location = new Point(i * 40, 0);
                        this.Controls.Add(koltuk);
                        this.koltuklar.Add(koltuk);
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
