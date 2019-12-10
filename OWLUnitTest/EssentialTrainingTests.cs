using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OWL_Teams.Models;

namespace OWLUnitTest
{
    [TestClass]
    public class EssentialTrainingTests
    {
        [TestMethod]
        public void ModelTest()
        {
            var team1 = new Team
            {
                Name = "Test Team name",
                City = "Test City name",
                Id = 999
            };
            Assert.AreEqual("Test Team name", team1.Name, "I expect Team name to be 'Test Team name'");
            Assert.AreEqual("Test City name", team1.City, "I expect Team city to be 'Test City name'");
            Assert.AreEqual(999, team1.Id, "I expect Id to be '999'");
        }
    }
}
