using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//libreria 
using ProyectoFinal.DB;
using ProyectoFinal.Data;
using System.Windows.Forms;

namespace ProyectoFinal.Modelo
{
    public class mdPersonal:dbConexion //
    {
        dbConexion cnx = new dbConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //menu de insertar
        public void insertarPersona(dtPersonal parametro)
        {
            try
            {
                comando.Connection = cnx.AbrirConexion();
                comando.CommandText = "sp_InsertarPersona";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codPersona", parametro.CodPersona);
                comando.Parameters.AddWithValue("@dni", parametro.Dni);
                comando.Parameters.AddWithValue("@edad", parametro.Edad);
                comando.Parameters.AddWithValue("@telefono", parametro.Telefono);
                comando.Parameters.AddWithValue("@apellido", parametro.Apellido);
                comando.Parameters.AddWithValue("@nombre", parametro.Nombre);
                comando.Parameters.AddWithValue("@direccion", parametro.Direccion);
                comando.Parameters.AddWithValue("@lNacimiento", parametro.LNacimiento);
                comando.Parameters.AddWithValue("@ocupacion", parametro.Ocupacion);
                comando.Parameters.AddWithValue("@procedencia", parametro.Procedencia);
                comando.Parameters.AddWithValue("@referido", parametro.Referido);
                comando.Parameters.AddWithValue("@fecha", parametro.FNacimiento);

                comando.ExecuteNonQuery();

                comando.Parameters.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                cnx.CerrarConexion();
            }


        }
    }
}
