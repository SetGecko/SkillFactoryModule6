namespace Task_6._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Age = 35;

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
                age = value;
            }
        }
    }
}