using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_buoi1
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Nhap chieu dai cua hinh chu nhat : ");
            double chieuRong = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong cua hinh chu nhat : ");
            double chieuCao = double.Parse(Console.ReadLine());
            Rectangle Rectangle = new Rectangle(chieuRong, chieuCao);
            Rectangle.HienThiThongTin();
            Console.ReadLine();
        }
    }
}
