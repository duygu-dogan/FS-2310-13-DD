namespace P06_Static
{
    public static class Deneme
    {
        public static int Sayi { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.ReadLine();
            Deneme.Sayi = 45;
        }
    }
}
