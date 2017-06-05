using GarageCars;
using GarageCars.Types;
using System;
using System.Collections.Generic;

namespace GarageSimulator
{
    class Program
    {
        private static Garage garage;
        private static IGarageLog logger;

        static void Main(string[] args)
        {
            logger = new GarageLog();
            garage = new Garage(logger);
            Car car = new Renault(RenaultSubType.Fluence, Color.White, 45);
            PrintJobs();
            Console.WriteLine();
            int jobId = SelectJob();
            Console.WriteLine();
            garage.RunJob(car, jobId);
            Console.ReadKey();
        }
        private static void PrintJobs()
        {
            Console.WriteLine("List of available jobs: ");
            List<string> jobs = garage.GetGarageJobs();
            int index = 1;
            jobs.ForEach(job => Console.WriteLine($"\t[{index++}] {job}"));
        }
        private static int SelectJob()
        {
            Console.Write("Please select a job: ");
            char input = (char)Console.Read();
            int selection = -1;
            int.TryParse(input.ToString(), out selection);
            return selection;
        }
    }
}
