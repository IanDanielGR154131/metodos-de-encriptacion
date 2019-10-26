using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_encriptacion
{
    class Xor
    {
        // Metodo para encriptar o desencriptar
        public string Encriptar(char[] texto, char clave)
        {
            int[] textoAscii = new int[texto.Length]; // Arreglo con el texto convertido a ASCII
            int claveAscii = (int)clave; //  Clave convertida a ascii

            // Convierte el texto a encriptar/desencriptar a formato ascii y lo guarda en otro arreglo
            for (int i = 0; i < texto.Length; i++)
            {
                textoAscii[i] = (int)texto[i];
                //Console.WriteLine(textoAscii[i]);
            }

            string claveBinario = Convert.ToString(claveAscii, 2).PadLeft(8, '0'); // Clave en binario 8 bits

            string[] textoBinario = new string[textoAscii.Length]; // Arreglo con el texto convertido a binario

            // Convierte el texto Ascii a binario y lo guarda en otro arreglo
            for (int i = 0; i < textoAscii.Length; i++)
            {
                textoBinario[i] = Convert.ToString(textoAscii[i], 2).PadLeft(8, '0');
                //Console.WriteLine(textoBinario[i]);
            }

            string[] encriptadoBinario = new string[textoBinario.Length]; // Guarda el texto desencriptado/encriptado en binario 8 bits

            // Ejecuta la suma XOR para cada caracter de texto en binario con la clave en binario
            for (int i = 0; i < textoBinario.Length; i++)
            {
                encriptadoBinario[i] = SumaXOR(textoBinario[i], claveBinario);
                //Console.WriteLine(encriptadoBinario[i]);
            }

            int[] encriptadoAscii = new int[encriptadoBinario.Length]; // Guarda el texto desencriptado/encriptado en codigo ASCII

            // Convierte el texto encriptado/desencriptado en Binario a Codigo ASCII
            for (int i = 0; i < encriptadoAscii.Length; i++)
            {
                encriptadoAscii[i] = Convert.ToInt32(encriptadoBinario[i], 2);
                //Console.WriteLine(encriptadoAscii[i]);
            }

            char[] encriptado = new char[encriptadoAscii.Length]; // Guarda el mensaje encriptado/desencriptado

            // Convierte el texto encriptado/desencriptado en ASCII a texto
            for (int i = 0; i < encriptado.Length; i++)
            {
                encriptado[i] = (char)encriptadoAscii[i];
                //Console.WriteLine(encriptado[i]);
            }

            // Retorna el mensaje encriptado/desencriptado
            string salida = new string(encriptado);
            return salida;
        }
        
        // Metodo que hace una suma XOR
        private string SumaXOR(string a, string b)
        {
            string suma = ""; // Guarda la suma XOR

            // Realiza las operaciones XOR
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '0' && b[i] == '0')
                {
                    suma += "0";
                }
                else if (a[i] == '0' && b[i] == '1')
                {
                    suma += "1";
                }
                else if (a[i] == '1' && b[i] == '0')
                {
                    suma += "1";
                }
                else if (a[i] == '1' && b[i] == '1')
                {
                    suma += "0";
                }
            }
            
            // Retorna el resultado final
            return suma;
        }
    }
}
