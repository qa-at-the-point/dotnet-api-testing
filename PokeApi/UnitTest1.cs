namespace PokeApi;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        System.Console.WriteLine("Hello World!");
        Assert.That(true, Is.True);
    }
}
