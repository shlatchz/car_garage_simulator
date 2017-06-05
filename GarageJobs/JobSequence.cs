using GarageCars;
using System.Collections.Generic;
using System.Linq;

namespace GarageJobs
{
    public sealed class JobSequence : IJob
    {
        private List<IJob> jobSequence;
        private string jobName;

        public JobSequence(IJob job) {
            jobSequence = new List<IJob>();
            jobSequence.Add(job);
            jobName = job.GetJobName();
        }
        public JobSequence(IJob[] jobs)
        {
            jobSequence = new List<IJob>(jobs);
            // Add an ampersand between the bulk jobs' name.
            jobName = string.Join(" & ", jobs.Select(s => s.GetJobName()));
        }
        public JobSequence AddJob(IJob job) {
            jobSequence.Add(job);
            // Add an ampersand between the bulk jobs' name.
            jobName += $" & {job.GetJobName()}";
            return this;
        }
        public string GetJobName() => jobName;
        public void Execute(Car car) => jobSequence.ForEach(job => job.Execute(car));
    }
}
