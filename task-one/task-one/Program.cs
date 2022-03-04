using System;

namespace n_dən_m_ə_qədər_7ə_bölünən_ədələrin_sayını_tapın_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Console.Write("n ededini daxil edin: ");
                int n = Int32.Parse(Console.ReadLine());
                Console.Write("m ededini daxil edin: ");

                int m = Int32.Parse(Console.ReadLine());

                if (n >= m)
                {
                    Console.Write("m ededi n ededinden boyuk olmalidir.\nm ededini tekrar daxil edin: ");
                    m = Int32.Parse(Console.ReadLine());
                }

                Console.Write("x ededini daxil edin: ");
                int x = Int32.Parse(Console.ReadLine());
                int count = 0;
                try
                {
                    for (int i = n; i <= m; i++)
                    {
                        if (i % x == 0) count++;
                    }
                    Console.WriteLine(n + " Ededi ile " + m + " ededi arasında " + x + " ededine bölünən ədədlərin sayı: " + count);
                    Console.WriteLine("===================================");
                }
                catch
                {
                    Console.WriteLine("Sistemde xeta bas verdi!!!");
                }
            }
        }

    }
}
