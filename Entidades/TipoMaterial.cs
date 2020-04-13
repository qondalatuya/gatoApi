using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GatoApi.Entidades
{
    public class TipoMaterial
    
    {
        public virtual int Id { get; set; }
        public virtual String Nombre { get; set; }
        
        [JsonIgnore]
        public virtual IList<Material> Materials { get; set; }

    }
}
