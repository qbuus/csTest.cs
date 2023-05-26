namespace Project 
{ 
    class PhoneBook:IPhoneBook
    {
        public string Name {get; set;}
        public string Number {get; set;}

        public PhoneBook(string PersonName, string PersonNumber)
        {
            Name = PersonName;
            Number = PersonNumber;
        }

        public PhoneBook(PhoneBook newPerson)
        {
            this.newPerson = newPerson;
        }

        public List<PhoneBook> ListOfContact;
        private PhoneBook newPerson;

        public void InfoPerson(PhoneBook text)
        {
            Console.WriteLine($"FileName: {text.Name}, Number: {text.Number}");
        }
        public void AddContact(PhoneBook input)
        {
            ListOfContact.Add(input);
        }

        public void NumberCheck(string number) 
        {
            var Contact = ListOfContact.FirstOrDefault(c => c.Number == number);
            if (Contact == null) 
            {Console.WriteLine("is null");} 
            else {
                InfoPerson(Contact);
                }
        }

        public void ShowAllContacts()
        {
            foreach (PhoneBook item in ListOfContact)
            {
                InfoPerson(item);
            }
        }

        public void ShowByName(string name) {
            var Contact = ListOfContact.FirstOrDefault(c => c.Name == name);
            if (Contact == null) {
                Console.WriteLine("is null");
            } else {
                InfoPerson(Contact);
            }
        }

        public void RemoveAll() 
        {
            ListOfContact.Clear();
        }
    }
}