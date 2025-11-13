namespace Ejercicio_1
{
    public class Avion : Transporte, IComparable<Avion>
    {
        public Avion(double precio,string destino,string patente):base(precio,destino,patente)
        {
        }
        public override double CalcularIVA()
        {
            return PrecioBase*0.21; // IVA del 21%
        }
        public override double CalcularPrecioFinal()
        {
            double impuestoAViajero = this.PrecioBase * 0.3;
            double precioFinal = this.PrecioBase + this.CalcularIVA() + impuestoAViajero; // Aplicar IVA del 21%
            return precioFinal;
        }

        public int CompareTo(Avion? other)
        {//comparo por Patente
            if (other == null) return 1;
            return this.Patente.CompareTo(other.Patente);
        }

        public override string ToString()
        {
            return $"{Patente}";
        }
    }
}
