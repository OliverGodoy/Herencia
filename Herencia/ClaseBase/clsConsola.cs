using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.ClaseBase
{
    internal class clsConsola
    {
        public string Marca { get; set; }
        public int AnioLanzamiento { get; set; }
        public void MostrarDetalles()
        {
            Console.WriteLine($"\nMarca: {Marca}, año lanzamiento: {AnioLanzamiento}");
        }


    }
}
