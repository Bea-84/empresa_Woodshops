using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_Woodshops
{
    internal class Tablero: Producto
    {
        private int altura;
        private int ancho;
        private TipoTablero tipoTablero;

        public int Altura { get => altura; set => altura = value; }
        public int Ancho { get => ancho; set => ancho = value; }
        internal TipoTablero TipoTablero { get => tipoTablero; set => tipoTablero = value; }

        public override string ToString()
        {
            return base.ToString()+"\t"+"Características:\n Altura:"+ altura+"\t"+"Ancho:"+ancho+"\t"+"Tipo de tablero:"+TipoTablero;
        }
    } 
}
