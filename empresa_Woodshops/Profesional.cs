using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class Profesional : Cliente
    {
        private float descuento;

        public float Descuento { get => descuento; set => descuento = value; }

        public override string ToString()
        {
            return base.ToString() +"\t"+"Descuento:"+descuento;
        }

    } 
}  
