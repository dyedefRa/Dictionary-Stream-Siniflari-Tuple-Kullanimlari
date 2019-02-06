using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDEMY_7._54_GENERIC_CLASSMETOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Musteri<int, string, bool> m1 = new Musteri<int, string, bool>();
            m1.ID = 21312;
            m1.Varmı = true;
            m1.Metodd(5, "asdas", true);
            

        }
        class Musteri<T, Y, Z>
        {
            public T No { get; set; }
            public T ID { get; set; }

            public Y Ad { get; set; }
            public Y Soyad { get; set; }

            public Z Varmı { get; set; }

             public void Metodd(T sa ,Y sasa, Z dsaf)
            {
                object c = sa.GetType();
                if( c is int)
                {
                MessageBox.Show("c int");
                }
                if( c is string)
                {
                    MessageBox.Show("c strng");
                }
          
            }
        }

   
    }
}
