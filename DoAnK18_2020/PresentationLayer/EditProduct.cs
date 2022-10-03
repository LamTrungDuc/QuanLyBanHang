using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnK18_2020.PresentationLayer
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data source=DESKTOP-4FH2OH5\SQLEXPRESS; Initial Catalog=BanHang ; Integrated Security=true");
        // treen laptop 
        //@"Data source=DESKTOP-4FH2OH5\SQLEXPRESS; Initial Catalog=BanHang ; Integrated Security=true"
        private void ketnoicsdl()
        {
            con.Open();
            // lấy dữ liệu trong bảng sinh viên 
            string sql = "select * from sanPham";
            // bắt đầu truy vấn 
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            // chuyển dữ liệu về 
            SqlDataAdapter da = new SqlDataAdapter(com);
            //tạo 1 kho ảo để lưu trữ dữ liệu 
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            // đổ dữ liệu vào gridView
            ds_SanPham.DataSource = dt;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string insertUPDATE = "UPDATE sanPham SET maSP=@maSP ,tenSP=@tenSP ,hinhDD=@hinhDD ,ndTomTat=@ndTomTat ,nhaSanXuat=@nhaSanXuat ,ngayDang=@ngayDang ,maLoai=@maLoai , noiDung=@noiDung ,taiKhoan=@taiKhoan ,daDuyet=@daDuyet ,giaBan=@giaBan ,giamGia=@giamGia where maSP=@maSP";
            SqlCommand cmd = new SqlCommand(insertUPDATE, con);
            this.con.Open();
            cmd.Parameters.AddWithValue("maSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("tenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("hinhDD", txtHinhDD.Text);
            cmd.Parameters.AddWithValue("ndTomTat", txtNoiDungTT.Text);
            cmd.Parameters.AddWithValue("nhaSanXuat", txtNhaSX.Text);
            cmd.Parameters.AddWithValue("ngayDang", txtNgayDang.Text);
            cmd.Parameters.AddWithValue("maLoai", txtMaLoai.Text);
            cmd.Parameters.AddWithValue("noiDung", txtNoiDung.Text);
            cmd.Parameters.AddWithValue("taiKhoan", txtTaiKhoan.Text);
            cmd.Parameters.AddWithValue("daDuyet", txtDaDuyet.Text);
            cmd.Parameters.AddWithValue("giaBan", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("giamGia", txtGiamGia.Text);
            cmd.ExecuteNonQuery();
            this.con.Close();
            ketnoicsdl();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
    }
}
