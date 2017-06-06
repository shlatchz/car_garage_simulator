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
        private string name;
        public string Name { get { return name; } }
        private Color color;
        public Color Color { get { return color; } }
        private int fuelTank;
        public int FuelTank { get { return fuelTank; } }

        protected Car(string name, Color color, int fuelTank)
        {
            this.name = name;
            this.color = color;
            this.fuelTank = fuelTank;
        }
        public void AddFuel(int addFuel)
        {
            fuelTank = FuelTank + addFuel < 100 ? FuelTank + addFuel : 100;
        }
        public void ChangeColor(Color newColor)
        {
            color = newColor;
        }
        public void ChangeName(string newName)
        {
            name = newName;
        }
        public override string ToString()
        {
            return $"\tName: {Name}\n" +
                   $"\tColor: {Color}\n" +
                   $"\tFuel Tank: {FuelTank}";
        }
    }
}
