using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDEMY_6._50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        abstract class Insan
        {

            public abstract string Dil { get; set; }
            public abstract void Konus();
          
        }

        class Turk : Insan
        {
            private string dil;

            public override string Dil
            {
                get
                {
                    return dil;
                }
                set
                {
                    dil = value;
                }
            }

            public override void Konus()
            {
                MessageBox.Show(string.Format("{0}", Dil));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turk t1 = new Turk();
                t1.Dil = "Suprayz";
            t1.Konus();
        }
    }
}
