using System.Xml;

namespace P09_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Intro
            //Console.WriteLine("Lütfen yaşınızı giriniz: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age>=18)
            //{
            //    Console.WriteLine("Giriş yapabilirsiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("18 yaşından küçüksünüz, giremezsiniz!");
            //}
            #endregion

            #region Tek Satırlık If

            //if (false) Console.WriteLine("Doğru");
            //Console.WriteLine("Bitti....");
            #endregion

            #region If-ElseIf

            //int age = 45;
            //if (age<18)
            //{
            //    Console.WriteLine("Çocuk");
            //}else if (age<40) 
            //{
            //    Console.WriteLine("Genç");
            //}
            //else
            //{
            //    Console.WriteLine("Yaşlı");
            //}
            #endregion

            #region SwitchCase
            //int x = 12;
            //switch (x)
            //{
            //    case 5:
            //        Console.WriteLine("Bugün ayın beşi");
            //        break;
            //    case 10:
            //        Console.WriteLine("Bugün ayın onu");
            //        break;
            //    case 15:
            //        Console.WriteLine("Bugün ayın on beşi");
            //        break;
            //    case 20:
            //        Console.WriteLine("Bugün ayın yirmisi");
            //        break;
            //    case 25:
            //        Console.WriteLine("Bugün ayın yirmi beşi");
            //        break;
            //    case 30:
            //        Console.WriteLine("Bugün ayın otuzu");
            //        break;
            //    default:
            //        Console.WriteLine("Söylenecek bir şey yok!");
            //        break;
            //}
            #endregion

            #region SwitchCase2
            int x = 11;
            switch (x)
            {
                case 5:
                case 10:
                case 15:
                case 20:
                case 25:
                case 30:
                    Console.WriteLine("Beşin katı");
                    break;
                default:
                    Console.WriteLine("Söylenecek bir şey yok!");
                    break;
            }
            #endregion
            Console.ReadLine();
        }
    }
}
