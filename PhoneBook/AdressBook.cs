using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class AdressBook
    {
        private AdressEntry[] entries;
        public AdressBook(int size)
        {
            entries = new AdressEntry[size];
        }
        public void AddEntry(string name, string adress, int rating)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] == null)
                {
                    AdressEntry entry = new AdressEntry(name, adress, rating);
                    entries[i] = entry;
                    Console.WriteLine("Entry has been added successfully!");
                    return;
                }
            }
            Console.WriteLine("Address book is full!");
        }
        public void DeleteEntry(int id)
        {
            if (id >= 1 && id <= entries.Length)
            {
                entries[id - 1] = null;
                Console.WriteLine($"Entry with ID [{id}] was deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Entry with ID [{id}] does not exist!");
            }
        }
        
        public void PrintAllEntries()
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] != null)
                {
                    Console.WriteLine($"ID: [{i + 1}]");
                    entries[i].Print();
                }
            }
        }
    }
}
