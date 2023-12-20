using P06_Static.Helper;

namespace P06_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string name = "Alex?de?Souza";
            //HelperMethods helperMethods = new HelperMethods();
            //Console.WriteLine(helperMethods.EditText(name));

            Console.WriteLine(HelperMethods.EditText(name));

            Console.ReadLine();
      
        }
    }
}
