using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_encriptacion
{
    class Vigenere
    {
        // Definir el array el abecedario y el que sera usado para la tabla de cifrado vigenere
        char[] abecedario = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[ , ] tabla = new char[26,26];

        public Vigenere()
        {
            // Llena la tabla de cifrado vigenere
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (j + i < 26)
                    {
                        tabla[i , j] = abecedario[j + i];
                    }
                    else
                    {
                        tabla[i, j] = abecedario[(j + i) - 26];
                    }
                }
            }
        }

        // Se utiliza para ver la tabla vigenre por consola
        public void MostrarTablaConsola()
        {
            // Recorre la tabla Vigenre y la muesta por consola
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    Console.Write(tabla[i, j]);
                }
                Console.WriteLine();
            }
        }

        // Metodo para crear la clave de encriptacion
        public char[] CrearClave(char[] texto, char[] clave)
        {
            // n = cuantas veces cabe la clave en el texto
            int n = texto.Length / clave.Length;
            // r = cuantos caracteres sobran
            int r = texto.Length % clave.Length;
            // Define la clave final
            char[] clavefinal = new char[(clave.Length * n) + r];

            // Copia el numero de veces que quepa la clave sobre el texto en la clave final
            if (clavefinal.Length >= clave.Length)
            {
                int contador = 0;
                do
                {
                    clave.CopyTo(clavefinal, contador * clave.Length);
                    contador++;
                } while (contador < n);
            }

            // Copia los ultimos caracteres que sobran
            for (int i = 0; i < r; i++)
            {
                clavefinal[(clavefinal.Length - r) + i] = clave[i];
            }
            // Retorna la clave final
            return clavefinal;
        }

        // Metodo para encriptar
        public string Encriptar(char[] texto, char[] clave)
        {
            // Definimos el array que guardara el texto encriptado
            char[] salida = new char[texto.Length];

            // Algoritmo que encripta usando la tabla Vigenere
            for (int i = 0; i < texto.Length; i++)
            {
                for (int j = 0; j < abecedario.Length; j++)
                {
                    if (clave[i] == abecedario[j])
                    {
                        for (int k = 0; k < abecedario.Length; k++)
                        {
                            if (texto[i] == abecedario[k])
                            {
                                salida[i] = tabla[j , k];
                            }
                        }
                    }
                }
            }

            // Retornar el mensaje encriptado
            string mensaje = new string(salida);
            return mensaje;
        }

        // Metodo para desencriptar
        public string Desencriptar(char[] texto, char[] clave)
        {
            // Definimos el array que guardara el texto desencriptado
            char[] salida = new char[texto.Length];

            for (int i = 0; i < clave.Length; i++)
            {
                for (int j = 0; j < abecedario.Length; j++)
                {
                    if (clave[i] == abecedario[j])
                    {
                        for (int k = 0; k < abecedario.Length; k++)
                        {
                            if (texto[i] == tabla[j , k])
                            {
                                salida[i] = abecedario[k];
                            }
                        }
                    }
                }
            }

            // Retornar el mensaje desencriptado
            string mensaje = new string(salida);
            return mensaje;
        }
    }
}
