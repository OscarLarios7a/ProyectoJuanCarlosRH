using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias a utilizar
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.DB
{
    public class dbConexion
    {
        protected SqlConnection conexion = new SqlConnection("Server=DESKTOP-UATUHL3;DataBase=demo20;integrated Security=true;");

        //Metodo para abrir la conexion.
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        //Metodo para cerrar la conexion.
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
    
}
