using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Negocio.WCF
{
    
    [ServiceContract]
    public interface IUsuarioService
    {

        [OperationContract]
        void Agregar(Usuario usuario);

        [OperationContract]
        void Modificar(Usuario usuario);

        [OperationContract]
        List<Usuario> Consultar();

        [OperationContract]
        void Eliminar(int id);

        
    }


    
}
