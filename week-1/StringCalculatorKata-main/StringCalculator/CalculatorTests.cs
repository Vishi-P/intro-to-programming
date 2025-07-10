

using NSubstitute.Routing.Handlers;

namespace StringCalculator;
public class CalculatorTests
{
    // Number 1
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    // Number 2
    [Theory]
    [InlineData("2", 2)]
    [InlineData("3", 3)]
    [InlineData("4", 4)]
    public void StringWithSingleInteger(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    // Number 3
    [Theory]
    [InlineData("2,2", 4)]
    [InlineData("2,3", 5)]
    [InlineData("4,4", 8)]
    public void StringWithTwoIntegers(string values, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(values);
        Assert.Equal(expected, result);
    }

    // Number 4
    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("1,2,3", 6)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void StringWithArbitraryLength(string values, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(values);
        Assert.Equal(expected, result);
    }

    // Number 5
    [Theory]
    [InlineData("1\n2", 3)]
	[InlineData("1\n2,3",6)]
    public void MixDelimters(string values, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(values);
        Assert.Equal(expected, result);
    }

    // Number 6
    [Theory]
    [InlineData("//#\n1#2#3", 6)]
    [InlineData("//#\n1#2,3\n1", 7)]
    public void CustomDelimiters(string values, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(values);
        Assert.Equal(expected, result);
    }
}
