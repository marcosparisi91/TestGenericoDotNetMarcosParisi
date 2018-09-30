using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public class UserDAO
    {
        string cadenaDeConexion = "Server=localhost\\SQLEXPRESS;Database=TestMarcosParisi;Trusted_Connection=True;MultipleActiveResultSets=true";
        public List<User> GetUsuarios()
        {
            SqlConnection sqlConnection1 = new SqlConnection(this.cadenaDeConexion);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            var listaUsuarios = this.MapearUsuarios(reader);
            sqlConnection1.Close();
            return listaUsuarios;
        }

        public List<User> MapearUsuarios(SqlDataReader usuarios)
        {
            List<User> retorno = new List<User>();
            while (usuarios.Read())
            {
                retorno.Add(new User
                {
                    Id = (int)usuarios["Id"],
                    Nombre = usuarios["Nombre"].ToString(),
                    Apellido = usuarios["Apellido"].ToString(),
                    Email = usuarios["Email"].ToString(),
                    Password = usuarios["Password"].ToString()
                });

            }
            return retorno;
        }
        public void DeleteUsuario(int id)
        {
            SqlConnection sqlConnection1 = new SqlConnection(this.cadenaDeConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Usuario where Id = " + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteReader();

            sqlConnection1.Close();
        }

        public void CreateUser(User usuario)
        {
            SqlConnection sqlConnection1 = new SqlConnection(this.cadenaDeConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT into Usuario (Nombre, Apellido, Email, Password) values ('" + usuario.Nombre + "','" + usuario.Apellido + "','" + usuario.Email + "','" + usuario.Password + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteReader();

            sqlConnection1.Close();
        }

        public User UpdateUser(User usuario)
        {
            SqlConnection sqlConnection1 = new SqlConnection(this.cadenaDeConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "update Usuario set Nombre = '" + usuario.Nombre + "', Apellido = '" + usuario.Apellido + "', Email = '" + usuario.Email + "', Password = '" + usuario.Password + "' where Id = '" + usuario.Id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteReader();

            sqlConnection1.Close();
           return this.GetUsuario(usuario.Id);
        }

        public User GetUsuario(int id)
        {
            SqlConnection sqlConnection1 = new SqlConnection(this.cadenaDeConexion);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Usuario where id = '" + id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            var usuario = this.MapearUsuarios(reader).First();
            sqlConnection1.Close();
            return usuario;
        }
    }
}