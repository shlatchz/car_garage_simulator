using GarageCars;

namespace GarageJobs.Types
{
    public sealed class FullyFuel : IJob
    {
        private const string jobName = "Fully Fuel Tank";
        public string GetJobName() => jobName;
        public void Execute(Car car) => car.AddFuel(100 - car.FuelTank);
    }
}
