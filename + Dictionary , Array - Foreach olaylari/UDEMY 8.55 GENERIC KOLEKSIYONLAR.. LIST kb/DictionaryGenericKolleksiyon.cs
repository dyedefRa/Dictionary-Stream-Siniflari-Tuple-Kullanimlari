using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDEMY_8._55_GENERIC_KOLEKSIYONLAR._LIST_kb
{
    public partial class DictionaryGenericKolleksiyon : Form
    {
        public DictionaryGenericKolleksiyon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("pencil", "kalem");
            sozluk.Add("egg", "yumurta");

            sozluk["egg"] = "yimırta";

            foreach (KeyValuePair<string,string> item in sozluk)
            {

            }
        }
    }
}
