using System.Reflection.Metadata.Ecma335;

namespace ClassesAndStructures_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();
            Console.WriteLine("---");

            // Когда создаётся новый объект не нужно писать Human human = new Human();, достаточно human = new Human("");
            human = new Human("Алексей");
            human.Greetings();
            Console.WriteLine("---");

            human = new Human("Жужа", 40);
            human.Greetings();
            Console.WriteLine("---");

            // Вызов конструктора инициализатором
            human = new Human { name = "Жопка хомячка", age = 2 };
            human.Greetings();

            Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };
            animal.Info();
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

        class Rectangle
        {
            public int a;
            public int b;

            public Rectangle()
            {
                a = 6;
                b = 4;
            }

            public Rectangle(int side)
            {
                a = side;
                b = side;
            }

            public Rectangle(int first, int second)
            {
                a = first;
                b = second;
            }

            public int Square()
            {
                return a * b;
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

        class Pen
        {
            public string color;
            public int cost;

            public Pen()
            {
                color = "Черный";
                cost = 100;
            }

            public Pen(string penColor, int penCost)
            {
                color = penColor;
                cost = penCost;
            }
        }

    }
}