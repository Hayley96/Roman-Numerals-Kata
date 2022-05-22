public class NumeralConverter
{
    public INumConvertType convertType { get; private set; }

    public NumeralConverter(INumConvertType numConvertType)
    {
        convertType = numConvertType;
    }   
}