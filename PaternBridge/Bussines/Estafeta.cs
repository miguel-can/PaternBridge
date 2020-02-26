using PaternBridge.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternBridge.Bussines
{
    public class Estafeta : IPaqueteria
    {
        public string RecogerPedido()
        {
            return "Recoge Pedido Estafeta";
        }
        public string EnviarPedido()
        {
            return "Envía Pedido Estafeta";
        }
        public string EntregarPedido()
        {
            return "Entrega Pedido Estafeta";
        }
    }
}
