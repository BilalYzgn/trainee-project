using Flurl;
using Flurl.Http;

CatFact catFact1 = await "https://catfact.ninja/fact".GetJsonAsync<CatFact>();
CatFact FactLength = await "https://catfact.ninja/fact".GetJsonAsync<CatFact>();
{
catFact1.PasteConsole(); 
} 
  int loop = catFact1.CheckEnter();
        for (int i = 0; i < loop; i++)
      {
        catFact1.ConsoleBeide(); 
      }  
