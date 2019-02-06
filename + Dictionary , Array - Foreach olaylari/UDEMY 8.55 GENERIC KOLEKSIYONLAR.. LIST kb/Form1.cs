using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace UDEMY_8._55_GENERIC_KOLEKSIYONLAR._.LIST_kb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int[] dizim = { 2, 3,4, 5, 6, 7 };


            ArrayList Al = new ArrayList();
            int x = 1;
            Al.Add(x);
         //   Al.AddRange(dizim);


            List<int> SAA = new List<int>();
            SAA.Add(1);
            SAA.AddRange(dizim);

            bool Kontrol = SAA.Contains(4);
            // MessageBox.Show(string.Format("Aradığınız değer generic listin içersinde {0}",Kontrol? "Var":"Yok"));


            SortedList<int, int> karesi = new SortedList<int, int>();
            karesi.Add(1, 1);
            karesi.Add(3, 9);
            karesi.Add(2, 4);

        }
    }
}
