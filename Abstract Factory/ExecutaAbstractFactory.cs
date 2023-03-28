using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class ExecutaAbstractFactory
    {
        public static Carro montarcarro(string tipo)
        {
            CarroFactory cf = null;
            switch (tipo)
            {
                case "luxo":
                    cf = new CarroLuxoFactory();
                    break;

                case "popular":
                    cf = new CarroPopularFactory();
                    break;
            }
            Carro carro = new Carro();
            carro.roda = cf.montarRoda();
            carro.som = cf.montarSom();
            
            return carro;
        }
    }
}
