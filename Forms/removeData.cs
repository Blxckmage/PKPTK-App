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
    public partial class removeData : Form
    {
        Function fn = new Function();
        String query;

        public removeData()
        {
            InitializeComponent();
        }

        private void removeData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pkptkDbDataSet3.datamagang' table. You can move, or remove it, as needed.
            this.datamagangTableAdapter1.Fill(this.pkptkDbDataSet3.datamagang);
            // TODO: This line of code loads data into the 'pkptkDbDataSet.datamagang' table. You can move, or remove it, as needed.
            this.datamagangTableAdapter.Fill(this.pkptkDbDataSet.datamagang);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void loadData()
        {
            query = "select * from datamagang";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Delete Item?", "Important Message",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                query = "delete from datamagang where id=" + id + "";
                fn.setData(query);
                loadData();
            }
        }

        private void txtPosisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from datamagang where nama like '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String nama = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            String alamat = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String jk = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            String kodesurat = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            String awalmagang = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            String akhirmagang = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            String perusahaan = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            String posisi = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            txtNama.Text = nama;
            txtAlamat.Text = alamat;
            txtJenisKelamin.Text = jk;
            txtKodeSurat.Text = kodesurat;
            txtStartDate.Text = awalmagang;
            txtEndDate.Text = akhirmagang;
            txtPerusahaan.Text = perusahaan;
            txtPosisi.Text = posisi;
        }

        private void s(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
