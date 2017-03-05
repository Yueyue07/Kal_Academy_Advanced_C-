using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new Contact[3]{
                new Contact {
                    FirstName = "Sue",
                    LastName = "Johnson",
                    Address = "Seattle"
                },
                new Contact {
                    FirstName = "Sue",
                    LastName = "Johnson",
                    Address = "Seattle"
                },
                new Contact {
                    FirstName = "Sue",
                    LastName = "Johnson",
                    Address = "Seattle"
                }
            };

            var pubs = new Publication[3]
            {
                new Publication {
                    Title = "C#",
                    Author = "Tom",
                    Year = 1990
                },

                new Publication {
                    Title = "C#",
                    Author = "Tom",
                    Year = 1990
                },

                new Publication {
                    Title = "C#",
                    Author = "Tom",
                    Year = 1990
                },
            };

            contacts[0].GetListName();
            pubs[0].GetListName();
            
            List(contacts);
            List(pubs);
  
            Console.WriteLine(contacts[0].CompareTo(contacts[1]));
            Compare(contacts);
            Console.ReadLine();
        }

        public static void List(IListable[] items) // only strict to IListable part of class
        {
            foreach (var item in items)
            {
                foreach (var column in item.ColumnNames)
                {
                    Console.WriteLine(column);
                }
            }
  
        }

        public static void Compare(IComparable[] items)
        {
            Console.WriteLine(items[0].CompareTo(items[1]));   
        }
    }
}
