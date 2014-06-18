using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidSoftWCF.POCO_s
{
    public class Usuario
    {
        Int64 idUsuario;

        public Int64 IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        DateTime fechaAlta;

        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        string foto;

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }


    }
}