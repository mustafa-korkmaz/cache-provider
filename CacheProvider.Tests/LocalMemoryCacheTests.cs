using System;
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

            sampleData.GetPeople(); // from cache
        }
    }
}
