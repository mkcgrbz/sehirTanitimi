using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sehirTanitimi
{
    public partial class Form1 : Form
    {
        sehirBilgiEntities sb = new sehirBilgiEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] dizi = comboBox2.SelectedItem.ToString().Split(',');
            int plaka = Convert.ToInt32(dizi[0]);
            Form2 f2 = new Form2();
            f2.plaka = plaka;
            this.Hide();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sehirler = (from x in sb.Illers select x.plaka + "," + x.sehir_adi).ToList();
            comboBox2.DataSource = sehirler;
        }
    }
}
