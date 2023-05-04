using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class Articulo : Producto
    {
        private TipoArticulo tipoArticulo;

        internal TipoArticulo TipoArticulo { get => tipoArticulo; set => tipoArticulo = value; }

        public override string ToString()
        {
            return base.ToString()+"\t"+"Tipo de artículo:"+TipoArticulo; 
        }
    } 
} 
