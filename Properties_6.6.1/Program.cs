namespace Properties_6._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Age = 14;

            Console.WriteLine(user.Age);

            Console.ReadKey();
        }
    }
    class User
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}