using PaternBridge.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternBridge.Bussines
{
    public class Fedex : IPaqueteria
    {
        public string RecogerPedido()
        {
            return "Recoge Pedido Fedex";
        }
        public  string EnviarPedido()
        {
            return "Envía Pedido Fedex";
        }
        public string EntregarPedido()
        {
            return "Entrega Pedido Fedex";
        }
    }
}
