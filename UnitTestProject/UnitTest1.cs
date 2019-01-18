using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient())
            {
                string result = client.HelloWorld();
                Assert.AreEqual("Hello World",client.HelloWorld());
            }
        }
    }
}
