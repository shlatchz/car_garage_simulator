using GarageCars;

namespace GarageJobs.Types
{
    public sealed class PaintRed : IJob
    {
        private const string jobName = "Paint Red";
        public string GetJobName() => jobName;
        public void Execute(Car car) => car.Color = Color.Red;
    }
}
