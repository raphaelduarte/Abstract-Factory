using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.montarcarro("luxo");
            Carro c2 = ExecutaAbstractFactory.montarcarro("popular");

            Console.ReadKey();
        }
    }
}