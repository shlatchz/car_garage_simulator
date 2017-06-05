using GarageCars;

namespace GarageJobs.Types
{
    public class PaintBlueLowerCaseFullyFuel : IJob
    {
        private JobSequence jobSeq;
        public PaintBlueLowerCaseFullyFuel()
        {
            jobSeq = new JobSequence(new IJob[] 
            {
                new PaintBlue(),
                new LowerCaseName(),
                new FullyFuel()
            });
        }
        public string GetJobName() => jobSeq.GetJobName();
        public void Execute(Car car) => jobSeq.Execute(car);
    }
}
