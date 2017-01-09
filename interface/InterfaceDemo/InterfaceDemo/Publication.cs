using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Publication : IListable
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }

        public string[] ColumnNames
        {
            get
            {
                return new string[]
                {
                    Title,
                    Author,
                    Year.ToString()
                };
            }
        }
    }
}
