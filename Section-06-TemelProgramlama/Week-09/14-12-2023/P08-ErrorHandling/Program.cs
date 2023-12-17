using System.Threading.Channels;

namespace P08_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            //Uygulamalarımız çalıştıkları esnada bir takım hatalardan dolayı durabilir. Bu tür hatalara Run Time Errors (Çalışma Zamanı Hataları) denir.
            //Run Time Errors'ı kontrol altına alabilmek için Try-Catch-Finally yapısını kullanacağız.

            /* try
             * {
             *       Çalışmasını beklediğimiz kodları buraya yazacağız (hata verme olasılığı olan). Dolayısıyla buraya yazdığımız kodları şu şekilde düşünebiliriz: Bu kodları çalıştırmayı DENE! Çalışıyorsa hiçbir sorun olmadan devam eder, yani catch scope'unu atlar, çalıştırmaz. Çalışmıyorsa/hata varsa catch scope'una geçer.
             * } 
             * catch 
             * {
             *       Eğer try scope'undaki kodda bir hata meydana gelirse bu bölümdeki kodlar çalışır.
               }
               finally
               {
                     Try ya da catch scope'larından hangisi çalışmış olursa olsun, her halükarda bu kısımda yazılan kodlar çalıştırılır.
               }
             */
            #endregion

            #region Sample01

            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //try
            //{
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    int sonuc = Convert.ToInt32(Math.Pow(sayi, 2));
            //    Console.WriteLine(sonuc);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Sample02
            try
            {
                Console.Write("Bölünen: ");
                int bolunen = int.Parse(Console.ReadLine());
                Console.Write("Bölen: ");
                int bolen = int.Parse(Console.ReadLine());
                int sonuc = bolunen / bolen;
                Console.WriteLine($"{bolunen} / {bolen} = {sonuc}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("bolen 0 olamaz");
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
            }
            catch (Exception ex)  
            {
                Console.WriteLine("Hata var!");
                    
             };


        #endregion
        Console.ReadLine();

        }
    }
}
