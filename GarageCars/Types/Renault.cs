using System.Reflection;

namespace GarageCars.Types
{
    public enum RenaultSubType
    {
        Fluence,
        Meghane,
        Clio,
        Duster,
        Espace,
        Pulse
    }
    public sealed class Renault : Car
    {
        public Renault(RenaultSubType subType, Color color, int fuelTank) :
            base($"{MethodBase.GetCurrentMethod().DeclaringType.Name} {subType}", color, fuelTank)
        { }
    }
}
