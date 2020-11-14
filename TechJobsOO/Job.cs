using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string jobName;
            string jobEmployer;
            string jobLocation;
            string jobType;
            string jobCompetency;
            string noData = "Data not available";
            int noJob = 0;

            if(Name == null || Name == "")
            {
                jobName = noData;
                noJob++;
            }
            else
            {
                jobName = Name;
            }

            if(EmployerName == null || EmployerName.Value == "")
            {
                jobEmployer = noData;
                noJob++;
            }
            else
            {
                jobEmployer = EmployerName.Value;
            }

            if(EmployerLocation == null || EmployerLocation.Value == "")
            {
                jobLocation = noData;
                noJob++;
            }
            else
            {
                jobLocation = EmployerLocation.Value;
            }

            if(JobType == null || JobType.Value == "")
            {
                jobType = noData;
                noJob++;
            }
            else
            {
                jobType = JobType.Value;
            }

            if(JobCoreCompetency == null || JobCoreCompetency.Value == "")
            {
                jobCompetency = noData;
                noJob++;
            }
            else
            {
                jobCompetency = JobCoreCompetency.Value;
            }

            string jobInfo = $"\nID: {Id}\nName: {jobName}\nEmployer: {jobEmployer}\nLocation: {jobLocation}\nPosition Type: {jobType}\nCore Competency: {jobCompetency}\n";

            if (noJob == 5)
            {
                jobInfo = "OOPS! This job does not seem to exist.";
            }

            return jobInfo;
        }

    }
}
