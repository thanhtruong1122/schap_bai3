using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schap_bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2,nTong = 0;
            Console.Clear();
            Console.Write("{0}", "Nhap So thu nhat: ");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap So thu hai: ");
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nTong = nSo1 + nSo2;
            Console.WriteLine("Tong cua " + nSo1 + " Va " + nSo2 + " La " + nTong);
            Console.ReadLine();
        }
    }
}
