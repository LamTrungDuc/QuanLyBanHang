using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnK18_2020.Lip;
using DoAnK18_2020.BusinessLayer.Entity;
using DoAnK18_2020.BusinessLayer.Workflow;

namespace DoAnK18_2020.PresentationLayer
{
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
            //Load data to comboBoc :cbMaQH , cbMaNhom 
            //1 load data to cbMaQH
            DataSet ds = new BussQuanHuyen().GetDataSet();
            this.cbMaQH.DataSource = ds.Tables[0];
            this.cbMaQH.DisplayMember = "tenQH";
            this.cbMaQH.ValueMember = "maQH";
            //---2 load data to cbMaNhom
            //ds = new BusNhomTK();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.txtTaikhoan.Clear(); this.txtTenTV.Clear(); this.txtNgaySinh.Clear(); this.rbdGioiTinh.Checked = true;
            this.txtDiaChi.Clear(); this.txtsoDT.Clear(); this.txtEmail.Clear(); this.cbMaQH.SelectedIndex = -1; this.cbMaNhom.SelectedIndex = -1;
            this.txtMatKhau.Clear(); this.txtXacNhan.Clear(); this.txtHoDem.Focus();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNgaySinh_Leave(object sender, EventArgs e)
        {
            if(this.txtNgaySinh.Text.Length>0 && !ValidationByRegex.checkDate(this.txtNgaySinh.Text))
            {
                this.BaoLoi.Show(@"Dữ liệu ngày tháng không đúng",this.txtNgaySinh,0,-68,5000);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtsoDT_Leave(object sender, EventArgs e)
        {
            if (this.txtsoDT.Text.Length > 0 && !ValidationByRegex.checkPhone(this.txtsoDT.Text))
                this.BaoLoi.Show("Không phải số điện thoại ",this.txtsoDT,0,-68,6000);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (this.txtEmail.Text.Length > 0 && !ValidationByRegex.checkPhone(this.txtEmail.Text))
                this.BaoLoi.Show("Không phải số điện thoại ", this.txtEmail, 0, -68, 6000);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTaikhoan_Leave(object sender, EventArgs e)
        {
            if (this.txtTaikhoan.Text.Length > 0 && !ValidationByRegex.checkUsernameRegex(this.txtTaikhoan.Text))
                this.BaoLoi.Show("tài khoản không đúng chuẩn , hãy đặt lại ! ", this.txtTaikhoan, 0, -68, 6000);
        }
        /// <summary>
        /// Đóng gói dữ liệu tài khoản từ giao diện vào taiKhoanTV object 
        /// </summary>
        /// <returns></returns>
        private TaiKhoanTV packageFromUI()
        {
            TaiKhoanTV kq = new TaiKhoanTV();
            // 1 :::: Member infor
            kq.HoDem = this.txtHoDem.Text.Trim();
            kq.TenTV = this.txtTenTV.Text.Trim();
            kq.NgaySinh = DateTime.Parse(this.txtNgaySinh.Text);
            kq.GioiTinh = this.rbdGioiTinh.Checked;
            //----2 : Connatc information 
            kq.DiaChi = this.txtDiaChi.Text.Trim();
            kq.MaQH =int.Parse( this.cbMaQH.SelectedValue.ToString());
            kq.SDT = this.txtsoDT.Text.Trim();
            kq.Email = this.txtEmail.Text.Trim();
            //---3 Member Account 
            kq.MaNhom = int.Parse(this.cbMaNhom.SelectedValue.ToString());
            kq.TaiKhoan = this.txtTaikhoan.Text.Trim();
            kq.MatKHau = new Encryption().SHA256_Hashing(this.txtMatKhau.Text.Trim());
            return kq;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool enableSaveButton()
        {
            return this.txtTaikhoan.Text.Trim().Length > 0 && this.txtMatKhau.Text.Trim().Length > 0 && this.txtTenTV.Text.Trim().Length > 0 &&
                this.cbMaNhom.SelectedIndex >= 0 && this.txtDiaChi.Text.Trim().Length > 0 && this.cbMaQH.SelectedIndex >= 0 && this.txtTaikhoan.Text.Trim().Length > 0;

        }

        private void txtTenTV_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = enableSaveButton();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = enableSaveButton();
        }

        private void txtsoDT_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = enableSaveButton();
        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = enableSaveButton();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = enableSaveButton();
        }

        private void cbMaQH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = enableSaveButton();
        }

        private void cbMaNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = enableSaveButton();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtMatKhau.Text.Trim().Equals(this.txtXacNhan.Text.Trim()))
            {
                BusTaiKhoanTV b = new BusTaiKhoanTV();

                //B1 
                b.info = packageFromUI();
                //B2 Call addTaiKhoanTV method to insert datato database
                int kq = b.addTaiKhoan();
                //----B3 ::Message for result
                if (kq == 1)
                {
                    MessageBox.Show(string.Format("Đã lưu thành công tài khoản  {0} cho thành viên {1} {2}", b.info.TaiKhoan, b.info.HoDem, b.info.TenTV));
                    this.btnNew.PerformClick();
                }
                else
                    MessageBox.Show("Có lỗi không lưu được ");

            }
            else
                this.BaoLoi.Show("Mật khẩu không khớp , hãy nhập lại !",this.txtMatKhau,0,-68,2000);
            this.txtMatKhau.Clear();
            this.txtXacNhan.Clear();
            txtMatKhau.Focus();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {

        }

       
       
    }
}
