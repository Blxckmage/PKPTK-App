using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKPTK.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addData ad = new addData();
            ad.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printData pd = new printData();
            pd.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData ud = new updateData();
            ud.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeData rd = new removeData();
            rd.Show();
            this.Hide();
        }
    }
}
