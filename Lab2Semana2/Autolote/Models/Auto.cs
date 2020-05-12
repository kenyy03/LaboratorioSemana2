using System;
using System.Collections.Generic;
using System.Text;

namespace Autolote.Models
{
    public class Auto
    {
        public string NumPlaca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }
        public string Estado { get; set; }


        public Auto()
        {
            this.NumPlaca = null;
            this.Marca = null;
            this.Modelo = null;
            this.Año = 0;
            this.Color = null;
            this.Estado = null;
        }

        public Auto(string pNP, string pM, string pMod, int pAño, string pColor, string pEs)
        {
            this.NumPlaca = pNP;
            this.Marca = pM;
            this.Modelo = pMod;
            this.Año = pAño;
            this.Color = pColor;
            this.Estado = pEs;
        }
    }
}
