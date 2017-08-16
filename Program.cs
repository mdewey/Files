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

            using (var writer = new StreamWriter(File.Open("contacts.csv", FileMode.OpenOrCreate)))
            {
                // write all the contacts to a file
                phoneBook.ForEach(person => writer.WriteLine(person));
            }

            var phoneFromFile = new List<Contact>();

            // read from a contact book (a file)
            using (var reader = new StreamReader(File.Open("contacts.csv", FileMode.OpenOrCreate)))
            {
               // read all the contacts from the file
                while (reader.Peek() >= 0)
                {
                    var contactFromFile = reader.ReadLine();
                    // ideal world, this would an object, of our Contact 
                    var data = contactFromFile.Split(',');
                    phoneFromFile.Add(new Contact(data));
                }                
            }
            phoneFromFile.ForEach(person => Console.WriteLine(person));

        }
    }
}
