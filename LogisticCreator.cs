using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class LogisticCreator
    {
        public abstract ITransport FactoryMethod();

        public void Delivar()
        {
            var transport = FactoryMethod();
            transport.Delivar();
        }
    }
}
