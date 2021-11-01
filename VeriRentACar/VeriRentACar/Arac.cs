using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriRentACar
{
    public class Arac
    {
        public AracTipi AracTipi { get; set; }
        public string Marka { get; set; }
        public int KiralanmaGunu { get; set; }
        public double GunlukKiraBedeli { get; set; }

        public double FaturaTutari
        {
            get { return this.KiralanmaGunu * this.GunlukKiraBedeli; }
        }

        public Arac(AracTipi aracTipi, string marka, double gunlukKiraBedeli)
        {
            this.AracTipi = aracTipi;
            this.Marka = marka;
            this.GunlukKiraBedeli = gunlukKiraBedeli;
        }

        public override string ToString()
        {
            return String.Format("{0}-Fatura Tutari:{1} ₺", this.Marka, this.FaturaTutari);
        }

    }
}
