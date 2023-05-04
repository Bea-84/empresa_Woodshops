using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class SedeEmpresa
    {
        private int nif;
        private string nombre;
        private ArrayList listaTiendas;
        private ArrayList listaProveedores;
        private ArrayList listaClientes;

        public SedeEmpresa()
        {
            listaTiendas = new ArrayList();
            listaProveedores = new ArrayList();
            listaClientes = new ArrayList();
        }

        public int Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public ArrayList ListaTiendas { get => listaTiendas; }
        public ArrayList ListaProveedores { get => listaProveedores; }
        public ArrayList ListaClientes { get => listaClientes; }

        public void addTienda(Tienda tienda) //método para añadir tiendas a arraylist empresa
        {
            listaTiendas.Add(tienda);
        }

        public ArrayList getTienda() //método consigue tienda arraylist
        {
            return listaTiendas;
        }

        public void addProveedor(Proveedor proveedor) //método para añadir proveedor a arraylist empresa
        {
            listaProveedores.Add(proveedor);
        }

        public ArrayList getProveedor() //método consigue proveedor arraylist
        {
            return listaProveedores;
        }

        public void addCliente(Cliente cliente) //método añadir clientes a arraylist empresa
        {
            listaClientes.Add(cliente);
        }

        public ArrayList getCliente() //método consigue clientes arraylist
        {
            return listaClientes;
        }

        public Cliente getClienteByNif(string nif) //método para conseguir cliente por dni
        {
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Nif.Equals(nif))
                {
                    return cliente;
                }

            }
            return null;
        }

        public Tienda getTiendaByPoblacion(string poblacion) //método conseguir tienda por población
        {
            foreach(Tienda tienda in listaTiendas)
            {
                if(tienda.Poblacion.Equals(poblacion))
                {
                    return tienda;
                }
            }
            return null;
        }

    } 
}        