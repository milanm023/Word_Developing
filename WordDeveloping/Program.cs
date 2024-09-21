using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    public static string? output;
    private static void Main(string[] args)
    {
        while (true)
        {
            string? input = Console.ReadLine();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string[] inputArray = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            string command = inputArray[0];
            if (Equals(input, "End"))
            {
                break;
            }
            else if (Equals(input, "Print"))
            {
                Console.WriteLine(output);
            }
            else
            {
                if (Equals(command, "Add"))
                {
                    output = inputArray[1];
                }
                else if (Equals(command, "Upgrade"))
                {
                    Upgrade(inputArray[1][0]);
                }
                else if (Equals(command, "Remove"))
                {
                    Remove(inputArray[1]);
                }
                else if (Equals(command, "Index"))
                {
                    FindIndexes(inputArray[1][0]);
                }
            }
        }



    }

    public static void Upgrade(char letter)
    {
        int n = letter + 1;
        char newLetter = (char)n;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        output = output.Replace(letter, newLetter);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
    public static void Remove(string substring)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.

#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }

    public static void FindIndexes(char letter)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        for (int i = 0; i < output.Length; i++)
        {
            if (output[i] == letter)
            {
                int index = output[i];
                Console.Write($"{index} ");
            }
        }
        Console.WriteLine();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

    }
}