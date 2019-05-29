using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dashpayroll_forTesting
{
    public partial class formSetup : Form
    {
        public formSetup()
        {
            InitializeComponent();


        }


         
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormSetupWorkingdays frmworkdays = new FormSetupWorkingdays();
         
        }
     
        private void btnDaysPerYear_Click(object sender, EventArgs e)
        {
            
            FormSetupWorkingdays f = new FormSetupWorkingdays();
            showForm(f);
        }
      
        private void btnMinWage_Click(object sender, EventArgs e)
        {
            formSetupMinWage f = new formSetupMinWage();
            showForm(f);
        }

        void showForm(Form f)
        {
            pnlMain.Controls.Clear();
            f.Size = pnlMain.Size;
            f.TopLevel = false;
            pnlMain.Controls.Add(f);
            f.Show();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            FormSetupShiftSched f = new FormSetupShiftSched();
            showForm(f);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnDepartment_Click(object sender, EventArgs e)
        {
            formSetupDepartment f = new formSetupDepartment();
            showForm(f);
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            FormSetupPosition f = new FormSetupPosition();
            showForm(f);
        }

        private void formSetup_Load(object sender, EventArgs e)
        {
            this.btnDaysPerYear_Click(sender, e);
        }
    }
}
