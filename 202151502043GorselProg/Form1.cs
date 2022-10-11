using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202151502043GorselProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            label5.Text = ""; // label5 ve label6'yı gizledik.
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ort;
            try
            {

                vize = Convert.ToDouble(numericUpDown1.Value);
                final = Convert.ToDouble(numericUpDown2.Value);
                if (numericUpDown1.Value < 0 || numericUpDown1.Value > 100 || numericUpDown2.Value < 0 || numericUpDown2.Value > 100)
                {

                    MessageBox.Show("kontrol ediniz.");
                }
                else
                {

                    ort = vize * 0.4 + final * 0.6;
                    label5.Text = ort.ToString();
                    if (final < 50 || ort < 50)
                    {
                        label6.Text = "FF";
                        MessageBox.Show("kaldınız");
                        label6.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (ort >= 90 && ort <= 100)
                        {
                            label6.Text = " AA";
                            label6.ForeColor = Color.Green;
                        }
                        else if (ort > 80 && ort < 90)
                        {
                            label6.Text = " BA";
                            label6.ForeColor = Color.Green;
                        }
                        else if (ort > 70 && ort < 80)
                        {
                            label6.Text = " BB";
                            label6.ForeColor = Color.Green; 
                        }
                        else if (ort > 60 && ort < 70)
                        {
                            label6.Text = " CB";
                            label6.ForeColor = Color.Green;

                        }
                        else if (ort > 50 && ort < 60)
                        {
                            label6.Text = ": CC";
                            label6.ForeColor = Color.Green;
                        }
                        else if (ort > 45 && ort < 50)
                        {
                            label6.Text = " DD";
                            label6.ForeColor = Color.Green;
                        }
                        else if (ort >= 0 && ort < 45)
                        {
                            label6.Text = "FF";
                            label6.ForeColor = Color.Red;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata!!!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
