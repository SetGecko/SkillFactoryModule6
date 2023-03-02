namespace Task_6._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Age = 35;
            user.Login = "setgecko";
            user.Email = "setgecko@gmail.com";

            Console.WriteLine(user.Age);

            Console.ReadKey();
        }
    }
    class User
    {
        private int age;
        private string login;
        private string email;
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
        public string Login
        {
            get 
            {
                return login;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Поле login должно быть длиннее 3 символов");
                }
                else
                {
                    login = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Неверный формат электронной почты");
                }
                else
                {
                    email = value;
                }
            }
        }
    }
}