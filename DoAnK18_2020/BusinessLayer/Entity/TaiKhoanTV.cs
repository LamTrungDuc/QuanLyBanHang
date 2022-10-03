using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnK18_2020.BusinessLayer.Entity
{
    class TaiKhoanTV
    {
        /// <summary>
        /// Tài khoản của người dùng trong hệ thống
        /// </summary>
        public string TaiKhoan { get; set; }
        /// <summary>
        /// Mật khẩu của người dùng trong hệ thống
        /// </summary>
        public string MatKHau { get; set; }
        /// <summary>
        /// Mã nhóm tài khoản
        /// </summary>

        public int MaNhom { get; set; }
        /// <summary>
        /// họ và tên đệm của nhân viên 
        /// </summary>
        public string HoDem { get; set; }
        /// <summary>
        /// tên của nhân viên
        /// </summary>
        public string TenTV { get; set; }
        /// <summary>
        /// ngày sinh của nhân viên 
        /// </summary>
        public DateTime NgaySinh { get; set; }

        /// <summary>
        /// giới tính của nhân viên [true:Nam ;fales:Nữ]
        /// </summary>
        public bool GioiTinh { get; set; }
        /// <summary>
        /// số điện thoại của Nhân viên
        /// </summary>

        public string SDT { get; set; }
        /// <summary>
        /// địa chỉ Email của nhân viên
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// địa chỉ của nhân viên , nhà , đường phố , nơi cư trú
        /// </summary>
        public string DiaChi { get; set; }
        /// <summary>
        /// thông tin ghi chú có liên quan 
        /// </summary>
        public int MaQH { get; set; }

        public string GhiChu { get; set; }
        /// <summary>
        /// trạng thái tài khoản của người dùng có tài khoản trong hệ thống
        /// </summary>
        public bool TrangThai { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaiKhoanTV()
        {
            this.TaiKhoan = ""; this.MatKHau = "";
            this.HoDem = ""; this.TenTV = ""; this.NgaySinh = new DateTime(1900, 1, 1);
            this.SDT = ""; this.Email = ""; this.DiaChi = ""; this.GhiChu="";
        }



    }
}
