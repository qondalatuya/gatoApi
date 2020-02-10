using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatoApi.Entidades
{
    public class Cliente
    {
        public virtual int Id { get; protected set; }
        public virtual String Nombre { get; set; }
        public virtual String Sexo { get; set; }
        public virtual int Edad { get; set; }
        public virtual float DemandaMensual { get; set; }

        public Cliente() { }
        
        /*
        public Cliente(string nombre, string sexo, int edad, float demandaMensual)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
            this.demandaMensual = demandaMensual;
        }*/
    }
}
