using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using registroCivil.entities;
using registroCivil.business;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class WSPropietario : IWSPropietario
{
    PropietarioFullBO bo = new PropietarioFullBO();
    public PropietarioFull GetPropietarioFull(string run)
    {
        PropietarioFull result;
        try
        {
            result = bo.GetPropietarioFull(run);
        }
        catch (Exception e)
        {
            result = new PropietarioFull();
        }
        return result;

    }

    public PropietarioFull GetVehiculoFull(string patente)
    {
        PropietarioFull result;
        try
        {
            result = bo.GetVehiculoFull(patente);
        }
        catch (Exception e)
        {
            result = new PropietarioFull();
        }
        return result;
    }
}
