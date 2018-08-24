using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        float hold;
        float n1;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains('.') == false)
            {
                if (lblDisplay.Text.Length < 8)
                {
                    if (lblDisplay.Text == "0")
                    {
                        lblDisplay.Text = ((Button)sender).Text;
                    }
                    else
                    {
                        if (((Button)sender).Text != "0")
                        {
                            lblDisplay.Text += ((Button)sender).Text;
                        }
                        else if (((Button)sender).Text == "0")
                        {
                            lblDisplay.Text = lblDisplay.Text + "0";
                        }
                    }
                }
            }
            if (lblDisplay.Text.Contains('.') == true)
            {
                if (lblDisplay.Text.Length < 9)
                {
                    if (lblDisplay.Text == "0")
                    {
                        lblDisplay.Text = ((Button)sender).Text;
                    }
                    else
                    {
                        if (((Button)sender).Text != "0")
                        {
                            lblDisplay.Text += ((Button)sender).Text;
                        }
                        else if (((Button)sender).Text == "0")
                        {
                            lblDisplay.Text = lblDisplay.Text + "0";
                        }
                    }
                }
            }

        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            Operation = ((Button)sender).Text;

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float n2;
            float ans;
            n2 = float.Parse(lblDisplay.Text);

            if (Operation == "+")
            {
                ans = (n1 + n2);
                lblDisplay.Text = Convert.ToString(ans);
                n1 = ans;
            }
            if (Operation == "-")
            {
                ans = (n1 - n2);
                lblDisplay.Text = Convert.ToString(ans);
                n1 = ans;
            }
            if (Operation == "X")
            {
                ans = (n1 * n2);
                lblDisplay.Text = Convert.ToString(ans);
                n1 = ans;
            }
            if (Operation == "÷")
            {
                if (n2 == 0)
                {
                    lblDisplay.Text = "Cannot divide by zero";

                }
                else
                {
                    ans = (n1 / n2);
                    lblDisplay.Text = Convert.ToString(ans);
                    n1 = ans;
                }
            }
            if (lblDisplay.Text.Length > 9 && lblDisplay.Text.Contains('.') == true)
            {
                lblDisplay.Text = "Error !";                                                                   
            }
            if(lblDisplay.Text.Length > 8 && lblDisplay.Text.Contains('.') == false)
            {
                lblDisplay.Text = "Error !";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains('.') == false)
            {
                lblDisplay.Text += ".";
            }
        }
        private void btnSign_Click(object sender, EventArgs e)
        {

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            hold = float.Parse(lblDisplay.Text);
            lblDisplay.Text = Convert.ToString(n1*(hold/100));
    }
}
    }