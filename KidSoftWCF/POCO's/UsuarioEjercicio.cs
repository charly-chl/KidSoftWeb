using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidSoftWCF.POCO_s
{
    public class UsuarioEjercicio
    {
        Int64 idUsuarioEjercicio;

        public Int64 IdUsuarioEjercicio
        {
            get { return idUsuarioEjercicio; }
            set { idUsuarioEjercicio = value; }
        }
        Int64 idUsuario;

        public Int64 IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        Int64 idEjercicio;

        public Int64 IdEjercicio
        {
            get { return idEjercicio; }
            set { idEjercicio = value; }
        }
        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        string puntuacion;

        public string Puntuacion
        {
            get { return puntuacion; }
            set { puntuacion = value; }
        }
        TimeSpan tiempoTotal;

        public TimeSpan TiempoTotal
        {
            get { return tiempoTotal; }
            set { tiempoTotal = value; }
        }
        string html;

        public string Html
        {
            get { return html; }
            set { html = value; }
        }
    }
}