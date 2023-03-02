namespace AccessModifiersGetSet_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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
            private set
            {
                age = value;
            }
        }
    }
}