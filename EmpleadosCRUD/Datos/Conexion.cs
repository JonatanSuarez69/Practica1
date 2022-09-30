using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmpleadosCRUD.Datos
{
    internal class Conexion
    {
        SqlConnection con;
        public Conexion()
        {
            con = new SqlConnection("Server=DESKTOP-65B6OMD\\SQLEXPRESS;Database=TareaM;integradet security=true");
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
