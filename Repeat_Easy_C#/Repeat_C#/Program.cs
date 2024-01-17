namespace MySpace
{
    class Array
    {
        // TASK 1
        /*
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // TASK 2
        /*
        public static void Main(string[] args)  
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var decimalNumbers = numbers.Average();

            Console.WriteLine(decimalNumbers.ToString());
        }*/

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // TASK 3
        /*
        public static void Main(string[] args)
        {
            string[] names = { "Andriy", "Jura", "Artur", "Oleksandr" };

            string orderBy = names.OrderByDescending(x => x).First();
            Console.WriteLine(orderBy);
        }*

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // TASK 4
        /*

        internal class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        public static void Main(string[] args)
        {
            List<Person> humans = new List<Person>();
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person person4 = new Person();
            Person person5 = new Person();

            humans.Add(person1);
            humans.Add(person2);
            humans.Add(person3);
            humans.Add(person4);
            humans.Add(person5);

            person1.Age = 5;
            person1.Name = "A";

            person2.Age = 20;
            person2.Name = "B";

            person3.Age = 50;
            person3.Name = "C";

            person4.Age = 30;
            person4.Name = "D";

            person5.Age = 11;
            person5.Name = "E";

            var less30 = humans.Where(a => a.Age < 30);
            foreach (var a in less30)
            {
                Console.WriteLine(a.Name);
            }
        }*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // TASK 4
        /*

        internal class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        public static void Main(string[] args)
        {

        }*/

    }
}