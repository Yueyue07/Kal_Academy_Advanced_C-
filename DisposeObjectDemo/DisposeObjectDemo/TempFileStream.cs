using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeObjectDemo
{
    public class TempFileStream : IDisposable
    {
        // when property only with get , you cannot modify the property even within the class 
        // But You still can set this variable from constructor
        public FileInfo File { get; } // People can read but cannot modify the FileInfo

        public FileStream Stream { get; } // People can read but cannot modify the stream

        // Constructor passing parameter
        public TempFileStream(string fileName)
        {
            File = new FileInfo(fileName);
            // Property is a wrapper around variable. Variable is just a piece of memory. 

            Stream = new FileStream(File.FullName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        // Constructor without passing paramter
        public TempFileStream()
            : this(Path.GetTempFileName())
        { }


        // nobody can call destructor only garbage collector can call destructor
        // overwrite destructor
        ~TempFileStream()
        {
            //Close();
            Dispose(false);
        }

        // 1.
        public void Close()
        {
            //Stream?.Close();
            //File?.Delete();
            Dispose();
        }

        #region IDisposable
        // 2.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // clean up TempFileStream Object (this) right way.
        }

        private void Dispose(bool disposing)
        {
            // Close();
            if (disposing)
            {
                Stream?.Close();
                File?.Delete();
            }

        }

        #endregion

    }
}
