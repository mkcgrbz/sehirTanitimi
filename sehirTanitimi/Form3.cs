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

namespace sehirTanitimi
{
    public partial class Form3 : Form
    {
        public int plaka;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("text\\"+plaka+".txt",Encoding.GetEncoding("iso-8859-9"),false);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadToEnd();
                richTextBox1.Text = s;
            }
        }
    }
}
