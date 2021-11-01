using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriRentACar
{
    public class AracTipi
    {
        public string Sinif { get; set; }
        public string Aciklama { get; set; }
        private int Kapasite
        {
            get
            {
                if (this.Sinif == "Araba")
                    return 4;
                else if (this.Sinif == "Otobus")
                    return 54;
                else
                    return 8;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}-Kapasitesi:{1}", this.Sinif, this.Kapasite.ToString());
        }
    }
}
