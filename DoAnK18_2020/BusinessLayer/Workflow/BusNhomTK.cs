using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnK18_2020.BusinessLayer.Entity;
using DoAnK18_2020.DataAccessLayer;
using DoAnK18_2020.BusinessLayer.Workflow;
using System.Data;
namespace DoAnK18_2020.BusinessLayer.Workflow
{
    class BusNhomTK
    {
        public NhomTK info { get; set; }
        public BusNhomTK()
        {
            this.info = new NhomTK();
        }
        public string insertSql()
        {
            return string.Format("insert into nhomTK(tenNhom, ghiChu) values(N'{0}',N'{1}')", this.info.TenNhom, this.info.ghiChu);
        }
        public string updateSql()
        {
            return string.Format("update nhomTK set tenNhom=N'{0}', ghiChu=N'{1}' where maNhom={2}", this.info.TenNhom, this.info.ghiChu, this.info.maNhom);
        }
        public string deleteSql()
        {
            return string.Format("delete nhomTK where maNhom={0}", this.info.maNhom);
        }
        public int addNhomTaiKhoanTV()
        {
            return new daoSQLServer().executeNonQuery(insertSql());
        }
        public int updateNhomTaiKhoanTV()
        {
            return new daoSQLServer().executeNonQuery(updateSql());
        }
        public int deleteNhomTaiKhoanTV()
        {
            return new daoSQLServer().executeNonQuery(deleteSql());
        }
        public DataSet getDataSet()
        {
            string query = "select n.maNhom, n.tenNhom,n.ghiChu,(select count(*) from taiKhoanTV where maNhom=n.maNhom) as 'NumOfAcc' from nhomTK n";
            return new daoSQLServer().GetdataSet(query, "nhomTK");
        }
    }
}
