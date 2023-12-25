using Entidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class D_Videojuego
    {
        protected string CadenaConexion = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        public void Agregar(E_Videojuego juego) 
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("agregaVideojuego",conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@fechaLanzamiento", juego.FechaLanzamiento);
                comando.Parameters.AddWithValue("@imagen", juego.Imagen);

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<E_Videojuego> ObtenerTodos()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            List<E_Videojuego> lista = new List<E_Videojuego>();
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("obtenerVideojuegos", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read()){
                    E_Videojuego juego = new E_Videojuego();
                    juego.IdVideojuego = Convert.ToInt32(reader["idVideojuego"]);
                    juego.Nombre = reader["nombre"].ToString();
                    juego.Precio = Convert.ToInt32(reader["precio"]);
                    juego.FechaLanzamiento = Convert.ToDateTime(reader["fechaLanzamiento"]);
                    juego.Imagen = reader["imagen"].ToString();

                    lista.Add(juego);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
