
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace PhamTuanHung_6551071040_VP103_LTTQ
{
    public partial class Form1 : Form
    {
        private DuLieu_Context db = new DuLieu_Context();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeComponent();
            this.KeyPreview = true;
            this.Load += Form1_Load;
        }
       
        private void SetControlState(bool isSelectingRow, bool isProcessing = false)
        {
            if (isProcessing)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Enabled = false;

            }
            dgvDuLieu.Enabled = !isProcessing;
            btnThem.Enabled = !isSelectingRow && !isProcessing;
            if (isSelectingRow)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        // Chỉ cho phép nhập số thực hoặc số nguyên vào textbox txtGiaTien
        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }
        

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SetControlState(false, true);
                var s = new CongViec
                {
                    MaSach = txtMaSach.Text,
                    TenSach = txtTenSach.Text,
                    GiaTien = txtGiaTien.Text
                };
                db.CongViecs.Add(s);
                db.SaveChanges();
                dgvDuLieu.DataSource = db.CongViecs.ToList();
                SetControlState(false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                SetControlState(false, false);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SetControlState(true, true);
                var selectedRow = dgvDuLieu.CurrentRow;
                if (selectedRow != null)
                {
                    string maSach = selectedRow.Cells["MaSach"].Value.ToString();
                    var s = db.CongViecs.Find(maSach);
                    if (s != null)
                    {
                        s.TenSach = txtTenSach.Text;
                        s.GiaTien = txtGiaTien.Text;
                        db.SaveChanges();
                        dgvDuLieu.DataSource = db.CongViecs.ToList();
                    }
                }
                SetControlState(false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                SetControlState(false, false);
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SetControlState(true, true);
                var selectedRow = dgvDuLieu.CurrentRow;
                if (selectedRow != null)
                {
                    string maSach = selectedRow.Cells["MaSach"].Value.ToString();
                    var s = db.CongViecs.Find(maSach);
                    if (s != null)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            db.CongViecs.Remove(s);
                            db.SaveChanges();
                            dgvDuLieu.DataSource = db.CongViecs.ToList();
                        }
                    }
                }
                SetControlState(false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                SetControlState(false, false);
            }
        }
        
        private void dgvDuLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDuLieu.CurrentRow != null)
            {
                var selectedRow = dgvDuLieu.CurrentRow;
                txtMaSach.Text = selectedRow.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = selectedRow.Cells["TenSach"].Value.ToString();
                txtGiaTien.Text = selectedRow.Cells["GiaTien"].Value.ToString();
                SetControlState(true);
            }
            else
            {
                SetControlState(false);
            }
        }
       
        private void dgvDuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvDuLieu.Rows[e.RowIndex];
                txtMaSach.Text = selectedRow.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = selectedRow.Cells["TenSach"].Value.ToString();
                txtGiaTien.Text = selectedRow.Cells["GiaTien"].Value.ToString();
                SetControlState(true);
            }
        }
    }
}