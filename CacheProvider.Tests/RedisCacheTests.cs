using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CacheProvider.Tests
{
    [TestClass]
    public class RedisCacheTests
    {
        [TestMethod]
        public void GetMen()
        {
            var sampleData = new SampleData();

            sampleData.GetMen(); // from source

            var res = sampleData.GetMen(); // from cache
            
            Assert.IsTrue(res.Count()==500);
        }
    }
}
