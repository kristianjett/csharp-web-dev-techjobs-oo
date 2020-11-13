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
    }
}
