using System;
namespace upg4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande");
            string meddelande = Console.ReadLine();

            Console.WriteLine("Hur många mellanslag ifrån kanten ska det vara?");
            int spaces = int.Parse(Console.ReadLine());

            for (int i = 0; i < meddelande.Length; i++)
            {
                if (spaces > 0)
                {
                    for (int j = 1; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine(meddelande[i]);
            }
        }
    }
}