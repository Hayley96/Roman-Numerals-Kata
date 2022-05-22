string result;
SetDictionaryObj dict = new();
NumeralConverter numConv;

dict = new(new ArabicToRomanDict());
numConv = new(new ArabicToRomanConvert());
result = numConv.convertType.RunConverter("500", dict);
Console.WriteLine(result);


dict = new(new RomanToArabicDict());
numConv = new(new RomanToArabicConvert());
result = numConv.convertType.RunConverter("MDIV", dict);
Console.WriteLine(result);
