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
    public partial class addData : Form
    {
        Function fn = new Function();
        String query;

        public addData()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            this.Hide();
            db.Show();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into datamagang (nama, alamat, jenis_kelamin, kode_surat, awal_magang, akhir_magang, nama_perusahaan, posisi) values ('" + txtNama.Text + "', '" + txtAlamat.Text + "', '" + txtJenisKelamin.Text + "', '" + txtKodeSurat.Text + "', '" + txtStartDate.Value + "', '" + txtEndDate.Value + "', '"+txtPerusahaan.Text+"', '" + txtPosisi.Text + "')";
                fn.setData(query);
                clearAll();
                loadData();
            } catch
            {
                MessageBox.Show("Wrong data input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadData()
        {
            query = "select * from datamagang";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void clearAll()
        {
            txtNama.Clear();
            txtAlamat.Clear();
            txtJenisKelamin.Clear();
            txtKodeSurat.Clear();
            txtStartDate.Value = DateTime.Now;
            txtEndDate.Value = DateTime.Now;
            txtPerusahaan.Clear();
            txtPosisi.Clear();
        }

        private void addData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pkptkDbDataSet.datamagang' table. You can move, or remove it, as needed.
            this.datamagangTableAdapter.Fill(this.pkptkDbDataSet.datamagang);

        }
    }
}
