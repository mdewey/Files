using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // Files!!!!
            // using statements

            // write a contact book  (a file)

            var bill = new Contact() { Email = "b@gmail.com", Name = "Bill", PhoneNumber = "123,123,1234" };

            var jenny = new Contact() { Email = "j@gmail.com", Name = "Jenny", PhoneNumber = "123-865-7309" };

            var susan = new Contact() { Email = "s@gmail.com", Name = "Susan", PhoneNumber = "555.555.5555" };

            var phoneBook = new List<Contact> { bill, jenny, susan };

            using (var writer = new StreamWriter(File.Open("contacts.txt", FileMode.OpenOrCreate)))
            {
                writer.WriteLine("Hello there file!!! the random number is" + new Random().Next(1,21));

            }

            // read from a contact book (a file)
            using (var reader = new StreamReader(File.Open("contacts.txt", FileMode.OpenOrCreate)))
            {
                var text = reader.ReadLine();
                Console.WriteLine(text);

            }


        }
    }
}
