using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTDT.BLL
{
    
    public class NhanSuBLL
    {
            NhanSuDAL dalNhanSu = null;
        public bool Login(string tenTK, string mk)
        {
            dalNhanSu = new NhanSuDAL();

            try
            {
                return dalNhanSu.Login(tenTK, mk);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
