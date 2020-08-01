using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLyTiemSuaChuaLaptop.Modules
{
    class XLCTHD: XLBANG
    {
        public XLCTHD() : base("XLBANG") { }
        public XLCTHD(string pQuery) : base("CTHD", pQuery) { }
    }
}
