using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodingTest
{
    [TestClass]
    public class NumberTest
    {
        [TestMethod]
        public void DecodeTest()
        {
            //arrange
            int number = 65;
            string Decode = "Это буква " + $"{(char)number}";
            //act
            coding.Numbers numbers = new coding.Numbers();
            numbers.Number = number;
            string actual = numbers.Decode();
            //assert
            Assert.AreEqual(Decode, actual);
        }
    }
}
