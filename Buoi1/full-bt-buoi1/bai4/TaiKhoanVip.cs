using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class TaiKhoanVip : Account
    {
        //hàm khỏi tạo
        public TaiKhoanVip(int ma, string ten, float st)
            : base(ma, ten, st)
        {
        }

        public override float SoDuToiDa()
        {
            return Sodu + 100;
        }
    }
}
