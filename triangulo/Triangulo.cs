using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    public class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;
        private string tipo;

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
            tipo = verificaTipo();

        }
        public string Tipo { get { return tipo; } set { tipo = value; } }
        private string verificaTipo()
        {
            if ((this.ladoA > 0 && ladoB > 0 && ladoC > 0) && (((ladoA + ladoB) > ladoC) || ((ladoB + ladoC) > ladoA) || ((ladoC + ladoB) > ladoA)))
            { 
            
                if((ladoA ==ladoB)&&(ladoB ==ladoC))
                {
                    tipo = "Equilátero";
                }else if(((ladoA ==ladoC) && (ladoC!=ladoB)) || ((ladoB == ladoA ) && ladoC!=ladoA) || ((ladoB == ladoC)&& (ladoA!=ladoB))) {

                    tipo = "Isóseles";
                }
                else
                {
                    tipo = "Escaleno";
                }

            }
            else
            {
                tipo = "não é um triangulo";
            }

            return tipo;
        }
        
    }
}
