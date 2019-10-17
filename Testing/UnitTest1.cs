using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_1_Bartosz;
using System;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Title needs to be at least 2 characters long!")]
        public void TitleTest()
        {
            Book book = new Book();
            book.Title = "a";
        }

        [TestMethod]
        public void TitleTestSuccess()
        {
            Book book = new Book();
            try
            {
                book.Title = "xyz";
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Fail("There is no Exception!");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Page number need to be higher then 10 and lower or equal 1000!")]
        public void PageNumberTest()
        {
            Book book = new Book();
            book.PageNumber = 9;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Page number need to be higher then 10 and lower or equal 1000!")]
        public void PageNumberTest2()
        {
            Book book = new Book();
            book.PageNumber = 99999;
        }

        [TestMethod]
        public void PageNumberInRangeTest()
        {
            Book book = new Book();
            try
            {
                book.PageNumber = 11;
            }
            catch(ArgumentOutOfRangeException e)
            {
                Assert.Fail("There is an Exception!");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Isbn13 string needs to have exactly 13 characters!")]
        public void Isbn13Test()
        {
            Book book = new Book();
            book.Isbn13 = "asdasdasd";
        }

        [TestMethod]
        public void Isbn13Success()
        {
            Book book = new Book();
            try
            {
                book.Isbn13 = "xydfghjkl 4 3";
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Fail("There is an Exception!");
            }
        }



    }
}
