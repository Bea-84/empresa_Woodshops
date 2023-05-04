using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class Tienda
    {
        private string direccion;
        private string poblacion;
        private ArrayList listaProductos;
        private ArrayList listaFacturas;

        public Tienda()
        {
            listaProductos = new ArrayList();
            listaFacturas = new ArrayList();
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public ArrayList Listaproductos { get => listaProductos;  }
        public ArrayList ListaFacturas { get => listaFacturas;  }

        public void addProducto(Producto producto) //método para añadir productos a arraylist
        {
            listaProductos.Add(producto);
        }
        public ArrayList getProducto() //método consigue productos arraylist
        {
            return listaProductos;
        }

        public void addFacturas(Factura factura) //método añadir facturas a arraylist
        {
            listaFacturas.Add(factura);
        }

        public ArrayList getFactura() //método consigue factura arraylist
        {
            return listaFacturas;
        }
            
        public Producto getProductoByCodigo(int codigo) //método consigue producto por código
        {
            foreach(Producto producto in listaProductos)
            {
                if(producto.Codigo == codigo)
                {
                    return producto;
                }
            }
            return null;
        }

       
    }  


}
