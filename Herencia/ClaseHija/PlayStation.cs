using Herencia.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.ClaseHija
{
    internal class PlayStation : clsConsola 
    {
        public string ModeloControlador { get; set; }
        public string MostrarDetallesPS()
        {
            MostrarDetalles();
            return $"Modelo de Controlador: {ModeloControlador}";
        }
    }
}
