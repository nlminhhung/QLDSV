using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    class SinhVien
    {
        private string tenSV;
        private string mssv;
        private float diem;
        private DateTime ngaySinh;
        private string xepLoai;
        private DataGridViewCheckBoxColumn check;

        public SinhVien() { }
        public SinhVien(string TenSV, string MSSV, float Diem, DateTime NgaySinh, string XepLoai, DataGridViewCheckBoxColumn Check)
        {
            tenSV = TenSV;
            mssv = MSSV;
            diem = Diem;
            ngaySinh = NgaySinh;
            xepLoai = XepLoai;
            check = Check;
        }

        public string TenSV { get => tenSV; set => tenSV = value; }
        public string MSSV { get => mssv; set => mssv = value; }
        public float Diem { get => diem; set => diem = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string XepLoai { get => xepLoai; set => xepLoai = value; }
        public DataGridViewCheckBoxColumn Check { get => check; set => check = value; }
    }
}
