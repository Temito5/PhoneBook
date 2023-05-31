using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the adress book: ");
            int size = int.Parse(Console.ReadLine());
            AdressBook adressBook = new AdressBook(size);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select an option:");
                Console.WriteLine("(1) [Add entry]");
                Console.WriteLine("(2) [Delete entry]");
                Console.WriteLine("(3) [Print entries]");
                Console.WriteLine("(4) [Exit]");
                Console.WriteLine();

                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter adress: ");
                        string adress = Console.ReadLine();
                        Console.Write("Enter rating: ");
                        int rating = int.Parse(Console.ReadLine());
                        adressBook.AddEntry(name, adress, rating);
                        break;
                    case 2:
                        Console.WriteLine("Enter the ID of the entry to delete:");
                        int deleteId = int.Parse(Console.ReadLine());
                        adressBook.DeleteEntry(deleteId);
                        break;
                    case 3:
                        adressBook.PrintAllEntries();
                        break;
                    case 4:
                        return;
                }
                Console.WriteLine();
            }
        }
    }
}
