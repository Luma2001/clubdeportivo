using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CludDeportivo.Entidades
{
    internal class E_Persona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public string DNI { get; set; }
        public string Direccion { get; set; }

        public bool EsSocio { get; set; }
        public bool AptoFisico { get; set; }

        public override string ToString()
        {
            return $" Nombre: {Nombre} {Apellido}, DNI: {DNI}, " +

                   $"Socio: {(EsSocio ? "Sí" : "No")}";
        }

    }
}
