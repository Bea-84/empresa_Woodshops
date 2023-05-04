using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace empresa_Woodshops
{
    enum TipoTablero
    {
        aglomerado, contrachapado, MDF
    }
    enum TipoColor
    {
        incoloro, caoba, nogal
    }
    enum TipoArticulo
    {
        estanteria, mesa, silla, armario
    }
    internal class Aplicacion
    {

        public void Inicio()
        {
            SedeEmpresa sedeEmpresa = new SedeEmpresa(); //creo objeto empresa

            bool salir = false;
            string opcion;
            do
            {

                Console.WriteLine("1.Crear y añadir productos, clientes,etc....");
                Console.WriteLine("2.Mostrar productos por tipo");
                Console.WriteLine("3.Mostrar stock de un producto , por su código, disponible en cada tienda");
                Console.WriteLine("4.Mostrar cliente por tipo");
                Console.WriteLine("5.Añadir factura a tienda seleccionada,cliente hace pedido generando su factura y detalle factura");
                Console.WriteLine("6.Mostrar listado facturas y detalle factura");
                Console.WriteLine("0.salir");
                Console.ForegroundColor = ConsoleColor.Magenta;
                opcion = pedirOpcionMenu();
                Console.ForegroundColor = ConsoleColor.Gray;
                switch (opcion)
                {
                    case "1":
                        crearProductos(sedeEmpresa);
                        break;
                    case "2":
                        listadoProductos(sedeEmpresa);
                        break;
                    case "3":
                        mostrarStockProductoTienda(sedeEmpresa);
                        break;
                    case "4":
                        listadoClientes(sedeEmpresa);
                        break;
                    case "5":
                        añadirFactura(sedeEmpresa);
                        break;
                    case "6":
                        listadoFacturas(sedeEmpresa);
                        break;
                    case "0":
                        salir = true;
                        break;
                }

            } while (!salir);
        }

        string pedirOpcionMenu() //método almacena valor en variable opción
        {
            string opcion;
            do
            {
                Console.Write("Opcion:");
                opcion = Console.ReadLine();
            } while (!"0123456".Contains(opcion));

            return opcion;
        }

        public void crearProductos(SedeEmpresa sedeEmpresa) //método crear y añadir productos,clientes ,etc....
        {

            Tienda tienda1 = new Tienda(); //creo objeto tienda1
            tienda1.Poblacion = "Ripollet";
            tienda1.Direccion = "Rambla Sant Jordi 120";

            Tienda tienda2 = new Tienda(); //creo objeto tienda2
            tienda2.Poblacion = "Cerdanyola";
            tienda2.Direccion = "San Ramon 14";

            sedeEmpresa.addTienda(tienda1); //añado tiendas a arraylist
            sedeEmpresa.addTienda(tienda2);

            Proveedor proveedor1 = new Proveedor(); //creo objeto proveedor
            proveedor1.Nombre = "Hermanos Sanz.S.A";
            proveedor1.Nif = "44444444S";

            Proveedor proveedor2 = new Proveedor();
            proveedor2.Nombre = "Hermanos Sanchez.S.A";
            proveedor2.Nif = "88888888L";

            sedeEmpresa.addProveedor(proveedor1); //añado proveedor a arraylist
            sedeEmpresa.addProveedor(proveedor2);

            Tablero producto1 = new Tablero(); //creo objeto productos
            producto1.Ancho = 14;
            producto1.Altura = 10;
            producto1.Codigo = 001;
            producto1.Descripcion = "Interior";
            producto1.Precio = 150;
            producto1.Stock = 128;
            producto1.Proveedor = proveedor1;
            producto1.TipoTablero = TipoTablero.contrachapado;


            Barniz producto2 = new Barniz();
            producto2.Mililitro = 12;
            producto2.Codigo = 002;
            producto2.Descripcion = "Exterior";
            producto2.Precio = 180;
            producto2.Stock = 200;
            producto2.Proveedor = proveedor1;
            producto2.TipoColor = TipoColor.caoba;

            Articulo producto3 = new Articulo();
            producto3.TipoArticulo = TipoArticulo.estanteria;
            producto3.Codigo = 003;
            producto3.Descripcion = "Exterior";
            producto3.Precio = 135;
            producto3.Stock = 15;
            producto3.Proveedor = proveedor1;

            tienda1.addProducto(producto1); //añado productos a la tienda1
            tienda1.addProducto(producto2);
            tienda1.addProducto(producto3);

            Tablero producto4 = new Tablero(); //creo objeto productos
            producto4.Ancho = 7;
            producto4.Altura = 10;
            producto4.Codigo = 004;
            producto4.Descripcion = "Exterior";
            producto4.Precio = 80;
            producto4.Stock = 225;
            producto4.Proveedor = proveedor2;
            producto4.TipoTablero = TipoTablero.MDF;

            Barniz producto5 = new Barniz();
            producto5.Mililitro = 12;
            producto5.Codigo = 002;
            producto5.Descripcion = "Exterior";
            producto5.Precio = 180;
            producto5.Stock = 300;
            producto5.Proveedor = proveedor1;
            producto5.TipoColor = TipoColor.caoba;

            Articulo producto6 = new Articulo();
            producto6.TipoArticulo = TipoArticulo.silla;
            producto6.Codigo = 005;
            producto6.Descripcion = "Exterior";
            producto6.Precio = 45;
            producto6.Stock = 37;
            producto6.Proveedor = proveedor2;

            tienda2.addProducto(producto4); //añado productos a la tienda2
            tienda2.addProducto(producto5);
            tienda2.addProducto(producto6);


            Profesional cliente1 = new Profesional(); //creo cliente 1
            cliente1.Nombre = "Antonio";
            cliente1.Nif = "45454545D";
            cliente1.Descuento = 25;

            Profesional cliente2 = new Profesional(); //creo cliente 2
            cliente2.Nombre = "Yolanda";
            cliente2.Nif = "78787878L";
            cliente2.Descuento = 15;

            Woodfriend cliente3 = new Woodfriend(); //creo cliente 3
            cliente3.Nombre = "Virginia";
            cliente3.Nif = "47474747K";
            cliente3.Codigo_socio = 001;

            Woodfriend cliente4 = new Woodfriend(); //creo cliente 4
            cliente4.Nombre = "Ricardo";
            cliente4.Nif = "96969696M";
            cliente4.Codigo_socio = 002;

            sedeEmpresa.addCliente(cliente1); //añado clientes a arraylist 
            sedeEmpresa.addCliente(cliente2);
            sedeEmpresa.addCliente(cliente3);
            sedeEmpresa.addCliente(cliente4);

            Factura factura = new Factura(); //creo factura cliente woodfriend
            factura.NumeroFactura = 001;
            string fechaFactura = "02/02/2022";
            factura.Fecha = DateTime.Parse(fechaFactura);
            factura.ClienteRegistrado = cliente4;

            Factura factura2 = new Factura(); //creo factura cliente profesional
            factura2.NumeroFactura = 002;
            string fechafactura2 = "15/02/23";
            factura2.Fecha = DateTime.Parse(fechafactura2);
            factura2.ClienteRegistrado = cliente1;

            tienda1.addFacturas(factura); //añado facturas a tiendas
            tienda2.addFacturas(factura2);

            Detallefactura detallefactura = new Detallefactura();// creo detalle factura
            detallefactura.Unidad =5;
            detallefactura.Precio =20;
            detallefactura.Total =100;

            Detallefactura detallefactura2 = new Detallefactura();
            detallefactura2.Unidad =3;
            detallefactura2.Precio =26;
            detallefactura2.Total =234;

            factura.addDetallefactura(detallefactura2);// añado detalle facturas a factura cliente profesional
            factura2.addDetallefactura(detallefactura);// añado detalle factura a factura cliente woodfriend

        }

        public void listadoProductos(SedeEmpresa sedeEmpresa) //método mostrar productos por tipo 
        { 
            string opcion;
            Console.WriteLine("Indique que tipo de producto necesitas 1)Tablero 2)Barniz 3)Articulo");
            opcion = Console.ReadLine();

            if ("123".Contains(opcion))
            {
                foreach (Tienda tienda in sedeEmpresa.ListaTiendas)
                {
                    switch (opcion)
                    {
                        case "1":
                            foreach (Producto producto in tienda.getProducto())
                            {
                                if (producto is Tablero)
                                {
                                    Console.WriteLine(producto.ToString());
                                }
                            }
                            break;
                        case "2":
                            foreach (Producto producto in tienda.getProducto())
                            {
                                if (producto is Barniz)
                                {
                                    Console.WriteLine(producto.ToString());
                                }
                            }
                            break;
                        case "3":
                            foreach (Producto producto in tienda.getProducto())
                            {
                                if (producto is Articulo)
                                {
                                    Console.WriteLine(producto.ToString());
                                }
                            }
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Opción incorrecta");
            }
        }

        public void mostrarStockProductoTienda(SedeEmpresa sedeEmpresa) //método para mostrar stock producto por tiendas a partir de un código
        {
            int codigo;

            Console.WriteLine("Introduce el código de el producto que buscas:");
            codigo = int.Parse(Console.ReadLine());

            foreach (Tienda tienda in sedeEmpresa.ListaTiendas)
            {
                Producto producto = tienda.getProductoByCodigo(codigo); //buscamos un producto por lo tanto,en objeto producto almaceno en 
                                                                        //variable producto, el valor encontrado en método
                if (producto == null)
                {
                    Console.WriteLine("En la tienda de " + "\t" + tienda.Poblacion + "\t" + "no disponemos de stock");

                }
                else
                {
                    Console.WriteLine("El stock disponible es:" + "\t" + producto.Stock + "en la tienda de " + "\t" + tienda.Poblacion);
                }
            }
        }

        public void listadoClientes(SedeEmpresa sedeEmpresa) //método mostrar clientes por tipo
        {
            string opcion;
            Console.WriteLine("Indique a que grupo de clientes pertenece 1)Profesional 2)Woodfriend");
            opcion = Console.ReadLine();

            if ("12".Contains(opcion))
            {
                foreach (Cliente cliente in sedeEmpresa.ListaClientes)
                {
                    switch (opcion)
                    {
                        case "1":

                            if (cliente is Profesional)
                            {

                                Console.WriteLine(cliente.ToString());
                            }
                            break;
                        case "2":

                            if (cliente is Woodfriend)
                            {

                                Console.WriteLine(cliente.ToString());
                            }
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Opción incorrecta");
            }
        }

        public void añadirFactura(SedeEmpresa sedeEmpresa) //método busca tienda/busco cliente/muestra factura
                                                           //hago pedido/muestra detalle factura con descuento si el cliente es profesional
        {
            string nif, num_factura, fecha, poblacion, clienteNoRegistrado;
            float descuento, precio, unidades = 0;
            Cliente cliente;
            Producto producto;
            Tienda tienda_seleccionada = null;
            Detallefactura detalle_Fac1 = null;
            int codigo = -1;
            float sumaTotal = 0;
            float total = 0;
            float sumaTotalDescuento = 0;


            //busco tienda

            Console.WriteLine("Indique la población de la tienda desde la que desea hacer su pedido:");
            poblacion = Console.ReadLine();

            tienda_seleccionada = sedeEmpresa.getTiendaByPoblacion(poblacion);

            if (tienda_seleccionada == null)
            {
                Console.WriteLine("Tienda seleccionada no disponible");
            }
            else
            {
                Console.WriteLine("La tienda seleccionada es" + tienda_seleccionada.Direccion);
            }

            //busco cliente

            Console.WriteLine("Indique su NIF:");
            nif = Console.ReadLine();
            cliente = sedeEmpresa.getClienteByNif(nif);

            if (cliente == null) //cliente no registrado
            {

                Console.WriteLine("Cliente no registrado");
                Console.WriteLine("Bienvenido/a Woodshops a continuación indique su nombre:");
                clienteNoRegistrado = Console.ReadLine();
                Console.WriteLine("Introduce tu numero de factura:");
                num_factura = Console.ReadLine();
                Console.WriteLine("Introduce fecha de compra:");
                fecha = Console.ReadLine();

                Factura factura1 = new Factura();
                factura1.ClienteRegistrado = null; //le damos valor null xq el objeto en este caso no existe(cliente no registrado)
                factura1.NumeroFactura = int.Parse(num_factura);
                factura1.Fecha = DateTime.Parse(fecha);

                tienda_seleccionada.addFacturas(factura1); //añado factura tienda seleccionada 
                Console.WriteLine(factura1 + "\nNombre cliente:" + clienteNoRegistrado);
            }
            else //cliente registrado
            {
                Console.WriteLine("Bienvenido/a" + cliente.Nombre);
                Console.WriteLine("Introduce tu numero de factura:");
                num_factura = Console.ReadLine();
                Console.WriteLine("Introduce fecha de compra:");
                fecha = Console.ReadLine();

                Factura factura1 = new Factura();
                factura1.ClienteRegistrado = cliente;
                factura1.NumeroFactura = int.Parse(num_factura);
                factura1.Fecha = DateTime.Parse(fecha);

                tienda_seleccionada.addFacturas(factura1); //añado factura tienda seleccionada 
                Console.WriteLine(factura1);

            }

            //comprar producto

            Console.WriteLine("Seleccione código producto que deseas comprar:");
            codigo = int.Parse(Console.ReadLine());

            while (codigo != 0)
            {
                producto = tienda_seleccionada.getProductoByCodigo(codigo);

                if (producto == null)
                {
                    Console.WriteLine("Producto inexistente");
                }
                else
                {
                    Console.WriteLine("Seleccione cuantas unidades necesitas del producto:");
                    unidades = float.Parse(Console.ReadLine());
                    precio = producto.Precio; // para que funcione la siguiente linea es necesaria,esta ya que el producto ya tiene un precio
                    Console.Write("El precio del producto es: " + precio);
                    total = unidades * precio;
                    sumaTotal += total;


                    detalle_Fac1 = new Detallefactura();
                    detalle_Fac1.Producto = producto;
                    detalle_Fac1.Unidad = unidades;
                    detalle_Fac1.Precio = precio;
                    detalle_Fac1.Total = total;

                    Factura factura1 = new Factura();
                    factura1.addDetallefactura(detalle_Fac1); //añado detalle factura a factura
                    Console.WriteLine(detalle_Fac1);
                }

                Console.WriteLine("Seleccione código producto que deseas comprar:");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("El precio de la factura es:" + sumaTotal);
            Console.ForegroundColor = ConsoleColor.Gray;

            if (cliente is Profesional) //profesional
            {
                descuento = ((Profesional)cliente).Descuento;
                sumaTotalDescuento = sumaTotal - (sumaTotal * descuento / 100);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El total de su factura con el descuento aplicado es" + sumaTotalDescuento); 
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        } 

        public void listadoFacturas(SedeEmpresa sedeEmpresa) //método mostrar factura y detalle factura
        {
            string poblacion;
            Tienda tienda_seleccionada = null;
            DateTime fecha = DateTime.Parse("01/01/2023");
            float descuento;
            
            //busco la tienda

            Console.WriteLine("Indique la población de la tienda desde la que necesita las facturas:");
            poblacion = Console.ReadLine();

            tienda_seleccionada = sedeEmpresa.getTiendaByPoblacion(poblacion);

            if (tienda_seleccionada == null)
            {
                Console.WriteLine("Tienda seleccionada no disponible");
            }
            else
            {
                Console.WriteLine("La tienda seleccionada es" + tienda_seleccionada.Direccion);
            }

            //busco factura y detalle factura

            foreach(Factura factura in tienda_seleccionada.ListaFacturas)
            {
                if(factura.Fecha.Year >= 2023) 
                {
                    Console.WriteLine(factura);

                    foreach (Detallefactura detallefactura in factura.ListaDetalles)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("El total de la factura es:"+detallefactura.Total);
                        Console.ForegroundColor = ConsoleColor.Gray;

                        if (factura.ClienteRegistrado is Profesional)
                        {
                            descuento = ((Profesional)factura.ClienteRegistrado).Descuento;
                            detallefactura.Total =  (detallefactura.Total * descuento / 100);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("La factura con descuento es :"+detallefactura.Total);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Factura no disponible");
                }

            } 

        }
    }

}



