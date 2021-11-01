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
    public partial class Form2 : Form
    {
        private ListBox kullanilanLstArac;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ListBox gelenLstArac)
        {
            InitializeComponent();
            this.kullanilanLstArac = gelenLstArac;
            decimal toplamTutar = 0;
            for (int i = 0; i < kullanilanLstArac.Items.Count; i++)
            {
                Arac arac = (Arac)kullanilanLstArac.Items[i];
                toplamTutar += Convert.ToDecimal(arac.FaturaTutari);
            }
            label2.Text = toplamTutar.ToString("C");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
