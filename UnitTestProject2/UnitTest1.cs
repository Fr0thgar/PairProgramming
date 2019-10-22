using Microsoft.VisualStudio.TestTools.UnitTesting;
using carsRESTprovider;
using carsRESTprovider.Controllers;
using carsRESTprovider.model;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MusicRecordsController musicRecordsController = new MusicRecordsController();

            musicRecordsController.Post(new MusicRecord());

            Assert.Fail();
        }
    }
}
