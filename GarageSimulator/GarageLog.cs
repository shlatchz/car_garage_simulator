using System;

namespace GarageSimulator
{
    public sealed class GarageLog : IGarageLog
    {
        public void Log(string message)
        {
            Console.WriteLine($"[{ DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}] {message}");
        }
    }
}
