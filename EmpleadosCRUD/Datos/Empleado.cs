using EmpleadosCRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmpleadosCRUD.Datos
{
    internal class Empleado
    {
        public static bool guardar(Emplea e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO tabla_empleados VALUES('"+e.Nombre+"', '"+e.Apellidos+"', '"+e.Correo+"', '"+e.FechaIngreso+"')";
                SqlCommand comando = new SqlCommand(sql,con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                con.desconectar();
                if (cantidad == 1)
                {

                    return true;
                }
                else return false;

                
            }

            catch (Exception ex)
            {
                return false;
            }

        }

        internal static bool guardar()
        {
            throw new NotImplementedException();
        }
    }

    public static DataTable lista()
    {
        try
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM tabla_empleados;";
            SqlCommand comando = new SqlCommand(sql, con.conectar());
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.desconectar();
            return dt;


        }

        catch (Exception ex)
        {
            return null;
        }

    }

    public static Empleado Consultar(string nombre)
    {
        try
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM tabla_empleados  WHERE nombre='" + nombre + "';";
            SqlCommand comando = new SqlCommand(sql, con.conectar());
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            Emplea em = new Emplea();      
            if (dr.Read())
            {
                em.Nombre = dr["nombre"].ToString();
                em.Apellidos = dr["apellido"].ToString();
                em.Correo = dr["Correo"].ToString();
                em.FechaIngreso = dr["fechaIngreso"].ToString();
                con.desconectar();
                return em;
            }
            else
            {
                return null;
            }
            
           


        }

        catch (Exception ex)
        {
            return null;
        }


    }
}
