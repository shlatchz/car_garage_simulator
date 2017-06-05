using GarageCars;

namespace GarageJobs
{
    public interface IJob
    {
        string GetJobName();
        void Execute(Car car);
    }
}
