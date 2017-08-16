namespace Files
{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        public override string ToString()
        {
            return $"{Name},{Email},{PhoneNumber}";
        }
        public Contact()
        {

        }
        public Contact(string[] data)
        {
            Name = data[0];
            Email = data[1];
            PhoneNumber = data[2];

        }
    }
}