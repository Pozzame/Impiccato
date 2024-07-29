using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rng = new Random();
        string parola="";
        try
        {
            dynamic json = JsonConvert.DeserializeObject(File.ReadAllText(@"Lib.json"))!;
            parola = json[rng.Next(0, json.Count - 1)].Parola;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore: {ex.Message}");
        }
        
        Console.Clear();
        if (args.Length != 0 && args[0] == "-d") Console.WriteLine(parola);
        string lettereTrovate = "";
        int tentativi=0;
        while (true)
        {
            Console.WriteLine("---Indovina la parola---");
            Console.WriteLine("Prova la parola. :-D");
            foreach (char carattere in parola)
                if (lettereTrovate.Contains(carattere)) Console.Write(carattere); else Console.Write("_");
            Console.WriteLine();
            string tryParola = Console.ReadLine()!.ToLower();
            tentativi++;
            if (parola == tryParola) break;
            Console.WriteLine("Parola errata.");
            Console.WriteLine("Prova una lettera...");
            char lettera = char.ToLower(Console.ReadKey(true).KeyChar);
            Console.Clear();
            if (parola.Contains(lettera))
            {
                Console.WriteLine($"Presente {parola.Split(lettera).Length - 1} volte");
                lettereTrovate += lettera;
            }
            else
                Console.WriteLine("Non presente.");
        }
        Console.WriteLine($"Hai vinto in {tentativi} tentativi!!");
    }
}