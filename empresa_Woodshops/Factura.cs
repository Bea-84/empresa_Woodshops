using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class Factura
    {
        private int numeroFactura;
        private DateTime fecha;
        private Cliente clienteRegistrado; //objeto cliente por relación entre clase cliente / clase factura
        private ArrayList listaDetalles;


        public Factura()
        {
            listaDetalles = new ArrayList();
        }

        public int NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public ArrayList ListaDetalles { get => listaDetalles; }
        internal Cliente ClienteRegistrado { get => clienteRegistrado; set => clienteRegistrado = value; }

        public void addDetallefactura(Detallefactura detalle) //método añadir detalle a arraylist 
        {
            listaDetalles.Add(detalle);
        }

        public ArrayList getDetallefactura() //método consigue detalle arraylist
        {
            return listaDetalles;
        }

        public override string ToString()
        {
            string str = "Numero factura" + numeroFactura +  "\nFecha compra" + fecha  ;
            if (clienteRegistrado != null) //se puede añadir condición
            {
                str += "\nNombre cliente: " + clienteRegistrado.Nombre;
            }
            return str;

        } 
    }
}
