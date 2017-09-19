using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leadr_Drivr
{
    public partial class leadr_drivr_form : Form
    {
        public leadr_drivr_form()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel_dashboard.Visible = true;
            panel_activity.Visible = false;
            panel_profile.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel_activity.Visible = true;
            panel_dashboard.Visible = false;
            panel_profile.Visible = false;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            panel_profile.Visible = true;
            panel_dashboard.Visible = false;
            panel_activity.Visible = false;
        }
    }
}
