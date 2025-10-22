using System;
using System.Collections.Generic;
class Vowels
{
    public static void Main()
    {
        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', };
        Console.WriteLine("Enter a string");
        string word = Console.ReadLine();
        int count = 0;
        foreach (char v in word)
        {
            if(vowels.Contains(v))
            {  count++; }

            
            
        }
        Console.WriteLine($"There are {count} vowels in your word");
    }
}