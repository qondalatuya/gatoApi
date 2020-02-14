using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatoApi.Entidades
{
    public class Material
    {
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual float Existencia { get; set; }
        public virtual string Unidad { get; set; }
        public virtual string ToString()
        {
            return (this.Id + " " + this.Nombre + " " + this.Unidad);

        }
    }
}
