using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Employee
    {
        private string ten;
        private double mucLuong;
        private DateTime ngayThue;

        public Employee(string ten, double mucLuong, DateTime ngayThue)
        {
            this.ten = ten;
            this.mucLuong = mucLuong;
            this.ngayThue = ngayThue;
        }

        public string LayTen()
        {
            return ten;
        }

        public void DatTen(string ten)
        {
            this.ten = ten;
        }

        public double LayMucLuong()
        {
            return mucLuong;
        }

        public void DatMucLuong(double mucLuong)
        {
            this.mucLuong = mucLuong;
        }

        public DateTime LayNgayThue()
        {
            return ngayThue;
        }

        public void DatNgayThue(DateTime ngayThue)
        {
            this.ngayThue = ngayThue;
        }

        public int TinhSoNamLamViec()
        {
            int soNam = DateTime.Now.Year - ngayThue.Year;
            if (DateTime.Now.DayOfYear < ngayThue.DayOfYear)
            {
                soNam--;
            }
            return soNam;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Tên: {ten}");
            Console.WriteLine($"Mức lương: {mucLuong}");
            Console.WriteLine($"Ngày thuê: {ngayThue.ToShortDateString()}");
            Console.WriteLine($"Số năm làm việc: {TinhSoNamLamViec()}");
            Console.WriteLine("-----------------------------");
        }
    }
}

