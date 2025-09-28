namespace Dagbok1
{
        internal class Program
        {



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
                    string input = Console.ReadLine();

                    switch (input)
                    {






                    }
                    List<DiaryEntry> diaryEntries = new List<DiaryEntry>();










                }
            }
        }
    }


