using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDefineException
{
    class KhachHangException : Exception
    {
        // exception tự định nghĩa phải kế thừa từ lớp Exception
        // Sử dụng nó như lớp Exception bình thường
        public KhachHangException(string message) : base(message)
        {

        }
    }
}
