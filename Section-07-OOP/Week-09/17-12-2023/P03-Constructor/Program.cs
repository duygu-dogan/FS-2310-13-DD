namespace P03_Constructor
{
    public class Student
    {
        public Student() {
            Age=18;
        }
        public Student(string name)
        {
            Name = name;
            Console.WriteLine("Bir student nesnesi oluşturuldu...");
        }
        public Student(int id, string name, int age, bool gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool Gender { get; set; }

        public void SelamVer ()
        {
            Console.WriteLine($"Merhaba, ben {Name}. {Age} yaşındayım.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Id = 1;
            //student.Name = "Melek";
            //student.Age = 22;
            //student.Gender = true;
            //student.SelamVer();

            //Student student2 = new Student
            //{
            //    Id = 2,
            //    Name="Çağdaş",
            //    Age=28,
            //    Gender = false,
            //};

            //Student student3 = new Student
            //{
            //    Gender = true,
            //    Id = 3,
            //};
            //student3.SelamVer();

            //student2.SelamVer();
            //Student student4 = new Student("Ali");
            //student4.SelamVer();
            Student student5 = new Student(5, "Duyguş", 29, true);
            student5.SelamVer();
            Console.ReadLine();
        }
    }
}
