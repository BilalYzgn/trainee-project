using Flurl;
using Flurl.Http;

CatFact catFact1 = await "https://catfact.ninja/fact".GetJsonAsync<CatFact>();
Console.WriteLine(catFact1.fact);
