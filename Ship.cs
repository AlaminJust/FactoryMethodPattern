using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Ship : ITransport
    {
        public void Delivar()
        {
            Console.WriteLine("Delivar by ship cargo by sea");
        }
    }
}
