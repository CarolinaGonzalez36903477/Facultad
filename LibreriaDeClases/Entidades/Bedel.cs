using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Entidades
{
    public class Bedel
    {
        private string _apodo;

        //constructor 

        public Bedel()
        { }

        public Bedel(string apodo)
        {
            _apodo = apodo;
        }

        //propiedades

        public string apodo

        {
            get

            {
                return _apodo;

            }
        }
    }
}
