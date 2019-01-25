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

            #region WCF及使用方法
            WCFTest.WCFClient wCFClient = new WCFTest.WCFClient();
            try
            {
                string s1 = wCFClient.DoWork();
                int i2 = wCFClient.Plus(12, 23);
                wCFClient.Close();
            }
            catch (Exception ex)
            {
                if (wCFClient != null)
                {
                    wCFClient.Abort();
                }
                Console.WriteLine(ex.Message);
            } 
            #endregion

        }
    }
}
