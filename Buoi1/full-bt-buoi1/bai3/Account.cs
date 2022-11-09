using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class Account
    {
        int intMaTK;
        string strTenTK;
        float fltSodu;

        public int MaTK
        {
            get { return intMaTK; }
            set { intMaTK = value; }
        }
        public string TenTK
        {
            get { return strTenTK; }
            set { strTenTK = value; }
        }
        public float Sodu
        {
            get { return fltSodu; }
            set { fltSodu = value; }
        }

        virtual public float SoDuToiDa()
        {
            return fltSodu;
        }
        //hàm khởi tạo
        public Account(int ma, string ten, float st)
        {
            MaTK = ma;
            TenTK = ten;
            Sodu = st;
        }

        //rut tiền
        public void RutTien(float st)
        {
            if (st > 0 && st < SoDuToiDa())
            {
                Sodu -= st;
            }
            else
            {
                Console.WriteLine("Số tiền rút không hợp lệ !");
            }
        }
        //nạp tiền
        public void NapTien(float st)
        {
            if (st > 0)
            {
                Sodu += st;
            }
            else
            {
                Console.WriteLine("Số tiền nạp vào không được nhỏ hơn 0 !");
            }
        }
        //chuyển khoản
        public void ChuyenKhoan(Account acc, float st)
        {
            if (this.MaTK != acc.MaTK)
            {
                if (st > 0 && st < SoDuToiDa())
                {
                    this.Sodu -= st;
                    acc.Sodu += st;
                }
                else
                {
                    Console.WriteLine("Số tiền chuyển khoản không hợp lệ !");
                }
            }
            else
            {
                Console.WriteLine("Không thể chuyển khoản cho chính mình !");
            }
        }

        //Xuất thông tin
        public void ThongTin()
        {
            Console.WriteLine("Mã tài khoản: {0} - Tên tài khoản: {1} - Số dư: {2}", MaTK, TenTK, Sodu);
        }



    }
}
