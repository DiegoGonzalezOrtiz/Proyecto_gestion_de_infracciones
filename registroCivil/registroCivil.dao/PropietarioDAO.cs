using System;
using System.Data;
using Npgsql;
using registroCivil.entities;
namespace registroCivil.dao
{
    public class PropietarioDAO
    {
        private NpgsqlConnection conexion = new NpgsqlConnection();
        public Propietario findPropietarioByRun(string run)
        {
            Propietario result = new Propietario();
            string query = "SELECT * FROM registro_civil.propietario where run='"+run+"'";
            DataTable table = Conexion.queryListResult(query);
            DataRow row = table.Rows[0];
            result.id_propietario = Convert.ToInt64(row["id_propietario"].ToString());
            result.run = row["run"].ToString();
            result.nombre = row["nombre"].ToString();
            result.apellido_paterno = row["apellido_paterno"].ToString();
            result.apellido_materno = row["apellido_materno"].ToString();
            result.direccion = row["direccion"].ToString();
            return result;
        }
        public Propietario findPropietarioById(long id)
        {
            Propietario result = new Propietario();
            string query = "SELECT * FROM registro_civil.propietario where id_propietario=" + id;
            DataTable table = Conexion.queryListResult(query);
            DataRow row = table.Rows[0];
            result.id_propietario = Convert.ToInt64(row["id_propietario"].ToString());
            result.run = row["run"].ToString();
            result.nombre = row["nombre"].ToString();
            result.apellido_paterno = row["apellido_paterno"].ToString();
            result.apellido_materno = row["apellido_materno"].ToString();
            result.direccion = row["direccion"].ToString();
            return result;
        }
    }
}
