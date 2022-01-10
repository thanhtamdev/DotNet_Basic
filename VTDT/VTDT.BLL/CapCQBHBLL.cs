using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTDT.DAL;
using VTDT.DTO;

namespace VTDT.BLL
{
    public class CapCQBHBLL
    {
        CapCQBHDAL dalCapCQBH = null;
        public List<CapCQBH> GetALL()
        {
            dalCapCQBH = new CapCQBHDAL();

            try
            {
                return dalCapCQBH.GetAll();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Insert(CapCQBH capCQBH)
        {
            dalCapCQBH = new CapCQBHDAL();

            try
            {
                return dalCapCQBH.Insert(capCQBH);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Update(CapCQBH capCQBH)
        {
            dalCapCQBH = new CapCQBHDAL();

            try
            {
                return dalCapCQBH.Update(capCQBH);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Delete(CapCQBH capCQBH)
        {
            dalCapCQBH = new CapCQBHDAL();

            try
            {
                return dalCapCQBH.Delete(capCQBH);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
