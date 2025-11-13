using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    [Serializable]
    public class Sistema
    {
        public List<string> destinoList = new List<string>();
        public List<Transporte> transporteList = new List<Transporte>();
        public List<Ticket> ticketList = new List<Ticket>();

        public Sistema() { }
        public bool CrearTicket(string destino, Transporte transporte, Pasajero pasajero)
        {
            double precioFinal = transporte.CalcularPrecioFinal();
            Ticket nuevoTicket = new Ticket(destino, precioFinal, transporte, pasajero);
            ticketList.Add(nuevoTicket);
            return true;
        }
        public bool AgregarTransporte(Transporte transporte)
        {
            transporteList.Add(transporte);
            //si el destino no esta en la lista lo agrego a la lista de destinos
            if(!destinoList.Contains(transporte.Destino))
            {
                destinoList.Add(transporte.Destino);
            }

            return true;
        }

        public string[] VerListaTransporte(string destino)
        {//este esta mal, agrega nulo cuando no hay nada y no deberia agregar
            string[] lista = new string[transporteList.Count];
            for (int i = 0; i < transporteList.Count; i++)
            {
                if(transporteList[i].Destino == destino)
                {
                    lista[i] = transporteList[i].ToString();
                }
            }//ahora tengo que quitar los nulos
            lista = lista.Where(s => s != null).ToArray();  


            return lista;
        }

        public string[] VerListaTickets()
        {
            string[] lista = new string[ticketList.Count];
            for (int i = 0; i < ticketList.Count; i++)
            {
                lista[i] = ticketList[i].ToString();
            }
            return lista;
        }

        public string[] VerListaDestinos()
        {
            destinoList.Sort();
            return destinoList.ToArray();
        }

    }
}
