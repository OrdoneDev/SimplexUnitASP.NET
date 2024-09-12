using Exec1.Model;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void TesteSoma() => Assert.Equal(30, Calculadora.Somar(14, 16));
}