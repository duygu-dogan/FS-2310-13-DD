namespace P04_ReferenceTypes
{
    class Product
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int number1 = 50;*/ //Bellekten okuma ve yazma işlemi stackte gerçekleştiği için bu tarz değişkenlere primitive type denir.
            //Console.WriteLine(number1);

            Random random = new Random();//reference type değişkenlerde stackteki alana heap'teki random nesnesinin adresi/referansı yazılır
            int sayi1 = random.Next();
            Console.WriteLine(sayi1);

            Product urun1 = new Product(); //urun1 referans tipli değişkendir

            Console.ReadLine();
        }
    }
}
