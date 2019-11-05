using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        //public Author(string name,string email,string country)
        //{
        //    this.Name = name;
        //    this.Email = email;
        //    this.Country = country;
        //}
        public void Print()
        {
            Console.WriteLine($"Nume autor: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Country: {Country}");
        }

    }
}
