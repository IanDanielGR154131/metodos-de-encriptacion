using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_encriptacion
{
    class Bifid
    {
        //int[] index = { 1, 2, 3, 4, 5 };

        char[,] tabla = new char[5, 5]; // Tabla con el cifrado Bifid

        // Abecedario (sin la j)
        char[] abecedario = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        // Crea la tabla Bifid con la clave
        public void CrearTabla(char[] clave)
        {
            char[] abclave = new char[clave.Length + abecedario.Length]; // Arreglo que contiene la clave mas el abecedario

            // Copia la clave y el abecedario a un solo array
            clave.CopyTo(abclave, 0);
            abecedario.CopyTo(abclave, clave.Length);

            // Cambia las J por la I
            for (int i = 0; i < abclave.Length; i++)
            {
                if (abclave[i] == 'J')
                {
                    abclave[i] = 'I';
                }
            }

            char[] abcfinal = abclave.Distinct().ToArray(); // Crea un abecedario final sin letras repetidas


            int x = 0; // Filas de la tabla
            int y = 0; // Columnas de la tabla

            // Coloca la clave sobre la tabla
            for (int i = 0; i < 25; i++)
            {
                tabla[x, y] = abcfinal[i];
                
                if (y == 4)
                {
                    y = 0;
                    x++;
                } else
                {
                    y++;
                }          
            }
        }

        public string Encriptar(char[] texto)
        {
            // Arreglos que guardan las coordenadas donde se encontra la letra en la tabla
            int[] coordenadasX = new int[texto.Length];
            int[] coordenadasY = new int[texto.Length];

            // Recorre la tabla bifid buscando las coincidencias del texto y guarda las coordenadas de esas coincidencias
            for (int i = 0; i < texto.Length; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        if (texto[i] == tabla[x, y])
                        {
                            //Console.WriteLine("Found " + texto[i] + " in [" + x + "," + y + "]");
                            coordenadasX[i] = x + 1;
                            coordenadasY[i] = y + 1;
                        }
                    }
                }
            }

            // Junta las coordenadas en un solo array que sirve como cifrado
            int[] encriptado = new int[texto.Length * 2];
            coordenadasX.CopyTo(encriptado, 0);
            coordenadasY.CopyTo(encriptado, texto.Length);
            // Retornamos el cifrado
            string salida = string.Join("", encriptado);
            return salida;
        }
    }
}
