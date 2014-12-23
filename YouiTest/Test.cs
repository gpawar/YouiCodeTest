using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouiCodeTest;

namespace YouiTest
{
    [TestClass]
    public class Test
    {
        private readonly YouiFileProcessor _youiFileProcessor;
        public Test()
        {
            _youiFileProcessor = new YouiFileProcessor(@"C:\test.txt");
        }
        [TestMethod]
        public void TestForFileExistance()
        {
           
        }
    }
}
