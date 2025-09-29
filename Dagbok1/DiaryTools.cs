using Dagbok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dagbok1
{
    internal class DiaryTools
    {
        public static void HanteraVal1(List<DiaryEntry> diaryEntries)

        {

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Skriv din anteckning:");
            Console.ResetColor();
            string text = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Anteckningen får inte vara tom.");
            }
            else
            {

                DiaryEntry newEntry = new DiaryEntry
                {
                    Date = DateTime.Now,
                    Text = text
                };

                diaryEntries.Add(newEntry);
                Console.WriteLine("Anteckningen sparades!");
            }
        }


        public static void VisaAllaAnteckningar(List<DiaryEntry> diaryEntries) // 
        {
            if (diaryEntries.Count == 0)
            {
                Console.WriteLine("Det finns inga anteckningar ännu.");
            }
            else
            {
                Console.WriteLine("Alla anteckningar:");
                foreach (var entry in diaryEntries)
                {
                    Console.WriteLine($"{entry.Date}: {entry.Text}");
                }
            }
        }

    

public static void ShowDate(List<DiaryEntry> diaryEntries)
        {
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
        }
    }
}