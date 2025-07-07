
namespace References.Tests;

public class AddingNumbers
{
    [Fact]
    public void CanAddTwoNumbers()
    {
        // Given
        int a = 10;
        int b = 20;
        int answer;

        // When
        answer = a + b;

        // Then
        // Answer should be 30
        Assert.Equal(30, answer);
        // This is a simple example, even though it's stupid
    }
}
