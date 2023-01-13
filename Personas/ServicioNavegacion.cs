using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class ServicioNavegacion
    {
        public bool? AbrirVentanaNacionalidad()
        {
            VentanaNacionalidad ventana = new VentanaNacionalidad();

            return ventana.ShowDialog();
        }
    }
}
