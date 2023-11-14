using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private int ClienteDNI;

        public int ClienteDNI1
        {
            get { return ClienteDNI; }
            set { ClienteDNI = value; }
        }
        private string Apellido;

        public string Apellido1
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private string Nombre;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Telefono;

        public string Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
    }
}
