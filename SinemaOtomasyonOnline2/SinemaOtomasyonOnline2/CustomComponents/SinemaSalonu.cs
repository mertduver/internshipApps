using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonOnline2
{
    public class SinemaSalonu : UserControl
    {
        public SinemaSalonu()
        {
            this.Size = new Size(36, 50);
            this.AutoSize = true;
        }

        private int grupSayisi;

        public int GrupSayisi
        {
            get { return grupSayisi; }
            set
            {
                grupSayisi = value;
                GruplariCiz();
            }
        }

        private List<int> siraListesi = new List<int>();

        public List<int> SiraListesi
        {
            get { return siraListesi; }
            set
            {
                siraListesi = value;
                GruplariCiz();
            }
        }

        private void GruplariCiz()
        {
            this.Controls.Clear();
            this.koltuklar.Clear();

            if (grupSayisi > 0)
            {
                for (int i = 0; i < grupSayisi; i++)
                {
                    SiraliKoltukGrubu siraliKoltukGrubu = new SiraliKoltukGrubu();
                    siraliKoltukGrubu.SiraListesi = this.siraListesi;
                    siraliKoltukGrubu.Location = new Point(0, i * this.siraListesi.Count * 50);
                    this.Controls.Add(siraliKoltukGrubu);
                    this.koltuklar.AddRange(siraliKoltukGrubu.Koltuklar);
                }

                SiraliKoltuklariHizala();
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

        private void SiraliKoltuklariHizala()
        {
            List<SiraliKoltuk> siraliKoltuklar = SiraliKoltuklariBul();
            var enUzunSira = siraliKoltuklar.Max(siraliKoltuk => siraliKoltuk.KoltukSayisi);

            siraliKoltuklar.ForEach(siraliKoltuk => {
                if(siraliKoltuk.KoltukSayisi < enUzunSira)
                {
                    siraliKoltuk.Location = new Point( (this.Width / 2) - (siraliKoltuk.Width / 2) , siraliKoltuk.Location.Y);
                }
            });
        }

        private List<SiraliKoltuk> SiraliKoltuklariBul()
        {
            List<SiraliKoltuk> siraliKoltuklar = new List<SiraliKoltuk>();


            foreach (var control in this.Controls)
            {
                var siraliKoltukGrubu = control as SiraliKoltukGrubu;
                foreach (var siraliKoltukGrubuKontrol in siraliKoltukGrubu.Controls)
                {
                    var siraliKoltuk = siraliKoltukGrubuKontrol as SiraliKoltuk;
                    siraliKoltuklar.Add(siraliKoltuk);
                }
            }



            return siraliKoltuklar;
        }
    }
}
