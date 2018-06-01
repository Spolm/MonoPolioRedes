namespace ServidorMonopolio
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tPuerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tIP = new System.Windows.Forms.TextBox();
            this.cCantidadJugadores = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tLogs = new System.Windows.Forms.TextBox();
            this.lListaJugadores = new System.Windows.Forms.ListBox();
            this.lListaPropiedades = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bRegistarJugador = new System.Windows.Forms.Button();
            this.lJugadoresRegistrados = new System.Windows.Forms.ListBox();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Panel de Administración";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cCantidadJugadores);
            this.panel1.Controls.Add(this.tIP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bIniciar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tPuerto);
            this.panel1.Location = new System.Drawing.Point(21, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 217);
            this.panel1.TabIndex = 12;
            // 
            // tPuerto
            // 
            this.tPuerto.Location = new System.Drawing.Point(107, 95);
            this.tPuerto.Name = "tPuerto";
            this.tPuerto.Size = new System.Drawing.Size(95, 20);
            this.tPuerto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puerto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Configuración de la partida";
            // 
            // bIniciar
            // 
            this.bIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIniciar.Location = new System.Drawing.Point(282, 147);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(315, 34);
            this.bIniciar.TabIndex = 4;
            this.bIniciar.Text = "Crear Partida";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dirección IP:";
            // 
            // tIP
            // 
            this.tIP.Location = new System.Drawing.Point(107, 58);
            this.tIP.Name = "tIP";
            this.tIP.Size = new System.Drawing.Size(228, 20);
            this.tIP.TabIndex = 2;
            // 
            // cCantidadJugadores
            // 
            this.cCantidadJugadores.FormattingEnabled = true;
            this.cCantidadJugadores.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cCantidadJugadores.Location = new System.Drawing.Point(682, 58);
            this.cCantidadJugadores.Name = "cCantidadJugadores";
            this.cCantidadJugadores.Size = new System.Drawing.Size(64, 21);
            this.cCantidadJugadores.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "N# Jugadores:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Configuración de conexión";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lListaPropiedades);
            this.tabPage1.Controls.Add(this.lListaJugadores);
            this.tabPage1.Controls.Add(this.tLogs);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estadisticas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(578, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jugadores Conectados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "LOGS - SERVIDOR MONOPOLIO";
            // 
            // tLogs
            // 
            this.tLogs.BackColor = System.Drawing.Color.White;
            this.tLogs.Location = new System.Drawing.Point(10, 42);
            this.tLogs.Multiline = true;
            this.tLogs.Name = "tLogs";
            this.tLogs.ReadOnly = true;
            this.tLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tLogs.Size = new System.Drawing.Size(523, 248);
            this.tLogs.TabIndex = 0;
            this.tLogs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lListaJugadores
            // 
            this.lListaJugadores.FormattingEnabled = true;
            this.lListaJugadores.Location = new System.Drawing.Point(582, 42);
            this.lListaJugadores.Name = "lListaJugadores";
            this.lListaJugadores.Size = new System.Drawing.Size(315, 108);
            this.lListaJugadores.TabIndex = 6;
            // 
            // lListaPropiedades
            // 
            this.lListaPropiedades.FormattingEnabled = true;
            this.lListaPropiedades.Location = new System.Drawing.Point(582, 195);
            this.lListaPropiedades.Name = "lListaPropiedades";
            this.lListaPropiedades.Size = new System.Drawing.Size(315, 290);
            this.lListaPropiedades.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Propiedades:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 535);
            this.tabControl1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bRegistarJugador);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.tUsuario);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.tNombre);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(21, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 233);
            this.panel2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Registrar Jugador";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lJugadoresRegistrados);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(492, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 233);
            this.panel3.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Jugadores Registrados";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Apellido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Nombre:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(102, 52);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(190, 20);
            this.tNombre.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 21;
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(102, 124);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(190, 20);
            this.tUsuario.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Contraseña:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Usuario:";
            // 
            // bRegistarJugador
            // 
            this.bRegistarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistarJugador.Location = new System.Drawing.Point(165, 190);
            this.bRegistarJugador.Name = "bRegistarJugador";
            this.bRegistarJugador.Size = new System.Drawing.Size(75, 32);
            this.bRegistarJugador.TabIndex = 22;
            this.bRegistarJugador.Text = "Registrar";
            this.bRegistarJugador.UseVisualStyleBackColor = true;
            this.bRegistarJugador.Click += new System.EventHandler(this.bRegistarJugador_Click);
            // 
            // lJugadoresRegistrados
            // 
            this.lJugadoresRegistrados.FormattingEnabled = true;
            this.lJugadoresRegistrados.Location = new System.Drawing.Point(21, 53);
            this.lJugadoresRegistrados.Name = "lJugadoresRegistrados";
            this.lJugadoresRegistrados.Size = new System.Drawing.Size(368, 160);
            this.lJugadoresRegistrados.TabIndex = 13;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 556);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServerForm";
            this.Text = "Servidor - Monopolio";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cCantidadJugadores;
        private System.Windows.Forms.TextBox tIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPuerto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lListaPropiedades;
        private System.Windows.Forms.ListBox lListaJugadores;
        private System.Windows.Forms.TextBox tLogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bRegistarJugador;
        private System.Windows.Forms.ListBox lJugadoresRegistrados;
    }
}

