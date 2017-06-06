using GarageCars;

namespace GarageJobs.Types
{
    public sealed class PaintBlue : IJob
    {
        private const string jobName = "Paint Blue";
        public string GetJobName() => jobName;
        public void Execute(Car car) => car.ChangeColor(Color.Blue);
    }
}
