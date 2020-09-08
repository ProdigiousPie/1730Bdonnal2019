using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bdonnal1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAUS.Text = "0.00";
            txtRateAUS.Text = "0.72";
            txtAmountCAN.Text = "0.00";
            txtRateCAN.Text = "0.76";
            txtAmountRUS.Text = "0.00";
            txtRateRUS.Text = "0.013";
            txtAmountGER.Text = "0.00";
            txtRateGER.Text = "1.18";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSdAUS.Text = (
                 Convert.ToDecimal(txtAmountAUS.Text)
                 * Convert.ToDecimal(txtRateAUS.Text)
                 ).ToString("0.00");

        }

        private void canadaTextChanged(object sender, EventArgs e)
        {
            txtUSdCAN.Text = (
                 Convert.ToDecimal(txtAmountCAN.Text)
                 * Convert.ToDecimal(txtRateCAN.Text)
                 ).ToString("0.00");
        }

        private void russiaTextChanged(object sender, EventArgs e)
        {
            txtUSdRUS.Text = (
                 Convert.ToDecimal(txtAmountRUS.Text)
                 * Convert.ToDecimal(txtRateRUS.Text)
                 ).ToString("0.00");
        }

        private void germanTextChanged(object sender, EventArgs e)
        {
            txtUSdGER.Text = (
                 Convert.ToDecimal(txtAmountGER.Text)
                 * Convert.ToDecimal(txtRateGER.Text)
                 ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                 Convert.ToDecimal(txtUSdAUS.Text)
                 + Convert.ToDecimal(txtUSdCAN.Text)
                 + Convert.ToDecimal(txtUSdRUS.Text)
                 + Convert.ToDecimal(txtUSdGER.Text)
                ).ToString("0.00");
        }
    }
}
