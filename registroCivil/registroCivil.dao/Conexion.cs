using System;
using System.Data;
using Npgsql;
using registroCivil.entities;
namespace registroCivil.dao
{
    public class Conexion
    {
        private static NpgsqlConnection conexion = new NpgsqlConnection();
        public static NpgsqlConnection getConexion()
        {
            if (conexion.State== System.Data.ConnectionState.Open)
            {
                return conexion;
            }
            else{
                conexion.ConnectionString = "User ID=administrador; Password=administrador1;Host=localhost;Port=5432;Database=registroCivil;commandtimeout=900";
                conexion.Open();
                return conexion;
            }
        }

        public static DataTable queryListResult(string query)
        {
            DataTable lista = new DataTable();
            NpgsqlCommand comando = new NpgsqlCommand(query, getConexion());
            NpgsqlDataAdapter respuesta = new NpgsqlDataAdapter(comando);
            respuesta.Fill(lista);
            return lista;
        } 
    }
}
