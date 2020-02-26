using PaternBridge.Bussines;
using PaternBridge.Bussines.Bridge;
using PaternBridge.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaqueteria svrPaqueteriaFedex = new Fedex();
            IPaqueteria svrPaqueteriaDHL = new DHL();
            IPaqueteria svrPaqueteriaEstafeta = new Estafeta();

            TransportadorBridge svrTransportador = new TransportadorBarco(svrPaqueteriaFedex);

            Console.WriteLine("Paqueteria Fedex");
            svrTransportador.Procesar();

            Console.WriteLine("Paqueteria DHL");
            svrTransportador = new TransportadorAvion(svrPaqueteriaDHL);
            svrTransportador.Procesar();
            svrTransportador = new TransportadorBarco(svrPaqueteriaDHL);
            svrTransportador.Procesar();

            Console.WriteLine("Paqueteria Estafeta");
            svrTransportador = new TransportadorTren(svrPaqueteriaEstafeta);
            svrTransportador.Procesar();

            Console.Write("Presiona cualquier tecla para salir del programa...");
            Console.ReadKey();
        }
    }
}
