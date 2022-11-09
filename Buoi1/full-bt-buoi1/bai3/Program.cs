using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float st = 0F;
            Account tk1 = new Account(123, "Trần Văn A", 100F);
            Account tk2 = new Account(124, "Trần Văn B", 200F);
            Console.WriteLine("Thông tin tài khoản 1: ");
            tk1.ThongTin();
            Console.WriteLine("Thông tin tài khoản 2: ");
            tk2.ThongTin();

            //rút tiền
            Console.WriteLine("\nRÚT TIỀN");
            Console.Write("Nhập số tiền cần rút: ");
            st = Single.Parse(Console.ReadLine());
            tk1.RutTien(st);
            Console.WriteLine("Thông tin tài khoản 1: ");
            tk1.ThongTin();

            //nạp tiền
            Console.WriteLine("\nNẠP TIỀN");
            Console.Write("Nhập số tiền cần nạp: ");
            st = Single.Parse(Console.ReadLine());
            tk1.NapTien(st);
            Console.WriteLine("Thông tin tài khoản 1: ");
            tk1.ThongTin();

            //Chuyển khoản
            Console.WriteLine("\nCHUYỂN KHOẢN");
            Console.Write("Nhập số tiền cần chuyển cho tk2: ");
            st = Single.Parse(Console.ReadLine());
            tk1.ChuyenKhoan(tk2, st);
            Console.WriteLine("Thông tin tài khoản 1: ");
            tk1.ThongTin();
            Console.WriteLine("Thông tin tài khoản 2: ");
            tk2.ThongTin();



            Console.Read();
        }
    }
}
