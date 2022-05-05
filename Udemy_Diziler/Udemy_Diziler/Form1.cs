using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] sayilar = { 12.4, 32.5, 2.7, 234.6 };
            label1.Text = sayilar[3].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] harfler = { 'A', 'Y','K', 'E'};
            label2.Text = harfler[2].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Ankara", "Eskişehir", "Antalya", "Adana" };
            for (int i = 0; i < sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }    
            
         }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] sayilar1 = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < sayilar1.Length; i++)
            {
               if(sayilar1[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayilar1[i]);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayilar2 = { 23, 12, 32, 7, 38, 83, 65, 6 };
            for (int i = 0; i < sayilar2.Length; i++)
            {
                if(sayilar2[i] % 2 == 0 && sayilar2[i] > 10)
                {
                    listBox3.Items.Add(sayilar2[i]);
                }
            }
        }
    }
}
