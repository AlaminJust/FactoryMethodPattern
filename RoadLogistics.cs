﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class RoadLogistics : LogisticCreator
    {
        public override ITransport FactoryMethod()
        {
            return new Truck();
        }
    }
}
