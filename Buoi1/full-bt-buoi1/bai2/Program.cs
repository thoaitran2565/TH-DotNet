using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        //hàm khởi tạo không tham số
        public Student()
        {
            SID = 1;
            TenSV = "Tran Van Thoai";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        //hàm khỏi tạo có tham số
        public Student(Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        //hàm khởi tạo có tham số
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        //Phương thức getter và setter
        #region getter
        public int get_id()
        {
            return SID;
        }
        public string get_name()
        {
            return TenSV;
        }
        public string get_khoa()
        {
            return Khoa;
        }
        public float get_diemtb()
        {
            return DiemTB;
        }

        #endregion

        #region setter
        public void set_id(int id)
        {
            SID = id;
        }
        public void set_name(string name)
        {
            TenSV = name;
        }
        public void set_khoa(string kh)
        {
            Khoa = kh;
        }
        public void set_diemtb(float dtb)
        {
            DiemTB = dtb;
        }

        #endregion

        //Phương thức hiển thị
        public void Show()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("MSSV: {0}", SID);
            Console.WriteLine("Tên SV: {0}", TenSV);
            Console.WriteLine("Khoa: {0}", Khoa);
            Console.WriteLine("Điểm TB: {0}", DiemTB);
        }

        //hàm nhập 1 sinh viên
        public void Nhap1SV()
        {
            Console.Write("Nhập mã số sinh viên: ");
            SID = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên sv: ");
            TenSV = Console.ReadLine();
            Console.Write("Nhập khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhập điểm TB: ");
            DiemTB = Single.Parse(Console.ReadLine());
        }
    }
   

    class Tester
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            Student[] DSSV;

            int n;
            Console.Write("Nhập số lượng sinh viên: ");
            n = int.Parse(Console.ReadLine());

            DSSV = new Student[n];
            Console.Write("Nhập Danh sách sinh viên: \n");

            NhapDS(DSSV,n);





            //Xuất danh sách sinh viên
            Console.WriteLine("\n ==== XUẤT DANH SÁCH SINH VIÊN ===");
            XuatDS(DSSV);


            Console.ReadLine();
        }

        //hàm nhập danh sách sinh viên
        public static void NhapDS(Student[] dssv,int n)
        {
            for (int i = 0; i < n; i++)
            {
                dssv[i] = new Student();
                dssv[i].Nhap1SV();
            }
        }

        //hàm xuất danh sách sv
        public static void XuatDS(Student[] dssv)
        {
            foreach (Student s in dssv)
            {
                s.Show();
            }
        }
    }
}
