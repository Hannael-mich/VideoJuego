using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Videojuego
    {
        public int IdVideojuego { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string Imagen {  get; set; }
    }
}
