using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {

        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            Assert.IsFalse(testJob1.Id == testJob2.Id);
            Assert.AreEqual(testJob1.Id, (testJob2.Id - 1));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPosition = new PositionType("Quality Control");
            CoreCompetency testCompetency = new CoreCompetency("Persistence");

            Job testJob3 = new Job("Product Tester", testEmployer, testLocation, testPosition, testCompetency);

            Assert.AreEqual("Product Tester", testJob3.Name);
            Assert.AreEqual(testEmployer, testJob3.EmployerName);
            Assert.AreEqual(testLocation, testJob3.EmployerLocation);
            Assert.AreEqual(testPosition, testJob3.JobType);
            Assert.AreEqual(testCompetency, testJob3.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPosition = new PositionType("Quality Control");
            CoreCompetency testCompetency = new CoreCompetency("Persistence");

            Job testJob4 = new Job("Product Tester", testEmployer, testLocation, testPosition, testCompetency);

            Job testJob5 = new Job("Product Tester", testEmployer, testLocation, testPosition, testCompetency);

            Assert.IsFalse(testJob4.Equals(testJob5));
        }

        [TestMethod]
        public void TestJobsToStringHasBlankLines()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPosition = new PositionType("Quality Control");
            CoreCompetency testCompetency = new CoreCompetency("Persistence");

            Job testJob6 = new Job("Product Tester", testEmployer, testLocation, testPosition, testCompetency);

            Assert.IsTrue(testJob6.ToString().StartsWith("\n"));
            Assert.IsTrue(testJob6.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestJobsToStringDisplaysAllJobData()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPosition = new PositionType("Quality Control");
            CoreCompetency testCompetency = new CoreCompetency("Persistence");

            Job testJob7 = new Job("Product Tester", testEmployer, testLocation, testPosition, testCompetency);

            string stringToCompare = $"\nID: {testJob7.Id}\nName: Product Tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality Control\nCore Competency: Persistence\n";

            Assert.AreEqual(stringToCompare, testJob7.ToString());
        }

        [TestMethod]
        public void TestJobsToStringDisplaysEmptyItemMessage()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("");
            PositionType testPosition = new PositionType("Quality Control");
            CoreCompetency testCompetency = new CoreCompetency("Persistence");

            Job testJob8 = new Job("Product Tester", testEmployer, testLocation, testPosition, testCompetency);

            Assert.IsTrue(testJob8.ToString().Contains("Location: Data not available"));
        }

        [TestMethod]
        public void TestJobsToSrtingDisplaysEmptyMessage()
        {
            Job testJob9 = new Job();

            Assert.IsTrue(testJob9.ToString() == "OOPS! This job does not seem to exist.");
        }
    }
}
