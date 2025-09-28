using Dagbok;

namespace Dagbok1
{
    internal class Program
    {

        static List<DiaryEntry> diaryEntries = new List<DiaryEntry>();

        static void Main(string[] args)
        {
            Console.WriteLine("------------");
            Console.WriteLine("Min dagbok");
            Console.WriteLine("-------------");

            while (true)
            {

                Console.WriteLine("\nVad vill du skriva om idag?");
                Console.WriteLine();
                Console.WriteLine("1. Skriv ny anteckning?");
                Console.WriteLine("2. Lista alla anteckningar?");
                Console.WriteLine("3. Sök anteckning på datum?");
                Console.WriteLine("4. Läs från fil");
                Console.WriteLine("5. Avsluta dagboken");

                Console.Write("\nDitt val: ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Skriv din anteckning: ");
                        string text = Console.ReadLine();
                        DiaryEntry newEntry = new DiaryEntry
                        {
                            Date = DateTime.Now,
                            Text = text
                        };
                        diaryEntries.Add(newEntry);
                        Console.WriteLine("Anteckning sparad!");
                        break;

                    case "2":
                        Console.WriteLine("Alla anteckningar:");
                        foreach (var entry in diaryEntries)
                        {
                            Console.WriteLine($"{entry.Date}: {entry.Text}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Ange datum (YYYY-MM-DD): ");
                        string dateInput = Console.ReadLine();
                        if (DateTime.TryParse(dateInput, out DateTime searchDate))
                        {
                            var foundEntries = diaryEntries.Where(e => e.Date.Date == searchDate.Date).ToList();
                            if (foundEntries.Any())
                            {
                                Console.WriteLine("Anteckningar för det datumet:");
                                foreach (var entry in foundEntries)
                                {
                                    Console.WriteLine($"{entry.Date}: {entry.Text}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Inga anteckningar hittades för det datumet.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt datumformat.");
                        }
                        break;
                    case "4":


                        Console.WriteLine("Funktionen för att läsa från fil är inte implementerad än.");
                        break;
                    case "5":


                        Console.WriteLine("Avslutar dagboken. Hej då!");
                        return;
                }
            }

        }
    }
}


    



