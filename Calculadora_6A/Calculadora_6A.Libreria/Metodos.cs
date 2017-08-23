using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_6A.Libreria
{
    public class Metodos
    {
/// <summary>
/// Funcion que envia saludo
/// </summary>
/// <returns>Cadena de caracteres</returns>
        public string Saludo()
        {
            return "HOLA MUNDO DE CARAMELO";
        }
        public float Sumar(float numero1, float numero2)
        
        {
            var resultado = numero1 + numero2;
            return resultado;
           

        }
        public float Restar(float numero3, float numero4)
        {
            var resultado2 = numero3 - numero4;
            return resultado2;
        }
        public float Multiplicar(float numero5, float numero6)
        {
            var resultado3 = numero5 * numero6;
            return resultado3;
        }
        public float Dividir(float numero7, float numero8)
        {
            var resultado4 = numero7 / numero8;
            return resultado4;
        }
    }
}
