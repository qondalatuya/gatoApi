using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GatoApi.Entidades;

namespace GatoApi.Mappings
{
    public class MaterialMap:ClassMap<Material>
    {
        public MaterialMap()
        {
            this.Id(x => x.Id).GeneratedBy.Native();
            this.Map(x => x.Nombre);
            this.Map(x => x.Existencia);
            this.Map(x => x.Unidad);
        }
    }
}
