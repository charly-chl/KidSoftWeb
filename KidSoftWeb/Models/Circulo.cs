using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidSoftWeb.Models
{
    public class Circulo
    {
        string color;
        string tamaño;

       public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string toString()
        {
            return "<div style=\"background-color:\">Pelota</div>";
        }

    }

    enum tipoColor : int { Rojo, Azul, Verde, Amarillo };

}