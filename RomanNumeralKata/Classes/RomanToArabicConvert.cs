public class RomanToArabicConvert : INumConvertType
{
    private char currentRomanChar;
    private int newNumber;
    private Dictionary<string, int> revDict;
    public string RunConverter(string ValueToConvert, SetDictionaryObj Dict)
    {
        if (!Validate.isValidRomanNum(ValueToConvert))
            Validate.RunInCorrectArgs(ValueToConvert);

        revDict = Dict.SelectedDict.ToDictionary(pair => pair.Value, pair => pair.Key);
        for (int i = 0; i < ValueToConvert.Length; i++)
        {
            currentRomanChar = ValueToConvert[i];
            revDict.TryGetValue(currentRomanChar.ToString(), out int currentCharNum);
            if (i + 1 < ValueToConvert.Length && revDict[currentRomanChar.ToString()] < revDict[ValueToConvert[i + 1].ToString()])
                newNumber -= currentCharNum;
            else
                newNumber += currentCharNum;
        }
        return newNumber.ToString();
    }
}

