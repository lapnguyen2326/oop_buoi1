using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Nhập tên nhân viên: ");
            string ten = Console.ReadLine();

            Console.Write("Nhập mức lương của nhân viên: ");
            double mucLuong = double.Parse(Console.ReadLine());

            Console.Write("Nhập ngày thuê (định dạng: dd/MM/yyyy): ");
            DateTime ngayThue = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Employee nhanVien = new Employee(ten, mucLuong, ngayThue);
            nhanVien.HienThiThongTin();
            Console.ReadLine();
        }
    }
}
