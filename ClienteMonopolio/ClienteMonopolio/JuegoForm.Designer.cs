namespace ClienteMonopolio
{
    partial class JuegoForm
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
            this.lazul = new System.Windows.Forms.Label();
            this.lTablero = new System.Windows.Forms.Label();
            this.lverde = new System.Windows.Forms.Label();
            this.lamarilla = new System.Windows.Forms.Label();
            this.lroja = new System.Windows.Forms.Label();
            this.bLanzar = new System.Windows.Forms.Button();
            this.bComprarPropiedad = new System.Windows.Forms.Button();
            this.bComprarCasa = new System.Windows.Forms.Button();
            this.bComprarHotel = new System.Windows.Forms.Button();
            this.bSalirCarcelA = new System.Windows.Forms.Button();
            this.bSalirCarcelC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lJugadores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lJugadorPropiedades = new System.Windows.Forms.ListBox();
            this.bSaltarTurno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lazul
            // 
            this.lazul.BackColor = System.Drawing.Color.Transparent;
            this.lazul.Image = global::ClienteMonopolio.Properties.Resources.FichaAzul;
            this.lazul.Location = new System.Drawing.Point(515, 448);
            this.lazul.Name = "lazul";
            this.lazul.Size = new System.Drawing.Size(15, 15);
            this.lazul.TabIndex = 2;
            // 
            // lTablero
            // 
            this.lTablero.BackColor = System.Drawing.Color.Transparent;
            this.lTablero.Image = global::ClienteMonopolio.Properties.Resources.tablero;
            this.lTablero.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lTablero.Location = new System.Drawing.Point(-1, -1);
            this.lTablero.Name = "lTablero";
            this.lTablero.Size = new System.Drawing.Size(565, 571);
            this.lTablero.TabIndex = 1;
            // 
            // lverde
            // 
            this.lverde.BackColor = System.Drawing.Color.Transparent;
            this.lverde.Image = global::ClienteMonopolio.Properties.Resources.FichaVerde;
            this.lverde.Location = new System.Drawing.Point(540, 469);
            this.lverde.Name = "lverde";
            this.lverde.Size = new System.Drawing.Size(15, 15);
            this.lverde.TabIndex = 3;
            // 
            // lamarilla
            // 
            this.lamarilla.BackColor = System.Drawing.Color.Transparent;
            this.lamarilla.Image = global::ClienteMonopolio.Properties.Resources.FichaAmarilla;
            this.lamarilla.Location = new System.Drawing.Point(515, 469);
            this.lamarilla.Name = "lamarilla";
            this.lamarilla.Size = new System.Drawing.Size(15, 15);
            this.lamarilla.TabIndex = 4;
            // 
            // lroja
            // 
            this.lroja.BackColor = System.Drawing.Color.Transparent;
            this.lroja.Image = global::ClienteMonopolio.Properties.Resources.FichaRoja1;
            this.lroja.Location = new System.Drawing.Point(540, 448);
            this.lroja.Name = "lroja";
            this.lroja.Size = new System.Drawing.Size(15, 15);
            this.lroja.TabIndex = 5;
            // 
            // bLanzar
            // 
            this.bLanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLanzar.Location = new System.Drawing.Point(590, 12);
            this.bLanzar.Name = "bLanzar";
            this.bLanzar.Size = new System.Drawing.Size(215, 40);
            this.bLanzar.TabIndex = 6;
            this.bLanzar.Text = "LANZAR DADO";
            this.bLanzar.UseVisualStyleBackColor = true;
            this.bLanzar.Click += new System.EventHandler(this.bLanzar_Click);
            // 
            // bComprarPropiedad
            // 
            this.bComprarPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bComprarPropiedad.Location = new System.Drawing.Point(590, 97);
            this.bComprarPropiedad.Name = "bComprarPropiedad";
            this.bComprarPropiedad.Size = new System.Drawing.Size(136, 28);
            this.bComprarPropiedad.TabIndex = 7;
            this.bComprarPropiedad.Text = "Comprar Propiedad";
            this.bComprarPropiedad.UseVisualStyleBackColor = true;
            // 
            // bComprarCasa
            // 
            this.bComprarCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bComprarCasa.Location = new System.Drawing.Point(759, 97);
            this.bComprarCasa.Name = "bComprarCasa";
            this.bComprarCasa.Size = new System.Drawing.Size(136, 28);
            this.bComprarCasa.TabIndex = 8;
            this.bComprarCasa.Text = "Comprar Casa";
            this.bComprarCasa.UseVisualStyleBackColor = true;
            // 
            // bComprarHotel
            // 
            this.bComprarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bComprarHotel.Location = new System.Drawing.Point(928, 97);
            this.bComprarHotel.Name = "bComprarHotel";
            this.bComprarHotel.Size = new System.Drawing.Size(136, 28);
            this.bComprarHotel.TabIndex = 9;
            this.bComprarHotel.Text = "Comprar Hotel";
            this.bComprarHotel.UseVisualStyleBackColor = true;
            // 
            // bSalirCarcelA
            // 
            this.bSalirCarcelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalirCarcelA.Location = new System.Drawing.Point(590, 145);
            this.bSalirCarcelA.Name = "bSalirCarcelA";
            this.bSalirCarcelA.Size = new System.Drawing.Size(215, 28);
            this.bSalirCarcelA.TabIndex = 10;
            this.bSalirCarcelA.Text = "Salir de la Carcel (arca)";
            this.bSalirCarcelA.UseVisualStyleBackColor = true;
            // 
            // bSalirCarcelC
            // 
            this.bSalirCarcelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalirCarcelC.Location = new System.Drawing.Point(849, 145);
            this.bSalirCarcelC.Name = "bSalirCarcelC";
            this.bSalirCarcelC.Size = new System.Drawing.Size(215, 28);
            this.bSalirCarcelC.TabIndex = 11;
            this.bSalirCarcelC.Text = "Salir de la Carcel (casualidad)";
            this.bSalirCarcelC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jugadores:";
            // 
            // lJugadores
            // 
            this.lJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJugadores.FormattingEnabled = true;
            this.lJugadores.ItemHeight = 16;
            this.lJugadores.Location = new System.Drawing.Point(590, 225);
            this.lJugadores.Name = "lJugadores";
            this.lJugadores.Size = new System.Drawing.Size(474, 84);
            this.lJugadores.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tus Propiedades:";
            // 
            // lJugadorPropiedades
            // 
            this.lJugadorPropiedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJugadorPropiedades.FormattingEnabled = true;
            this.lJugadorPropiedades.ItemHeight = 16;
            this.lJugadorPropiedades.Location = new System.Drawing.Point(590, 364);
            this.lJugadorPropiedades.Name = "lJugadorPropiedades";
            this.lJugadorPropiedades.Size = new System.Drawing.Size(474, 164);
            this.lJugadorPropiedades.TabIndex = 15;
            // 
            // bSaltarTurno
            // 
            this.bSaltarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSaltarTurno.Location = new System.Drawing.Point(849, 12);
            this.bSaltarTurno.Name = "bSaltarTurno";
            this.bSaltarTurno.Size = new System.Drawing.Size(215, 40);
            this.bSaltarTurno.TabIndex = 17;
            this.bSaltarTurno.Text = "SALTAR TURNO";
            this.bSaltarTurno.UseVisualStyleBackColor = true;
            // 
            // bSaltar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 566);
            this.Controls.Add(this.bSaltarTurno);
            this.Controls.Add(this.lJugadorPropiedades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lJugadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSalirCarcelC);
            this.Controls.Add(this.bSalirCarcelA);
            this.Controls.Add(this.bComprarHotel);
            this.Controls.Add(this.bComprarCasa);
            this.Controls.Add(this.bComprarPropiedad);
            this.Controls.Add(this.bLanzar);
            this.Controls.Add(this.lroja);
            this.Controls.Add(this.lamarilla);
            this.Controls.Add(this.lverde);
            this.Controls.Add(this.lazul);
            this.Controls.Add(this.lTablero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "bSaltar";
            this.Text = "JuegoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JuegoForm_FormClosing);
            this.Load += new System.EventHandler(this.JuegoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTablero;
        public System.Windows.Forms.Label lazul;
        public System.Windows.Forms.Label lverde;
        public System.Windows.Forms.Label lamarilla;
        public System.Windows.Forms.Label lroja;
        private System.Windows.Forms.Button bLanzar;
        private System.Windows.Forms.Button bComprarPropiedad;
        private System.Windows.Forms.Button bComprarCasa;
        private System.Windows.Forms.Button bComprarHotel;
        private System.Windows.Forms.Button bSalirCarcelA;
        private System.Windows.Forms.Button bSalirCarcelC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lJugadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lJugadorPropiedades;
        private System.Windows.Forms.Button bSaltarTurno;
    }
}