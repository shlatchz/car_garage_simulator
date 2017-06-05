using System.Reflection;

namespace GarageCars.Types
{
    public enum FordSubType
    {
        Fiesta,
        Focus,
        Fusion,
        Mustang,
        Taurus
    }
    public sealed class Ford : Car
    {
        public Ford(FordSubType subType, Color color, int fuelTank) :
            base($"{MethodBase.GetCurrentMethod().DeclaringType.Name} {subType}", color, fuelTank)
        { }
    }
}
