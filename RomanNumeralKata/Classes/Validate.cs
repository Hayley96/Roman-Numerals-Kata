using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
public class Validate
{
    public static void RunInCorrectArgs(string value, [CallerArgumentExpression("value")] string expression = "",
        string conditionExpression = "")
    {
        Console.WriteLine($"Incorrect input value: {value} passed in property {expression}");
        throw new ArgumentException($"Incorrect input value: {value} passed in property {expression}");
    }

    public static bool isValidArabicNum(string ValueToConvert) => ValueToConvert.All(char.IsDigit);

    public static bool isValidArabicNumRange(int ValueToConvert) =>
        (1 <= ValueToConvert && ValueToConvert <= 3000) ? true : false;

    public static bool isValidRomanNum(string ValueToConvert)
    {
        Regex rgValidRoman = new Regex(@"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
        return rgValidRoman.IsMatch(ValueToConvert);
    }
}
