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

        public string Tipo { get { return tipo; } set { tipo = value; } }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
            tipo = VerificaTipo();
        }

        private bool CamposValidos()
        {
            return (ladoA > 0 && ladoB > 0 && ladoC > 0);
        }

        private bool ETriangulo()
        {
            return ((ladoB + ladoC) > ladoA || (ladoA + ladoC) > ladoB || (ladoA + ladoB) > ladoC);
        }

        private bool Equilatero()
        {
            return (ladoA == ladoB && ladoB == ladoC);
        }

        private bool Isoseles()
        {
            return ((ladoA == ladoC && ladoC != ladoB) || (ladoB == ladoA && ladoC != ladoA) || (ladoB == ladoC && ladoA != ladoB));
        }

        private string VerificaTipo()
        {
            if (ETriangulo() && CamposValidos())
            {
                if (Equilatero())
                {
                    tipo = "Equilátero";
                }
                else if (Isoseles())
                {
                    tipo = "Isóseles";
                }
                else
                {
                    tipo = "Escaleno";
                }
            }
            else
            {
                tipo = "Não é um triângulo";
            }

            return tipo;
        }
    }
}
