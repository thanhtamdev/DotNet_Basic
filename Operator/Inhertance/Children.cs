using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Children:Father
    {
        // che thuộc tính: tạo ra thuộc tính có tên giống với thuộc tính ở lớp cha
        private int number = 20;
        
        public Children()
        {
            Console.WriteLine(number);
            // lấy giá trị trong thuộc tính trung tên của lớp cha sử dụng từ khóa base
            Console.WriteLine(base.number); 
        }
    }
}
