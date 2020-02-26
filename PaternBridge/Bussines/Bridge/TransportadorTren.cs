using PaternBridge.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternBridge.Bussines.Bridge
{
    class TransportadorTren : TransportadorBridge
    {
        public TransportadorTren(IPaqueteria _svrPaqueteria) : base(_svrPaqueteria) { }

        public override void Procesar()
        {
            Console.WriteLine("Medio de Transporte Tierra, " + base.svrPaqueteria.EnviarPedido() + ", " + base.svrPaqueteria.EntregarPedido());
        }
    }
}
