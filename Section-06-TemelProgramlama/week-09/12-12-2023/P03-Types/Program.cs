using System;

namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes
            //C# veri tipleri çok önemli, çeşitli veri tipleri bulunur. Özellikle sayılar ve sayı olmayanlar şeklinde incelemek iyi olacaktır.
            //TAM SAYILAR
            byte sayi1 = 255; //8 bitlik alan kapladığı için 0-255 arası değer alabilir.
            sbyte sayi2 = -128; //Yine 8 bitlik alan kaplar ancak -128 ile 127 arası değer alabilir.
            Console.WriteLine(sayi1 + " sayısının alabileceği max değer: " + byte.MaxValue) ; 
            Console.WriteLine(sayi1 + " sayısının alabileceği min değer: " + byte.MinValue);
            Console.WriteLine(sayi1 + " sayısının bellekte kapladığı alan: " + sizeof(byte) + " byte"); //sizeof byte cinsinden kapladığı alanı verir
            Console.WriteLine(sayi2 + " " + sizeof(sbyte) + " byte") ;


            #endregion
            Console.ReadLine();
        }
    }
}
