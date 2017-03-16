using System;
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

            sampleData.GetMen(); // from cache

      
        }
    }
}
