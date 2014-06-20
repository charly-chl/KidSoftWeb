using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidSoftWeb.Models
{
    public class Circulo
    {
        ColorCirculo color;
        string width;
        string height;


        public string toString()
        {
            return String.Format("<div style=\"background-color:{0}; width:{1}; height:{2};'\">Pelota</div>", this.color.ToString(),this.width,this.height);
        }

    }

    enum ColorCirculo : int { red, blue, green, yellow };

}   