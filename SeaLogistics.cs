using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class SeaLogistics : LogisticCreator
    {
        public override ITransport FactoryMethod()
        {
            return new Ship();
        }
    }
}
