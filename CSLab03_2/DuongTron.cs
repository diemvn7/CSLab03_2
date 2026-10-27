using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuongTron
{
    class DuongTron
    {
        private Diem tam;
        private int banKinh;

        internal Diem Tam
        {
            get { return tam; }
            set { tam = value; }
        }

        public int BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }

        // Phương thức khởi tạo mặc định
        public DuongTron()
        {
            tam = new Diem();
            banKinh = 0;
        }

        // Phương thức khởi tạo khi biết đầy đủ thông tin
        public DuongTron(Diem t, int r)
        {
            Tam = t;
            BanKinh = r;
        }

        // Phương thức khởi tạo sao chép
        public DuongTron(DuongTron dt)
        {
            Tam = new Diem(dt.Tam);
            BanKinh = dt.BanKinh;
        }

        // Tính chu vi đường tròn
        public double ChuVi()
        {
            double cv;
            cv = 2 * Math.PI * BanKinh;
            return cv;
        }

        // Phương thức Xuất
        public void Xuat()
        {
            Console.WriteLine("Tam: " + tam.ToString() + ", Ban kinh: " + banKinh);
        }
    }
}