using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            double km = Convert.ToDouble(textBox1.Text);
            double cm = Convert.ToDouble(textBox1.Text);

            double rezultat_temperature = 32 + (c * 1.8);
            double rezultat_kilometrov = km / 1.609344;
            double rezultat_centimetrov = cm / 2.54;

            if(checkBox1.Checked==true)
            {
                label3.Text = rezultat_temperature.ToString();
            }    
            else if (checkBox2.Checked==true) 
            { 
                label3.Text = rezultat_kilometrov.ToString();
            }
            else if (checkBox3.Checked==true) 
            {
                label3.Text = rezultat_centimetrov.ToString();
            }

       
        }
    }
}
