namespace Metodos_de_encriptacion
{
    partial class Ventana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabpCesar = new System.Windows.Forms.TabPage();
            this.btnCesar = new System.Windows.Forms.Button();
            this.tbKeyCesar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbEngCesar = new System.Windows.Forms.RadioButton();
            this.rbEspCesar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDesCesar = new System.Windows.Forms.RadioButton();
            this.rbEnCesar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutCesar = new System.Windows.Forms.TextBox();
            this.tbInCesar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnATBASH = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbDesAT = new System.Windows.Forms.RadioButton();
            this.rbEnAt = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOutAT = new System.Windows.Forms.TextBox();
            this.tbInAT = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnVigenere = new System.Windows.Forms.Button();
            this.tbKeyVigenere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbDesVigenere = new System.Windows.Forms.RadioButton();
            this.rbEnVigenere = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOutVigenere = new System.Windows.Forms.TextBox();
            this.tbInVigenere = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBifid = new System.Windows.Forms.Button();
            this.tbKeyBifid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDesBifid = new System.Windows.Forms.RadioButton();
            this.rbEnBifid = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOutBifid = new System.Windows.Forms.TextBox();
            this.tbInBifid = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnXOR = new System.Windows.Forms.Button();
            this.tbKeyXOR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbOutXOR = new System.Windows.Forms.TextBox();
            this.tbInXOR = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabpCesar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpCesar);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(879, 350);
            this.tabControl.TabIndex = 1;
            // 
            // tabpCesar
            // 
            this.tabpCesar.Controls.Add(this.btnCesar);
            this.tabpCesar.Controls.Add(this.tbKeyCesar);
            this.tabpCesar.Controls.Add(this.label3);
            this.tabpCesar.Controls.Add(this.groupBox2);
            this.tabpCesar.Controls.Add(this.groupBox1);
            this.tabpCesar.Controls.Add(this.label2);
            this.tabpCesar.Controls.Add(this.label1);
            this.tabpCesar.Controls.Add(this.tbOutCesar);
            this.tabpCesar.Controls.Add(this.tbInCesar);
            this.tabpCesar.Location = new System.Drawing.Point(4, 25);
            this.tabpCesar.Name = "tabpCesar";
            this.tabpCesar.Padding = new System.Windows.Forms.Padding(3);
            this.tabpCesar.Size = new System.Drawing.Size(871, 321);
            this.tabpCesar.TabIndex = 0;
            this.tabpCesar.Text = "César";
            this.tabpCesar.UseVisualStyleBackColor = true;
            // 
            // btnCesar
            // 
            this.btnCesar.AutoSize = true;
            this.btnCesar.Location = new System.Drawing.Point(392, 278);
            this.btnCesar.Name = "btnCesar";
            this.btnCesar.Size = new System.Drawing.Size(76, 27);
            this.btnCesar.TabIndex = 8;
            this.btnCesar.Text = "Ejecutar";
            this.btnCesar.UseVisualStyleBackColor = true;
            this.btnCesar.Click += new System.EventHandler(this.BtnCesar_Click);
            // 
            // tbKeyCesar
            // 
            this.tbKeyCesar.Location = new System.Drawing.Point(423, 233);
            this.tbKeyCesar.Name = "tbKeyCesar";
            this.tbKeyCesar.Size = new System.Drawing.Size(45, 24);
            this.tbKeyCesar.TabIndex = 7;
            this.tbKeyCesar.Text = "0";
            this.tbKeyCesar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clave:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEngCesar);
            this.groupBox2.Controls.Add(this.rbEspCesar);
            this.groupBox2.Location = new System.Drawing.Point(333, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 86);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Idioma";
            // 
            // rbEngCesar
            // 
            this.rbEngCesar.AutoSize = true;
            this.rbEngCesar.Location = new System.Drawing.Point(20, 52);
            this.rbEngCesar.Name = "rbEngCesar";
            this.rbEngCesar.Size = new System.Drawing.Size(68, 21);
            this.rbEngCesar.TabIndex = 1;
            this.rbEngCesar.Text = "Inglés";
            this.rbEngCesar.UseVisualStyleBackColor = true;
            // 
            // rbEspCesar
            // 
            this.rbEspCesar.AutoSize = true;
            this.rbEspCesar.Checked = true;
            this.rbEspCesar.Location = new System.Drawing.Point(20, 29);
            this.rbEspCesar.Name = "rbEspCesar";
            this.rbEspCesar.Size = new System.Drawing.Size(81, 21);
            this.rbEspCesar.TabIndex = 0;
            this.rbEspCesar.TabStop = true;
            this.rbEspCesar.Text = "Español";
            this.rbEspCesar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDesCesar);
            this.groupBox1.Controls.Add(this.rbEnCesar);
            this.groupBox1.Location = new System.Drawing.Point(333, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            // 
            // rbDesCesar
            // 
            this.rbDesCesar.AutoSize = true;
            this.rbDesCesar.Location = new System.Drawing.Point(20, 52);
            this.rbDesCesar.Name = "rbDesCesar";
            this.rbDesCesar.Size = new System.Drawing.Size(115, 21);
            this.rbDesCesar.TabIndex = 1;
            this.rbDesCesar.Text = "Desencriptar";
            this.rbDesCesar.UseVisualStyleBackColor = true;
            // 
            // rbEnCesar
            // 
            this.rbEnCesar.AutoSize = true;
            this.rbEnCesar.Checked = true;
            this.rbEnCesar.Location = new System.Drawing.Point(20, 29);
            this.rbEnCesar.Name = "rbEnCesar";
            this.rbEnCesar.Size = new System.Drawing.Size(89, 21);
            this.rbEnCesar.TabIndex = 0;
            this.rbEnCesar.TabStop = true;
            this.rbEnCesar.Text = "Encriptar";
            this.rbEnCesar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrada";
            // 
            // tbOutCesar
            // 
            this.tbOutCesar.BackColor = System.Drawing.SystemColors.Menu;
            this.tbOutCesar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOutCesar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutCesar.Location = new System.Drawing.Point(557, 32);
            this.tbOutCesar.Multiline = true;
            this.tbOutCesar.Name = "tbOutCesar";
            this.tbOutCesar.ReadOnly = true;
            this.tbOutCesar.Size = new System.Drawing.Size(284, 245);
            this.tbOutCesar.TabIndex = 1;
            // 
            // tbInCesar
            // 
            this.tbInCesar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInCesar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInCesar.Location = new System.Drawing.Point(23, 32);
            this.tbInCesar.Multiline = true;
            this.tbInCesar.Name = "tbInCesar";
            this.tbInCesar.Size = new System.Drawing.Size(284, 245);
            this.tbInCesar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnATBASH);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbOutAT);
            this.tabPage2.Controls.Add(this.tbInAT);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ATBASH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnATBASH
            // 
            this.btnATBASH.AutoSize = true;
            this.btnATBASH.Location = new System.Drawing.Point(391, 149);
            this.btnATBASH.Name = "btnATBASH";
            this.btnATBASH.Size = new System.Drawing.Size(76, 27);
            this.btnATBASH.TabIndex = 17;
            this.btnATBASH.Text = "Ejecutar";
            this.btnATBASH.UseVisualStyleBackColor = true;
            this.btnATBASH.Click += new System.EventHandler(this.BtnATBASH_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbDesAT);
            this.groupBox4.Controls.Add(this.rbEnAt);
            this.groupBox4.Location = new System.Drawing.Point(332, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 89);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forma";
            // 
            // rbDesAT
            // 
            this.rbDesAT.AutoSize = true;
            this.rbDesAT.Location = new System.Drawing.Point(20, 52);
            this.rbDesAT.Name = "rbDesAT";
            this.rbDesAT.Size = new System.Drawing.Size(115, 21);
            this.rbDesAT.TabIndex = 1;
            this.rbDesAT.Text = "Desencriptar";
            this.rbDesAT.UseVisualStyleBackColor = true;
            // 
            // rbEnAt
            // 
            this.rbEnAt.AutoSize = true;
            this.rbEnAt.Checked = true;
            this.rbEnAt.Location = new System.Drawing.Point(20, 29);
            this.rbEnAt.Name = "rbEnAt";
            this.rbEnAt.Size = new System.Drawing.Size(89, 21);
            this.rbEnAt.TabIndex = 0;
            this.rbEnAt.TabStop = true;
            this.rbEnAt.Text = "Encriptar";
            this.rbEnAt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(678, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Entrada";
            // 
            // tbOutAT
            // 
            this.tbOutAT.BackColor = System.Drawing.SystemColors.Menu;
            this.tbOutAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOutAT.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutAT.Location = new System.Drawing.Point(556, 34);
            this.tbOutAT.Multiline = true;
            this.tbOutAT.Name = "tbOutAT";
            this.tbOutAT.Size = new System.Drawing.Size(284, 245);
            this.tbOutAT.TabIndex = 10;
            // 
            // tbInAT
            // 
            this.tbInAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInAT.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInAT.Location = new System.Drawing.Point(22, 34);
            this.tbInAT.Multiline = true;
            this.tbInAT.Name = "tbInAT";
            this.tbInAT.Size = new System.Drawing.Size(284, 245);
            this.tbInAT.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnVigenere);
            this.tabPage1.Controls.Add(this.tbKeyVigenere);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbOutVigenere);
            this.tabPage1.Controls.Add(this.tbInVigenere);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 321);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Vigenère";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnVigenere
            // 
            this.btnVigenere.AutoSize = true;
            this.btnVigenere.Location = new System.Drawing.Point(395, 218);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(76, 27);
            this.btnVigenere.TabIndex = 17;
            this.btnVigenere.Text = "Ejecutar";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // tbKeyVigenere
            // 
            this.tbKeyVigenere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbKeyVigenere.Location = new System.Drawing.Point(384, 144);
            this.tbKeyVigenere.Name = "tbKeyVigenere";
            this.tbKeyVigenere.Size = new System.Drawing.Size(145, 24);
            this.tbKeyVigenere.TabIndex = 16;
            this.tbKeyVigenere.Text = "A";
            this.tbKeyVigenere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Clave:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbDesVigenere);
            this.groupBox5.Controls.Add(this.rbEnVigenere);
            this.groupBox5.Location = new System.Drawing.Point(336, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 89);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Forma";
            // 
            // rbDesVigenere
            // 
            this.rbDesVigenere.AutoSize = true;
            this.rbDesVigenere.Location = new System.Drawing.Point(20, 52);
            this.rbDesVigenere.Name = "rbDesVigenere";
            this.rbDesVigenere.Size = new System.Drawing.Size(115, 21);
            this.rbDesVigenere.TabIndex = 1;
            this.rbDesVigenere.Text = "Desencriptar";
            this.rbDesVigenere.UseVisualStyleBackColor = true;
            // 
            // rbEnVigenere
            // 
            this.rbEnVigenere.AutoSize = true;
            this.rbEnVigenere.Checked = true;
            this.rbEnVigenere.Location = new System.Drawing.Point(20, 29);
            this.rbEnVigenere.Name = "rbEnVigenere";
            this.rbEnVigenere.Size = new System.Drawing.Size(89, 21);
            this.rbEnVigenere.TabIndex = 0;
            this.rbEnVigenere.TabStop = true;
            this.rbEnVigenere.Text = "Encriptar";
            this.rbEnVigenere.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(684, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(130, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Entrada";
            // 
            // tbOutVigenere
            // 
            this.tbOutVigenere.BackColor = System.Drawing.SystemColors.Menu;
            this.tbOutVigenere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOutVigenere.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutVigenere.Location = new System.Drawing.Point(560, 34);
            this.tbOutVigenere.Multiline = true;
            this.tbOutVigenere.Name = "tbOutVigenere";
            this.tbOutVigenere.ReadOnly = true;
            this.tbOutVigenere.Size = new System.Drawing.Size(284, 245);
            this.tbOutVigenere.TabIndex = 10;
            // 
            // tbInVigenere
            // 
            this.tbInVigenere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInVigenere.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInVigenere.Location = new System.Drawing.Point(26, 34);
            this.tbInVigenere.Multiline = true;
            this.tbInVigenere.Name = "tbInVigenere";
            this.tbInVigenere.Size = new System.Drawing.Size(284, 245);
            this.tbInVigenere.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBifid);
            this.tabPage3.Controls.Add(this.tbKeyBifid);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tbOutBifid);
            this.tabPage3.Controls.Add(this.tbInBifid);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(871, 321);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Bífid";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBifid
            // 
            this.btnBifid.AutoSize = true;
            this.btnBifid.Location = new System.Drawing.Point(395, 232);
            this.btnBifid.Name = "btnBifid";
            this.btnBifid.Size = new System.Drawing.Size(76, 27);
            this.btnBifid.TabIndex = 25;
            this.btnBifid.Text = "Ejecutar";
            this.btnBifid.UseVisualStyleBackColor = true;
            this.btnBifid.Click += new System.EventHandler(this.BtnBifid_Click);
            // 
            // tbKeyBifid
            // 
            this.tbKeyBifid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbKeyBifid.Location = new System.Drawing.Point(384, 158);
            this.tbKeyBifid.Name = "tbKeyBifid";
            this.tbKeyBifid.Size = new System.Drawing.Size(145, 24);
            this.tbKeyBifid.TabIndex = 24;
            this.tbKeyBifid.Text = "A";
            this.tbKeyBifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Clave:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDesBifid);
            this.groupBox3.Controls.Add(this.rbEnBifid);
            this.groupBox3.Location = new System.Drawing.Point(336, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 89);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forma";
            // 
            // rbDesBifid
            // 
            this.rbDesBifid.AutoSize = true;
            this.rbDesBifid.Location = new System.Drawing.Point(20, 52);
            this.rbDesBifid.Name = "rbDesBifid";
            this.rbDesBifid.Size = new System.Drawing.Size(115, 21);
            this.rbDesBifid.TabIndex = 1;
            this.rbDesBifid.Text = "Desencriptar";
            this.rbDesBifid.UseVisualStyleBackColor = true;
            // 
            // rbEnBifid
            // 
            this.rbEnBifid.AutoSize = true;
            this.rbEnBifid.Checked = true;
            this.rbEnBifid.Location = new System.Drawing.Point(20, 29);
            this.rbEnBifid.Name = "rbEnBifid";
            this.rbEnBifid.Size = new System.Drawing.Size(89, 21);
            this.rbEnBifid.TabIndex = 0;
            this.rbEnBifid.TabStop = true;
            this.rbEnBifid.Text = "Encriptar";
            this.rbEnBifid.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(684, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Salida";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(130, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Entrada";
            // 
            // tbOutBifid
            // 
            this.tbOutBifid.BackColor = System.Drawing.SystemColors.Menu;
            this.tbOutBifid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOutBifid.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutBifid.Location = new System.Drawing.Point(560, 48);
            this.tbOutBifid.Multiline = true;
            this.tbOutBifid.Name = "tbOutBifid";
            this.tbOutBifid.ReadOnly = true;
            this.tbOutBifid.Size = new System.Drawing.Size(284, 245);
            this.tbOutBifid.TabIndex = 19;
            // 
            // tbInBifid
            // 
            this.tbInBifid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInBifid.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInBifid.Location = new System.Drawing.Point(26, 48);
            this.tbInBifid.Multiline = true;
            this.tbInBifid.Name = "tbInBifid";
            this.tbInBifid.Size = new System.Drawing.Size(284, 245);
            this.tbInBifid.TabIndex = 18;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnXOR);
            this.tabPage4.Controls.Add(this.tbKeyXOR);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.tbOutXOR);
            this.tabPage4.Controls.Add(this.tbInXOR);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(871, 321);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "XOR";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnXOR
            // 
            this.btnXOR.AutoSize = true;
            this.btnXOR.Location = new System.Drawing.Point(402, 158);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(76, 27);
            this.btnXOR.TabIndex = 33;
            this.btnXOR.Text = "Ejecutar";
            this.btnXOR.UseVisualStyleBackColor = true;
            this.btnXOR.Click += new System.EventHandler(this.btnXOR_Click);
            // 
            // tbKeyXOR
            // 
            this.tbKeyXOR.Location = new System.Drawing.Point(391, 84);
            this.tbKeyXOR.MaxLength = 1;
            this.tbKeyXOR.Name = "tbKeyXOR";
            this.tbKeyXOR.Size = new System.Drawing.Size(145, 24);
            this.tbKeyXOR.TabIndex = 32;
            this.tbKeyXOR.Text = "A";
            this.tbKeyXOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Clave:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(684, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Salida";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(130, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Entrada";
            // 
            // tbOutXOR
            // 
            this.tbOutXOR.BackColor = System.Drawing.SystemColors.Menu;
            this.tbOutXOR.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutXOR.Location = new System.Drawing.Point(560, 48);
            this.tbOutXOR.Multiline = true;
            this.tbOutXOR.Name = "tbOutXOR";
            this.tbOutXOR.ReadOnly = true;
            this.tbOutXOR.Size = new System.Drawing.Size(284, 245);
            this.tbOutXOR.TabIndex = 27;
            // 
            // tbInXOR
            // 
            this.tbInXOR.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInXOR.Location = new System.Drawing.Point(26, 48);
            this.tbInXOR.Multiline = true;
            this.tbInXOR.Name = "tbInXOR";
            this.tbInXOR.Size = new System.Drawing.Size(284, 245);
            this.tbInXOR.TabIndex = 26;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(346, 370);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(206, 13);
            this.lbAutor.TabIndex = 2;
            this.lbAutor.Text = "Por: Ian Daniel Garay Rodríguez [154131]";
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(903, 392);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ventana";
            this.ShowIcon = false;
            this.Text = "Métodos de Encriptación";
            this.tabControl.ResumeLayout(false);
            this.tabpCesar.ResumeLayout(false);
            this.tabpCesar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabpCesar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbInCesar;
        private System.Windows.Forms.TextBox tbOutCesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeyCesar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbEngCesar;
        private System.Windows.Forms.RadioButton rbEspCesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDesCesar;
        private System.Windows.Forms.RadioButton rbEnCesar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Button btnCesar;
        private System.Windows.Forms.Button btnATBASH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbDesAT;
        private System.Windows.Forms.RadioButton rbEnAt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOutAT;
        private System.Windows.Forms.TextBox tbInAT;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnVigenere;
        private System.Windows.Forms.TextBox tbKeyVigenere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbDesVigenere;
        private System.Windows.Forms.RadioButton rbEnVigenere;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOutVigenere;
        private System.Windows.Forms.TextBox tbInVigenere;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnBifid;
        private System.Windows.Forms.TextBox tbKeyBifid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDesBifid;
        private System.Windows.Forms.RadioButton rbEnBifid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbOutBifid;
        private System.Windows.Forms.TextBox tbInBifid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.TextBox tbKeyXOR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbOutXOR;
        private System.Windows.Forms.TextBox tbInXOR;
    }
}

