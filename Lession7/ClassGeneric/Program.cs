using System;

namespace ClassGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntList intList = new IntList(3);
            //intList.Set(0, 10);
            //intList.Set(1, -15);
            //intList.Set(2, 9);

            //for (int i = 0; i < intList.Size(); i++)
            //{
            //    Console.WriteLine(intList.Get(i));
            //}

            //DoubleList doubleList = new DoubleList(3);
            //doubleList.Set(0, 1.5);

            MyList<int> myList = new MyList<int>(3);
            myList.Set(0, 10);
            myList.Set(1, -15);
            myList.Set(2, 9);

            MyList<double> myList1 = new MyList<double>(2);
            myList1.Set(0, 10.09);
            myList1.Set(1, -1.5);

            MyList<string> myList2 = new MyList<string>(1);
            myList2.Set(0, "green");

            MyList<SinhVien> myList3 = new MyList<SinhVien>(3);
            
        }
    }
}
