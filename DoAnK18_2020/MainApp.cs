using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnK18_2020.PresentationLayer;


namespace DoAnK18_2020
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }
        private void MainApp_Load(object sender, EventArgs e)
        {

        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnDistricts_Click(object sender, EventArgs e)
        {
            Districts d = new Districts();
            d.MdiParent = this;
            d.Show();
        }

        private void rbdNewAccounts_Click(object sender, EventArgs e)
        {
            Accounts a = new Accounts();
            a.MdiParent = this;
            a.Show();
           
        }

        private void rbbAddProduct_Click(object sender, EventArgs e)
        {
            AddMani a = new AddMani();
            a.MdiParent = this;
            a.Show();
        }

        private void rbbEditProduct_Click(object sender, EventArgs e)
        {
            EditProduct d = new EditProduct();
            d.MdiParent = this;
            d.Show();
        }

        private void rbbDeleteProduct_DoubleClick(object sender, EventArgs e)
        {
            DeleteProduct c = new DeleteProduct();
            c.MdiParent = this;
            c.Show();
        }

        
    }
}
