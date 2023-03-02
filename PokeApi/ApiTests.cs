namespace PokeApi;

using RestSharp;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Get_Pokemon_by_name()
    {
        var client = new RestClient();
        var request = new RestRequest("https://pokeapi.co/api/v2/pokemon/clefairy/", Method.Get);
        var response = client.ExecuteAsync(request).Result;
        
        Assert.That(response, Is.Not.Zero);
    }
}
