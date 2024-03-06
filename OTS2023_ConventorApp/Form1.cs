using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Convert(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioMass_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Pounds";
            label2.Text = "kg";

        }

        private void radiolength_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Feet";
            label2.Text = "m";

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
           // textBox2.Text=(Convert.ToInt32(textBox1.Text).ToString());
        }


        public void Convert()
        {
           /* if (radioMass_CheckedChanged(this,))
            {

            }*/


        }
    }
}
