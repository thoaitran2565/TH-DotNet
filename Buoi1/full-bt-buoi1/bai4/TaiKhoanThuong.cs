using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    public class TaiKhoanThuong : Account
    {
        //hàm khỏi tạo
        public TaiKhoanThuong(int ma, string ten, float st)
            : base(ma, ten, st)
        {
        }

        public override float SoDuToiDa()
        {
            return Sodu - 50;
        }
    }
}
