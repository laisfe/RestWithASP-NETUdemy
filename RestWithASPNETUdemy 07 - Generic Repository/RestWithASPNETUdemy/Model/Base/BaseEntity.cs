﻿using System.Runtime.Serialization;

namespace RestWithASPNETUdemy.Model.Base
{
    /*Contrato entre os atributos
     e a estrutura da tabela*/
    [DataContract]
    public class BaseEntity
    {
        public long Id { get; set; }
    }
}