using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;
using System.Windows.Forms;

namespace CSAY_RESERVOIR
{
    public partial class FrmZScore : Form
    {
        double sigma, X, mu, z, CDF;

        private void TxtX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FindZ();
            }
            catch
            {

            }
        }

        private void Txtmu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FindZ();
            }
            catch
            {

            }
        }

        private void Txtsigma_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FindZ();
            }
            catch
            {

            }
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void TxtZ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FindZ();
            }
            catch
            {

            }
        }

        public FrmZScore()
        {
            InitializeComponent();
        }

        private void ThomasFieringModel_Load(object sender, EventArgs e)
        {

        }
        public void FindZ()
        {
            try
            {
                sigma = Convert.ToDouble(Txtsigma.Text);
                mu = Convert.ToDouble(Txtmu.Text);
                X = Convert.ToDouble(TxtX.Text);

                z = (X - mu) / sigma;
                TxtZ.Text = z.ToString();


                CDF = Normal.CDF(mu, sigma, X);

                TxtCDF.Text = CDF.ToString();
            }
            catch
            {

            }
        }
    }
}
