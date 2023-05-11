public class CatFact
{
    
    public string? fact { get; set; }
    public string? length { get; set; }

    public int CheckEnter()
    {
         Console.WriteLine("Bitte nenne mir eine Zahl zwischen 1 und 10");
         int zahl = 0;
    try
    {
         zahl = System.Convert.ToInt32(Console.ReadLine());
      
      while (zahl<0|zahl >=10){
        Console.WriteLine("try again");
      zahl = System.Convert.ToInt32(Console.ReadLine());
      } 
    }
    catch (FormatException)
    {
        
        zahl = CheckEnter();
    }
    return zahl;
    }

    public void ConsoleBeide()
    {
    PasteConsole();
    PasteConsole2();
    }

    public void PasteConsole()
    {
    Console.WriteLine("---- Fact ----");
    Console.WriteLine(fact); 
    }

    public void PasteConsole2()
    {
    Console.WriteLine("---- Length ----");
    Console.WriteLine(length);
    
    }

}

