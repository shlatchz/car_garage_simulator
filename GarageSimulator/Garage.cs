using GarageCars;
using GarageJobs;
using GarageJobs.Types;
using System.Collections.Generic;
using System.Reflection;
using System;
using System.Linq;

namespace GarageSimulator
{
    public sealed class Garage
    {
        private List<IJob> availableJobs;
        private IGarageLog logger;

        public Garage(IGarageLog logger)
        {
            availableJobs = new List<IJob>();
            this.logger = logger;
            InitGarage();
        }
        private void InitGarage()
        {
            availableJobs.Add(new PaintRed());
            availableJobs.Add(new PaintBlue());
            availableJobs.Add(new LowerCaseName());
            availableJobs.Add(new FullyFuel());
            availableJobs.Add(new PaintBlueLowerCaseFullyFuel());

            /*
            // Loading jobs without changing InitGarage method:

            const string ASSEMBLY_NAME = "GarageJobs";
            const string NAMESPACE = "Types";
            Assembly assembly = Assembly.Load(Assembly.GetExecutingAssembly().GetReferencedAssemblies().Where(w => w.Name == ASSEMBLY_NAME).First());
            availableJobs = assembly.GetTypes()
                .Where(w => w.IsClass && w.Namespace == $"{ASSEMBLY_NAME}.{NAMESPACE}")
                .Select(s => Activator.CreateInstance(s))
                .OfType<IJob>().ToList();
           */
        }
        public List<string> GetGarageJobs() => availableJobs.Select(s => s.GetJobName()).ToList();
        public void RunJob(Car car, int jobId)
        {
            IJob job = availableJobs[jobId - 1];
            logger.Log($"Initial state of car:\n {car.ToString()}");
            job.Execute(car);
            logger.Log($"Ran job \"{job.GetJobName()}\" on car with outcome:\n {car.ToString()}");
        }
    }
}
