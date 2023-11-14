using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private string UserName;

        public string UserName1
        {
            get { return UserName; }
            set { UserName = value; }
        }
        private string Password;

        public string Password1
        {
            get { return Password; }
            set { Password = value; }
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
        private string Rol;

        public string Rol1
        {
            get { return Rol; }
            set { Rol = value; }
        }
    }
}
