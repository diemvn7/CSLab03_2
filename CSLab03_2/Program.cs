using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuongTron
{
    class Program
    {
        static void Main(string[] args)
        {
            DuongTron dt = new DuongTron();
            dt.Xuat();

            Diem point = new Diem(1, 3);
            DuongTron dt2 = new DuongTron(point, 10);
            dt2.Xuat();

            DuongTron dt3 = new DuongTron(dt2);
            dt3.Xuat();

            double chuvi = dt2.ChuVi();
            Console.WriteLine("Chu vi duong tron: " + chuvi);

            Console.ReadKey();
        }
    }
}