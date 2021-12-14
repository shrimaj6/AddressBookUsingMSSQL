using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUsingLINQ
{
    public class AddressBookModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Int64 Zip { get; set; }
        public Int64 Phone_No { get; set; }
       
        public string Email { get; set; }
        
    }
}
