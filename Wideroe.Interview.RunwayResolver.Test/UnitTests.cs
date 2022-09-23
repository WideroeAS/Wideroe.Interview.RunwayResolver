namespace Wideroe.Interview.RunwayResolver.Test;

public class UnitTests
{
    [Fact]
    public void TaskA()
    {
        var expected = 0;

        var actual = Program.Runway();

        Assert.Equal(expected, actual);
    }
}