namespace P06_NumberMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 40;
            //int number2 = 60;
            //Console.WriteLine($"En küçük: { Math.Min(number1, number2)}");
            //Console.WriteLine($"En büyük: { Math.Max(number1, number2)}");

            //int sayi = 4; 
            //int us = 2;
            /*Console.WriteLine(Math.Pow(sayi, us));*/ //örtülü dönüştürme-implicit conversion yaparak double'a çevirdi

            //int sonuc = Math.Pow(sayi, us); Bu şekilde yapamıyoruz çünkü pow double döndürdüğünden int bir değişkene atayamıyor.

            //int sonuc = Convert.ToInt32(Math.Pow(sayi, us));
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Bir sayı giriniz: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir sayı daha giriniz: ");
            //int number2 = Convert.ToInt32(Console.ReadLine()); 
            //Console.WriteLine(number1 + number2);
            //Console.ReadLine();

            //Kullanıcıdan taban ve üs sayılarını alıp tabanon üssüncü kuvvetini hesaplayarak konsola yazdıran kodu yazınız.
            //Console.Write("Üssü alınacak sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Üs olacak sayı giriniz: ");
            //int us = Convert.ToInt32(Console.ReadLine());

            //int sonuc = Convert.ToInt32(Math.Pow(sayi, us));
            //Console.WriteLine($"{sayi} sayısının {us}. kuvveti: {sonuc}");

            double sayi = 5.493486;
            Console.WriteLine(sayi);
            Console.WriteLine($" Ceiling: {Math.Ceiling(sayi)}");
            Console.WriteLine($" Floor: {Math.Floor(sayi)}");
            Console.WriteLine($" Round: {Math.Round(sayi)}");
            Console.WriteLine($" Round: {Math.Round(sayi, 3)}");
            Console.ReadLine();

        }
    }
}
