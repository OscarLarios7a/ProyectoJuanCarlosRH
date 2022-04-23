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
    public class mdAntecedentes : dbConexion
    {
        dbConexion cnx = new dbConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void insertarAntecedentes(dtAntecedentes parametro)
        {
            try
            {
                comando.Connection = cnx.AbrirConexion();
                comando.CommandText = "sp_IngresarAntecedentes";
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.AddWithValue("@codPersona", parametro.CodPersona);
                comando.Parameters.AddWithValue("@diabetico", parametro.Diabetico);
                comando.Parameters.AddWithValue("@hipertenso", parametro.Hipertenso);
                comando.Parameters.AddWithValue("@cardiacos", parametro.Cardiaco);
                comando.Parameters.AddWithValue("@lagrimeo", parametro.Lagrimeo);
                comando.Parameters.AddWithValue("@otros ", parametro.Otros);
                comando.Parameters.AddWithValue("@alergico_a", parametro.AlergicoA);
                comando.Parameters.AddWithValue("@medicamentos", parametro.Medicamento);
                comando.Parameters.AddWithValue("@anestesicos", parametro.Anestesico);
                comando.Parameters.AddWithValue("@medicamentos_u", parametro.MedicamentoU);


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
