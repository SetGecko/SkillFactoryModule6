namespace ClassesAndStructures_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();
            Console.WriteLine("---");

            human = new Human("Алексей");
            human.Greetings();
            Console.WriteLine("---");

            human = new Human("Жужа", 40);
            human.Greetings();
        }
        class Human
        {
            public string name;
            public int age;

            public void Greetings()
            {
                Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
            }

            public Human()
            {
                name = "Неизвестно";
                age = 35;
            }

            public Human(string n)
            {
                name = n;
                age = 35;
            }

            public Human(string n, int a)
            {
                name = n;
                age = a;
            }
        }

        struct Animal
        {
            public string type;
            public string name;
            public int age;

            public void Info()
            {
                Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
            }
        }

    }
}