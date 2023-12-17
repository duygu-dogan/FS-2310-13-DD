using System;


namespace P04_Inheritance
{
    public class Living
    {
        public int Category { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Eğer bu metodun, miras alan sınıflarda yeniden yazılabilmesine izin vermek istiyorsak virtual keywordu ile işaretleriz. 
       public virtual void Intro()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}");
        }
    }
    //Miras alınan class: base class, miras alan class: delivired class
    public class Student:Person
    {
        public int StudentNum { get; set; }
        
    }
    public class Teacher:Person
    {
        public string Branch { get; set; }
        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Branş: {Branch}");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            //Teacher teacher1 = new Teacher();
            //teacher1.FirstName = "Temel";
            //teacher1.LastName = "Suluk";
            //teacher1.Branch = "Fizik";
            //teacher1.Intro();
            //Base nesne = new Base(); //Base abstract class olduğu için bu şekilde yeni nesne oluşturamayız
            Product product = new Product();



            Console.ReadLine();
        }
    }
}
