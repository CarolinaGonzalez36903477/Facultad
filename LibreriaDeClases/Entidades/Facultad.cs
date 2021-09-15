using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDeClases.Entidades;

namespace LibreriaDeClases.Entidades
{
    public class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        //constructor 
        public Facultad()
        { }

        public Facultad(List<Alumno> alumnos, int cantsedes, List<Empleado> empleados, string nombre)
        {
            _alumnos = alumnos;
            _cantidadSedes = cantsedes;
            _empleados = empleados;
            _nombre = nombre;
        }

        //propiedades

        public List<Alumno> Alumnos

        {
            get

            {
                return _alumnos;

            }
        }

        public int cantsedes

        {
            get

            {
                return _cantidadSedes;

            }
        }

        public List<Empleado> empleados

        {
            get

            {
                return _empleados;

            }
        }

        public string nombres

        {
            get

            {
                return _nombre;

            }
        }
    }
}
