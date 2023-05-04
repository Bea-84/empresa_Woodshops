using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class Detallefactura
    {
        private float unidad;
        private float precio;
        private float total;
        private Producto producto; //creo este objeto por la relación entre detalle factura y producto

        public float Unidad { get => unidad; set => unidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Total { get => total; set => total = value; }
        internal Producto Producto { get => producto; set => producto = value; }

      

        public override string ToString()
        {
            return "\nunidad:"+unidad+"\nprecio:"+precio+"\nCódigo producto:"+producto.Codigo + "\nTotal:" + total;
        }
    }  
} 
