using PaternBridge.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternBridge.Bussines
{
    public class DHL : IPaqueteria
    {
        public string RecogerPedido()
        {
            return "Recoge Pedido DHL";
        }
        public string EnviarPedido()
        {
            return "Envía Pedido DHL";
        }
        public string EntregarPedido()
        {
            return "Entrega Pedido DHL";
        }
    }
}
