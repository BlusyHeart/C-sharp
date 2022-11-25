
using System;
using System.Collections.Generic;
using System.Linq;

namespace StreeRacing
{
    class StartUp
    {
        static void Main()
        {
            Queue<int> guestValues = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> plateValues = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedGrams = 0;
            int currentGuestValue = 0;
            while (true)
            {

                if (guestValues.Count == 0 || plateValues.Count == 0)
                {
                    break;
                }

                currentGuestValue = guestValues.Peek();

                while (currentGuestValue > 0)
                {
                    if (currentGuestValue - plateValues.Peek() > 0)
                    {
                        currentGuestValue -= plateValues.Peek();
                        plateValues.Pop();
                    }
                    else if (currentGuestValue - plateValues.Peek() <= 0)
                    {
                        wastedGrams += plateValues.Peek() - currentGuestValue;
                        guestValues.Dequeue();
                        plateValues.Pop();
                        currentGuestValue = 0;
                    }
                }
            }

            if (guestValues.Count > 0)
            {
                Console.WriteLine($"Guests: {String.Join(" ", guestValues)}");
            }
            else if (plateValues.Count > 0)
            {
                Console.WriteLine($"Plates: {String.Join(" ", plateValues)}");
            }
            Console.WriteLine($"Wasted grams of food: {wastedGrams}");
        }
    }
}
