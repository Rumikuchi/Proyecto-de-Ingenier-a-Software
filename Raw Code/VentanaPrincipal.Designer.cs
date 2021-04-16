namespace Proyecto_Fichajes
{
    partial class VentanaPrincipal
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
            this.HorarioCalendario = new System.Windows.Forms.TabControl();
            this.Horario = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Calendario = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Opciones = new System.Windows.Forms.GroupBox();
            this.EditarNotificaciones = new System.Windows.Forms.Button();
            this.SaldoTiempo = new System.Windows.Forms.Button();
            this.ConsultaFichajes = new System.Windows.Forms.Button();
            this.GestionAusencias = new System.Windows.Forms.Button();
            this.ConsultarHoras = new System.Windows.Forms.Button();
            this.Fichar = new System.Windows.Forms.Button();
            this.EditarHorario = new System.Windows.Forms.Button();
            this.EditarCalendario = new System.Windows.Forms.Button();
            this.EditarPlantilla = new System.Windows.Forms.Button();
            this.CalculoHorasFichajes = new System.Windows.Forms.Button();
            this.OpcionesAdmin = new System.Windows.Forms.GroupBox();
            this.bAuditoria = new System.Windows.Forms.Button();
            this.bInfoEmpresa = new System.Windows.Forms.Button();
            this.ConsultarAusencias = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.HorarioCalendario.SuspendLayout();
            this.Horario.SuspendLayout();
            this.Calendario.SuspendLayout();
            this.Opciones.SuspendLayout();
            this.OpcionesAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HorarioCalendario
            // 
            this.HorarioCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HorarioCalendario.Controls.Add(this.Horario);
            this.HorarioCalendario.Controls.Add(this.Calendario);
            this.HorarioCalendario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorarioCalendario.Location = new System.Drawing.Point(119, 33);
            this.HorarioCalendario.Name = "HorarioCalendario";
            this.HorarioCalendario.SelectedIndex = 0;
            this.HorarioCalendario.Size = new System.Drawing.Size(1419, 692);
            this.HorarioCalendario.TabIndex = 0;
            // 
            // Horario
            // 
            this.Horario.Controls.Add(this.flowLayoutPanel1);
            this.Horario.Location = new System.Drawing.Point(4, 22);
            this.Horario.Name = "Horario";
            this.Horario.Padding = new System.Windows.Forms.Padding(3);
            this.Horario.Size = new System.Drawing.Size(1411, 666);
            this.Horario.TabIndex = 0;
            this.Horario.Text = "Horario";
            this.Horario.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1399, 657);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Calendario
            // 
            this.Calendario.Controls.Add(this.flowLayoutPanel2);
            this.Calendario.Location = new System.Drawing.Point(4, 22);
            this.Calendario.Name = "Calendario";
            this.Calendario.Padding = new System.Windows.Forms.Padding(3);
            this.Calendario.Size = new System.Drawing.Size(1411, 666);
            this.Calendario.TabIndex = 1;
            this.Calendario.Text = "Calendario";
            this.Calendario.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1399, 684);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // Opciones
            // 
            this.Opciones.Controls.Add(this.EditarNotificaciones);
            this.Opciones.Controls.Add(this.SaldoTiempo);
            this.Opciones.Controls.Add(this.ConsultaFichajes);
            this.Opciones.Controls.Add(this.GestionAusencias);
            this.Opciones.Controls.Add(this.ConsultarHoras);
            this.Opciones.Controls.Add(this.Fichar);
            this.Opciones.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opciones.Location = new System.Drawing.Point(5, 12);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(108, 339);
            this.Opciones.TabIndex = 1;
            this.Opciones.TabStop = false;
            this.Opciones.Text = "Opciones";
            // 
            // EditarNotificaciones
            // 
            this.EditarNotificaciones.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EditarNotificaciones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditarNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarNotificaciones.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarNotificaciones.Location = new System.Drawing.Point(7, 287);
            this.EditarNotificaciones.Name = "EditarNotificaciones";
            this.EditarNotificaciones.Size = new System.Drawing.Size(94, 40);
            this.EditarNotificaciones.TabIndex = 9;
            this.EditarNotificaciones.Text = "Configurar Notificaciones";
            this.EditarNotificaciones.UseVisualStyleBackColor = false;
            this.EditarNotificaciones.Click += new System.EventHandler(this.EditarNotificaciones_Click);
            // 
            // SaldoTiempo
            // 
            this.SaldoTiempo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SaldoTiempo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaldoTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaldoTiempo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldoTiempo.Location = new System.Drawing.Point(6, 227);
            this.SaldoTiempo.Name = "SaldoTiempo";
            this.SaldoTiempo.Size = new System.Drawing.Size(94, 54);
            this.SaldoTiempo.TabIndex = 7;
            this.SaldoTiempo.Text = "Consultar Saldo de Tiempo";
            this.SaldoTiempo.UseVisualStyleBackColor = false;
            this.SaldoTiempo.Click += new System.EventHandler(this.SaldoTiempo_Click);
            // 
            // ConsultaFichajes
            // 
            this.ConsultaFichajes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ConsultaFichajes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConsultaFichajes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConsultaFichajes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaFichajes.Location = new System.Drawing.Point(6, 179);
            this.ConsultaFichajes.Name = "ConsultaFichajes";
            this.ConsultaFichajes.Size = new System.Drawing.Size(94, 42);
            this.ConsultaFichajes.TabIndex = 6;
            this.ConsultaFichajes.Text = "Consultar Fichajes";
            this.ConsultaFichajes.UseVisualStyleBackColor = false;
            this.ConsultaFichajes.Click += new System.EventHandler(this.ConsultaFichajes_Click);
            // 
            // GestionAusencias
            // 
            this.GestionAusencias.BackColor = System.Drawing.Color.PaleTurquoise;
            this.GestionAusencias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GestionAusencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GestionAusencias.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionAusencias.Location = new System.Drawing.Point(7, 131);
            this.GestionAusencias.Name = "GestionAusencias";
            this.GestionAusencias.Size = new System.Drawing.Size(94, 42);
            this.GestionAusencias.TabIndex = 5;
            this.GestionAusencias.Text = "Gestionar Ausencias";
            this.GestionAusencias.UseVisualStyleBackColor = false;
            this.GestionAusencias.Click += new System.EventHandler(this.GestionAusencias_Click);
            // 
            // ConsultarHoras
            // 
            this.ConsultarHoras.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ConsultarHoras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConsultarHoras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConsultarHoras.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarHoras.Location = new System.Drawing.Point(6, 70);
            this.ConsultarHoras.Name = "ConsultarHoras";
            this.ConsultarHoras.Size = new System.Drawing.Size(95, 55);
            this.ConsultarHoras.TabIndex = 4;
            this.ConsultarHoras.Text = "Consultar Horas Trabajadas";
            this.ConsultarHoras.UseVisualStyleBackColor = false;
            this.ConsultarHoras.Click += new System.EventHandler(this.ConsultarHoras_Click);
            // 
            // Fichar
            // 
            this.Fichar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Fichar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Fichar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fichar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fichar.Location = new System.Drawing.Point(6, 22);
            this.Fichar.Name = "Fichar";
            this.Fichar.Size = new System.Drawing.Size(96, 42);
            this.Fichar.TabIndex = 3;
            this.Fichar.Text = "Fichar";
            this.Fichar.UseVisualStyleBackColor = false;
            this.Fichar.Click += new System.EventHandler(this.Fichar_Click);
            // 
            // EditarHorario
            // 
            this.EditarHorario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EditarHorario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarHorario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarHorario.Location = new System.Drawing.Point(7, 34);
            this.EditarHorario.Name = "EditarHorario";
            this.EditarHorario.Size = new System.Drawing.Size(94, 42);
            this.EditarHorario.TabIndex = 0;
            this.EditarHorario.Text = "Editar Horario";
            this.EditarHorario.UseVisualStyleBackColor = false;
            this.EditarHorario.Click += new System.EventHandler(this.EditarHorario_Click);
            // 
            // EditarCalendario
            // 
            this.EditarCalendario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EditarCalendario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditarCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarCalendario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarCalendario.Location = new System.Drawing.Point(7, 82);
            this.EditarCalendario.Name = "EditarCalendario";
            this.EditarCalendario.Size = new System.Drawing.Size(94, 44);
            this.EditarCalendario.TabIndex = 1;
            this.EditarCalendario.Text = "Editar Calendario";
            this.EditarCalendario.UseVisualStyleBackColor = false;
            this.EditarCalendario.Click += new System.EventHandler(this.EditarCalendario_Click);
            // 
            // EditarPlantilla
            // 
            this.EditarPlantilla.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EditarPlantilla.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditarPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarPlantilla.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarPlantilla.Location = new System.Drawing.Point(6, 132);
            this.EditarPlantilla.Name = "EditarPlantilla";
            this.EditarPlantilla.Size = new System.Drawing.Size(94, 44);
            this.EditarPlantilla.TabIndex = 2;
            this.EditarPlantilla.Text = "Gestionar Plantilla";
            this.EditarPlantilla.UseVisualStyleBackColor = false;
            this.EditarPlantilla.Click += new System.EventHandler(this.EditarPlantilla_Click);
            // 
            // CalculoHorasFichajes
            // 
            this.CalculoHorasFichajes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CalculoHorasFichajes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CalculoHorasFichajes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculoHorasFichajes.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculoHorasFichajes.Location = new System.Drawing.Point(7, 182);
            this.CalculoHorasFichajes.Name = "CalculoHorasFichajes";
            this.CalculoHorasFichajes.Size = new System.Drawing.Size(94, 38);
            this.CalculoHorasFichajes.TabIndex = 10;
            this.CalculoHorasFichajes.Text = "Cálculo Horas/Fichajes";
            this.CalculoHorasFichajes.UseVisualStyleBackColor = false;
            this.CalculoHorasFichajes.Click += new System.EventHandler(this.CalculoHorasFichajes_Click);
            // 
            // OpcionesAdmin
            // 
            this.OpcionesAdmin.Controls.Add(this.bAuditoria);
            this.OpcionesAdmin.Controls.Add(this.bInfoEmpresa);
            this.OpcionesAdmin.Controls.Add(this.ConsultarAusencias);
            this.OpcionesAdmin.Controls.Add(this.CalculoHorasFichajes);
            this.OpcionesAdmin.Controls.Add(this.EditarPlantilla);
            this.OpcionesAdmin.Controls.Add(this.EditarCalendario);
            this.OpcionesAdmin.Controls.Add(this.EditarHorario);
            this.OpcionesAdmin.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionesAdmin.Location = new System.Drawing.Point(5, 357);
            this.OpcionesAdmin.Name = "OpcionesAdmin";
            this.OpcionesAdmin.Size = new System.Drawing.Size(108, 370);
            this.OpcionesAdmin.TabIndex = 0;
            this.OpcionesAdmin.TabStop = false;
            this.OpcionesAdmin.Text = "Opciones Administrativas";
            this.OpcionesAdmin.Visible = false;
            // 
            // bAuditoria
            // 
            this.bAuditoria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bAuditoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAuditoria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAuditoria.Location = new System.Drawing.Point(7, 322);
            this.bAuditoria.Name = "bAuditoria";
            this.bAuditoria.Size = new System.Drawing.Size(93, 37);
            this.bAuditoria.TabIndex = 15;
            this.bAuditoria.Text = "Auditoría";
            this.bAuditoria.UseVisualStyleBackColor = false;
            this.bAuditoria.Click += new System.EventHandler(this.bAuditoria_Click);
            // 
            // bInfoEmpresa
            // 
            this.bInfoEmpresa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bInfoEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bInfoEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bInfoEmpresa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfoEmpresa.Location = new System.Drawing.Point(6, 274);
            this.bInfoEmpresa.Name = "bInfoEmpresa";
            this.bInfoEmpresa.Size = new System.Drawing.Size(94, 42);
            this.bInfoEmpresa.TabIndex = 12;
            this.bInfoEmpresa.Text = "Info. Empresa";
            this.bInfoEmpresa.UseVisualStyleBackColor = false;
            this.bInfoEmpresa.Click += new System.EventHandler(this.bInfoEmpresa_Click);
            // 
            // ConsultarAusencias
            // 
            this.ConsultarAusencias.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ConsultarAusencias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConsultarAusencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConsultarAusencias.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarAusencias.Location = new System.Drawing.Point(6, 226);
            this.ConsultarAusencias.Name = "ConsultarAusencias";
            this.ConsultarAusencias.Size = new System.Drawing.Size(94, 42);
            this.ConsultarAusencias.TabIndex = 11;
            this.ConsultarAusencias.Text = "Consultar Ausencias";
            this.ConsultarAusencias.UseVisualStyleBackColor = false;
            this.ConsultarAusencias.Click += new System.EventHandler(this.ConsultarAusencias_Click);
            // 
            // LogOut
            // 
            this.LogOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(1419, 14);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(116, 16);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Desconectarse";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Proyecto_Fichajes.Properties.Resources.Salir;
            this.pictureBox1.Location = new System.Drawing.Point(1382, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombre.Location = new System.Drawing.Point(714, 14);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(206, 25);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "NombreEmpresa";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1550, 737);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.OpcionesAdmin);
            this.Controls.Add(this.HorarioCalendario);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI C You";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HorarioCalendario.ResumeLayout(false);
            this.Horario.ResumeLayout(false);
            this.Calendario.ResumeLayout(false);
            this.Opciones.ResumeLayout(false);
            this.OpcionesAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl HorarioCalendario;
        private System.Windows.Forms.TabPage Horario;
        private System.Windows.Forms.TabPage Calendario;
        private System.Windows.Forms.GroupBox Opciones;
        private System.Windows.Forms.Button EditarHorario;
        private System.Windows.Forms.Button EditarCalendario;
        private System.Windows.Forms.Button ConsultaFichajes;
        private System.Windows.Forms.Button GestionAusencias;
        private System.Windows.Forms.Button ConsultarHoras;
        private System.Windows.Forms.Button Fichar;
        private System.Windows.Forms.Button EditarPlantilla;
        private System.Windows.Forms.Button EditarNotificaciones;
        private System.Windows.Forms.Button SaldoTiempo;
        private System.Windows.Forms.Button CalculoHorasFichajes;
        private System.Windows.Forms.GroupBox OpcionesAdmin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Button ConsultarAusencias;
        private System.Windows.Forms.Button bInfoEmpresa;
        private System.Windows.Forms.Button bAuditoria;
        private System.Windows.Forms.Label labelNombre;
    }
}

