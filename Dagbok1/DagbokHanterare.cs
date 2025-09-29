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
        public static void LäsDagbokTillFil(List<DiaryEntry> diaryEntries)
        {
            string filName = "minDagbok.txt";

            diaryEntries.Clear();

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

        }
        public static void SparaDagbokFil(List<DiaryEntry> diaryEntries)
        {
            string filName = "minDagbok.txt";

            List<string> lines = new List<string>();

            foreach (var entry in diaryEntries)
            {

                lines.Add($"{entry.Date}|{entry.Text}");
            }

            File.WriteAllLines(filName, lines);
        }



        public static void ReadDiary(List<DiaryEntry> diaryEntries)
        {
            DagbokHanterare.LäsDagbokTillFil(diaryEntries);
            if (diaryEntries.Count > 0)
            {
                Console.WriteLine("Alla anteckningar från filen:");
                foreach (var entry in diaryEntries)
                {
                    Console.WriteLine($"{entry.Date}: {entry.Text}");
                }
            }
            else
            {
                Console.WriteLine("Ingen sparad dagbok finns än.");
            }
        }


        public static void SaveDiary(List<DiaryEntry> diaryEntries)
        {
            try
            {
                DagbokHanterare.SparaDagbokFil(diaryEntries);
                Console.WriteLine("Dagboken har sparats till fil.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fel vid sparande: " + ex.Message);
            }

        }
    }
}