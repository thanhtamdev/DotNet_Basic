using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTDT.DTO;

namespace VTDT.DAL
{
    public class CapCQBHDAL
    {
        DBLib db = null;

        public List<CapCQBH> GetAll()
        {
            List<CapCQBH> list = new List<CapCQBH>();
            db = new DBLib();

            DataTable dataTable = new DataTable();
            try
            {
                dataTable = db.FillDataTable("sp_SelectCapCQBH", CommandType.StoredProcedure);

                // Doc du lieu tu datatable vao list

                foreach (DataRow dr in dataTable.Rows)
                {
                    CapCQBH capCQBH = new CapCQBH();
                    capCQBH.MaCapCQBH = dr[0].ToString();
                    capCQBH.TenCapCQBH = dr[1].ToString();
                    capCQBH.GhiChu = dr[2].ToString();
                    list.Add(capCQBH);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return list;
        }


        // Phương thức thêm dữ liệu vào bảng cơ quan ban hành
        public bool Insert(CapCQBH capCQBH)
        {
            bool check = false;
            db = new DBLib();

            db.AddParameter("@MaCapCQBH", capCQBH.MaCapCQBH);
            db.AddParameter("@TenCapCQBH", capCQBH.TenCapCQBH);
            db.AddParameter("@GhiChu", capCQBH.GhiChu);

            try
            {
                check = db.ExcuteNonQuery("sp_InsertCapCQBH", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return check;
        }

        public bool Update(CapCQBH capCQBH)
        {
            bool check = false;
            db = new DBLib();

            db.AddParameter("@MaCapCQBH", capCQBH.MaCapCQBH);
            db.AddParameter("@TenCapCQBH", capCQBH.TenCapCQBH);
            db.AddParameter("@GhiChu", capCQBH.GhiChu);

            try
            {
                check = db.ExcuteNonQuery("sp_UpdateCapCQBH", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return check;
        }

        public bool Delete(CapCQBH capCQBH)
        {
            bool check = false;
            db = new DBLib();

            db.AddParameter("@MaCapCQBH", capCQBH.MaCapCQBH);
            try
            {
                check = db.ExcuteNonQuery("sp_DeleteCapCQBH", System.Data.CommandType.StoredProcedure);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return check;
        }
    }
}
