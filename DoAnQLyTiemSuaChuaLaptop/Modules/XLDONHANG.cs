﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLyTiemSuaChuaLaptop.Modules
{
    class XLDONHANG : XLBANG
    {
        public XLDONHANG() : base("XLBANG") { }
        public XLDONHANG(string pQuery) : base("DONHANG", pQuery) { }
    }
}