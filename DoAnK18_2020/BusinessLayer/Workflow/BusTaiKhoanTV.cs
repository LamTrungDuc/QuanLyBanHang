using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnK18_2020.BusinessLayer.Entity;
using DoAnK18_2020.DataAccessLayer;

namespace DoAnK18_2020.BusinessLayer.Workflow
{
    class BusTaiKhoanTV
    {
        public TaiKhoanTV info { get; set; }
        public BusTaiKhoanTV()
        {
            this.info = new TaiKhoanTV();
        }

        private string insertsql()
        {
            return string.Format("Insert into taiKhoanTV (taiKhoan,matKhau,maNhom,hoDem,tenTV,ngaySinh,gioiTinh,soDT,email,diaChi,maQH,trangThai,ghiChu)"+
                "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{10}','{11}','{12}');",this.info.TaiKhoan,this.info.MatKHau,
                this.info.MaNhom, this.info.HoDem, this.info.TenTV, string.Format("{0:yyyy/MM/dd}", this.info.NgaySinh),(this.info.GioiTinh?1:0),this.info.SDT,
                this.info.Email,this.info.DiaChi,this.info.MaQH,(this.info.TrangThai?1:0),this.info.GhiChu);
        }


        private string updatesql()
        {
            return string.Format("Update taiKhoanTV set hoDem=N'{0}',tenTV=N'{1}',ghiChu=N'{2}',maNhom='3',ngaySinh='{4}',gioiTinh={5},"+
                "soDT='{6}',email='{7}',diaChi=N'{8}',maQH={9},ghiChu=N'{10}'"+"Where taiKhoan='{11}'",this.info.HoDem,this.info.TenTV,this.info.GhiChu,this.info.MaNhom,string.Format("{0:yyyy,MM,dd}",this.info.NgaySinh),(this.info.GioiTinh?1:0),
                this.info.SDT,this.info.Email,this.info.DiaChi,this.info.MaQH,this.info.MaQH,this.info.GhiChu,this.info.TaiKhoan   );
        }

        private string deletesql()
        {
            return string.Format("Delete taiKhoanTV where taiKhoan='{0}'",this.info.TaiKhoan);
        }

        public int addTaiKhoan()
        {
            return new daoSQLServer().executeNonQuery(insertsql());
        }
        public int UpdateTaiKhoan()
        {
            return new daoSQLServer().executeNonQuery(updatesql());

        }
        public int deleteTaiKhoan()
        {
            return new daoSQLServer().executeNonQuery(deletesql());
        }
    }
}
