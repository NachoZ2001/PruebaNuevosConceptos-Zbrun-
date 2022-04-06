using System.Text.RegularExpressions;
namespace PruebaNuevosConceptos_Zbrun_
{
    public static class Utilidades
    {
        //Punto 1
        public static int CalcularCantidadPalabrasExtension(this string mensaje)
        {
            return mensaje.Split(' ').Count();
        }

        //Punto 2
        public static int CalcularCantidadPalabrasExtension(this string mensaje, char separador)
        {
            return mensaje.Split(separador).Count();
        }

        //Punto 3
        public static double CalcularDiferenciaFechas(this DateTime fecha1, DateTime fecha2)
        {
            return (fecha1 - fecha2).TotalSeconds / 60;
        }

        //Punto 4 
        public static double RetornarPromedioExtension(this List<int> numeros) 
        {
            return numeros.Average();
        }

        //Punto 5 
        public static int RetornarSumaParesPorRestaImparesExtension(this List<int> numeros) 
        {           
            return (numeros.Where(x => x % 2 != 0).Sum()) * (numeros.Where(x => x % 2 != 0).Sum());
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

        //Punto 6 
        public static DateTime RetornarDatetimeAPartirDeString(this string Fecha)
        {           
            try
            {
                return DateTime.Parse(Fecha);
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }

        //Punto 7
        public static string RetornarStringInvertido(this string mensaje)
        {
            return mensaje.Reverse().ToString();           
        }

        //Punto 8 
        public static string RetornarArrayStringsComoString(string[] palabras, char separador)
        {
            return string.Join(separador, palabras);
        }

        //Punto 9 
        public static bool EsCorreoElectronico(this string correo) 
        {
            string patronCorreo = @"^[a-zA-Z\.\-_]+@^([a-zA-Z\.\-_]+\.)+[a-zA-Z{2,4}]$";
            return new Regex(patronCorreo).IsMatch(correo);
        }

        //Punto 10  
        public static bool EsCuit(this string cuit) 
        {
            string patronCuit = @"^([20|23|24|27|30|33|34])([0-9]{8})([0-9]{1})";
            return new Regex(patronCuit).IsMatch(cuit);
        }

        //Punto 13 
        public static int RetornarRestaDosEnteros(this int entero1, int entero2)
        {
            return entero1 - entero2;
        }
    }
}