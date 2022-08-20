namespace DotNetDev.Api;

public interface IMyCalculator
{
    int ConvertToInt(string input);
    int ConvertToIntOrThrow(string input);
}

public class MyCalculator : IMyCalculator
{
    public int ConvertToInt(string input)
    {
        return int.TryParse(input, out var convertedInt) ? convertedInt : 0;
    }
    
    public int ConvertToIntOrThrow(string input)
    {
        if(int.TryParse(input, out var convertedInt))
        {
            return convertedInt;
        }

        throw new InvalidOperationException("Bad news!");
    }
}