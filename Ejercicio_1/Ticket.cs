using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Ticket : IComparable<Ticket>
    {
        public string Destino;
        public double PrecioFinal;
        public Transporte transporte;
        public Pasajero pasajero;

        public Ticket(string destino, double precio, Transporte transporte, Pasajero pasajero)
        {
            Destino = destino;
            PrecioFinal = precio;
            this.transporte = transporte;
            this.pasajero = pasajero;
        }
        public override string ToString()
        {
            return $"{Destino};{PrecioFinal};{transporte.ToString()}";
        }

        public int CompareTo(Ticket? other)
        {//comparo por Destino
            if (other == null) return 1;
            return this.Destino.CompareTo(other.Destino);
        }
    }
}
