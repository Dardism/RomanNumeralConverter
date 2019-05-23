using System;

namespace RomanNumeralConverter{
  class Program {
    static void Main(string[] args) {

      int arabicNum = 0;
      string input = "";

      Console.WriteLine("Welcome to The Roman Numeral Converter. Enter a number less than 4000, or type 'q' to quit.");

      do {
        Console.Write("Enter a number: ");
        input = Console.ReadLine();

        if (!(int.TryParse(input, out arabicNum)) || (arabicNum < 1 || arabicNum > 3999)) {
          Console.WriteLine("Invalid entry. Must be between 1-3999.");
          continue;
        }

        Console.WriteLine(RomanConverter.toRoman(arabicNum));

      } while (input != "q");

      Environment.Exit(0);
    }
  }
}
