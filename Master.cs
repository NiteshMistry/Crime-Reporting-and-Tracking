using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrimeReport_Windows
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            objLogin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchFIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_FIR objFIR = new View_FIR();
            objFIR.Show();
        }

        private void searchCrimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCrm objsearchcrime = new SearchCrm();
            objsearchcrime.Show();
        }

        private void crimeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_FIR objView = new View_FIR();
            objView.Show();
        }

        private void viewLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewLog vlog = new ViewLog();
            vlog.Show();
        }

        private void crimeOnMAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCrimeOnGoogleMap objgmap = new ViewCrimeOnGoogleMap();
            objgmap.Show();
        }
    }
}
