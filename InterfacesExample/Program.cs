using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Program
    {
        /// <summary>
        /// Whats happening here is we are reading from an unknown source and do not care either 
        /// The get Object method will determine the source
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IReadWrite myWriter = getObject();
            myWriter.Read();
        }
        /// <summary>
        /// This method can return any class that implements the IReadWrite Interface
        /// This way we can swap reading from database to reading from any source
        /// Feel it is a good example of why you should use interfaces compared to the other over complicated examples online
        /// </summary>
        /// <returns>class that implements the IReadWrite Interface</returns>
        public static IReadWrite getObject()
        {
            return new DatabaseInteraction();
        }
    }
}
