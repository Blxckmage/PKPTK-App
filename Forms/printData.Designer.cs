namespace PKPTK.Forms
{
    partial class printData
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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.pkptkDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datamagangTableAdapter = new PKPTK.pkptkDbDataSetTableAdapters.datamagangTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.namaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodesuratDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awalmagangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akhirmagangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaperusahaanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posisiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamagangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrintData = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamagangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkptkDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkptkDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamagangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hack NF", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(351, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Print Data";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Hack NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.btnMinimize.Location = new System.Drawing.Point(972, 15);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 25);
            this.btnMinimize.TabIndex = 15;
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
            this.btnExit.Location = new System.Drawing.Point(1007, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 25);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(95, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(876, 348);
            this.dataGridView1.TabIndex = 17;
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
            // pkptkDbDataSetBindingSource
            // 
            this.pkptkDbDataSetBindingSource.DataSource = this.pkptkDbDataSet;
            this.pkptkDbDataSetBindingSource.Position = 0;
            // 
            // datamagangTableAdapter
            // 
            this.datamagangTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dataGridView2.Location = new System.Drawing.Point(95, 96);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(876, 348);
            this.dataGridView2.TabIndex = 17;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaDataGridViewTextBoxColumn1,
            this.alamatDataGridViewTextBoxColumn1,
            this.jeniskelaminDataGridViewTextBoxColumn1,
            this.kodesuratDataGridViewTextBoxColumn1,
            this.awalmagangDataGridViewTextBoxColumn1,
            this.akhirmagangDataGridViewTextBoxColumn1,
            this.namaperusahaanDataGridViewTextBoxColumn1,
            this.posisiDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.datamagangBindingSource1;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dataGridView3.Location = new System.Drawing.Point(16, 96);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(1017, 439);
            this.dataGridView3.TabIndex = 17;
            // 
            // namaDataGridViewTextBoxColumn1
            // 
            this.namaDataGridViewTextBoxColumn1.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn1.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn1.Name = "namaDataGridViewTextBoxColumn1";
            this.namaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn1
            // 
            this.alamatDataGridViewTextBoxColumn1.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn1.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn1.Name = "alamatDataGridViewTextBoxColumn1";
            this.alamatDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // jeniskelaminDataGridViewTextBoxColumn1
            // 
            this.jeniskelaminDataGridViewTextBoxColumn1.DataPropertyName = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn1.HeaderText = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.jeniskelaminDataGridViewTextBoxColumn1.Name = "jeniskelaminDataGridViewTextBoxColumn1";
            this.jeniskelaminDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kodesuratDataGridViewTextBoxColumn1
            // 
            this.kodesuratDataGridViewTextBoxColumn1.DataPropertyName = "kode_surat";
            this.kodesuratDataGridViewTextBoxColumn1.HeaderText = "kode_surat";
            this.kodesuratDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kodesuratDataGridViewTextBoxColumn1.Name = "kodesuratDataGridViewTextBoxColumn1";
            this.kodesuratDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // awalmagangDataGridViewTextBoxColumn1
            // 
            this.awalmagangDataGridViewTextBoxColumn1.DataPropertyName = "awal_magang";
            this.awalmagangDataGridViewTextBoxColumn1.HeaderText = "awal_magang";
            this.awalmagangDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.awalmagangDataGridViewTextBoxColumn1.Name = "awalmagangDataGridViewTextBoxColumn1";
            this.awalmagangDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // akhirmagangDataGridViewTextBoxColumn1
            // 
            this.akhirmagangDataGridViewTextBoxColumn1.DataPropertyName = "akhir_magang";
            this.akhirmagangDataGridViewTextBoxColumn1.HeaderText = "akhir_magang";
            this.akhirmagangDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.akhirmagangDataGridViewTextBoxColumn1.Name = "akhirmagangDataGridViewTextBoxColumn1";
            this.akhirmagangDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // namaperusahaanDataGridViewTextBoxColumn1
            // 
            this.namaperusahaanDataGridViewTextBoxColumn1.DataPropertyName = "nama_perusahaan";
            this.namaperusahaanDataGridViewTextBoxColumn1.HeaderText = "nama_perusahaan";
            this.namaperusahaanDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.namaperusahaanDataGridViewTextBoxColumn1.Name = "namaperusahaanDataGridViewTextBoxColumn1";
            this.namaperusahaanDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // posisiDataGridViewTextBoxColumn1
            // 
            this.posisiDataGridViewTextBoxColumn1.DataPropertyName = "posisi";
            this.posisiDataGridViewTextBoxColumn1.HeaderText = "posisi";
            this.posisiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.posisiDataGridViewTextBoxColumn1.Name = "posisiDataGridViewTextBoxColumn1";
            this.posisiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datamagangBindingSource1
            // 
            this.datamagangBindingSource1.DataMember = "datamagang";
            this.datamagangBindingSource1.DataSource = this.pkptkDbDataSetBindingSource;
            // 
            // btnPrintData
            // 
            this.btnPrintData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnPrintData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPrintData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintData.Font = new System.Drawing.Font("Hack NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.btnPrintData.Location = new System.Drawing.Point(381, 592);
            this.btnPrintData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintData.Name = "btnPrintData";
            this.btnPrintData.Size = new System.Drawing.Size(287, 65);
            this.btnPrintData.TabIndex = 18;
            this.btnPrintData.Text = "Print Data";
            this.btnPrintData.UseVisualStyleBackColor = false;
            this.btnPrintData.Click += new System.EventHandler(this.btnPrintData_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Hack NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(148)))), ((int)(((byte)(150)))));
            this.btnBack.Location = new System.Drawing.Point(16, 629);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 59);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // printData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1049, 703);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrintData);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "printData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "printData";
            this.Load += new System.EventHandler(this.printData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamagangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkptkDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkptkDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamagangBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pkptkDbDataSetBindingSource;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodesuratDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn awalmagangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn akhirmagangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaperusahaanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn posisiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource datamagangBindingSource1;
        private System.Windows.Forms.Button btnPrintData;
        private System.Windows.Forms.Button btnBack;
    }
}