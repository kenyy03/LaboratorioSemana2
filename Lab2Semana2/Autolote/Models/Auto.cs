using System;
using System.Collections.Generic;
using System.Text;

namespace Autolote.Models
{
    public class Auto
    {
        private string numPlaca;
        private string marca;
        private string modelo;
        private int año;
        private string color;
        private string estado;

        public Auto()
        {
            this.numPlaca = null;
            this.marca = null;
            this.modelo = null;
            this.año = 0;
            this.color = null;
            this.estado = null;
        }

        public Auto(string pNP, string pM, string pMod, int pAño, string pColor, string pEs)
        {
            this.numPlaca = pNP;
            this.marca = pM;
            this.modelo = pMod;
            this.año = pAño;
            this.color = pColor;
            this.estado = pEs;
        }

        // Setters and Getters
        public string NumPlaca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Color { get; set; }
        public string Estado { get; set; }

        public void IngresarAuto()
        {

        }

        public void AutosDisp()
        {

        }

        public void AutosNOdisp()
        {

        }

        public void VenderAuto()
        {

        }


    }
}
