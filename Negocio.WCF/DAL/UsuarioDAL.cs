using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Negocio.WCF.DAL
{
    public class UsuarioDAL
    {
        string conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public void Agregar(Usuario usuario)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("SP_Usuario_CRUD", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Operacion", "INSERT");
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void Modificar(Usuario usuario)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Usuario_CRUD", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Operacion", "UPDATE");
                cmd.Parameters.AddWithValue("@Id", usuario.Id);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Usuario> Consultar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Usuario_CRUD", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Operacion", "SELECT");
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                        Sexo = reader["Sexo"].ToString()
                    };
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

        public void Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SP_Usuario_CRUD", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Operacion", "DELETE");
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }


        }
    }
}