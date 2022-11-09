using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float st = 0F;
            TaiKhoanThuong tkt = new TaiKhoanThuong(123, "Nguyễn Văn A", 250);
            TaiKhoanVip tkv = new TaiKhoanVip(124, "Nguyễn Văn B", 550);
            Console.WriteLine("Thông tin tài khoản thường: ");
            tkt.ThongTin();
            Console.WriteLine("Thông tin tài khoản Vip: ");
            tkv.ThongTin();

            //rút tiền của tài khoản thường
            Console.Write("\nNhập số tiền cần rút (Tài khoản thường): ");
            st = Single.Parse(Console.ReadLine());
            tkt.RutTien(st);
            Console.WriteLine("Thông tin tài khoản thường: ");
            tkt.ThongTin();
            Console.WriteLine("Thông tin tài khoản Vip: ");
            tkv.ThongTin();

            //nạp tiền tài khoản thường
            Console.Write("\nNhập số tiền cần nạp (tài khoản thường): ");
            st = Single.Parse(Console.ReadLine());
            tkt.NapTien(st);
            Console.WriteLine("Thông tin tài khoản thường: ");
            tkt.ThongTin();
            Console.WriteLine("Thông tin tài khoản Vip: ");
            tkv.ThongTin();

            //chuyển khoản từ tài khoản thường sang tài khoản vip
            Console.Write("\nChuyển khoản từ tài khoản thường sang tài khoản vip: ");
            st = Single.Parse(Console.ReadLine());
            tkt.ChuyenKhoan(tkv, st);
            Console.WriteLine("Thông tin tài khoản thường: ");
            tkt.ThongTin();
            Console.WriteLine("Thông tin tài khoản Vip: ");
            tkv.ThongTin();

            //rút tiền của tài khoản vip
            Console.Write("\nNhập số tiền cần rút (Tài khoản vip): ");
            st = Single.Parse(Console.ReadLine());
            tkv.RutTien(st);
            Console.WriteLine("Thông tin tài khoản thường: ");
            tkt.ThongTin();
            Console.WriteLine("Thông tin tài khoản Vip: ");
            tkv.ThongTin();

            //nạp tiền tài khoản thường
            Console.Write("\nNhập số tiền cần nạp (tài khoản vip): ");
            st = Single.Parse(Console.ReadLine());
            tkv.NapTien(st);
            Console.WriteLine("Thông tin tài khoản thường: ");
            tkt.ThongTin();
            Console.WriteLine("Thông tin tài khoản Vip: ");
            tkv.ThongTin();

            //chuyển khoản từ tài khoản vip sang tài khoản thường
            Console.Write("\nChuyển khoản từ tài khoản Vip sang tài khoản Thường: ");
            st = Single.Parse(Console.ReadLine());
            tkv.ChuyenKhoan(tkt, st);
            Console.WriteLine("Thông tin tài khoản thường: ");
            tkt.ThongTin();
            Console.WriteLine("Thông tin tài khoản Vip: ");
            tkv.ThongTin();


            Console.Read();
        }
    }
}
