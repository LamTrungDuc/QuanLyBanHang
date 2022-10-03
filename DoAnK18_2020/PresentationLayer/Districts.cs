using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnK18_2020.BusinessLayer.Entity;
using DoAnK18_2020.BusinessLayer.Workflow;

namespace DoAnK18_2020.PresentationLayer
{
    //  Các vấn đề liên quan đến quận huyện thêm xóa sửa 

    public partial class Districts : Form
    {
        private DataSet ds;
        private DataViewManager dsView;


        public Districts()
        {
            InitializeComponent();
            dataBinding();
        }
        private void dataBinding()
        {
            updateDataGridView();
            //------Gắn nút delete vào các dòng cho dsQuanHuyen
            //--------B1:tạo 1 nút để gắn vào DataGridView
            DataGridViewButtonColumn nutXoa = new DataGridViewButtonColumn();
            nutXoa.Name = "Delete";
            nutXoa.Text = "Xóa quận này";
            nutXoa.UseColumnTextForButtonValue = true;
            //----B2 gắn cái nút cờ vào DataGridView
            this.dsQuanHuyen.Columns.Add(nutXoa);
            this.dsQuanHuyen.CellClick += dsQuanHuyen_CellClick;
            //----Binding to textBox [txtName ; txtCity;txtNote]
            this.txtName.DataBindings.Add("Text",dsView,"quanHuyen.tenQH");
            this.txtCity.DataBindings.Add("Text",dsView,"quanHuyen.tinhThanh");
            this.txtNote.DataBindings.Add("Text",dsView,"quanHuyen.ghiChu");
                
        }

        private void updateDataGridView()
        {
            BussQuanHuyen x = new BussQuanHuyen();
            ds = x.GetDataSet();
            //--- set default view to dsView
            dsView = ds.DefaultViewManager;
            // ---- Binding to DataGridView
            this.dsQuanHuyen.DataSource = dsView;
            this.dsQuanHuyen.DataMember = "quanHuyen";
            //định dạng cột cho dsQuanHuyen
            this.dsQuanHuyen.Columns[0].Width = 50;
            this.dsQuanHuyen.Columns[1].Width = 150;
            this.dsQuanHuyen.Columns[2].Width = 200;
            this.dsQuanHuyen.Columns[3].Width = 250;
            this.dsQuanHuyen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
        }


        private void dsQuanHuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dsQuanHuyen.Columns["Delete"].Index)
            {
                int maCX = int.Parse( this.dsQuanHuyen.Rows[e.RowIndex].Cells[1].Value.ToString());
                BussQuanHuyen x = new BussQuanHuyen();
                x.info = packageQH();
                x.info.MaQH = maCX;
                if (x.deleteQuanHuyen() > 0)
                    updateDataGridView();
            }
           
        } 


        /// <summary>
        /// Hàm thoát 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// đây là sự kiện xảy ra khi người dùng nhập dữ trên textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = enableSaveButton();
        }
        /// <summary>
        /// trả về true nếu dữ liệu của các textBox tenQH,tinhThanh có dữ liệu 
        /// </summary>
        /// <returns></returns>
        private bool enableSaveButton()
        {
            return (this.txtName.Text.Length > 0 && this.txtCity.Text.Length > 0);
        }
        /// <summary>
        /// Sự kiện khi người dùng muốn tạo mới nhấn vào nút New
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtCity.Text = "";
            this.txtNote.Text = "";
            this.txtName.Focus();
        }
        /// <summary>
        /// Sự kiện khi người dùng nhấn vào nút save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //B1 ::Đóng gói dữ liệu 
            BussQuanHuyen x = new BussQuanHuyen();
            x.info = packageQH();
            //B2 :: Gọi hàm lưu dữ liệu BussQuanHuyen để cập nhập xuống database
            int kq = x.addQuanHuyen();
            if (kq == 1)
                updateDataGridView();

            // thi hành tự động gọi nút new chạy 
            this.btnNew.PerformClick();
        }
        private QuanHuyen packageQH()
        {
            QuanHuyen x = new QuanHuyen();
            x.TenQH = this.txtName.Text.Trim();
            x.TinhThanh = this.txtCity.Text.Trim();
            x.GhiChu = this.txtNote.Text.Trim();
            return x;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
