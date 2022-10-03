using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnK18_2020.BusinessLayer.Entity
{
    class QuanHuyen

    {

        /// <summary>
        /// Lưu trữ thông tin mã quận huyện 
        /// </summary>
        public int MaQH { get; set; }
        /// <summary>
        /// tên gọi của quận hoặc huyện trong danh mục 
        /// </summary>
        public string TenQH { get; set; }
        /// <summary>
        /// Tên của thành phố hoặc tỉnh quản lý quận tương ứng
        /// </summary>
        public string TinhThanh { get; set; }
        /// <summary>
        /// Ghi chú nhũng thông tin khác liên quan đến quận huyện 
        /// </summary>
        public string GhiChu { get; set; }
        /// <summary>
        /// Default constructor  : Khởi gán giá trị cho class
        /// </summary>

        public QuanHuyen()
        {
            this.TenQH = "";
            this.TinhThanh = "";
            this.GhiChu = "";

        }


    }

}
