using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.NewFolder1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı, sonuç;
            sayı = Convert.ToInt32(textBox1.Text);
            sonuç = sayı * sayı;
            label1.Text = sonuç.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if(sayi%2==0)
            {
                label1.Text = "çift";
            }
            else
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
