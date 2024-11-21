using TS_lab1.Core;
using System;
using Xunit;

namespace TS_lab1;

public class OperationsTests
{
    private readonly Operations _operations = new Operations();


    [Fact]
    public void TestSubtractTwoNumbers()
    {
        var result = _operations.Subtract(5, 3);
        Assert.Equal(2, result);
    }

}
