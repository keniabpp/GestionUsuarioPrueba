using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Negocio.WCF
{
    
    [ServiceContract] // la interfaz es un contracto WCF,
    public interface IUsuarioService // esto declara los metodos nada de logica 
    {

        [OperationContract] //cada metodo es un contrato de operacion publica
        void Agregar(Usuario usuario);

        [OperationContract]
        void Modificar(Usuario usuario);

        [OperationContract]
        List<Usuario> Consultar();

        [OperationContract]
        void Eliminar(int id);

        
    }


    
}
