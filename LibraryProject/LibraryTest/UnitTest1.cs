using System;
using LibraryProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Checks if exception is thrown when attempting to checkout
        /// over the Adults checkout limit
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void AdultCheckOut_MaxCheckOutLimit()
        {
            // arrange
            Item media = new Item("title", false, "tom cruise", DateTime.Now, DateTime.Now);
            Adult person = new Adult("tom", "huck", 6);
            
            // Act - add one more item to person to checkout
            Assert.IsFalse(person.checkout(ref media));

        }
        /// <summary>
        /// Checks the ability to check out items
        /// </summary>
        [TestMethod]
        public void AdultCheckOut_Success_0ItemsTo2Item()
        {
            // arrange
            Item media = new Item("title", false, "tom cruise", DateTime.Now, DateTime.Now);
            Adult person = new Adult("tom", "huck", 0);
            person.checkout(ref media);
            
            // Act - add 1 item to person without any checked out items
            Assert.AreEqual(1, person.numberofItems);

        }
        /// <summary>
        /// Checks the ability to check out items
        /// </summary>
        [TestMethod]
        public void AdultCheckOut_Success_5ItemsTo6Item()
        {
            // arrange
            Item media = new Item("title", false, "tom cruise", DateTime.Now, DateTime.Now);
            Adult person = new Adult("tom", "huck", 5);
            person.checkout(ref media);

            // Act - add 1 item to person without any checked out items
            Assert.AreEqual(6, person.numberofItems);

        }

        [TestMethod]
        public void AdultCheckIn_Succes()
        {
            // arrange
            Item media = new Item("title", false, "tom cruise", DateTime.Now, DateTime.Now);
            Adult person = new Adult("tom", "huck", 1);

            // Act - add 1 item to person without any checked out items
            person.checkin(ref media);
            Assert.AreEqual(0, person.numberofItems);

        }
        /// <summary>
        ///  Test to ensure MAX data member in each function
        ///  is unchanged from orginal specifications
        /// </summary>
        [TestMethod]
        public void Items_MaxDays_check()
        {
            AdultBook a = new AdultBook();
            ChildBook c = new ChildBook();
            DVD d = new DVD();
            VHS v = new VHS();

            Assert.AreEqual(14, a.maxDays());
            Assert.AreEqual(7, c.maxDays());
            Assert.AreEqual(2, d.maxDays());
            Assert.AreEqual(3, v.maxDays());
        }
        /// <summary>
        /// Checks checkout validation for every class
        /// Every item classes
        /// </summary>
        [TestMethod]
        public void Item_CheckOutValidation()
        {
            AdultBook a = new AdultBook();
            ChildBook c = new ChildBook();
            DVD d = new DVD();
            VHS v = new VHS();

            a.checkout("Tom");
            c.checkout("Dick");
            d.checkout("Harry");
            v.checkout("Mickey");

            Assert.AreEqual("Tom", a.whoCheckedOut);
            Assert.AreEqual("Dick", c.whoCheckedOut);
            Assert.AreEqual("Harry", d.whoCheckedOut);
            Assert.AreEqual("Mickey", v.whoCheckedOut);



        }



    }
}
