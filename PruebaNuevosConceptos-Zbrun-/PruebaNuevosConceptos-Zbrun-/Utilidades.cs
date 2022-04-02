namespace PruebaNuevosConceptos_Zbrun_
{
    public static class Utilidades
    {
        //Punto 1
        public static int CalcularCantidadPalabrasExtension(this string mensaje)
        {           
            string [] palabras = mensaje.Split(' ');        
            return palabras.Count();
        }

        //Punto 2
        public static int CalcularCantidadPalabrasExtension(this string mensaje, char separador)
        {
            string[] palabras = mensaje.Split(separador);
            return palabras.Count();
        }

        //Punto 3
        //public static decimal CalcularDiferenciaFechas(this DateTime fecha1, DateTime fecha2)
        //{

        //}

        //Punto 4 
        public static double RetornarPromedioExtension(this List<int> enteros)
        {
            return enteros.Average();
        }

        //Punto 5: 
        public static int RetornarSumaParesPorRestaImparesExtension(this List<int> enteros)
        {
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            foreach (int entero in enteros)
            {
                if (entero % 2 == 0)
                {
                    pares.Add(entero);
                }
                else
                {
                    impares.Add(entero);
                }
            }
            int sumaPares = pares.Sum();
            int sumaImpares = RetornarRestaImpares(impares);
            return sumaPares * sumaImpares;
        }
        public static int RetornarRestaImpares(this List<int> impares)
        {
            int resta = impares[0];
            for (int i = 1; i < impares.Count + 1; i++)
            {
                resta = resta - impares[i];
            }
            return resta;
        }
    }
}