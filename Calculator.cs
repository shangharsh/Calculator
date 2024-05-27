using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.TxtResult.Text = "0";
        }

        void BtnEnabled()
        {
            BtnDot.Enabled = true;
            BtnAddition.Enabled = true;
            BtnDivide.Enabled = true;
            BtnSubtract.Enabled = true;
            BtnMultiply.Enabled = true;
            BtnEquals.Enabled = true;
        }

        void BtnDisabled()
        {
            BtnDot.Enabled = false;
            BtnAddition.Enabled = false;
            BtnDivide.Enabled = false;
            BtnSubtract.Enabled = false;
            BtnMultiply.Enabled = false;
            BtnEquals.Enabled = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.TxtResult.Clear();
            this.TxtOldValue.ResetText();
            this.LblOperator.ResetText();
            BtnEnabled();
            this.Btn9.Focus();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "9";
            BtnEnabled();

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "8";
            BtnEnabled();


        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "7";
            BtnEnabled();


        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "6";
            BtnEnabled();


        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "5";
            BtnEnabled();

        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "4";
            BtnEnabled();

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "3";
            BtnEnabled();

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "2";
            BtnEnabled();

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "1";
            BtnEnabled();

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += "0";
            BtnEnabled();

        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            this.TxtResult.Text += ".";
            this.BtnDot.Enabled = false;
            BtnDisabled();
        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            this.TxtOldValue.Text = this.TxtResult.Text;
            this.TxtResult.Text = "";
            this.LblOperator.Text = "+";
            BtnDisabled();
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "+")
            {
                this.TxtResult.Text = (double.Parse(TxtOldValue.Text) + double.Parse(TxtResult.Text)).ToString();    
            }
            else if (LblOperator.Text == "-")
            {
                this.TxtResult.Text = (double.Parse(TxtOldValue.Text) - double.Parse(TxtResult.Text)).ToString();

            }
            else if (LblOperator.Text == "*")
            {
                this.TxtResult.Text = (double.Parse(TxtOldValue.Text) * double.Parse(TxtResult.Text)).ToString();

            }
            else if (LblOperator.Text == "/")
            {
                this.TxtResult.Text = (double.Parse(TxtOldValue.Text) / double.Parse(TxtResult.Text)).ToString();

            }
            this.TxtOldValue.Clear();
            this.LblOperator.ResetText();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            this.TxtOldValue.Text = this.TxtResult.Text;
            this.TxtResult.Text = "";
            this.LblOperator.Text = "-";
            this.BtnAddition.Enabled = false;
            BtnDisabled();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            this.TxtOldValue.Text = this.TxtResult.Text;
            this.TxtResult.Text = "";
            this.LblOperator.Text = "*";
            BtnDisabled();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            this.TxtOldValue.Text = this.TxtResult.Text;
            this.TxtResult.Text = "";
            this.LblOperator.Text = "/";
            BtnDisabled();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }

    }
}
