using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;


namespace IzmirimKartProject
{
    

    public class IzmirimKart
    {
        decimal transferPrice = Convert.ToDecimal(0.10);
        decimal price = Convert.ToDecimal(3.46);
        Stopwatch stopWatch = new Stopwatch();
        

        private decimal _bakiye;
        public decimal Bakiye
        {
            get { return _bakiye; }
            set
            {
                if (value >= 0)
                {
                    _bakiye = value;
                }
                else
                {
                    MessageBox.Show("Bakiye yetersiz");
                }
            }
        }

        public virtual void Okut()
        {
            if (!stopWatch.IsRunning)
            {
                stopWatch.Start();
                Bakiye = Decimal.Subtract(Bakiye, price);
            }
            else if (stopWatch.ElapsedMilliseconds <= 5000)
            {
                Bakiye = Decimal.Subtract(Bakiye, price);
            }
            else if (stopWatch.ElapsedMilliseconds > 5000 && stopWatch.ElapsedMilliseconds <= 90000)
            {
                Bakiye = Decimal.Subtract(Bakiye, transferPrice);
            }
            if (stopWatch.ElapsedMilliseconds > 90000)
            {
                stopWatch.Stop();
            }


        }

      

        public void BakiyeYazdir(Control control)
        {
            control.Text = Bakiye.ToString();
        }
    }
}
