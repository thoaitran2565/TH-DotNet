using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
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

        //các thuộc tính
        public int StudentID
        {
            get {return SID;}
            set {SID = value;}
        }

        public string Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }

        public string Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }

        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }

        //Phương thức hiển thị
        public void Show()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("MSSV: {0}", SID);
            Console.WriteLine("Tên SV: {0}", TenSV);
            Console.WriteLine("Khoa: {0}", Khoa);
            Console.WriteLine("Điểm TB: {0}", DiemTB);
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
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.Write("Nhập mã số sinh viên {0}: ", i + 1);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Nhập tên sinh viên: ");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhập khoa: ");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhập điểm TB: ");
                DSSV[i].Mark = Single.Parse(Console.ReadLine());
            }
            //Xuất danh sách sinh viên
            Console.WriteLine("\n ==== XUẤT DANH SÁCH SINH VIÊN ===");
            foreach (Student s in DSSV)
            {
                s.Show();
            }


            Console.ReadLine();
        }
    }



}
