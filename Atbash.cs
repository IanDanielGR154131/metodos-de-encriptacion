using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_encriptacion
{
    class Atbash
    {
        // Definir abecedarios original e invertido
        char[] abecedario_o = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] abecedario_i = { 'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q', 'P', 'O', 'N', 'M', 'L', 'K', 'J', 'I', 'H', 'G', 'F', 'E', 'D', 'C', 'B', 'A' };
        
        // Metodo para encriptar
        public string Encriptar(char[] entrada)
        {
            // Definir array de salida
            char[] salida = new char[entrada.Length];
            // Encripta el mensaje
            for (int i = 0; i < entrada.Length; i++)
            {
                for (int j = 0; j < abecedario_o.Length; j++)
                {
                    if (entrada[i] == abecedario_o[j])
                    {
                        salida[i] = abecedario_i[j];
                        break;
                    }
                    else
                    {
                        salida[i] = ' ';
                    }
                }
            }
            // Retornar el mensaje
            string mensaje_encriptado = new string(salida);
            return mensaje_encriptado;
        }

        // Metodo para desencriptar
        public string Desencriptar(char[] entrada)
        {
            // Definir array de salida
            char[] salida = new char[entrada.Length];
            // Desencripta el mensaje
            for (int i = 0; i < entrada.Length; i++)
            {
                for (int j = 0; j < abecedario_i.Length; j++)
                {
                    if (entrada[i] == abecedario_i[j])
                    {
                        salida[i] = abecedario_o[j];
                        break;
                    }
                    else
                    {
                        salida[i] = ' ';
                    }
                }
            }
            // Retornar el mensaje
            string mensaje_desencriptado = new string(salida);
            return mensaje_desencriptado;
        }
    }
}
