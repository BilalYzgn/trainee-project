using Flurl;
using Flurl.Http;

string factAlsString = await "https://catfact.ninja/fact".GetStringAsync();
Console.WriteLine(factAlsString);