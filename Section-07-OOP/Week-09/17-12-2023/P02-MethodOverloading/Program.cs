namespace P02_MethodOverloading
{
    internal class Program
    {
        /// <summary>
        /// Bu metot aldığı iki tam sayıyı toplayıp sonucu tam sayı olarak döndürür.
        /// </summary>
        /// <param name="sayi1">Toplanacak ilk tam sayı değer</param>
        /// <param name="sayi2">Toplanacak ikinci tam sayı değer</param>
        /// <returns>Geriye tam sayı bir değer gösterir.</returns>
        static int Sum(int sayi1, int sayi2) 
        { 
            return sayi1 + sayi2;
        }
        static int Sum(int sayi1, int sayi2, int sayi3) 
        { 
            return (sayi1 + sayi2 + sayi3);
        }
        static double Sum (double sayi1, double sayi2) 
        {
            return sayi1 + sayi2;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(Sum(3, 4));
            Console.WriteLine(Sum(3, 4, 5));
            Sum(2, 3);
            Console.ReadLine();
        }
    }
}
