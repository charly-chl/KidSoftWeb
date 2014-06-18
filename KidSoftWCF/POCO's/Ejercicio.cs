using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidSoftWCF.POCO_s
{
    public class Ejercicio
    {
        Int64 idEjercicio;

        public Int64 IdEjercicio
        {
            get { return idEjercicio; }
            set { idEjercicio = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string instrucciones;

        public string Instrucciones
        {
            get { return instrucciones; }
            set { instrucciones = value; }
        }
        DateTime fechaCreacion;

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
    }
}