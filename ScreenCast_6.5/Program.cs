namespace ScreenCast_6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Car
    {
        public double Fuel;

        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }
        public void Move()
        {
            // Движениае на 1 километр
            Mileage++;
            Fuel -= 0.5;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
}