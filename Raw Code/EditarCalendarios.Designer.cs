namespace Proyecto_Fichajes
{
    partial class EditarCalendarios
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
            this.labelCalendarios = new System.Windows.Forms.Label();
            this.lbCalendarios = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bAnadir = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCalendarios
            // 
            this.labelCalendarios.AutoSize = true;
            this.labelCalendarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarios.Location = new System.Drawing.Point(36, 18);
            this.labelCalendarios.Name = "labelCalendarios";
            this.labelCalendarios.Size = new System.Drawing.Size(111, 18);
            this.labelCalendarios.TabIndex = 0;
            this.labelCalendarios.Text = "Calendarios";
            // 
            // lbCalendarios
            // 
            this.lbCalendarios.FormattingEnabled = true;
            this.lbCalendarios.Location = new System.Drawing.Point(39, 50);
            this.lbCalendarios.Name = "lbCalendarios";
            this.lbCalendarios.Size = new System.Drawing.Size(936, 420);
            this.lbCalendarios.TabIndex = 2;
            this.lbCalendarios.SelectedIndexChanged += new System.EventHandler(this.lbCalendarios_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 36);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bAnadir);
            this.flowLayoutPanel1.Controls.Add(this.bEditar);
            this.flowLayoutPanel1.Controls.Add(this.bEliminar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(741, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bAnadir
            // 
            this.bAnadir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAnadir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnadir.Location = new System.Drawing.Point(167, 3);
            this.bAnadir.Name = "bAnadir";
            this.bAnadir.Size = new System.Drawing.Size(75, 23);
            this.bAnadir.TabIndex = 9;
            this.bAnadir.Text = "Añadir";
            this.bAnadir.UseVisualStyleBackColor = false;
            this.bAnadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEditar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditar.Location = new System.Drawing.Point(86, 3);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(75, 23);
            this.bEditar.TabIndex = 10;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = false;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEliminar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.Location = new System.Drawing.Point(5, 3);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 11;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // EditarCalendarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(987, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCalendarios);
            this.Controls.Add(this.labelCalendarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarCalendarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Calendarios";
            this.Load += new System.EventHandler(this.EditarCalendarios_Load_1);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCalendarios;
        private System.Windows.Forms.ListBox lbCalendarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bAnadir;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bEliminar;
    }
}