using GarageCars;

namespace GarageJobs.Types
{
    public sealed class LowerCaseName : IJob
    {
        private const string jobName = "Rename to Lower Case";
        public string GetJobName() => jobName;
        public void Execute(Car car) => car.ChangeName(car.Name.ToLower());
    }
}
