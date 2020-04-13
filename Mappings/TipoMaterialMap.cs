using FluentNHibernate.Mapping;
using GatoApi.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatoApi.Mappings
{
    public class TipoMaterialMap:ClassMap<TipoMaterial>
    {
        public TipoMaterialMap()
        {
            this.Id(x => x.Id).GeneratedBy.Native();
            this.Map(x => x.Nombre);
            this.HasMany<Material>(x => x.Materials).Inverse().Cascade.All();
        }
    }
}
