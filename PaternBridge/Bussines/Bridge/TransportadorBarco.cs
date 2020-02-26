using PaternBridge.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternBridge.Bussines.Bridge
{
    class TransportadorBarco : TransportadorBridge
    {
        public TransportadorBarco(IPaqueteria _svrPaqueteria) : base(_svrPaqueteria) { }

        public override void Procesar()
        {
            Console.WriteLine("Medio de Transporte AGUA, " + base.svrPaqueteria.EnviarPedido() + ", " +  base.svrPaqueteria.EntregarPedido());
        }
    }
}
