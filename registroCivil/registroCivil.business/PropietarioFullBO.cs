using System;
using registroCivil.dao;
using registroCivil.entities;


namespace registroCivil.business
{
    public class PropietarioFullBO
    {
        PropietarioDAO propietarioDAO;
        VehiculoDAO vehiculoDAO;
        public PropietarioFullBO(){
            propietarioDAO = new PropietarioDAO();
            vehiculoDAO = new VehiculoDAO();
        }
        public PropietarioFull GetPropietarioFull(string run)
        {
            PropietarioFull result=new PropietarioFull();
            result.propietario = propietarioDAO.findPropietarioByRun(run);
            result.vehiculoList = vehiculoDAO.findVehiculoByIdPropietario(result.propietario.id_propietario);
            return result;
        }

        public PropietarioFull GetVehiculoFull(string patente)
        {
            Vehiculo vehiculo = new Vehiculo();
            PropietarioFull result = new PropietarioFull();
            vehiculo = vehiculoDAO.findVehiculoByPatente(patente);
            result.propietario = propietarioDAO.findPropietarioById(vehiculo.id_propietario);
            result.vehiculoList = vehiculoDAO.findVehiculoByIdPropietario(result.propietario.id_propietario);
            return result;
        }
    }
}
