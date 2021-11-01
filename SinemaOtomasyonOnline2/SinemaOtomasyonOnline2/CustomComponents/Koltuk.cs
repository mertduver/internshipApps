using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonOnline2
{
    public class Koltuk : PictureBox, IKoltuk
    {
        public event RezerveHandler RezerveChanged;
        public Koltuk()
        {
            this.Image = new Bitmap(MaviKoltukPath);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Size = new Size(36, 50);
            this.Name = Guid.NewGuid().ToString();
            this.Click += Form1.OrtakKoltuk_Clicked;
        }

        const string KirmiziKoltukPath = @"C:\Users\dogan.dagbasti\Downloads\BC\Interns\SinemaOtomasyonOnline2\SinemaOtomasyonOnline2\SinemaOtomasyonOnline2\Assets\kirmizi_koltuk.png";
        const string MaviKoltukPath = @"C:\Users\dogan.dagbasti\Downloads\BC\Interns\SinemaOtomasyonOnline2\SinemaOtomasyonOnline2\SinemaOtomasyonOnline2\Assets\mavi_koltuk.jpg";

        private bool isRezerve;
        public bool IsRezerve
        {
            get
            {
                return isRezerve;
            }
            set
            {
                isRezerve = value;

                if (this.RezerveChanged != null)
                    this.RezerveChanged(this);

                if (value)
                    this.Image = new Bitmap(KirmiziKoltukPath);
                else
                    this.Image = new Bitmap(MaviKoltukPath);
                
            }
        }
        public Musteri Musteri { get; set; }
    }
}
