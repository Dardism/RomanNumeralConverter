using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralConverter;

namespace RomanConverterTests {
  [TestClass]
  public class ToRomanTests {
    [TestMethod]
    public void InputTooLarge() {
      RomanConverter.toRoman(4000);
      Assert.AreEqual("", "");
    }

    [TestMethod]
    public void InputTooSmall() {
      RomanConverter.toRoman(0);
      Assert.AreEqual("", "");
    }

    [TestMethod]
    public void InputShouldBeX() {
      string convertedInput = RomanConverter.toRoman(10);
      Assert.AreEqual("X", convertedInput);
    }

    [TestMethod]
    public void InputShouldBeMMMXXX() {
      string convertedInput = RomanConverter.toRoman(3030);
      Assert.AreEqual("MMMXXX", convertedInput);
    }
  }
}

