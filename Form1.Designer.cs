namespace PhamTuanHung_6551071040_VP103_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvDuLieu = new DataGridView();
            duLieuContextBindingSource = new BindingSource(components);
            btnThem = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtMaSach = new TextBox();
            txtGiaTien = new TextBox();
            txtTenSach = new TextBox();
            congViecBindingSource = new BindingSource(components);
            maSachDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenSachDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaTienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duLieuContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)congViecBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(-3, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 2;
            label3.Text = "Tên sách:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 282);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 3;
            label4.Text = "Giá tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(248, 74);
            label5.Name = "label5";
            label5.Size = new Size(144, 28);
            label5.TabIndex = 4;
            label5.Text = "Danh sách sách";
            // 
            // dgvDuLieu
            // 
            dgvDuLieu.AutoGenerateColumns = false;
            dgvDuLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuLieu.Columns.AddRange(new DataGridViewColumn[] { maSachDataGridViewTextBoxColumn, tenSachDataGridViewTextBoxColumn, giaTienDataGridViewTextBoxColumn });
            dgvDuLieu.DataSource = congViecBindingSource;
            dgvDuLieu.Location = new Point(248, 109);
            dgvDuLieu.Name = "dgvDuLieu";
            dgvDuLieu.ReadOnly = true;
            dgvDuLieu.RowHeadersWidth = 51;
            dgvDuLieu.Size = new Size(540, 329);
            dgvDuLieu.TabIndex = 5;
            // 
            // duLieuContextBindingSource
            // 
            duLieuContextBindingSource.DataSource = typeof(DuLieu_Context);
            // 
            // btnThem
            // 
            btnThem.Location = new Point(248, 9);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 46);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(658, 9);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 46);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(522, 9);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 46);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(386, 9);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 46);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(12, 109);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(224, 27);
            txtMaSach.TabIndex = 10;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(12, 322);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(224, 27);
            txtGiaTien.TabIndex = 11;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(12, 223);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(224, 27);
            txtTenSach.TabIndex = 12;
            // 
            // congViecBindingSource
            // 
            congViecBindingSource.DataSource = typeof(CongViec);
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            maSachDataGridViewTextBoxColumn.HeaderText = "MaSach";
            maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            maSachDataGridViewTextBoxColumn.ReadOnly = true;
            maSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            tenSachDataGridViewTextBoxColumn.HeaderText = "TenSach";
            tenSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            tenSachDataGridViewTextBoxColumn.ReadOnly = true;
            tenSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaTienDataGridViewTextBoxColumn
            // 
            giaTienDataGridViewTextBoxColumn.DataPropertyName = "GiaTien";
            giaTienDataGridViewTextBoxColumn.HeaderText = "GiaTien";
            giaTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaTienDataGridViewTextBoxColumn.Name = "giaTienDataGridViewTextBoxColumn";
            giaTienDataGridViewTextBoxColumn.ReadOnly = true;
            giaTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTenSach);
            Controls.Add(txtGiaTien);
            Controls.Add(txtMaSach);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(dgvDuLieu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản lý sách / Thư viện - VP103";
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)duLieuContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)congViecBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvDuLieu;
        private Button btnThem;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtMaSach;
        private TextBox txtGiaTien;
        private TextBox txtTenSach;
        private BindingSource duLieuContextBindingSource;
        private DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaTienDataGridViewTextBoxColumn;
        private BindingSource congViecBindingSource;
    }
}
