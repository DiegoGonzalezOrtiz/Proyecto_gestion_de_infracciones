using System;
using System.Collections.Generic;
using System.Data;
using registroCivil.entities;

namespace registroCivil.dao
{
    public class VehiculoDAO
    {
        public List<Vehiculo> findVehiculoByIdPropietario(long idPropietaro)
        {
            List<Vehiculo> result = new List<Vehiculo>();
            string query = "SELECT * FROM registro_civil.vehiculo where id_propietario=" + idPropietaro;
            DataTable table = Conexion.queryListResult(query);

            foreach (DataRow item in table.Rows)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.id_vehiculo = Int64.Parse(item["id_vehiculo"].ToString());
                vehiculo.id_propietario = Int64.Parse(item["id_propietario"].ToString());
                vehiculo.patente = item["patente"].ToString();
                vehiculo.marca = item["marca"].ToString();
                vehiculo.modelo = item["modelo"].ToString();
                vehiculo.version = item["version"].ToString();
                vehiculo.anio = Int32.Parse(item["anio"].ToString());
                result.Add(vehiculo);
            }
            return result;
        }
        public Vehiculo findVehiculoByPatente(string patente)
        {
            string query = "SELECT * FROM registro_civil.vehiculo where patente='" + patente +"'";
            DataTable table = Conexion.queryListResult(query);
            DataRow item = table.Rows[0];
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.id_vehiculo = Int64.Parse(item["id_vehiculo"].ToString());
            vehiculo.id_propietario = Int64.Parse(item["id_propietario"].ToString());
            vehiculo.patente = item["patente"].ToString();
            vehiculo.marca = item["marca"].ToString();
            vehiculo.modelo = item["modelo"].ToString();
            vehiculo.version = item["version"].ToString();
            vehiculo.anio = Int32.Parse(item["anio"].ToString());
            return vehiculo;
        }
    }
}
