namespace P05_StringMethods_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringMethods
            //Birleştirme

            //string name = "Halil Umut Meler";
            //int len = name.Length;
            //Console.WriteLine(name + " değerinin uzunluğu: " + len +" karakterdir"); 16

            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());

            //string m1 = "Bahçeşehir";
            //string m2 = "Üniversitesi";
            //int year = 1996;
            //Console.WriteLine(m1 + " " + m2); //1.teknik
            //Console.WriteLine(String.Concat(m1, " ", m2));//2.teknik
            //Console.WriteLine(m1 + " " + m2 + " " + year + " yılında kurulmuştur.");
            //Console.WriteLine(String.Concat(m1, " ", m2, " ", year, " yılında kurulmuştur."));

            //string result = $"{m1} {m2} {year} yılında kurulmuştur.";
            //Console.WriteLine(result); //3.teknik

            //Boşluk bırakma

            //string name = "duygu";
            //int age = 29;
            //string graduate = "Ankara Üni";
            //string result = $"Ad: {name} \nYaş: {age} \nOkul: {graduate}"; // \n: newline
            //Console.WriteLine(result);
            //Console.WriteLine($"{name}\t{age}\t{graduate}"); // \t: tab

            // İçerisinde arama-contains

            //string courseName = "FullStack Web Developer Eğitimi";
            //string findText = "web";
            //bool result = courseName.ToLower().Contains(findText.ToLower());
            //Console.WriteLine(result);

            //IndexOf, StartsWith, EndsWith

            //string name = "Zeyno";
            //Console.WriteLine(name.IndexOf("y")); //2
            //Console.WriteLine(name.StartsWith("A")); //false
            //Console.WriteLine(name.EndsWith("no")); //true

            //string school = "Yeditepe İlköğretim Okulu";
            //string result = school.Replace("Okulu", "Mektebi");
            //Console.WriteLine(result);

            //Replace
            //string title = "C#'ta Metinsel İşlemler";
            //string url = title.Replace(" ", "-").ToLower();
            //Console.WriteLine(url);

            //string text = "Bugün hava çok güzeldi ama akşama doğru hava bozdu. Öyle bozdu, öyle bozdu ki daha bozmaz dedik, daha da bozdu. Bozdukça bozdu.";
            //Console.WriteLine(text.ToLower().Replace(",", "").Replace(".", ","));

            string title = "Tesla, 2 milyon'dan fazla aracı otopilot yazılımını güncellemek için geri çağıracak!";
            Console.WriteLine(title);
            title = title.ToLower();
            title = title.Replace(" ", "-");
            title = title.Replace(",", "");
            title = title.Replace("'", "");
            title = title.Replace("ı", "i");
            title = title.Replace("ç", "c");
            Console.WriteLine(title);


            #endregion

            Console.ReadLine();
        }
    }
}
