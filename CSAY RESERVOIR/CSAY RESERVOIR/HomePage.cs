using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAY_RESERVOIR
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            FrmReservoir freservoir = new FrmReservoir();
            if(comboBoxBranch.Text == "STANDARD OPERATION POLICY")
            {
                freservoir.Show();
            }
            FrmReservoirOperationForHP fresopshpgeneration = new FrmReservoirOperationForHP();
            if (comboBoxBranch.Text == "RESERVOIR OPERATION FOR HP GENERATION")
            {
                fresopshpgeneration.Show();
            }
            FrmZScore fzscore = new FrmZScore();
            if(comboBoxBranch.Text == "STANDARD NORMAL DISTRIBUTION")
            {
                fzscore.Show();
            }

            FrmThomasFieringModel fTHModel = new FrmThomasFieringModel();
            if (comboBoxBranch.Text == "THOMAS FIERING MODEL")
            {
                fTHModel.Show();
            }
            
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            ComboBoxMain.Items.Clear();
            ComboBoxMain.Text = "";
            
            ComboBoxMain.Items.Add("RESERVOIR");
            //ComboBoxMain.Items.Add("PROBABILITY DISTRIBUTION");
            ComboBoxMain.Items.Add("MODEL");
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout fabout = new FrmAbout();
            fabout.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBoxMain_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxBranch.Items.Clear();
            comboBoxBranch.Text = "";

            LblNavigateTo.Text = "CHOOSE FOR " + ComboBoxMain.Text;

            if(ComboBoxMain.Text == "RESERVOIR")
            {
                comboBoxBranch.Items.Add("STANDARD OPERATION POLICY");
                comboBoxBranch.Items.Add("RESERVOIR OPERATION FOR HP GENERATION");
            }
            if (ComboBoxMain.Text == "PROBABILITY DISTRIBUTION")
            {
                comboBoxBranch.Items.Add("STANDARD NORMAL DISTRIBUTION");
            }
            if (ComboBoxMain.Text == "MODEL")
            {
                comboBoxBranch.Items.Add("THOMAS FIERING MODEL");
            }

        }

        private void ComboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
