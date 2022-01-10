using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.Write(" Nhap so luong thi sinh: n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            ThiSinh[] ts = new ThiSinh[n];

            NhapDSTS(ts);
            HienThiKQ(ts);
        }

        private static void NhapDSTS(ThiSinh[] ts)
        {
            for (int i = 0; i < ts.Length; i++)
            {
                Console.WriteLine("\n Nhap thong tin thi sinh thu: " + (i + 1));

                string val = "";

                Console.Write(" Doi tuong (Chuyen - ‘C’, Sieu cup ‘S’): ");
                val = Console.ReadLine().ToLower();

                if (String.Compare(val, "c") == 0)
                {
                    ts[i] = new Chuyen();
                    ts[i].NhapTTTS();
                }
                else
                {
                    ts[i] = new SieuCup();
                    ts[i].NhapTTTS();
                }
            }
        }

        private static void HienThiKQ(ThiSinh[] ts)
        {
            Console.WriteLine(" Ket qua cua cac thi sinh: ");

            foreach (var item in ts)
            {
                item.InTTTS();
            }
        }
    }
}
