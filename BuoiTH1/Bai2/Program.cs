﻿using System.Text;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSLN sln = new TimSLN();
            int n;
            Console.Write("Nhập n = ");
            n = sln.NhapMotSo();
            Console.WriteLine("Số lớn nhất trong {0} số vừa nhập là {1} ", n, sln.TimMax(n));
            Console.ReadLine();
        }
    }
}