using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            /*SinhVien sv1 = new SinhVien("1811505310129", "Pham Tien Long");
            SinhVien sv2 = new SinhVien("1811505310130", "Lilia", "Lien minh");
            SinhVien sv3 = new SinhVien("1811505310131", "Lucian", "Lien Minh", 5 , 9);
            Console.WriteLine(sv1.ToString());
            Console.WriteLine(sv2.ToString());
            Console.WriteLine(sv3.ToString());*/

            

            Console.WriteLine("Muon nhap bao nhieu sv :");
            int soSV = Validation.CheckInt();
            SinhVien[] arrSinhVien = new SinhVien[soSV+1];

            for(int i = 0; i < soSV; i++)
            {
                SinhVien sv = new SinhVien("1811", "Long", "DN", 20, 9);

                Console.WriteLine("Nhap ma SV thu "+i+": ");
                sv.MaSV = Validation.CheckString();

                Console.WriteLine("Nhap ten " + i + ": ");
                sv.TenSV = Validation.CheckString();

                Console.WriteLine("Nhap dia chi " + i + ": ");
                sv.DiaChiSV = Validation.CheckString();

                Console.WriteLine("Nhap tuoi " + i + ": ");
                sv.TuoiSV = Validation.CheckInt();

                Console.WriteLine("Nhap diem TB" + i + ": ");
                sv.DiemTBSV = Validation.CheckFloat();

                arrSinhVien[i] = sv;

            }

            for(int i=0; i<soSV; i++)
            {
                Console.WriteLine(arrSinhVien[i].ToString());
            }


            Console.ReadLine();
        }
    }
}
