namespace P07_DateTimeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now); //gün, ay, yıl, saat
            //Console.WriteLine(DateTime.Today); //gün, ay, yıl, 00:00:00
            //DateTime birthday = new DateTime(1994, 2, 16);
            //Console.WriteLine(birthday.ToShortDateString());
            //Console.WriteLine(birthday.ToLongDateString());
            //DateTime today = DateTime.Now;
            //Console.WriteLine(today.ToShortTimeString()); //Saat bilgisini saniye olmadan
            //Console.WriteLine(today.ToLongTimeString()); //Saniye ile birlikte

            //Gelecek yılın ilk gününün tarihini bulduran kod
            //int year = DateTime.Now.Year + 1;
            //int month = 1;
            //int day = 1;
            //DateTime resultDate = new DateTime(year, month, day);
            //Console.WriteLine(resultDate.ToLongDateString());

            DateTime today = DateTime.Today;
            int year = today.Year + 1;
            int month = today.Month;
            int day = today.Day;
            DateTime resultDate = new DateTime(year, month, day);
            Console.WriteLine(resultDate.ToLongDateString());
            Console.ReadLine();

            //ÖDEV: C#'ta tarihlerle ilgili yapılabilecek işlemleri araştırınız. 
        }
    }
}
