using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal abstract class Producto
    {
        private int codigo;
        private string descripcion;
        private float precio;
        private int stock;
        private Proveedor proveedor; //declaramos aqui el atributo por la relación producto-proveedor por lo tanto,añadimos al metodo string
                                    //los atributos que queramos mostrar por consola

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        internal Proveedor Proveedor { get => proveedor; set => proveedor = value; }

        public override string ToString()
        {
            return "Código producto:"+codigo+"\t"+"\ndescripción:"+descripcion+"\t"+"Precio:"+precio+"\t"+"Stok:"+Stock+"\n Nombre proveedor:"+"\t"+Proveedor.Nombre+"\n";
        }
    }   
}
