using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternBridge.Bussines.Interface
{
    public interface IPaqueteria
    {
        string RecogerPedido();
        string EnviarPedido();
        string EntregarPedido();
    }
}
