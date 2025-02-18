using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Circle
    {
        private double banKinh;

        public Circle(double banKinh)
        {
            this.banKinh = banKinh;
        }

        public double LayBanKinh()
        {
            return banKinh;
        }

        public void DatBanKinh(double banKinh)
        {
            if (banKinh > 0)
            {
                this.banKinh = banKinh;
            }
            else
            {
                Console.WriteLine("Ban kinh phai lon hon 0!");
            }
        }

        public double TinhDienTich()
        {
            return Math.PI * banKinh * banKinh;
        }

        public double TinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ban kinh: {banKinh}");
            Console.WriteLine($"Dien tich: {TinhDienTich()}");
            Console.WriteLine($"Chu vi: {TinhChuVi()}");
            Console.WriteLine("-----------------------------");
        }
    }
}

