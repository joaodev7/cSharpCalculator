namespace Calculadora
{
    class Calculadora
    {
        
        public static double Soma (double valor1, double valor2)
        {
            return valor1 + valor2;
        }
        public static double Subtracao (double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        public static double Divisao(double valor1, double valor2)
        {
            if(valor2 == 0)
            {
                return valor1;
            }
            else
            {
                return valor1 / valor2;
            }
        }
        public static double Multiplicacao(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

    }
}
