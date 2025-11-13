using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Pasajero
    {
        //cuit,nombre,telefono,tarjeta
        public string Cuit;
        public string Nombre;
        public string Telefono;
        public string Tarjeta;
        public Pasajero() { }
        public Pasajero(string cuit, string nombre, string telefono, string tarjeta)
        {
            if (string.IsNullOrWhiteSpace(cuit) || cuit.Length != 11)
            {
                throw new ArgumentException("Cuit/cuil inválido. Debe tener 11 caracteres y no estar vacío.");
            }
            if (string.IsNullOrWhiteSpace(tarjeta) || tarjeta.Length != 16)
            {
                throw new ArgumentException("Nº de tarjeta de crédito inválido. Debe tener 16 caracteres y no estar vacío.");
            }

            Cuit = cuit;
            Nombre = nombre;
            Telefono = telefono;
            Tarjeta = tarjeta;
        }

    }
}
