using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // read text

        string text = Console.ReadLine();

        // initialize sortedDictionary

        SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

        // iterate through text

        TextIterator(text, symbols);
        PrintSymbols(symbols);

    }

    private static void PrintSymbols(SortedDictionary<char, int> symbols)
    {
        foreach (KeyValuePair<char, int> symbol in symbols)
        {
            Console.WriteLine($"{symbol.Key}: {symbol.Value} times/s");
        }
    }

    private static void TextIterator(string text, SortedDictionary<char, int> symbols)
    {
        for (int i = 0; i < text.Length; i++)
        {
            // check if symbol exist in symbols
            char curentSymbol = text[i];
            CheckSymbol(symbols, curentSymbol);
            // add counter
            symbols[curentSymbol] += 1;
        }
    }

    private static void CheckSymbol(SortedDictionary<char, int> symbols, char curentSymbol)
    {
        if (!symbols.ContainsKey(curentSymbol)) 
        {
            symbols.Add(curentSymbol, 0);
        }
    }
}
