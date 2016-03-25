using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class FileInputOutput : IReadWrite
    {
        public void Read()
        {
            Console.WriteLine("Reading from text File");
        }

        public void Write()
        {
            Console.WriteLine("Writing to text File");
        }
    }
}
