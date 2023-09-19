using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public interface IPersonas
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        int Edad { get; set; }
        public void PreguntarNombre();
    }
}
