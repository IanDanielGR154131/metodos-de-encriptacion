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

        // Metodo para encriptar
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
                            coordenadasX[i] = x;
                            coordenadasY[i] = y;
                        }
                    }
                }
            }

            // Junta las coordenadas en un solo array empalmando primero las coordenadas X y luego las Y
            int[] coordenadas = new int[texto.Length * 2];
            coordenadasX.CopyTo(coordenadas, 0);
            coordenadasY.CopyTo(coordenadas, texto.Length);

            // Arreglo donde se guardara el mensaje encriptado
            char[] encriptado = new char[texto.Length];

            // Encripta el mensaje utlizando las coordenadas de la tabla bifid para crear un texto nuevo cifrado
            int ce = 0; // Contador auxiliar para llenar el arreglo encriptado
            for (int i = 0; i < coordenadas.Length; i += 2)
            {
                encriptado[ce] = tabla[coordenadas[i], coordenadas[i+1]];
                ce++;
            }
            
            // Retorna el cifrado
            string salida = new string(encriptado);
            return salida;
            
        }

        // Metodo para desencriptar
        public string Desencriptar(char[] texto)
        { 
            int[] coordenadas = new int[texto.Length * 2]; // Arreglo para guardar las coordenadas donde coincida el texto con la tabla bifid

            int cc = 0; // Contador auxiliar para llenar el arreglo cordenadas

            // Recorre la tabla bifid buscando las coincidencias del texto y guarda las coordenadas de esas coincidencias
            for (int i = 0; i < texto.Length; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        if (texto[i] == tabla[x, y])
                        {
                            coordenadas[cc] = x;
                            cc++;
                            coordenadas[cc] = y;
                            cc++;
                        }
                    }
                }
            }

            char[] desencriptado = new char[texto.Length]; // Arreglo que guarda el mensaje desencriptado

            // Busca las coordenadas en la tabla bifid y devuelve  su valor para el mensaje desencriptado
            for (int i = 0; i < coordenadas.Length / 2; i++)
            {
                desencriptado[i] = tabla[coordenadas[i], coordenadas[i + coordenadas.Length / 2]];
            }
             
            // Retorna el mensaje desencriptado
            string salida = new string(desencriptado);
            return salida;
        }
    }
}
