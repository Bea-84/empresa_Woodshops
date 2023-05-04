using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class Barniz: Producto
    {
        private int mililitro;
        private TipoColor tipoColor;

        public int Mililitro { get => mililitro; set => mililitro = value; }

        internal TipoColor TipoColor { get => tipoColor; set => tipoColor = value; }

        public override string ToString()
        {
            return base.ToString()+"\t"+"Características:\n Mililitro:"+ mililitro+"\t"+"Tipo de color:"+TipoColor;
        }
    } 
} 
