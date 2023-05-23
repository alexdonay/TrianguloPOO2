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
            tipo = verificaTipo();

        }
        
       
       private boolean camposValidos(){
            if(this.ladoA > 0 && ladoB > 0 && ladoC > 0 {
                return True;
            }else{
                return False;
            }
        }
        private boolean eTriangulo(){
            if((ladoB + ladoC) > ladoA) || ((ladoA + ladoC) > ladoB) || (ladoA + ladoB > ladoC){
                return True;
            }else{
            return False;
            }
        }
        private boolean equilatero(){
             if((ladoA ==ladoB)&&(ladoB ==ladoC)){
             return True;
             }else{
             return False;
             }
        }
        private boolean isoseles(){
            if(((ladoA ==ladoC) && (ladoC!=ladoB)) || ((ladoB == ladoA ) && ladoC!=ladoA) || ((ladoB == ladoC)&& (ladoA!=ladoB))){
                return True;
            }else{
                return False;
            }
            
        }
        private string verificaTipo()
        {
            if (eTriangulo() == True || camposValidos() == True)
            { 
            
                if(equilatero == True)
                {
                    tipo = "Equilátero";
                }else if(isoseles == True) {

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
