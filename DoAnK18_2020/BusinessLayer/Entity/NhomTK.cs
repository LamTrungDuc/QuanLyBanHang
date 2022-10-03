using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnK18_2020.BusinessLayer.Entity
{
    class NhomTK
    {
        public string TenNhom { get; set; }
        public int maNhom { get; set; }
        public string ghiChu { get; set; }
        public NhomTK()
        {
            this.TenNhom = "";
            this.ghiChu = "";
        }
    }
}
