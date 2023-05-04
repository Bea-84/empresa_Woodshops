using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class Woodfriend : Cliente
    {
        private int codigo_socio;

        public int Codigo_socio { get => codigo_socio; set => codigo_socio = value; }

        public override string ToString()
        {
            return base.ToString()+"\t"+ "Codigo socio:"+codigo_socio;
        }
    } 
}
