using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4_RNG
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int numberMin = Convert.ToInt32(txtMin.Text);
            int numberMax = Convert.ToInt32(txtMax.Text);
            int totalNumber = generator.Next (numberMin, numberMax);
            lblNmbr.Text = totalNumber + "";
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNmbr_Click(object sender, EventArgs e)
        {

        }

        private void btnDbl_Click(object sender, EventArgs e)
        {
            int numberMin = Convert.ToInt32(txtMin.Text);
            int numberMax = Convert.ToInt32(txtMax.Text);
            lblNmbr.Text = (generator.Next(numberMin, numberMax) + generator.NextDouble()) + "";
             

        }
    }
}
