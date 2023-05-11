using Flurl;
using Flurl.Http;

CatFact catFact1 = await "https://catfact.ninja/fact".GetJsonAsync<CatFact>();
{
catFact1.PasteConsole(); 
}  
