using System;

namespace biblioteca
{
    public class Calculadora
    {
        public static double soma(double n1, double n2)
        {

            double resp;
            resp = n1 + n2;
            return resp;
        }//fim função soma
        public static double dividir(double n1, double n2)
        {
           if (n2 == 0)
                return 0;

           return n1 / n2;
        }//fim função dividir
    }//fim classe calculadora
}
