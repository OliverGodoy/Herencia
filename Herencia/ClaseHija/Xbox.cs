using Herencia.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.ClaseHija
{
    internal class Xbox : clsConsola 
    {
        public bool GamePass { get; set; }

        public string MostrarDetallesXbox()
        {
            MostrarDetalles();
            return $"Tiene GamePass: {GamePass}";
        }
    }
}
