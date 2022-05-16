using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Clients
    {
        public static void ClientCode(LogisticCreator creator)
        {
            creator.Delivar();
        }
    }
}
