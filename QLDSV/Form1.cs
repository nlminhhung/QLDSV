using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firstDBDataSet1.SinhVien' table. You can move, or remove it, as needed.
            //this.sinhVienTableAdapter1.Fill(this.firstDBDataSet1.SinhVien);
            bangSinhVien.DataSource = modify.getAllSinhVien();

        }

        private void button_them_Click(object sender, EventArgs e)
        {
            try { 
                string mssv = tb_mssv.Text;
                string tenSV = tb_tsv.Text;
                string temp = tb_diemso.Text;
                float diem = float.Parse(tb_diemso.Text);
                DateTime ngaySinh = date_ngaysinh.Value;
                string xepLoai = tb_xeploai.Text;
                DataGridViewCheckBoxColumn check = checkedbox;

                if (mssv.Trim() == "") { MessageBox.Show("Khong duoc de trong!"); return; }
                if (tenSV.Trim() == "") { MessageBox.Show("Khong duoc de trong!"); return; }
                if (temp.Trim() == "") { MessageBox.Show("Khong duoc de trong!"); return; }
                if (diem.GetType() != typeof(float)) { MessageBox.Show("Vui long nhap dung kieu!"); return; }
                if (ngaySinh.GetType() != typeof(DateTime)) { MessageBox.Show("Vui long nhap dung kieu!"); return; }
                SinhVien sv = new SinhVien(tenSV, mssv, diem, ngaySinh, xepLoai, check);
                modify.insertSinhVien(sv);
                MessageBox.Show("Them thanh cong!");
                bangSinhVien.DataSource = modify.getAllSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSSV da duoc su dung!");
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void bangSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = bangSinhVien.Rows[e.RowIndex];
                tb_mssv.Text = row.Cells[0].Value.ToString();
                tb_tsv.Text = row.Cells[1].Value.ToString();
                tb_diemso.Text = row.Cells[2].Value.ToString();
                date_ngaysinh.Text = row.Cells[3].Value.ToString();
                tb_xeploai.Text = row.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Vui long nhan vao hang hoc sinh");
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            // xoa theo check box
            try 
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in bangSinhVien.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["checkedBox"].Value) == true)
                    {
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in rows)
                {
                    modify.deleteSinhVien(row.Cells[0].Value.ToString());
                }
                
                bangSinhVien.DataSource = modify.getAllSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong tim thay sinh vien can xoa!");
                MessageBox.Show(ex.Message);
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = tb_mssv.Text;
                string tenSV = tb_tsv.Text;
                string temp = tb_diemso.Text;
                float diem = float.Parse(tb_diemso.Text);
                DateTime ngaySinh = date_ngaysinh.Value;
                string xepLoai = tb_xeploai.Text;
                DataGridViewCheckBoxColumn check = checkedbox;
                if (mssv.Trim() == "") { MessageBox.Show("Khong duoc de trong!"); return; }
                if (tenSV.Trim() == "") { MessageBox.Show("Khong duoc de trong!"); return; }
                if (temp.Trim() == "") { MessageBox.Show("Khong duoc de trong!"); return; }
                if (diem.GetType() != typeof(float)) { MessageBox.Show("Vui long nhap dung kieu!"); return; }
                if (ngaySinh.GetType() != typeof(DateTime)) { MessageBox.Show("Vui long nhap dung kieu!"); return; }
                SinhVien sv = new SinhVien(tenSV, mssv, diem, ngaySinh, xepLoai, check);
                modify.updateSinhVien(sv);
                bangSinhVien.DataSource = modify.getAllSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra!");
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
