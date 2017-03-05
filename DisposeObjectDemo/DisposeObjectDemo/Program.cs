using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Do nothing and wait for Gabarge Collector
            // 2. Finalizer: When G0 is full, GC will kick off and run throug GO and move unused Object into
            //.in frechable Q, second thread will call finalizer to destruct the object sitting there
            // 3. IDisposable

            //TempFileStream f = new TempFileStream();
            //f.Close();

            // Not Lazy Loading
            using (TempFileStream f = new TempFileStream())
            {
            }

            TempFileStream f2 = new TempFileStream();
            f2.Close(); // User may call it or may not call it
            // put Stream and File into Frechable Q. Instead of two circle runs, just one circle.

        }
    }
}
