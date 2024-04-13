using Herencia.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.ClaseHija
{
    //De esta forma se heredan la propiedades
    internal class Nintendo : clsConsola 
    {
        public bool EsPortatil {  get; set; }

        public string MostrarDetallesNintendo()
        {
            MostrarDetalles();
            return $"Es portatil: {EsPortatil}";
        }

    }
}
