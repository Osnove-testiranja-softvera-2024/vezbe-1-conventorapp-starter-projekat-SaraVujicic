using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        //public TimeConventer conventer;
        public Form1()
        {
            InitializeComponent();
           TimeConventer conventer = new TimeConventer();
        }
        

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = true;
            label1.Text = "pounds";
            label2.Text = "kg";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = true;
            label1.Text = "feet";
            label2.Text = "m";
        }

        public void Button1_Click(object sender, EventArgs e)
            //private bilo
        {
            TimeConventer conventer = new TimeConventer();
            if (radioMass.Checked)
            {
                MassConventer converter = new MassConventer();
                if (radioArray.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertArray(textBox1.Text).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        textBox2.Text = converter.Convert(Double.Parse(textBox1.Text)).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (radiolength.Checked)
            {
                LengthConverter converter = new LengthConverter();
                if (radioArray.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertArray(textBox1.Text).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        textBox2.Text = converter.Convert(Double.Parse(textBox1.Text)).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (radioMoney.Checked)
            {
                label1.Text = "eur";
                label2.Text = "rsd";
                MoneyConventer converter = new MoneyConventer();
                if (radioArray.Checked)
                {

                    try
                    {
                        textBox2.Text = converter.ConvertArray(textBox1.Text).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        textBox2.Text = converter.Convert(Double.Parse(textBox1.Text)).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (radioTime.Checked)
            {
                if (radioHours.Checked)
                {
                    label2.Text = "hours";
                }
                else if (radioMinutes.Checked)
                {
                    label2.Text = "minutes";
                }
                else
                {
                    label2.Text = "seconds";
                }
                try
                {
                    if (radioHours.Checked)
                    {
                        textBox2.Text = conventer.ConvertHours(Double.Parse(textBox1.Text)).ToString();
                    }
                    else if (radioMinutes.Checked)
                    {
                        textBox2.Text = conventer.ConvertMinutes(Double.Parse(textBox1.Text)).ToString();
                    }
                    else if (radioSeconds.Checked)
                    {
                        textBox2.Text = conventer.ConvertSeconds(Double.Parse(textBox1.Text)).ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioCustom.Checked)
            {
                label1.Text = "custom expression";
                label2.Text = "result";

                CustomMoneyConventer converter = new CustomMoneyConventer();
                try
                {
                    textBox2.Text = converter.ConvertCustomMoney(textBox1.Text).ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RbtnMoney_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = true;
            label1.Text = "eur";
            label2.Text = "rsd";
        }

        private void RbtnTime_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "days";
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            if (radioHours.Checked)
            {
                label2.Text = "hours";
            }
            else if (radioMinutes.Checked)
            {
                label2.Text = "minutes";
            }
            else
            {
                label2.Text = "seconds";
            }
        }

        private void RbtnCustomMoney_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            label1.Text = "custom expression";
            label2.Text = "result";
        }
    }
}
