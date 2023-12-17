namespace P13_Methods
{
    internal class Program
    {
        static void SelamVer()
        {
            Console.WriteLine("Günaydın!");
        }

        static int KacKelime(string metin)
        {
            string[] kelimeler = metin.Split(' ');
            return kelimeler.Length;
        }

        static int KelimeAdedi(string metin, string aranacakMetin, bool buyukKucuk)
        {
            if (!buyukKucuk)
            {
                metin = metin.ToLower();
                aranacakMetin = aranacakMetin.ToLower();
            }

            string[] kelimeler = metin.Split(" ");
            int count = 0;
            foreach (string kelime in kelimeler)
            {
                if (kelime == aranacakMetin) count++;
            }
            return count;
        }

        static int[] SayiUret(int adet, int min, int max)
        {
            Random random = new Random();
            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = random.Next(min, max);
            }
            return sayilar;
        }

        static int SesliHarfAdedi(string metin)
        {
            char[] sesliHarf = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            int sesliHarfAdedi = 0;
            metin = metin.ToLower();
            for (int i = 0; i < metin.Length; i++)
            {
                if (sesliHarf.Contains(metin[i])) sesliHarfAdedi++;
            }
            return sesliHarfAdedi;

        }

        static int[] SesliSessizHarfAdedi(string metin)
        {
            char[] sesliHarf = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            int sesliHarfAdedi = 0;

            metin = metin.ToLower();
            metin = metin.Replace(" ", "");
            metin = metin.Replace(",", "");
            metin = metin.Replace(".", "");
            for (int i = 0; i < metin.Length; i++)
            {
                if (sesliHarf.Contains(metin[i])) sesliHarfAdedi++;

            }
            int sessizHarfAdedi = metin.Length - sesliHarfAdedi;
            int[] sesliSessizHarfAdetleri = { sesliHarfAdedi, sessizHarfAdedi };

            return sesliSessizHarfAdetleri;

        }

        //İçinde Türkçe karakter barındırmadan tüm küçük harfleri, 0-9 arasındaki rakamları, (.) işaretini, virgül (,), artı (+) ve eksi(-) işaretini barındırabilen toplam uzunluğu 6 karakter olacak şekilde rastgele bir şifre üreten metodu yazınız.
        static string SifreUret()
        {
            string karakterler = "abcdefghijklmnoprstuvyz0123456789-+.,";
            Random random = new Random();
            string sifre = "";
            for (int i = 0; i < 6; i++)
            {
                sifre += karakterler[random.Next(0, karakterler.Length)];

            }
            return sifre;
        }

        //Şifre üretme: 1) Şifre mutlaka harfle başlamalı, 2) Şifrenin içinde mutlaka en az bir rakam olmalı, 3) Şifrenin içinde bir adet özel karakter olmalı, 4) Kalan karakter harf olmalı, 5) Şifre 6 karakter olmalı, 6) büyük harf yok
        static string SifreUret2()
        {
            string harfler = "abcdefghijklmnoprstuvyz";
            string rakamlar = "0123456789";
            string ozelKarakterler = "-+.,";

            Random random = new Random();
            string sifre = "";
            sifre += harfler[random.Next(0, harfler.Length)];
            sifre += rakamlar[random.Next(0, rakamlar.Length)];
            sifre += ozelKarakterler[random.Next(0, ozelKarakterler.Length)];

            for (int i = 0; i < 3; i++)
            {
                sifre += harfler[random.Next(0, harfler.Length)];
            }

            return sifre;
        }
        static void Main(string[] args)
        {
            //SelamVer();
            //Console.WriteLine("Bir cümle giriniz: ");
            //string cumle = Console.ReadLine();
            //int KelimeSayisi = KacKelime(cumle);
            //Console.WriteLine($"'{cumle}' cümlesindeki kelime sayısı: {KelimeSayisi}");

            //int adet = KelimeAdedi("Bugün çok güzel. Çok mutluyum, çok iyiyim.", "çok", true);
            //Console.WriteLine(adet);

            //int[] sayilar = SayiUret(10, 1, 100);
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            //int[] sonuc = SesliSessizHarfAdedi("Bu cümleyi say");
            //Console.WriteLine($"Sesli harf adedi: {sonuc[0]}");
            //Console.WriteLine($"Sessiz harf adedi: {sonuc[1]}");
            //Console.WriteLine(SesliSessizHarfAdedi("Melek Yağcı ve Ayşenur Gezgin"));

            //Console.WriteLine(SifreUret());
            Console.WriteLine(SifreUret2());
            Console.ReadLine();
        }
    }
}
    

