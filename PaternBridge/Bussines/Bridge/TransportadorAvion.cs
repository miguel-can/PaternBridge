using PaternBridge.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternBridge.Bussines.Bridge
{
    class TransportadorAvion : TransportadorBridge
    {
        public TransportadorAvion(IPaqueteria _svrPaqueteria) : base(_svrPaqueteria) { }

        public override void Procesar()
        {
            Console.WriteLine("Medio de Transporte Aire, " + base.svrPaqueteria.EnviarPedido() + ", " + base.svrPaqueteria.EntregarPedido());
        }
    }
}
