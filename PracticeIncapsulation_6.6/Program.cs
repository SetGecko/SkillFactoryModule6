namespace PracticeIncapsulation_6._6
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

        private string color;

        private TurnDirection turn;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
            color = "white";
        }
        private void Move()
        {
            // Движениае на 1 километр
            Mileage++;
            Fuel -= 0.5;
        }
        private void Turn(TurnDirection direction)
        {
            turn = direction;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }
        public string GetColor()
        {
            return color;
        }
        private void ChangeColor(string newColor)
        {
            if (color != newColor)
            {
                color = newColor;
            }
        }
        public bool IsTurningLeft()
        {
            return turn == TurnDirection.Left;
        }
        public bool IsTurningRight()
        {
            return turn == TurnDirection.Right;
        }
    }
    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }
}