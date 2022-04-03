using System.Text.RegularExpressions;
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

        //Punto 6 : Crear un método de extensión que retorne una fecha en formato DateTime a partir de un string
        //(si se genera una excepción por mal formato retornar el MinValue del tipo de datos).
        //public static DateTime RetornarDatetimeAPartirDeString(this string Fecha)
        //{
        //    string[] fechas = Fecha.Split(' ');
        //    DateTime fechaRetornar = new DateTime(fechas[0], fechas[1], fechas[2]);
        //    return fechaRetornar;
        //}

        //Punto 7
        public static string RetornarStringInvertido(this string mensaje)
        {
            string mensajeInvertido = "";
            foreach (char letra in mensaje)
            {
                mensajeInvertido = letra + mensajeInvertido;
            }
            return mensajeInvertido;
        }

        //Punto 8 
        public static string RetornarArrayStringsComoString(string[] strings, char separador)
        {
            string retornarString = "";
            foreach (string elemento in strings)
            {
                retornarString = retornarString + separador + elemento;
            }
            return retornarString;
        }

        //Punto 9 
        public static bool EsCorreoElectronico(string correo)
        {
            string patronCorreo = @"^[a-zA-Z\.\-_]+@^([a-zA-Z\.\-_]+\.)+[a-zA-Z{2,4}]$";
            Regex rgxCorreo = new Regex(patronCorreo);
            return (rgxCorreo.IsMatch(correo));
        }

        //Punto 10  
        public static bool EsCuit(string cuit)
        {
            string patronCuit = @"^([20|23|24|27|30|33|34])([0-9]{8})([0-9]{1})";
            Regex rgxCuit = new Regex(patronCuit);
            return rgxCuit.IsMatch(cuit);
        }

        //Punto 13 : Crear un método de extensión que reste dos números enteros.
        public static int RetornarRestaDosEnteros(this int entero1, int entero2)
        {
            return entero1 - entero2;
        }
    }
}