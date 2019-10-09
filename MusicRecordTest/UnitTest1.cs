using System.Collections.Generic;
using carsRESTprovider.model;
using carsRESTprovider.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MusicRecordTest
{
    [TestClass]
    public class UnitTest1
    {
        private MusicRecordsController controller = new MusicRecordsController();
        [TestMethod]
        public void TestMethod1()
        {
            List<MusicRecord> temp = new List<MusicRecord>();
            int countfirst = temp.Count;

            foreach (MusicRecord m in controller.Get())
            {
                temp.Add(m);
            }
            Assert.AreNotEqual(countfirst, temp.Count);

            Assert.AreEqual(4, temp.Count);
        }
    }
}
