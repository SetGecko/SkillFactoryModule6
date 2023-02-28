namespace BoxingUnboxing_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Процесс упаковки( неявный):
            int i = 123;
            // Упаковка значения i в объект o
            object o = i;

            // или явная упаковка object o = (object)i;

            //Распаковка же происходит только явным образом

            int j = (int)o;
        }
    }
}