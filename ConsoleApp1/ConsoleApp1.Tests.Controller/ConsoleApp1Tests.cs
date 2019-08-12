using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Tests.Controller
{
    [TestClass]
    public class ConsoleApp1Tests
    {
        [TestMethod]
        public void Caster_input_string20_output_int20()
        {
            //arrange
            string a = "20";
            int expected = 20;

            //act
           var actual = TypesConversion.ConvertValue<int>(a);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Caster_input_string20_2_output_double20_2()
        {
            //arrange
            string a = "20,2";
            double expected = 20.2;

            //act
            var actual = TypesConversion.ConvertValue<double>(a);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Caster_input_stringTrue_output_bool_true()
        {
            //arrange
            string a = "true";
            bool expected = true;

            //act
            var actual = TypesConversion.ConvertValue<bool>(a);

            //assert
            Assert.AreEqual(actual, expected);
        }

        public void Caster_input_stringOlolo_output_null()
        {
            //arrange
            string a = "ololo";
            int expected = 0;

            //act
            var actual = TypesConversion.ConvertValue<int>(a);

            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}
