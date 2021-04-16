namespace Proyecto_Fichajes
{
    partial class EditarHorarios
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
            this.lbHorarios = new System.Windows.Forms.ListBox();
            this.lbTramos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAnadir = new System.Windows.Forms.Button();
            this.bTrEliminar = new System.Windows.Forms.Button();
            this.bTrAnadir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHorarios
            // 
            this.lbHorarios.FormattingEnabled = true;
            this.lbHorarios.Location = new System.Drawing.Point(35, 50);
            this.lbHorarios.Name = "lbHorarios";
            this.lbHorarios.Size = new System.Drawing.Size(449, 420);
            this.lbHorarios.TabIndex = 0;
            this.lbHorarios.SelectedIndexChanged += new System.EventHandler(this.lbHorarios_SelectedIndexChanged);
            // 
            // lbTramos
            // 
            this.lbTramos.FormattingEnabled = true;
            this.lbTramos.Location = new System.Drawing.Point(18, 50);
            this.lbTramos.Name = "lbTramos";
            this.lbTramos.Size = new System.Drawing.Size(449, 420);
            this.lbTramos.TabIndex = 1;
            this.lbTramos.SelectedIndexChanged += new System.EventHandler(this.lbTramos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Horarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tramos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-1, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 41);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancelar);
            this.flowLayoutPanel1.Controls.Add(this.bAceptar);
            this.flowLayoutPanel1.Controls.Add(this.bEliminar);
            this.flowLayoutPanel1.Controls.Add(this.bEditar);
            this.flowLayoutPanel1.Controls.Add(this.bAnadir);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(558, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(410, 30);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(332, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(251, 3);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 4;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Visible = false;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEliminar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.Location = new System.Drawing.Point(170, 3);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 1;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEditar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditar.Location = new System.Drawing.Point(89, 3);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(75, 23);
            this.bEditar.TabIndex = 2;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = false;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAnadir
            // 
            this.bAnadir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAnadir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnadir.Location = new System.Drawing.Point(8, 3);
            this.bAnadir.Name = "bAnadir";
            this.bAnadir.Size = new System.Drawing.Size(75, 23);
            this.bAnadir.TabIndex = 0;
            this.bAnadir.Text = "Añadir";
            this.bAnadir.UseVisualStyleBackColor = false;
            this.bAnadir.Click += new System.EventHandler(this.bAnadir_Click);
            // 
            // bTrEliminar
            // 
            this.bTrEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bTrEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTrEliminar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTrEliminar.Location = new System.Drawing.Point(387, 449);
            this.bTrEliminar.Name = "bTrEliminar";
            this.bTrEliminar.Size = new System.Drawing.Size(75, 23);
            this.bTrEliminar.TabIndex = 4;
            this.bTrEliminar.Text = "Eliminar";
            this.bTrEliminar.UseVisualStyleBackColor = false;
            this.bTrEliminar.Visible = false;
            this.bTrEliminar.Click += new System.EventHandler(this.bTrEliminar_Click);
            // 
            // bTrAnadir
            // 
            this.bTrAnadir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bTrAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTrAnadir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTrAnadir.Location = new System.Drawing.Point(306, 449);
            this.bTrAnadir.Name = "bTrAnadir";
            this.bTrAnadir.Size = new System.Drawing.Size(75, 23);
            this.bTrAnadir.TabIndex = 3;
            this.bTrAnadir.Text = "Añadir";
            this.bTrAnadir.UseVisualStyleBackColor = false;
            this.bTrAnadir.Visible = false;
            this.bTrAnadir.Click += new System.EventHandler(this.bTrAnadir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bTrEliminar);
            this.panel2.Controls.Add(this.bTrAnadir);
            this.panel2.Controls.Add(this.lbTramos);
            this.panel2.Location = new System.Drawing.Point(490, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 476);
            this.panel2.TabIndex = 6;
            // 
            // EditarHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(969, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHorarios);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Horarios";
            this.Load += new System.EventHandler(this.EditarHorarios_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbHorarios;
        private System.Windows.Forms.ListBox lbTramos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAnadir;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bTrEliminar;
        private System.Windows.Forms.Button bTrAnadir;
        private System.Windows.Forms.Panel panel2;
    }
}