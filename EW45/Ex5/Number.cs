using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Number
    {
        private int num;

        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public void NhapVaTinhCBH()
        {
            try
            {
                Console.Write(" Nhap n = ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    throw new NumberException("Invalid number.");
                }
                else
                {
                    double res = Math.Sqrt(Convert.ToDouble(num));

                    Console.WriteLine(" Can bac hai cua n = {0} la: {1}", num, res);
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(" Loi nhap lieu: " + fe.Message);
            }
            catch (NumberException ne)
            {
                Console.WriteLine(" Exception: " + ne.Message);
            }
            finally
            {
                Console.WriteLine(" Good bye!!!");
            }
        }
    }
}
