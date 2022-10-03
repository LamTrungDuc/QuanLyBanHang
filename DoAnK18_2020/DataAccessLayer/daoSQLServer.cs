using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DoAnK18_2020.DataAccessLayer
{
    class daoSQLServer
    {
        private string strConnect;
        /// <summary>
        /// Default contructor :: Get Connection String from 
        /// </summary>
        public daoSQLServer()
        {
            this.strConnect = Properties.Settings.Default.chuoiKetNoi;
        }
        /// <summary>
        /// trả về cho nơi gọi 1 cái sql connection object đã kết nối [lý tưởng ]
        /// </summary>
        /// <returns></returns>
        public SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(this.strConnect);
            conn.Open();
            return conn;
          

        }
        /// <summary>
        /// Hàm cho phép thực thi các lệnh DML thuộc dạng [Insert Update delete]
        /// </summary>
        /// <param name="query">câu truy vấn sql cần thi hành trên sql server</param>
        /// <returns></returns>
        public int executeNonQuery(string query)
        {
            int kq = 0;
            SqlCommand cmd = new SqlCommand(query, getConnection());
            kq = cmd.ExecuteNonQuery();
            return kq;
        }
        /// <summary>
        /// đọc dữ liệu truy vấn từ database
        /// </summary>
        /// <param name="query">Câu truy vấn cần thực hiện trên sql server</param>
        /// <param name="tableName">tên table dùng để Mapping cho dataSet </param>
        /// <returns></returns>

        public DataSet GetdataSet(string query, string tableName)
        {
            //B1 tạo DataSet
            DataSet ds = new DataSet();
            //B2 tạo dataAdapter
            SqlDataAdapter adap = new SqlDataAdapter(query,getConnection());
            //B3 :Fill data to DataSet
            adap.TableMappings.Add("Table",tableName);
            adap.Fill(ds);
            return ds;
        }
            
    }
}
