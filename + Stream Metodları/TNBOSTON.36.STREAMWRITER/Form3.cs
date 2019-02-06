using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TNBOSTON._36.STREAMWRITER
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           SaveFileDialog ofd = new SaveFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                //  StreamWriter sw = new StreamWriter(File.Ope)

                File.CreateText(ofd.FileName);

             }
           

            }
        }
}
