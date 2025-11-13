using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Bus : Transporte,IComparable<Bus>
    {
        public int Clase;
        public Bus(double precio, string destino, string patente, int clase) : base(precio, destino, patente)
        {
            Clase = clase;
        }
        public override double CalcularIVA()
        {
            return PrecioBase * 0.115; // IVA del 21%
        }
        public override double CalcularPrecioFinal()
        {
            double precioFinal = this.PrecioBase + this.CalcularIVA();
            return precioFinal;
        }

        public int CompareTo(Bus? other)
        {//comparo por Clase y Patente
            if (other == null) return 1;
            int claseComparison = this.Clase.CompareTo(other.Clase);
            if (claseComparison != 0)
            {
                return claseComparison;
            }
            else
            {
                return this.Patente.CompareTo(other.Patente);
            }
        }
        public int CompareTo(Bus? other,string destino)
        {//comparo por Destino
            if (other == null) return 1;
            return this.Destino.CompareTo(other.Destino);
        }

        public override string ToString()
        {
            return $"{Patente};{Clase}";
        }
    }
}
