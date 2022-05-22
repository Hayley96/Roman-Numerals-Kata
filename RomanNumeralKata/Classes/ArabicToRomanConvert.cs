public class ArabicToRomanConvert : INumConvertType
{
    private int _maxValue;
    private string _convertedResult = "";
    private const int _zeroValue = 0;
    public string RunConverter(string ValueToConvert, SetDictionaryObj Dict)
    {
        if ((!Validate.isValidArabicNum(ValueToConvert) || !Validate.isValidArabicNumRange(int.Parse(ValueToConvert))))
            Validate.RunInCorrectArgs(ValueToConvert);

        int inputNumToInt = int.Parse(ValueToConvert);

        do
        {
            _maxValue = Dict.SelectedDict.Where(x => x.Key <= inputNumToInt).Max(w => w.Key);
            _convertedResult += Dict.SelectedDict[_maxValue];
            inputNumToInt -= _maxValue;
        }
        while (inputNumToInt > _zeroValue);
        return _convertedResult;
    }
}

