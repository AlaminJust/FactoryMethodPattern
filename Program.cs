using System;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clients.ClientCode(new SeaLogistics());
            Clients.ClientCode(new RoadLogistics());
        }
    }
}
