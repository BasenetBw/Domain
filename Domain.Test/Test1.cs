using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test
{ 
    [TestFixture]
    public class Test1
    {
        NumberCalculator nc;
        
        [TestFixtureSetUp]
        public void Init()
        {
            nc = new NumberCalculator(100, 100);
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            nc = null;
        }

        [Test]
        public void AddTwoNumber()
        {
            
            Assert.AreEqual(200, nc.AddNumber());
        }


        [Test]
        public void MultiplyTwoNumber()
        {
            var result = 2 * 3;
            Assert.AreEqual(6, result);
        }
        [Test]
        public void Grouping_List_of_One_by_One_Produces_groupOfOne()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement() { HighValue =10, LowValue = 1}
            };
            
            var grouper = new SizeGrouper(10);
            var groupedResultes = grouper.Group(measurements);

            Assert.AreEqual(1, groupedResultes.Count);

        }

        [Test]
        public void TestOneAfterGitHubUpload()
        {
            var name = "john";
            Assert.AreEqual("john", name);
        }

        [Test]
        public void TestOneNumberEqualsAnother()
        {
            var number = 7;
            Assert.AreEqual(7, number);
        }

    }
}
