using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTDT.DAL
{
    public class DBLib
    {
        // Khai báo biến thành viên
        private SqlConnection cnn;
        private SqlCommand cmd;

        // Phương thức khởi tạo mặc định
        public DBLib()
        {
            // Khai báo chuỗi kết nối
            string strCnn = "Server=THINKPAD; Database=VTDT; Integrated Security=true;";

            // Khởi tạo đối tượng SqlConnection
            cnn = new SqlConnection(strCnn);

            // Khởi tạo đối tượng SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = cnn;
        }

        // Phương thức mở kết nối
        public void Open()
        {
            if (cnn.State != System.Data.ConnectionState.Open)
            {
                cnn.Open();
            }
        }

        // Phương thức đóng kết nối
        public void close()
        {
            if (cnn.State != System.Data.ConnectionState.Closed)
            {
                cnn.Close();
            }
        }

        // Phương thức thực thi câu lệnh SQL với tên và kiểu câu lệnh
        public bool ExcuteNonQuery(string cmdText, CommandType cmdType)
        {
            int count = 0;
            try
            {
                Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return count > 0;
        }

        // Phương thức truyền tham số với tên và giá trị của tham số
        public void AddParameter(string name, object value)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            cmd.Parameters.Add(parameter);
        }

        public void AddParameter(string name, object value, ParameterDirection direction)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.Direction = direction;
            cmd.Parameters.Add(parameter);
        }

        // Phương thức thấy giá trị tham số đầu ra
        public int GetParameter(string parameterName)
        {
            return (int)cmd.Parameters[parameterName].Value;
        }

        // Phương thức điền dữ liệu vào datatable với tên câu lệnh và kiểu câu lệnh
        public DataTable FillDataTable(string cmdText, CommandType cmdType)
        {
            DataTable dataTable = null;

            try
            {
                Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dataTable;
        }

        public DataTable FillDataTable(string cmdText, CommandType cmdType, string[] arrayParaName,
            object[] arrayValue, SqlDbType[] arraySqlDbType)
        {
            DataTable dataTable = null;

            try
            {
                Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                SqlParameter parameter = null;

                for (int i = 0; i < arrayParaName.Length; i++)
                {
                    parameter = new SqlParameter();
                    parameter.ParameterName = arrayParaName[i];
                    parameter.Value = arrayValue[i];
                    parameter.SqlDbType = arraySqlDbType[i];
                    cmd.Parameters.Add(parameter);
                }
                dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);                
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dataTable;
        }
    }
}
