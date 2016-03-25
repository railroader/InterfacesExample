using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class DatabaseInteraction : IReadWrite
    {
        public void Read()
        {
            Console.WriteLine("Reading from Database");
        }

        public void Write()
        {
            Console.WriteLine("Writing to database");
        }
    }
}
