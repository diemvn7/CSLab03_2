using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuongTron
{
    class Diem
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Diem()
        {
            x = 0;
            y = 0;
        }

        public Diem(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Diem(Diem p)
        {
            X = p.X;
            Y = p.Y;
        }

        public double KhoangCach(Diem b)
        {
            return Math.Sqrt(Math.Pow(b.x - x, 2) + Math.Pow(b.y - y, 2));
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}