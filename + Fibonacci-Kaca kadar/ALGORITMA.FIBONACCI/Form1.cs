using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALGORITMA.FIBONACCI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int b = Convert.ToInt32(textBox1.Text);
            int[] atadım = BUL(b);
            for(int j =0;j<b;j++)
            {
                listBox1.Items.Add(atadım[j].ToString());
            }
        }
        private int[] BUL(int kacakadar)
        {
            int[] merhaba = new int[kacakadar];

            merhaba[0] = 1;
            merhaba[1] = 1;
            for(int i =2; i< kacakadar;i++)
            {
                merhaba[i] = merhaba[i - 1] + merhaba[i - 2];

            }



            return merhaba;
        }
    }
}
