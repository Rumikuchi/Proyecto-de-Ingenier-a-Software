namespace Proyecto_Fichajes
{
    partial class ModuloFichaje
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
            this.components = new System.ComponentModel.Container();
            this.Son = new System.Windows.Forms.Label();
            this.turnoEmpieza = new System.Windows.Forms.Label();
            this.Fichar = new System.Windows.Forms.Button();
            this.noEntrar = new System.Windows.Forms.Label();
            this.deServicio = new System.Windows.Forms.Label();
            this.turnoFinaliza = new System.Windows.Forms.Label();
            this.noSalir = new System.Windows.Forms.Label();
            this.horaActual = new System.Windows.Forms.Label();
            this.horaEntrada = new System.Windows.Forms.Label();
            this.horaSalida = new System.Windows.Forms.Label();
            this.tiempoServicio = new System.Windows.Forms.Label();
            this.timerSeg = new System.Windows.Forms.Timer(this.components);
            this.timerActual = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Son
            // 
            this.Son.AutoSize = true;
            this.Son.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Son.Location = new System.Drawing.Point(15, 27);
            this.Son.Name = "Son";
            this.Son.Size = new System.Drawing.Size(284, 29);
            this.Son.TabIndex = 0;
            this.Son.Text = "Actualmente son las";
            // 
            // turnoEmpieza
            // 
            this.turnoEmpieza.AutoSize = true;
            this.turnoEmpieza.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoEmpieza.Location = new System.Drawing.Point(15, 72);
            this.turnoEmpieza.Name = "turnoEmpieza";
            this.turnoEmpieza.Size = new System.Drawing.Size(318, 29);
            this.turnoEmpieza.TabIndex = 1;
            this.turnoEmpieza.Text = "Su turno empieza a las";
            // 
            // Fichar
            // 
            this.Fichar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Fichar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Fichar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fichar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fichar.Location = new System.Drawing.Point(151, 162);
            this.Fichar.Name = "Fichar";
            this.Fichar.Size = new System.Drawing.Size(188, 35);
            this.Fichar.TabIndex = 4;
            this.Fichar.Text = "Fichar";
            this.Fichar.UseVisualStyleBackColor = false;
            this.Fichar.Click += new System.EventHandler(this.Fichar_Click);
            // 
            // noEntrar
            // 
            this.noEntrar.AutoSize = true;
            this.noEntrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noEntrar.Location = new System.Drawing.Point(46, 210);
            this.noEntrar.Name = "noEntrar";
            this.noEntrar.Size = new System.Drawing.Size(394, 13);
            this.noEntrar.TabIndex = 5;
            this.noEntrar.Text = "No puede fichar para entrar antes de que empiece su turno";
            this.noEntrar.Visible = false;
            // 
            // deServicio
            // 
            this.deServicio.AutoSize = true;
            this.deServicio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deServicio.ForeColor = System.Drawing.Color.LightGreen;
            this.deServicio.Location = new System.Drawing.Point(98, 124);
            this.deServicio.Name = "deServicio";
            this.deServicio.Size = new System.Drawing.Size(220, 23);
            this.deServicio.TabIndex = 6;
            this.deServicio.Text = "Tiempo de servicio:";
            this.deServicio.Visible = false;
            // 
            // turnoFinaliza
            // 
            this.turnoFinaliza.AutoSize = true;
            this.turnoFinaliza.BackColor = System.Drawing.Color.SteelBlue;
            this.turnoFinaliza.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoFinaliza.Location = new System.Drawing.Point(15, 72);
            this.turnoFinaliza.Name = "turnoFinaliza";
            this.turnoFinaliza.Size = new System.Drawing.Size(303, 29);
            this.turnoFinaliza.TabIndex = 7;
            this.turnoFinaliza.Text = "Su turno finaliza a las";
            this.turnoFinaliza.Visible = false;
            // 
            // noSalir
            // 
            this.noSalir.AutoSize = true;
            this.noSalir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSalir.ForeColor = System.Drawing.Color.Black;
            this.noSalir.Location = new System.Drawing.Point(53, 210);
            this.noSalir.Name = "noSalir";
            this.noSalir.Size = new System.Drawing.Size(378, 13);
            this.noSalir.TabIndex = 8;
            this.noSalir.Text = "No puede fichar para salir antes de que termine su turno";
            this.noSalir.Visible = false;
            // 
            // horaActual
            // 
            this.horaActual.AutoSize = true;
            this.horaActual.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaActual.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.horaActual.Location = new System.Drawing.Point(331, 27);
            this.horaActual.Name = "horaActual";
            this.horaActual.Size = new System.Drawing.Size(140, 29);
            this.horaActual.TabIndex = 9;
            this.horaActual.Text = "horaActual";
            this.horaActual.Click += new System.EventHandler(this.horaActual_Click);
            // 
            // horaEntrada
            // 
            this.horaEntrada.AutoSize = true;
            this.horaEntrada.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaEntrada.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.horaEntrada.Location = new System.Drawing.Point(331, 72);
            this.horaEntrada.Name = "horaEntrada";
            this.horaEntrada.Size = new System.Drawing.Size(159, 29);
            this.horaEntrada.TabIndex = 10;
            this.horaEntrada.Text = "horaEntrada";
            // 
            // horaSalida
            // 
            this.horaSalida.AutoSize = true;
            this.horaSalida.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaSalida.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.horaSalida.Location = new System.Drawing.Point(331, 72);
            this.horaSalida.Name = "horaSalida";
            this.horaSalida.Size = new System.Drawing.Size(138, 29);
            this.horaSalida.TabIndex = 11;
            this.horaSalida.Text = "horaSalida";
            this.horaSalida.Visible = false;
            // 
            // tiempoServicio
            // 
            this.tiempoServicio.AutoSize = true;
            this.tiempoServicio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoServicio.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tiempoServicio.Location = new System.Drawing.Point(321, 124);
            this.tiempoServicio.Name = "tiempoServicio";
            this.tiempoServicio.Size = new System.Drawing.Size(119, 23);
            this.tiempoServicio.TabIndex = 12;
            this.tiempoServicio.Text = "tiempoServ";
            this.tiempoServicio.Visible = false;
            // 
            // timerSeg
            // 
            this.timerSeg.Interval = 10;
            this.timerSeg.Tick += new System.EventHandler(this.timerSeg_Tick);
            // 
            // timerActual
            // 
            this.timerActual.Enabled = true;
            this.timerActual.Interval = 10;
            this.timerActual.Tick += new System.EventHandler(this.timerActual_Tick_1);
            // 
            // ModuloFichaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(483, 235);
            this.Controls.Add(this.tiempoServicio);
            this.Controls.Add(this.horaSalida);
            this.Controls.Add(this.horaEntrada);
            this.Controls.Add(this.horaActual);
            this.Controls.Add(this.noSalir);
            this.Controls.Add(this.turnoFinaliza);
            this.Controls.Add(this.deServicio);
            this.Controls.Add(this.noEntrar);
            this.Controls.Add(this.Fichar);
            this.Controls.Add(this.turnoEmpieza);
            this.Controls.Add(this.Son);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModuloFichaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fichar";
            this.Load += new System.EventHandler(this.Fichar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Son;
        private System.Windows.Forms.Label turnoEmpieza;
        private System.Windows.Forms.Button Fichar;
        private System.Windows.Forms.Label noEntrar;
        private System.Windows.Forms.Label deServicio;
        private System.Windows.Forms.Label turnoFinaliza;
        private System.Windows.Forms.Label noSalir;
        private System.Windows.Forms.Label horaActual;
        private System.Windows.Forms.Label horaEntrada;
        private System.Windows.Forms.Label horaSalida;
        private System.Windows.Forms.Label tiempoServicio;
        private System.Windows.Forms.Timer timerSeg;
        private System.Windows.Forms.Timer timerActual;
    }
}