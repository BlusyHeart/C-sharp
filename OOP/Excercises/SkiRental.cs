using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    internal class SkiRental
    {
        
        public SkiRental(string name, int capacity)
        {
            Data = new List<Ski>();
            Name = name;
            Capacity = capacity;           
        }

        public int Count
        {
            get { return Data.Count; }
        }

        public static List<Ski> Data { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public void Add(Ski ski)
        {
            if (Capacity >= Data.Count + 1)
            {
                Data.Add(ski);
            }          
        }

        public bool Remove(string manufacturer, string model)
            => Data.Remove(Data.Find(x => x.Manufacturer == manufacturer && x.Model == model));

        public Ski GetNewestSki() => Data.OrderByDescending(x => x.Year).FirstOrDefault();

        public Ski GetSki(string manufacturer, string model)
            => Data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The skis stored in {Name}:");
            sb.Append(string.Join(Environment.NewLine, Data));
            return sb.ToString();
        }

       
    }
}
