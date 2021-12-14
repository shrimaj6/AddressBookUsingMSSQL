using System;

namespace AddressBookUsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");
            AddressBookRepo repo = new AddressBookRepo();
            AddressBookModel AddressBook = new AddressBookModel();

            AddressBook.FirstName = "Shrimaj";
            AddressBook.LastName = "Mehta";
            AddressBook.Address = "33 north hope st";
            AddressBook.City = "Pune";
            AddressBook.State = "Maharashtra";
            AddressBook.Zip = 425408;
            AddressBook.Phone_No = 9834084341;
            AddressBook.Email = "shrimaj1@gmail.com";

            repo.AddAddressBooks(AddressBook);
        }
    }
}
