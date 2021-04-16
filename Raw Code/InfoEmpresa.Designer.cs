namespace Proyecto_Fichajes
{
    partial class InfoEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.labelTelf = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.bEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de Teléfono:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo electrónico de contacto:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombre.Location = new System.Drawing.Point(242, 21);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(155, 18);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "NombreEmpresa";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.BackColor = System.Drawing.Color.SteelBlue;
            this.labelDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDireccion.Location = new System.Drawing.Point(123, 53);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(88, 18);
            this.labelDireccion.TabIndex = 6;
            this.labelDireccion.Text = "Dirección";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCP.Location = new System.Drawing.Point(162, 83);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(122, 18);
            this.labelCP.TabIndex = 7;
            this.labelCP.Text = "CódigoPostal";
            // 
            // labelTelf
            // 
            this.labelTelf.AutoSize = true;
            this.labelTelf.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTelf.Location = new System.Drawing.Point(223, 113);
            this.labelTelf.Name = "labelTelf";
            this.labelTelf.Size = new System.Drawing.Size(82, 18);
            this.labelTelf.TabIndex = 8;
            this.labelTelf.Text = "NumTelf";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMail.Location = new System.Drawing.Point(313, 144);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(69, 18);
            this.labelMail.TabIndex = 9;
            this.labelMail.Text = "Correo";
            // 
            // bEditar
            // 
            this.bEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEditar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditar.Location = new System.Drawing.Point(217, 175);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(90, 26);
            this.bEditar.TabIndex = 10;
            this.bEditar.Text = "Editar Info.";
            this.bEditar.UseVisualStyleBackColor = false;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // InfoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(523, 211);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTelf);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InfoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información de la Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelTelf;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button bEditar;
    }
}