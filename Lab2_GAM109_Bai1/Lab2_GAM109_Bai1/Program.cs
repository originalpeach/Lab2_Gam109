﻿using Lab2_GAM109_Bai1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_GAM109_Bai1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bai 1a: ");
            Bai1a.start();

            Console.WriteLine("Bai 1b:");
            bai1b.Bai1b();

            Console.WriteLine("bai 1c:");
            var user = new UserData(1, 1, "1st player");
            bai1c.XuatThongTin("level", user.level);
            bai1c.XuatThongTin("name", user.name);

            Console.ReadLine();
        }
    }
}
