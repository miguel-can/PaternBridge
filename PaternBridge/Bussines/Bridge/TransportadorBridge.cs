using PaternBridge.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternBridge.Bussines.Bridge
{
    abstract class TransportadorBridge
    {
        protected IPaqueteria svrPaqueteria;

        public TransportadorBridge(IPaqueteria _svrPaqueteria)
        {
            this.svrPaqueteria = _svrPaqueteria;
        }

        public virtual void Procesar() {}
    }
}
