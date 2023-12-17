using System.Collections;

namespace P12_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //int[] ages = new int[3] { 5, 3, 15 };
            //int[] sizes = {5, 3, 2, 4, 6, 7 };

            //Console.WriteLine(sizes[3]);

            //int[] sayilar = new int[50];
            //Random random = new Random();
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = random.Next(1, 101); //altsınır dahil, üstsınır değil
            //                                      //sayilar[i] = random.Next(100); 

            //}
            //ArrayList tekSayilar = new ArrayList();
            //ArrayList ciftSayilar = new ArrayList();

            //foreach (var sayi in sayilar)
            //{
                //    if (sayi % 2 == 0)
                //    {
                //        ciftSayilar.Add(sayi);
                //    }
                //    else
                //    {
                //        tekSayilar.Add(sayi);
                //    }

            //}

            //Console.WriteLine($"Çift sayi adedi: {ciftSayilar.Count}");
            //Console.WriteLine($"Tek sayı adedi: {tekSayilar.Count}");

            Random random = new Random();
            int[] tekSayilar = new int[5];
            int[] ciftSayilar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int sayi = 0;
                do
                {
                    sayi = random.Next(1,101);
                } while (sayi % 2 != 1);
                tekSayilar[i] = sayi;

                do
                {
                    sayi = random.Next(1, 101);
                } while (sayi % 2 != 0);
                ciftSayilar[i] = sayi;
            }
            Console.WriteLine($"Tek sayılar:");
            foreach (var i in tekSayilar)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Çift sayılar:");
            foreach (var i in ciftSayilar)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }
}
