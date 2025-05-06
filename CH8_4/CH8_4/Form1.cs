using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] data = new int[6];
        int min = 0, max = 0;

        private int arrMin(int x)
        {
            int min = data[0];
            data[0] = Convert.ToInt32(textBox1.Text);
            data[1] = Convert.ToInt32(textBox2.Text);
            data[2] = Convert.ToInt32(textBox3.Text);
            data[3] = Convert.ToInt32(textBox4.Text);
            data[4] = Convert.ToInt32(textBox5.Text);
            data[5] = Convert.ToInt32(textBox6.Text);
            for (int i=0 ; i<data.Length ; i++)
            {
                if (data[i] < min)
                    min = data[i];
            }
            return min;
        }

        private int arrMax(int y)
        {
            int max = data[0];
            data[0] = Convert.ToInt32(textBox1.Text);
            data[1] = Convert.ToInt32(textBox2.Text);
            data[2] = Convert.ToInt32(textBox3.Text);
            data[3] = Convert.ToInt32(textBox4.Text);
            data[4] = Convert.ToInt32(textBox5.Text);
            data[5] = Convert.ToInt32(textBox6.Text);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > max)
                    max = data[i];
            }
            return max;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arrMax(max);
            label1.Text = $" 最大值 = {arrMax(max)}"; ;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            arrMin(min);
            label1.Text = $" 最小值 = {arrMin(min)}";            
        }
    }
}