using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactManager.Models;

namespace ContactManager.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRandomContactGenerator()
        {

            var contactArray = new Contact[100];
            contactArray = RandomContactGenerator.ContactGenerator();
            Assert.AreEqual("John4", contactArray[4].FirstName);

         
        }
    }
}
