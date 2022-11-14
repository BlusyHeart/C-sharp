using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> reservations = new HashSet<string>();

        AddReservation(reservations);
        CheckedGuests(reservations);
        PrintMissedGuestsCount(reservations);

        // first VIP guests then regular
        PrintMissedGuests(reservations);

    }

    private static void PrintMissedGuestsCount(HashSet<string> reservations) => Console.WriteLine(reservations.Count);    
    private static void PrintMissedGuests(HashSet<string> reservations)
    {
        PrintVIP(reservations);
        PrintRegular(reservations);
    }

    private static void PrintRegular(HashSet<string> reservations)
    {
        foreach (string guest in reservations)
        {
            if (!char.IsDigit(guest[0]))
            {
                Console.WriteLine(guest);
            }
        }
    }

    private static void PrintVIP(HashSet<string> reservations)
    {
        foreach (string guest in reservations)
        {
            if (char.IsDigit(guest[0]))
            {
                Console.WriteLine(guest);
            }
        }
    }

    private static void CheckedGuests(HashSet<string> reservations)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                string guest = input;
                if (reservations.Contains(guest))
                {
                    reservations.Remove(guest);
                }
            }

        }
    }

    private static void AddReservation(HashSet<string> reservations)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "PARTY")
            {
                break;
            }
           
            else if (input.Length != 8)
            {
                continue;
            }
            else
            {
                reservations.Add(input);
            }
        }
    }
  
}
