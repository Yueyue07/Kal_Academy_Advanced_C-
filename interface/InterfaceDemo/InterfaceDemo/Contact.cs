using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Contact : IListable, IComparable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string[] ColumnNames
        {
            get
            {
                return new string[]
                {
                    FirstName, 
                    LastName, 
                    Address
                };
            }
        }

        public int CompareTo(object obj)
        {
            var otherContact = obj as Contact;
            // as will not throw exception instead return null
            // (Contact) obj will throw exception

            if (obj == null) // not convertable
            {
                return 1;
            }
            else if (obj.GetType() != typeof(Contact))
            {

                throw new ArgumentException(
                    $"The parameter is not type of {nameof(Contact)}", nameof(obj)
                    );
            }
            else if (Contact.ReferenceEquals(this, obj)) //  compare memory address
            {
                return 0;
            }
            else
            {
               return  LastName.CompareTo(otherContact.LastName);
            }
        }
    }
}
