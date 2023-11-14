using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Sector
    {
        private string Identificador;

        public string Identificador1
        {
            get { return Identificador; }
            set { Identificador = value; }
        }
        private int SectorCodigo;

        public int SectorCodigo1
        {
            get { return SectorCodigo; }
            set { SectorCodigo = value; }
        }
        private string Descripcion;

        public string Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        private bool Habilitado;

        public bool Habilitado1
        {
            get { return Habilitado; }
            set { Habilitado = value; }
        }
    }
}
