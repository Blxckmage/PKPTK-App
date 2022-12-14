namespace PKPTK.Forms
{
    partial class addData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJenisKelamin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKodeSurat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPerusahaan = new System.Windows.Forms.TextBox();
            this.txtPosisi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodesuratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awalmagangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akhirmagangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaperusahaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamagangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pkptkDbDataSet = new PKPTK.pkptkDbDataSet();
            this.btnAddData = new System.Windows.Forms.Button();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.datamagangTableAdapter = new PKPTK.pkptkDbDataSetTableAdapters.datamagangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamagangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkptkDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hack NF", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(505, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Data";
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Hack NF", 16F);
            this.txtNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtNama.Location = new System.Drawing.Point(25, 491);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(589, 39);
            this.txtNama.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hack NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(20, 464);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hack NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(20, 631);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis Kelamin";
            // 
            // txtJenisKelamin
            // 
            this.txtJenisKelamin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtJenisKelamin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJenisKelamin.Font = new System.Drawing.Font("Hack NF", 16F);
            this.txtJenisKelamin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtJenisKelamin.Location = new System.Drawing.Point(25, 658);
            this.txtJenisKelamin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJenisKelamin.Name = "txtJenisKelamin";
            this.txtJenisKelamin.Size = new System.Drawing.Size(589, 39);
            this.txtJenisKelamin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hack NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(20, 546);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Font = new System.Drawing.Font("Hack NF", 16F);
            this.txtAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtAlamat.Location = new System.Drawing.Point(25, 574);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(589, 39);
            this.txtAlamat.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hack NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(1101, 465);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Awal Magang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hack NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(20, 716);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kode Surat";
            // 
            // txtKodeSurat
            // 
            this.txtKodeSurat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtKodeSurat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeSurat.Font = new System.Drawing.Font("Hack NF", 16F);
            this.txtKodeSurat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtKodeSurat.Location = new System.Drawing.Point(25, 743);
            this.txtKodeSurat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKodeSurat.Name = "txtKodeSurat";
            this.txtKodeSurat.Size = new System.Drawing.Size(589, 39);
            this.txtKodeSurat.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hack NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(1088, 546);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Akhir Magang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Hack NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.label8.Location = new System.Drawing.Point(1048, 631);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nama Perusahaan";
            // 
            // txtPerusahaan
            // 
            this.txtPerusahaan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtPerusahaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerusahaan.Font = new System.Drawing.Font("Hack NF", 16F);
            this.txtPerusahaan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtPerusahaan.Location = new System.Drawing.Point(653, 658);
            this.txtPerusahaan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPerusahaan.Name = "txtPerusahaan";
            this.txtPerusahaan.Size = new System.Drawing.Size(606, 39);
            this.txtPerusahaan.TabIndex = 5;
            // 
            // txtPosisi
            // 
            this.txtPosisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtPosisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosisi.Font = new System.Drawing.Font("Hack NF", 16F);
            this.txtPosisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtPosisi.Location = new System.Drawing.Point(653, 743);
            this.txtPosisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosisi.Name = "txtPosisi";
            this.txtPosisi.Size = new System.Drawing.Size(606, 39);
            this.txtPosisi.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Hack NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.label9.Location = new System.Drawing.Point(1168, 716);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Posisi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.kodesuratDataGridViewTextBoxColumn,
            this.awalmagangDataGridViewTextBoxColumn,
            this.akhirmagangDataGridViewTextBoxColumn,
            this.namaperusahaanDataGridViewTextBoxColumn,
            this.posisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datamagangBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dataGridView1.Location = new System.Drawing.Point(25, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 348);
            this.dataGridView1.TabIndex = 8;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            this.jeniskelaminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodesuratDataGridViewTextBoxColumn
            // 
            this.kodesuratDataGridViewTextBoxColumn.DataPropertyName = "kode_surat";
            this.kodesuratDataGridViewTextBoxColumn.HeaderText = "kode_surat";
            this.kodesuratDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodesuratDataGridViewTextBoxColumn.Name = "kodesuratDataGridViewTextBoxColumn";
            this.kodesuratDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // awalmagangDataGridViewTextBoxColumn
            // 
            this.awalmagangDataGridViewTextBoxColumn.DataPropertyName = "awal_magang";
            this.awalmagangDataGridViewTextBoxColumn.HeaderText = "awal_magang";
            this.awalmagangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.awalmagangDataGridViewTextBoxColumn.Name = "awalmagangDataGridViewTextBoxColumn";
            this.awalmagangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // akhirmagangDataGridViewTextBoxColumn
            // 
            this.akhirmagangDataGridViewTextBoxColumn.DataPropertyName = "akhir_magang";
            this.akhirmagangDataGridViewTextBoxColumn.HeaderText = "akhir_magang";
            this.akhirmagangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.akhirmagangDataGridViewTextBoxColumn.Name = "akhirmagangDataGridViewTextBoxColumn";
            this.akhirmagangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaperusahaanDataGridViewTextBoxColumn
            // 
            this.namaperusahaanDataGridViewTextBoxColumn.DataPropertyName = "nama_perusahaan";
            this.namaperusahaanDataGridViewTextBoxColumn.HeaderText = "nama_perusahaan";
            this.namaperusahaanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaperusahaanDataGridViewTextBoxColumn.Name = "namaperusahaanDataGridViewTextBoxColumn";
            this.namaperusahaanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // posisiDataGridViewTextBoxColumn
            // 
            this.posisiDataGridViewTextBoxColumn.DataPropertyName = "posisi";
            this.posisiDataGridViewTextBoxColumn.HeaderText = "posisi";
            this.posisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.posisiDataGridViewTextBoxColumn.Name = "posisiDataGridViewTextBoxColumn";
            this.posisiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datamagangBindingSource
            // 
            this.datamagangBindingSource.DataMember = "datamagang";
            this.datamagangBindingSource.DataSource = this.pkptkDbDataSet;
            // 
            // pkptkDbDataSet
            // 
            this.pkptkDbDataSet.DataSetName = "pkptkDbDataSet";
            this.pkptkDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddData
            // 
            this.btnAddData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnAddData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddData.Font = new System.Drawing.Font("Hack NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.btnAddData.Location = new System.Drawing.Point(501, 807);
            this.btnAddData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(287, 65);
            this.btnAddData.TabIndex = 9;
            this.btnAddData.Text = "Add Data";
            this.btnAddData.UseVisualStyleBackColor = false;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // txtStartDate
            // 
            this.txtStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtStartDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtStartDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtStartDate.Font = new System.Drawing.Font("Hack Nerd Font", 16F);
            this.txtStartDate.Location = new System.Drawing.Point(653, 491);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(605, 39);
            this.txtStartDate.TabIndex = 10;
            // 
            // txtEndDate
            // 
            this.txtEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtEndDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtEndDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.txtEndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.txtEndDate.Font = new System.Drawing.Font("Hack Nerd Font", 16F);
            this.txtEndDate.Location = new System.Drawing.Point(655, 574);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(605, 39);
            this.txtEndDate.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Hack NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.btnBack.Location = new System.Drawing.Point(12, 820);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 59);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Hack NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.btnMinimize.Location = new System.Drawing.Point(1204, 15);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 25);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(47)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Hack NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.btnExit.Location = new System.Drawing.Point(1239, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 25);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // datamagangTableAdapter
            // 
            this.datamagangTableAdapter.ClearBeforeFill = true;
            // 
            // addData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1281, 894);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPosisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKodeSurat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPerusahaan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJenisKelamin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addData";
            this.Load += new System.EventHandler(this.addData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamagangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkptkDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJenisKelamin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKodeSurat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPerusahaan;
        private System.Windows.Forms.TextBox txtPosisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private pkptkDbDataSet pkptkDbDataSet;
        private System.Windows.Forms.BindingSource datamagangBindingSource;
        private pkptkDbDataSetTableAdapters.datamagangTableAdapter datamagangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodesuratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awalmagangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akhirmagangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaperusahaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posisiDataGridViewTextBoxColumn;
    }
}