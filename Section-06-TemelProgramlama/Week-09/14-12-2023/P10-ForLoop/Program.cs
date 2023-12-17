namespace P10_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}
            #endregion

            #region ForEach
            //string[] names = { "Ayşenur", "Zeynep", "Ece", "Ferda", "Murat" };

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, };
            //int[] newArr = new int[5];
            //int index = 0;
            //foreach (var number in numbers)
            //{
            //    newArr[index] = number * 2;
            //    index++;
            //}

            //Klavyeden girilecek bir sayıya kadar olan sayıların içinden kaç tanesinin çift kaç tanesinin üçün katı olduğunu buldurup konsola yazdıralım.
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int ciftSayiAdedi = 0;
            int ucunKatiSayiAdedi = 0;
            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 == 0) ciftSayiAdedi++;
                if (i%3==0) ucunKatiSayiAdedi++;
                
            }
            Console.Clear();
            Console.WriteLine("Sonuç: ");
            Console.WriteLine("---------");
            Console.WriteLine($"0-{sayi} arasındaki çift sayıların adedi: {ciftSayiAdedi}");
            Console.WriteLine($"0-{sayi} arasındaki üçün katı sayıların adedi: {ucunKatiSayiAdedi}");

            #endregion
            Console.ReadLine();
        }
    }
}
