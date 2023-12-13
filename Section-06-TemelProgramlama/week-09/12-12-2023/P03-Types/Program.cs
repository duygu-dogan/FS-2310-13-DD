using System;

namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TAMSAYILAR
            //C# veri tipleri çok önemli, çeşitli veri tipleri bulunur. Özellikle sayılar ve sayı olmayanlar şeklinde incelemek iyi olacaktır.
            //TAM SAYILAR
            /* byte sayi1 = 255; //8 bitlik alan kapladığı için 0-255 arası değer alabilir.
              sbyte sayi2 = -128; //Yine 8 bitlik alan kaplar ancak -128 ile 127 arası değer alabilir.
            Console.WriteLine(sayi1 + " sayısının alabileceği max değer: " + byte.MaxValue) ; 
            Console.WriteLine(sayi1 + " sayısının alabileceği min değer: " + byte.MinValue);*/
            /* Console.WriteLine(sayi1 + " sayısının bellekte kapladığı alan: " + sizeof(byte) + " byte");*/ //sizeof byte cinsinden kapladığı alanı verir
                                                                                                             //Console.WriteLine(sayi2 + " " + sizeof(sbyte) + "byte");

            //byte sayi1 = 10;
            //ushort sayi2 = 10;
            //uint sayi3 = 40;
            //ulong sayi4 = 50;

            //sbyte sayi5 = -50;
            //short sayi6 = -6;
            //int sayi7 = -7;
            //long sayi8 = -8;

            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(sizeof(int));

            #endregion

            #region ONDALIKLISAYILAR
            //float sayi1 = 56.7f;
            //double sayi2 = 56.7;
            //decimal sayi3 = 76.89m;


            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(sizeof(float));
            //Console.WriteLine(sayi1.GetType());
            //Console.WriteLine();
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(sizeof(double));
            //Console.WriteLine(sayi2.GetType());
            //Console.WriteLine();
            //Console.WriteLine(decimal.MinValue);
            //Console.WriteLine(decimal.MaxValue);
            //Console.WriteLine(sizeof(decimal));
            //Console.WriteLine(sayi3.GetType());

            #endregion

            #region METİN VE KARAKTERLER
            //char answer = 'A';
            //string name = "Ali Veli";
            //Console.WriteLine(answer + " tipi" + answer.GetType() + "minimum değer: " + char.MinValue);
            //Console.WriteLine(name[4]); //4.karakter-char dizisi

            // C#'ta string değerler "" arasına yazılır, char'lar ise '' içine yazılır.
            #endregion

            #region MANTIKSAL

            //bool isActive = true;
            //Console.WriteLine(isActive);
            #endregion

            #region TARİH SAAT
            DateTime birthday = new DateTime(1994, 2, 16);
            
            Console.WriteLine(birthday);
            #endregion
            Console.ReadLine();
        }
    }
}
