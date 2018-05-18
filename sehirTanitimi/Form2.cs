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
    public partial class Form2 : Form
    {
        public int plaka;
        sehirBilgiEntities sb = new sehirBilgiEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Iller il = (from x in sb.Illers where x.plaka == plaka select x).FirstOrDefault();
            var nufus = (from x in sb.Nufus where x.iller_plaka == plaka select x.toplamNufus).First();
            var bid = il.bolge_id;
            string bolge = (from x in sb.Bolgelers where x.bolge_id == bid select x.ad).First();
            label1.Text = il.sehir_adi;
            label8.Text = il.plaka.ToString();
            label9.Text = nufus.ToString();
            label10.Text = il.rakim.ToString();
            label12.Text = il.tel_kodu.ToString();
            label13.Text = bolge;

            string ilocation = "\\images\\" +plaka+"";
            int a = 20;
            int b = 20;
            //pictureBox2.Image = Image.FromFile(Application.StartupPath + ilocation +"\\1.jpg");
            for (int i = 0; i < 4; i++)
            {
                int resim = i + 1;
                PictureBox pb = new PictureBox();
                pb.Size = new Size(200, 200);
                if (i < 2)
                {
                    pb.Location = new Point(20, ((i) * 200) + a);
                    pb.Image = Image.FromFile(Application.StartupPath + ilocation + "\\" + resim + ".jpg");
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pb);
                    a += 20;
                }
                else if(i>=2)
                {
                    
                    pb.Location = new Point(564, ((i-2)*200)+b);
                    pb.Image = Image.FromFile(Application.StartupPath + ilocation + "\\" + resim + ".jpg");
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pb);
                    b += 20;
                    

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.plaka = plaka;
            f3.Show();
        }
    }
}
