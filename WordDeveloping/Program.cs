﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    public static string output = string.Empty;
    private static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
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
        output = output.Replace(letter, newLetter);
    }
    public static void Remove(string substring)
    {
        if (output.Contains(substring))
        {
            output = output.Replace(substring, string.Empty);
        }
    }

    public static void FindIndexes(char letter)
    {

        if (!output.Contains(letter))
        {
            Console.WriteLine("None");
        }
        else
        {
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == letter)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

    }
}