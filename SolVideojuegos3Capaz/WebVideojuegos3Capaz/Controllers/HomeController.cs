using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebVideojuegos3Capaz.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<E_Videojuego> lista = new List<E_Videojuego>();
            try
            {
                N_Videojuego negocio = new N_Videojuego();
                lista = negocio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return View("Consulta", lista);
        }

        public ActionResult IrAgregar()
        {
            return View("VistaAgregar");
        }
        public ActionResult Agregar(E_Videojuego juego, HttpPostedFileBase archivoImagen)
        {
            try
            {
                //Guarda la imagen en el servidor 
                //Crear la ruta donde se guarda
                string rutaCarpeta = Server.MapPath("~/Images");
                string rutaArchivo = Path.Combine(rutaCarpeta, archivoImagen.FileName);

                //Guarda la imagen en el servidor
                archivoImagen.SaveAs(rutaArchivo);

                N_Videojuego negocio = new N_Videojuego();
                juego.Imagen = archivoImagen.FileName;
                negocio.Agregar(juego);
                //juego.Imagen = "imagen.jpg";
                TempData["mensaje"] = $"Se agrego correctamente el juego {juego.IdVideojuego}"; 
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return RedirectToAction("Index");
        }
    }
}