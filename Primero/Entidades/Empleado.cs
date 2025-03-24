using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primero.Entidades
{
    public class Empleado : Persona
    {
        //ATRIBUTOS
        private int _legajo;
        private DateTime _fechaIngreso;

        // PROPIEDADES
        protected int Legajo { get => _legajo; set => _legajo = value; }
        protected DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }

        //PROPIEDADES HEREDADAS


        protected override void GetCrendencial()
        {
            
        }
    }
}
