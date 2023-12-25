using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Videojuego
    {
        public void Agregar(E_Videojuego juego)
        {
            D_Videojuego datos = new D_Videojuego();
            datos.Agregar(juego);
        }

        public List<E_Videojuego> ObtenerTodos()
        {
            D_Videojuego datos = new D_Videojuego();
            return datos.ObtenerTodos();
        }
    }
}
