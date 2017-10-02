using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string mailAddress;

        public string MailAddress
        {
            get { return mailAddress; }
            set { mailAddress = value; }
        }

        public Contact(string firstName, string lastName, string mailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            MailAddress = mailAddress;
        }

        



    }
}
