using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    /// <summary>
    /// Interface defining two methods for reading and writing to a data source
    /// </summary>
    interface IReadWrite
    {
         void Read();
         void Write();

    }
}
