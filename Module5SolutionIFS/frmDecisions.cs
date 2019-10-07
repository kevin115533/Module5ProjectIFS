using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Author: Kevin Tran
 * ITD 1252
 * Fall 2019
 * Due: 10/8/2019
 * */

namespace Module5SolutionIFS
{
    public partial class frmDecisions : Form
    {
        public frmDecisions()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtCheckNumber.Text = "";
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblMessage.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Convert text in text boxes to int variables
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int checkNum = int.Parse(txtCheckNumber.Text);
            
            if (checkNum == num1 || checkNum == num2)// This statement will check if the checked number is equal to any of the range numbers
            {
                if(checkNum == num1) // This nested statement will now decide which message to display 
                {
                    lblMessage.Text = "The checked number is equal to the low end number";
                }
                else if(checkNum == num2)
                {
                    lblMessage.Text = "The checked number is equal to the high end number";
                }
            }
            else if (checkNum < num1) // Checks to see if the number is lower than the range
            {
                lblMessage.Text = "The checked number is smaller than the range";
            }
            else if (checkNum > num2) // Checks to see if the number is higher than the range
            {
                lblMessage.Text = "The checked number is larger than the range";
            }
            else // Checks for the last possible outcome
            {
                lblMessage.Text = "The checked number is within range";
            }
        }
    }
}
