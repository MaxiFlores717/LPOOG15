using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class TipoVehiculo
    {
        private int TVCodigo;

        public int TVCodigo1
        {
            get { return TVCodigo; }
            set { TVCodigo = value; }
        }
        private string Descripcion;

        public string Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        private decimal Tarifa;

        public decimal Tarifa1
        {
            get { return Tarifa; }
            set { Tarifa = value; }
        }
    }
}
