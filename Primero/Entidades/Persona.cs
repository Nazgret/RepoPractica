using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primero.Entidades
{
    public abstract class Persona
    {
        //ATRIBUTOS
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;

        //PROPIEDADES
        protected string Nombre { get => _nombre; set => _nombre = value; }
        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        //MÉTODOS
        protected abstract void GetCrendencial(); //como es abstracto, no tiene implementación "{ }"

        protected virtual void GetNombreCompleto() //Virtual: implementación por default, osea si debe ir entre { } 
        {

        }

        protected void GetSaludoInformal()
        {

        }
        
    }
}
