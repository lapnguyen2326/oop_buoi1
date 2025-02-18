using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_buoi1
{

    public class Rectangle
    {
        private double chieuRong;
        private double chieuCao;

        public Rectangle(double chieuRong, double chieuCao)
        {
            this.chieuRong = chieuRong;
            this.chieuCao = chieuCao;
        }

        public double LayChieuRong()
        {
            return chieuRong;
        }

        public void DatChieuRong(double chieuRong)
        {
            if (chieuRong > 0)
            {
                this.chieuRong = chieuRong;
            }
            else
            {
                Console.WriteLine("Chieu rong phai lon hon 0!");
            }
        }

        public double LayChieuCao()
        {
            return chieuCao;
        }

        public void DatChieuCao(double chieuCao)
        {
            if (chieuCao > 0)
            {
                this.chieuCao = chieuCao;
            }
            else
            {
                Console.WriteLine("Chieu cao phai lon hon 0!");
            }
        }

        public double TinhDienTich()
        {
            return chieuRong * chieuCao;
        }

        public double TinhChuVi()
        {
            return 2 * (chieuRong + chieuCao);
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Chieu rong: {chieuRong}");
            Console.WriteLine($"Chieu cao: {chieuCao}");
            Console.WriteLine($"Dien tich: {TinhDienTich()}");
            Console.WriteLine($"Chu vi: {TinhChuVi()}");
            Console.WriteLine("-----------------------------");
        }
    }
}

     