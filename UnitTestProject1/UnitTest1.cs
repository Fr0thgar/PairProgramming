using System.Collections.Generic;
using carsRESTprovider.Controllers;
using carsRESTprovider.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MusicRecordsController controller = new MusicRecordsController();
        [TestMethod]
        public void TestMethodGet()
        {
            List<MusicRecord> list = new List<MusicRecord>();

            foreach (MusicRecord music in controller.Get())
            {
                list.Add(music);
            }

            Assert.AreEqual(4, list.Count);

        }
    }
}
