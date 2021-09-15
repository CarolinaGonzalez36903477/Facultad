using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDeClases.Entidades;

namespace LibreriaDeClases
{
    public class Empleado
    {

        private DateTime _fechaIngreso;
        private int _legajo;
        private List <Salario> _salarios;

        //constructores

        public Empleado()
        { 
        
        }

        public Empleado(DateTime fechaingreso, int legajo, List<Salario> salarios)
        {
            _fechaIngreso = fechaingreso;
            _legajo = legajo;
            _salarios = salarios;

        }

        //propiedades 

        public DateTime fechaingreso

        {
            get

            {
                return _fechaIngreso;

            }
        }

        public List <Salario> Salarios

        {
            get

            {
                return _salarios;

            }
        }

        public double bruto

        {
            get

            {
                return _bruto;

            }
        }
    }
}
