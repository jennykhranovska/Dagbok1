using Dagbok;

namespace Dagbok1
{
    internal class Program
    {

        static List<DiaryEntry> diaryEntries = new List<DiaryEntry>();

        static void Main(string[] args)
        {
            DagbokHanterare.LäsDagbokTillFil(diaryEntries);

            while (true)
            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("------------");
                Console.WriteLine("Min dagbok");
                Console.WriteLine("------------");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nVad vill du skriva om idag?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Skriv ny anteckning?");
                Console.WriteLine("2. Lista alla anteckningar?");
                Console.WriteLine("3. Sök anteckning på datum?");
                Console.WriteLine("4. Läs från fil");
                Console.WriteLine("5. Spara till fil");
                Console.WriteLine("6. Avsluta dagboken");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\nDitt val: ");
                Console.ResetColor();

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DiaryTools.HanteraVal1(diaryEntries);
                        Console.WriteLine("\nTryck på valfri tangent för att gå tillbaka till menyn...");
                        Console.ReadKey();
                        break;

                    case "2":
                        DiaryTools.VisaAllaAnteckningar(diaryEntries);
                        Console.WriteLine("\nTryck på valfri tangent för att gå tillbaka till menyn...");
                        Console.ReadKey();
                        break;

                    case "3":
                        DiaryTools.ShowDate(diaryEntries);
                        Console.WriteLine("\nTryck på valfri tangent för att gå tillbaka till menyn...");
                        Console.ReadKey();
                        break;

                    case "4":
                        DagbokHanterare.ReadDiary(diaryEntries);
                        Console.WriteLine("\nTryck på valfri tangent för att gå tillbaka till menyn...");
                        Console.ReadKey();
                        break;

                    case "5":
                        DagbokHanterare.SaveDiary(diaryEntries);
                        Console.WriteLine("\nTryck på valfri tangent för att gå tillbaka till menyn...");
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Avslutar dagboken. Hej då!");
                        return;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        Console.WriteLine("\nTryck på valfri tangent för att gå tillbaka till menyn...");
                        Console.ReadKey();
                        break;
                }
            }


        }
    }

}


    



