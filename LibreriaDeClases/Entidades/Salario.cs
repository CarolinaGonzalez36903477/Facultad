using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Entidades
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        //constructor 

        public Salario()
        { 
        
        }

        public Salario(double bruto, string codtrans, double desc, DateTime fecha)
        {
            _bruto = bruto;
            _codigoTransferencia = codtrans;
            _descuentos = desc;
            _fecha = fecha;
        }

        //propiedades

        public double bruto

        {
            get

            {
                return _bruto;

            }
        }

        public string codigotransferencia

        {
            get

            {
                return _codigoTransferencia;

            }
        }

        public DateTime fecha

        {
            get

            {
                return _fecha;

            }
        }

        public int codigo

        {
            get

            {
                return _codigo;

            }
        }
    }
}
