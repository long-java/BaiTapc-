using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Validation
    {
        public static int CheckInt()
        {
            int num = 0;
            Boolean valid = false;
            while (valid == false)
            {
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap lai");

                }
            }
            return num;
        }

        public static float CheckFloat()
        {
            float num = 0;
            Boolean valid = false;
            while (valid == false)
            {
                try
                {
                    num = float.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap lai");

                }
            }
            return num;
        }

        public static string CheckString()
        {
            string str = "";
            Boolean valid = false;
            while (valid == false)
            {
                try
                {
                    str = Console.ReadLine();
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap lai");

                }
            }
            return str;
        }
    }
}
