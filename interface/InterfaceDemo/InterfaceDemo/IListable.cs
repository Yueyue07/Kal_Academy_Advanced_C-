using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public interface IListable
    {
        // property
        string[] ColumnNames { get;}
        // method
        void GetListName();
    }

}
