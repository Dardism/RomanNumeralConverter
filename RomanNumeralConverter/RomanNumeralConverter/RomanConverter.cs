using System.Collections.Generic;

namespace RomanNumeralConverter{
  public static class RomanConverter {

    private static readonly Dictionary<int, string> romanNumerals = new Dictionary<int, string>
                                      {
                                        {1000,"M"},{900,"CM"},{500,"D"},{400,"CD"},
                                        {100,"C"},{90,"XC"},{50,"L"},{40,"XL"},
                                        {10,"X"},{9,"IX"},{5,"V"},{4,"IV"},{1,"I"}
                                      };

    //Converts from arabic numbers to Roman Numerals
    public static string toRoman(int num) {
      string romanConversion = "";

      while (num > 0) {
        foreach (var RomanNumPair in romanNumerals) {
          if (num / RomanNumPair.Key >= 1) {
            romanConversion += RomanNumPair.Value;
            num -= RomanNumPair.Key;
            break;
          }
        }
      }
      return romanConversion;
    }
  }
}
