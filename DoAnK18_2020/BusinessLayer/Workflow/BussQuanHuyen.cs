using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DoAnK18_2020.BusinessLayer.Entity;
using DoAnK18_2020.DataAccessLayer;
namespace DoAnK18_2020.BusinessLayer.Workflow

{
    class BussQuanHuyen
    {
        public QuanHuyen info { get; set; }
        public BussQuanHuyen()
        {
            this.info = new QuanHuyen();
        }
        /// <summary>
        /// trả về câu DML dùng cho mục đích insert dữ liệu vào sql server 
        /// </summary>
        /// <returns></returns>
        private string insertSQL()
        {
            return string.Format("Insert into quanHuyen(tenQH,tinhThanh,ghiChu) values(N'{0}',N'{1}',N'{2}');", this.info.TenQH, this.info.TinhThanh, this.info.GhiChu);
        }
        /// <summary>
        /// Tạo ra câu lệnh update đối với table quận huyện 
        /// </summary>
        /// <returns></returns>
        private string UpdateSQL()
        {
            return string.Format("Update quanHuyen set tenQH=N'{0}',set tinhThanh=N'{1}',set ghiChu=N'{2}' where maQH={3}", this.info.TenQH, this.info.TinhThanh, this.info.GhiChu,this.info.MaQH);
        }
        /// <summary>
        /// tạo truy vấn xóa dữ liệu trong table
        /// </summary>
        /// <returns></returns>
        private string DeleteSQL()
        {
            return string.Format("Delete quanHuyen where maQH={0}" ,this.info.MaQH);
        }
        public int addQuanHuyen()
        {
            int kq = 0;
            string query = this.insertSQL();
            // 
            kq = new daoSQLServer().executeNonQuery(query);
            return kq;
        }
        /// <summary>
        /// cập nhật thông tin quận huyện trên database
        /// </summary>
        /// <returns></returns>
        



        public int updateQuanHuyen()
        {
            return new daoSQLServer().executeNonQuery(UpdateSQL());
        }
        /// <summary>
        /// xóa thông tin quận huyện trên database
        /// </summary>
        /// <returns></returns>
        public int deleteQuanHuyen()
        {
            return new daoSQLServer().executeNonQuery(DeleteSQL());
        }
        /// <summary>
        /// đọc về dữ liệu từ table quanHuyen và trả ra cho nơi gọi 1 DataSet Object 
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet()
        {
            string query = "select *from quanHuyen";
            return new daoSQLServer().GetdataSet(query, "quanHuyen");
        }
    }
}
