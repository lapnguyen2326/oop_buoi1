using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Nhap ban kinh cua hinh tron: ");
            double banKinh = double.Parse(Console.ReadLine());

            Circle hinhTron = new Circle(banKinh);
            hinhTron.HienThiThongTin();
            Console.ReadLine();
        }
    }
}

