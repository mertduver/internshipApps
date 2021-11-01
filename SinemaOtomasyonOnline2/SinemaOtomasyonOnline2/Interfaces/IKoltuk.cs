using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonOnline2
{
    public interface IKoltuk
    {
        bool IsRezerve { get; set; }
        Musteri Musteri { get; set; }
    }
}
