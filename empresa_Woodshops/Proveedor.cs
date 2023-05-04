using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class Proveedor
    {
        private string nif;
        private string nombre;

      
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nif { get => nif; set => nif = value; }

      
    }
}
