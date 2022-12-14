using DGVPrinterHelper;
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
    public partial class printData : Form
    {
        public printData()
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

        private void printData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pkptkDbDataSet.datamagang' table. You can move, or remove it, as needed.
            this.datamagangTableAdapter.Fill(this.pkptkDbDataSet.datamagang);

        }

        private void btnPrintData_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Data Permagangan";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Cirebon, .................. 2022" + "\r\n" +  "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Agus Suherman, SH, MH.";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView3);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
