public class SetDictionaryObj
{
    public Dictionary<int, string> SelectedDict { get; private set; }

    public SetDictionaryObj(INumeralDictionary dict) =>
        SelectedDict = (Dictionary<int, string>)dict.NumeralDict();

    public SetDictionaryObj() { }
}

