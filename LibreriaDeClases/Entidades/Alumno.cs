using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Entidades
{
    public class Alumno
    {
        private int _codigo;

        //constructores

        public Alumno()
        {

        }

         public Alumno(int cod)
        {
            _codigo = cod;

        }

        //propiedades

        public int codigo

        {
            get

            {
                return _codigo;

            }
        }



    }

}
