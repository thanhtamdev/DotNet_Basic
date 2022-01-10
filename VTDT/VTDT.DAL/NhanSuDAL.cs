using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTDT.DAL
{
    class NhanSuDAL
    {
        DBLib db = null;
        public bool Login(string tenTK, string mk)
        {
            bool check = false;
            DataTable table = new DataTable();
            string[] arrPara = new string[2] { "@TenTaiKhoan", "@MatKhau" };
            object[] arrValue = new object[2] { tenTK, mk };
            SqlDbType[] arrSqlDbType = new SqlDbType[2] { SqlDbType.NVarChar, SqlDbType.NVarChar };
            try
            {
                table = db.FillDataTable("sp_DangNhapHeThong", CommandType.StoredProcedure, 
                    arrPara, arrValue, arrSqlDbType);
                if (table.Rows.Count > 0)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return check;
        }
    }
}
