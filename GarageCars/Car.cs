namespace GarageCars
{
    public enum Color
    {
        Red,
        Blue,
        Green,
        Yellow,
        Black,
        White
    }
    public abstract class Car
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public int FuelTank { get; set; }

        protected Car(string name, Color color, int fuelTank)
        {
            Name = name;
            Color = color;
            FuelTank = fuelTank;
        }
        public override string ToString()
        {
            return $"\tName: {Name}\n" +
                   $"\tColor: {Color}\n" +
                   $"\tFuel Tank: {FuelTank}";
        }
    }
}
