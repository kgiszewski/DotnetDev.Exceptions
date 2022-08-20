namespace DotNetDev.Api;

public interface IMyService
{
    int DoSomething(string input);
    int DoSomethingElse(string input);
}

public class MyService : IMyService
{
    private readonly IMyCalculator _myCalculator;

    public MyService(IMyCalculator myCalculator)
    {
        _myCalculator = myCalculator;
    }
    
    public int DoSomething(string input)
    {
        return _myCalculator.ConvertToInt(input);
    }
    
    public int DoSomethingElse(string input)
    {
        return _myCalculator.ConvertToIntOrThrow(input);
    }
}