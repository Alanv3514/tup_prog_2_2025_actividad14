using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    abstract public class Transporte : IComparable<Transporte>
    {
        public double PrecioBase;
        public string Destino;
        public string Patente;
        public Transporte(double precio,string destino, string patente)
        {
            this.PrecioBase = precio;
            this.Destino = destino;
            this.Patente = patente;
        }
        abstract public double CalcularIVA();
        virtual public double CalcularPrecioFinal() {
        return this.PrecioBase * CalcularIVA();
        }

        virtual public int CompareTo(Transporte? other)
        {
            return this.Patente.CompareTo(other.Patente);
        }

        public override string ToString()
        {
            return $"{Patente}";
        }
    }
}
