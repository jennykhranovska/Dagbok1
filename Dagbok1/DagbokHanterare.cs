using Dagbok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagbok1
{
    internal class DagbokHanterare
    {
        public static void LäsDagbokFil(List<DiaryEntry> diaryEntries)
        {
            string filName = "minDagbok.txt";

            if (File.Exists(filName))
            {
                string[] delet = File.ReadAllLines(filName);
                foreach (var line in delet)
                {
                    var parts = line.Split('|');
                    DateTime date = DateTime.Parse(parts[0]);
                    string text = parts[1];

                    DiaryEntry entry = new DiaryEntry
                    {
                        Date = date,
                        Text = text
                    };
                    diaryEntries.Add(entry);
                }
            }

            else
            {
                Console.WriteLine("Ingen sparad dagbok finns än.");
            }

        }
            public static void SparaDagbokFil(List<DiaryEntry> diaryEntries)
        {
            string filName = "minDagbok.txt";

            // Skapa en lista med rader i rätt format
            List<string> lines = new List<string>();

            foreach (var entry in diaryEntries)
            {
                // Format: "Datum|Text"
                lines.Add($"{entry.Date}|{entry.Text}");
            }

            // Skriv alla rader till filen (skriver över filen varje gång)
            File.WriteAllLines(filName, lines);
        }

    }
}
