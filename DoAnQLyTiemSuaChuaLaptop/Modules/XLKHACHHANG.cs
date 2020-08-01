using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLyTiemSuaChuaLaptop.Modules
{
    class XLKHACHHANG : XLBANG
    {
        public XLKHACHHANG() : base("XLBANG") { }
        public XLKHACHHANG(string pQuery) : base("KHACHHANG", pQuery) { }
    }
}
