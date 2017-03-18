using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CacheProvider.Tests
{
    [TestClass]
    public class LocalMemoryCacheTests
    {
        [TestMethod]
        public void GetPeople()
        {
            var sampleData = new SampleData();

            sampleData.GetPeople(); // from source

            var res=sampleData.GetPeople(); // from cache

            Assert.IsTrue(res.Count() == 1000);
        }
    }
}
