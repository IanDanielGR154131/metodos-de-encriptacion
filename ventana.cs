using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_de_encriptacion
{
    public partial class Ventana : Form
    {

        Cesar cesar = new Cesar();
        Atbash atbash = new Atbash();
        Vigenere vigenere = new Vigenere();
        Bifid bifid = new Bifid();
        Xor xor = new Xor();

        public Ventana()
        {
            InitializeComponent();
        }

        // Metodo para ejecutar el cifrado Cesar
        private void BtnCesar_Click(object sender, EventArgs e)
        {
            // Clave del algoritmo
            int clave = Convert.ToInt32(tbKeyCesar.Text);
            // Entrada de texto
            char[] entrada = tbInCesar.Text.ToCharArray();

            // Encriptar
            if (rbEnCesar.Checked) {
                // Español
                if (rbEspCesar.Checked) {
                    char[] abecedario_new = cesar.CrearAbecedario(clave, "esp");
                    tbOutCesar.Text = cesar.Encriptar(entrada, abecedario_new, "esp");
                }
                // Ingles
                else if (rbEngCesar.Checked) {
                    char[] abecedario_new = cesar.CrearAbecedario(clave, "eng");
                    tbOutCesar.Text = cesar.Encriptar(entrada, abecedario_new, "eng");
                }
            }
            // Desencriptar
            else if (rbDesCesar.Checked) {
                // Español
                if (rbEspCesar.Checked)
                {
                    char[] abecedario_new = cesar.CrearAbecedario(clave, "esp");
                    tbOutCesar.Text = cesar.Desencriptar(entrada, abecedario_new, "esp");
                }
                // Ingles
                else if (rbEngCesar.Checked)
                {
                    char[] abecedario_new = cesar.CrearAbecedario(clave, "eng");
                    tbOutCesar.Text = cesar.Desencriptar(entrada, abecedario_new, "eng");
                }
            }
        }

        // Metodo para ejecutar el cifrado ATBASH
        private void BtnATBASH_Click(object sender, EventArgs e)
        {
            // Definir entrada de texto
            char[] entrada = tbInAT.Text.ToCharArray();

            // Encriptar
            if (rbEnAt.Checked)
            {
                tbOutAT.Text = atbash.Encriptar(entrada);  
            }
            // Desencriptar
            else if (rbDesAT.Checked)
            {
                tbOutAT.Text = atbash.Desencriptar(entrada);
            }
        }

        // Metodo para ejecutar el cifrado Vigenere
        private void btnVigenere_Click(object sender, EventArgs e)
        {
            // Encriptar
            if (rbEnVigenere.Checked)
            {
                // Leemos el texto a encriptar y la clave quitando espacios
                char[] texto = tbInVigenere.Text.Replace(" ", string.Empty).ToCharArray();
                char[] clave = tbKeyVigenere.Text.Replace(" ", string.Empty).ToCharArray();
                // Guardamos la clave que usaremos para encriptar
                char[] clavefinal = vigenere.CrearClave(texto, clave);
                // Mostramos el texto encriptado
                tbOutVigenere.Text = vigenere.Encriptar(texto, clavefinal);
            }
            // Desencriptar
            else if (rbDesVigenere.Checked)
            {
                // Leemos el texto a desencriptar y la clave quitando espacios
                char[] texto = tbInVigenere.Text.Replace(" ", string.Empty).ToCharArray();
                char[] clave = tbKeyVigenere.Text.Replace(" ", string.Empty).ToCharArray();
                // Guardamos la clave que usaremos para desencriptar
                char[] clavefinal = vigenere.CrearClave(texto, clave);
                // Mostramos el texto desencriptado
                tbOutVigenere.Text = vigenere.Desencriptar(texto, clavefinal);
            }
        }

        private void BtnBifid_Click(object sender, EventArgs e)
        {
            if (rbEnBifid.Checked)
            {
                // Leemos el texto a encriptar y la clave quitando espacios
                char[] clave = tbKeyBifid.Text.Replace(" ", string.Empty).ToCharArray();
                char[] texto = tbInBifid.Text.Replace(" ", string.Empty).ToCharArray();
                // Crea la tabla bifid con la clave
                bifid.CrearTabla(clave);
                // Encripta el mensaje y lo muestra
                tbOutBifid.Text = bifid.Encriptar(texto);
            }
            else if (rbDesBifid.Checked)
            {
                // Leemos el texto a desencriptar y la clave quitando espacios
                char[] clave = tbKeyBifid.Text.Replace(" ", string.Empty).ToCharArray();
                char[] texto = tbInBifid.Text.Replace(" ", string.Empty).ToCharArray();
                // Crea la tabla bifid con la clave
                bifid.CrearTabla(clave);
                // Desncripta el mensaje y lo muestra
                tbOutBifid.Text = bifid.Desencriptar(texto);
            }

        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
                // Leemos el texto a encriptar/desencriptar y la clave
                char clave = tbKeyXOR.Text[0];
                char[] texto = tbInXOR.Text.ToCharArray();
                // Encripta/Desencripta el mensaje
                tbOutXOR.Text = xor.Encriptar(texto, clave);
        }
    }
}
