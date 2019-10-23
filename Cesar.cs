using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_encriptacion
{
    class Cesar
    {
        // Define los abecedarios español e ingles
        char[] abecedario_esp = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        char[] abecedario_eng = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        // Metodo que crea el nuevo abecedario
        public char[] CrearAbecedario(int clave, string idioma)
        {
            // Caso español
            if (idioma == "esp") {
                // Define el nuevo abecedario
                int num_chars = 27;
                char[] abecedario_new = new char[num_chars];
                // Llena la primer parte del abecedario empezando desde donde indique la clave
                for (int i = 0; i < num_chars - clave; i++) {
                    abecedario_new[i] = abecedario_esp[i + clave];
                }
                // Llena la segunda parte del abecedario con los caracteres que quedan
                for (int i = num_chars - clave; i < num_chars; i++) {
                    abecedario_new[i] = abecedario_esp[i - (num_chars - clave)];
                }
                // Retorna el nuevo abecedario
                return abecedario_new;
            }
            // Caso ingles
            else {
                // Define el nuevo abecedario
                int num_chars = 26;
                char[] abecedario_new = new char[num_chars];
                // Llena la primer parte del abecedario empezando desde donde indique la clave
                for (int i = 0; i < num_chars - clave; i++) {
                    abecedario_new[i] = abecedario_eng[i + clave];
                }
                // Llena la segunda parte del abecedario con los caracteres que quedan
                for (int i = num_chars - clave; i < num_chars; i++) {
                    abecedario_new[i] = abecedario_eng[i - (num_chars - clave)];
                }
                // Retorna el nuevo abecedario
                return abecedario_new;
            }
        }

        // Metodo para encriptar
        public string Encriptar(char[] entrada, char[] abecedario_new, string idioma)
        {
            // Caso español
            if (idioma == "esp") {
                // Crear salida del mismo tamaño que la entrada
                char[] salida = new char[entrada.Length];
                // Encripta el mensaje
                for (int i = 0; i < entrada.Length; i++) {
                    for (int j = 0; j < abecedario_esp.Length; j++) {
                        if (entrada[i] == abecedario_esp[j]) {
                            salida[i] = abecedario_new[j];
                            break;
                        }
                        else {
                            salida[i] = ' ';
                        }
                    }
                }
                //Retorna el mensaje encriptado
                string mensaje_encriptado = new string(salida);
                return mensaje_encriptado;
            }
            // Caso ingles
            else {
                // Crear salida del mismo tamaño que la entrada
                char[] salida = new char[entrada.Length];
                // Encripta el mensaje
                for (int i = 0; i < entrada.Length; i++) {
                    for (int j = 0; j < abecedario_eng.Length; j++) {
                        if (entrada[i] == abecedario_eng[j]) {
                            salida[i] = abecedario_new[j];
                            break;
                        }
                        else {
                            salida[i] = ' ';
                        }
                    }
                }
                //Retorna el mensaje encriptado
                string mensaje_encriptado = new string(salida);
                return mensaje_encriptado;
            }
        }

        // Metodo para desencriptar
        public string Desencriptar(char[] entrada, char[] abecedario_new, string idioma)
        {
            // Caso español
            if (idioma == "esp")
            {
                // Crear salida del mismo tamaño que la entrada
                char[] salida = new char[entrada.Length];
                // Desencripta el mensaje
                for (int i = 0; i < entrada.Length; i++)
                {
                    for (int j = 0; j < abecedario_new.Length; j++)
                    {
                        if (entrada[i] == abecedario_new[j])
                        {
                            salida[i] = abecedario_esp[j];
                            break;
                        }
                        else
                        {
                            salida[i] = ' ';
                        }
                    }
                }
                //Retorna el mensaje desencriptado
                string mensaje_desencriptado = new string(salida);
                return mensaje_desencriptado;
            }
            // Caso ingles
            else
            {
                // Crear salida del mismo tamaño que la entrada
                char[] salida = new char[entrada.Length];
                // Desencripta el mensaje
                for (int i = 0; i < entrada.Length; i++)
                {
                    for (int j = 0; j < abecedario_new.Length; j++)
                    {
                        if (entrada[i] == abecedario_new[j])
                        {
                            salida[i] = abecedario_eng[j];
                            break;
                        }
                        else
                        {
                            salida[i] = ' ';
                        }
                    }
                }
                //Retorna el mensaje desencriptado
                string mensaje_desencriptado = new string(salida);
                return mensaje_desencriptado;
            }
        }
    }
}
