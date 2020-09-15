using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bdonnal1f1
{
    public partial class frmCurancy : Form
    {
        public frmCurancy()
        {
            InitializeComponent();
        }

        private void frmCurancy_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            lblCurrency.Text = "Australian Dollar:";
            txtRate.Text = "0.72";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            lblCurrency.Text = "Australian Dollar:";
            txtRate.Text = "0.72";
            txtCurrency.Focus();
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            lblCurrency.Text = "Canadain Dollar:";
            txtRate.Text = "0.76";
            txtCurrency.Focus();
        }

        private void btnGermany_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnGermany.BackgroundImage = picGermany.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            lblCurrency.Text = "Euro:";
            txtRate.Text = "1.18";
            txtCurrency.Focus();
        }

        private void btnRussia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnRussia.BackgroundImage = picRussia.Image;
            lblCurrency.Text = "Ruble:";
            txtRate.Text = "0.013";
            txtCurrency.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUsDollars.Text = (Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtCurrency_Click(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUsDollars.Text = (Convert.ToDecimal(txtTotalUsDollars.Text)
            + Convert.ToDecimal(txtUsDollars.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtTotalUsDollars.Text;
            txtCurrency.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnRussia.BackgroundImage = picRussiaDim.Image;
            lblCurrency.Text = "Australian Dollar:";
            txtRate.Text = "0.72";
            txtCurrency.Text = "0.00";
            txtTotalUsDollars.Text = "0.00";
            lblEquation.Text = "";
        }
    }
}
