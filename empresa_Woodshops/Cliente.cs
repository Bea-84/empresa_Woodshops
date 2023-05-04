using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal  class Cliente
    {
        private string nif;
        private string nombre;

        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return "Cliente con nif:"+nif+"\t"+" nombre cliente:"+nombre;
        }
    } 
} 
