using System.Runtime.Serialization;

namespace RestWithASPNETUdemy.Model.Base
{
    /*Contrato entre os atributos
     e a estrutura da tabela*/
    //[DataContract] //ordem em que os atributos sao inicializados
    public class BaseEntity
    {

        public long? Id { get; set; }
    }
}
