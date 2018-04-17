using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using registroCivil.entities;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IWSPropietario
{

    [OperationContract]
    [WebGet(UriTemplate = "GetPropietarioFull/{run}", ResponseFormat = WebMessageFormat.Json)]
    PropietarioFull GetPropietarioFull(string run);
    [OperationContract]
    [WebGet(UriTemplate = "GetVehiculoFull/{patente}", ResponseFormat = WebMessageFormat.Json)]
    PropietarioFull GetVehiculoFull(string patente);

    // TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.


