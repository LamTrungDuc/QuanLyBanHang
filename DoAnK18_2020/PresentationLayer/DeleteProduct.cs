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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string insertDELETE = "DELETE from  sanPham  where maSP=@maSP";
            SqlCommand cmd = new SqlCommand(insertDELETE, con);
            this.con.Open();
            cmd.Parameters.AddWithValue("@maSP", txtMaSP.Text);
            cmd.ExecuteNonQuery();
            this.con.Close();
            MessageBox.Show("Đã Xóa thành công :");

        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
    }
}
