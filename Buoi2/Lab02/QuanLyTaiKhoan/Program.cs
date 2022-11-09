using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan
{
    class Account
    {
        string AccountID;
        string FirstName;
        string LastName;
        float Balance;

        #region constructor
        public Account()
        {
            AccountID = "";
            FirstName = "";
            LastName = "";
            Balance = 0.0F;
        }

        public Account(string accountID, string firstName, string lastName, float balance)
        {
            AccountID = accountID;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }




        #endregion

        #region thuôc tính
        public string accountid
        {
            get { return AccountID; }
            set { AccountID = value; }
        }

        public string firstname
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public float balance
        {
            get { return Balance; }
            set
            {
                Balance = value;
            }
        }

        #endregion

        #region Phương thức
        public void FullInfo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập Account ID: ");
            AccountID = Console.ReadLine();
            Console.Write("Nhập First Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Nhập Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Nhập Balance: ");
            Balance = Single.Parse(Console.ReadLine());
        }

        public void Query()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Thông tin tài khoản:");
            Console.WriteLine("Account ID: {0}",AccountID);
            Console.WriteLine("First Name: {0}",FirstName);
            Console.WriteLine("Last Name: {0}",LastName);
            Console.WriteLine("Balance: {0}",Balance);

        }

        #endregion


    }

    class AccountList
    {
        private ArrayList Accounts = new ArrayList();

        public AccountList()
        {
            Accounts.Clear();
        }

        #region Phương thưc
        public void NewAccount()
        {
            Account acc = new Account();
            acc.FullInfo();

            Accounts.Add(acc);
        }

        public void SaveFile()
        {
            Console.Write("Nhập tên file: ");
            string filename = Console.ReadLine();

            try
            {
                FileStream output = new FileStream(filename,FileMode.CreateNew,FileAccess.Write);

                StreamWriter write = new StreamWriter(output);

                foreach(Account acc in Accounts)
                {
                    write.WriteLine("{0}, {1}, {2}, {3}",acc.accountid,acc.firstname,acc.lastname,acc.balance);
                }
                write.Close();
                output.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void LoadFile()
        {
            Console.Write("Nhập tên file: ");
            string filename = Console.ReadLine();

            Accounts.Clear();
            try
            {
                FileStream input = new FileStream(filename,FileMode.Open,FileAccess.Read);

                StreamReader reader = new StreamReader(input);

                string str;

                while ((str = reader.ReadLine()) != null)
                {
                    string[] list = str.Split(',');

                    Account acc = new Account(list[0], list[1], list[2], Single.Parse(list[3]));

                    Accounts.Add(acc);
                }
                input.Close();
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        public void show()
        {
            foreach(Account acc in Accounts)
            {
                acc.Query();
            }
        }


        #endregion

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int chon;
            AccountList list = new AccountList();
            
            Console.WriteLine("1. Thêm dữ liệu");
            Console.WriteLine("2. Save file");
            Console.WriteLine("3. Load File");
            Console.WriteLine("4. Report");
            Console.WriteLine("5. Exit");

            do
            {
                Console.Write("Chọn số: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        {
                            list.NewAccount();
                            break;
                        }
                    case 2:
                        {
                            list.SaveFile();
                            break;
                        }
                    case 3:
                        {
                            list.LoadFile();
                            break;
                        }
                    case 4:
                        {
                            list.show();
                            break;
                        }
                }



            }
            while(chon > 0 && chon < 5);

        }
    }
}
