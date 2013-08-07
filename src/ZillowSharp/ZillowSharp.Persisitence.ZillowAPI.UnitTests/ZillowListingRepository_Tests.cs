using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZillowSharp.Persistence.ZillowAPI;

namespace ZillowSharp.Persisitence.ZillowAPI.UnitTests
{
    [TestFixture]
    public class ZillowListingRepository_Tests
    {
        [Test]
        public void Test()
        {
            var result = new ZillowListingRepository("abc123")
                            .FindAll(1, 50);

            Assert.That(result.Count, Is.GreaterThan(0), string.Format("Total listings: '{0}'.)", result.Count));
        }
    }
}
