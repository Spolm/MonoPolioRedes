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
            this.tLogs = new System.Windows.Forms.TextBox();
            this.bApagar = new System.Windows.Forms.Button();
            this.bIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tIP = new System.Windows.Forms.TextBox();
            this.tPuerto = new System.Windows.Forms.TextBox();
            this.lListaJugadores = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cCantidadJugadores = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tLogs
            // 
            this.tLogs.BackColor = System.Drawing.Color.White;
            this.tLogs.Location = new System.Drawing.Point(12, 40);
            this.tLogs.Multiline = true;
            this.tLogs.Name = "tLogs";
            this.tLogs.ReadOnly = true;
            this.tLogs.Size = new System.Drawing.Size(558, 467);
            this.tLogs.TabIndex = 0;
            this.tLogs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bApagar
            // 
            this.bApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bApagar.Location = new System.Drawing.Point(586, 476);
            this.bApagar.Name = "bApagar";
            this.bApagar.Size = new System.Drawing.Size(315, 31);
            this.bApagar.TabIndex = 5;
            this.bApagar.Text = "Cerrar Conexión";
            this.bApagar.UseVisualStyleBackColor = true;
            this.bApagar.Click += new System.EventHandler(this.bApagar_Click);
            // 
            // bIniciar
            // 
            this.bIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIniciar.Location = new System.Drawing.Point(586, 425);
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
            this.label1.Location = new System.Drawing.Point(583, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dirección IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puerto:";
            // 
            // tIP
            // 
            this.tIP.Location = new System.Drawing.Point(673, 359);
            this.tIP.Name = "tIP";
            this.tIP.Size = new System.Drawing.Size(228, 20);
            this.tIP.TabIndex = 2;
            // 
            // tPuerto
            // 
            this.tPuerto.Location = new System.Drawing.Point(672, 391);
            this.tPuerto.Name = "tPuerto";
            this.tPuerto.Size = new System.Drawing.Size(95, 20);
            this.tPuerto.TabIndex = 3;
            // 
            // lListaJugadores
            // 
            this.lListaJugadores.FormattingEnabled = true;
            this.lListaJugadores.Location = new System.Drawing.Point(586, 40);
            this.lListaJugadores.Name = "lListaJugadores";
            this.lListaJugadores.Size = new System.Drawing.Size(315, 160);
            this.lListaJugadores.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "LOGS - SERVIDOR MONOPOLIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lista de Jugadores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Configuración de la partida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(583, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "N# Jugadores:";
            // 
            // cCantidadJugadores
            // 
            this.cCantidadJugadores.FormattingEnabled = true;
            this.cCantidadJugadores.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cCantidadJugadores.Location = new System.Drawing.Point(685, 260);
            this.cCantidadJugadores.Name = "cCantidadJugadores";
            this.cCantidadJugadores.Size = new System.Drawing.Size(64, 21);
            this.cCantidadJugadores.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(582, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Configuración de conexión";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 519);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cCantidadJugadores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lListaJugadores);
            this.Controls.Add(this.tPuerto);
            this.Controls.Add(this.tIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.bApagar);
            this.Controls.Add(this.tLogs);
            this.Name = "ServerForm";
            this.Text = "Servidor - Monopolio";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tLogs;
        private System.Windows.Forms.Button bApagar;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tIP;
        private System.Windows.Forms.TextBox tPuerto;
        private System.Windows.Forms.ListBox lListaJugadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cCantidadJugadores;
        private System.Windows.Forms.Label label7;
    }
}

