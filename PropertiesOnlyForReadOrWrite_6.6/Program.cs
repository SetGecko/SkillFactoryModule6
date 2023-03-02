namespace PropertiesOnlyForReadOrWrite_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class User
    {
        private string login;
        private DateTime lastSeen;
        // Только для чтения
        public string Login
        {
            get
            {
                return login;
            }
        }
        // Только для записи
        public DateTime LastSeen
        {
            set
            {
                lastSeen = value;
            }
        }
    }
}