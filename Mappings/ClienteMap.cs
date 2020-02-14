using GatoApi.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace GatoApi.Mapping
{
    public class ClienteMap: ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Nombre);
            Map(x => x.Sexo);
            Map(x => x.Edad);
            Map(x => x.DemandaMensual);
        }
    }
    
}
