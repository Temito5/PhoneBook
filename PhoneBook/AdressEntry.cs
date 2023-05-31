using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class AdressEntry
    {
        private string name;
        private string adress;
        private string phoneNumber;
        private int rating;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public AdressEntry(string name, string address, int rating)
        {
            this.Name = name;
            this.Adress = address;
            this.Rating = rating;
            Random random = new Random();
            this.PhoneNumber = "0" + random.Next(860000000, 900000000).ToString();
        }
        public void Print()
        {
            Console.WriteLine($"Name: [{this.Name}]");
            Console.WriteLine($"Address: [{this.Adress}]");
            Console.WriteLine($"Phone Number: [{this.PhoneNumber}]");
            Console.WriteLine($"Rating: [{this.Rating}]");
            Console.WriteLine();
        }
    }
}
