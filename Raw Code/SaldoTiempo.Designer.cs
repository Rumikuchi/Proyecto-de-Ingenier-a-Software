namespace Proyecto_Fichajes
{
    partial class SaldoTiempo
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
            this.labelHorasTrabajadas = new System.Windows.Forms.Label();
            this.labelHorasAusencias = new System.Windows.Forms.Label();
            this.labelSaldoTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tiempo trabajado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(411, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tiempo restado por ausencias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(239, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "SALDO DE TIEMPO:";
            // 
            // labelHorasTrabajadas
            // 
            this.labelHorasTrabajadas.AutoSize = true;
            this.labelHorasTrabajadas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorasTrabajadas.ForeColor = System.Drawing.Color.Lime;
            this.labelHorasTrabajadas.Location = new System.Drawing.Point(193, 26);
            this.labelHorasTrabajadas.Name = "labelHorasTrabajadas";
            this.labelHorasTrabajadas.Size = new System.Drawing.Size(118, 13);
            this.labelHorasTrabajadas.TabIndex = 19;
            this.labelHorasTrabajadas.Text = "horasTrabajadas";
            // 
            // labelHorasAusencias
            // 
            this.labelHorasAusencias.AutoSize = true;
            this.labelHorasAusencias.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorasAusencias.ForeColor = System.Drawing.Color.Red;
            this.labelHorasAusencias.Location = new System.Drawing.Point(673, 27);
            this.labelHorasAusencias.Name = "labelHorasAusencias";
            this.labelHorasAusencias.Size = new System.Drawing.Size(110, 13);
            this.labelHorasAusencias.TabIndex = 20;
            this.labelHorasAusencias.Text = "horasAusencias";
            // 
            // labelSaldoTiempo
            // 
            this.labelSaldoTiempo.AutoSize = true;
            this.labelSaldoTiempo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoTiempo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSaldoTiempo.Location = new System.Drawing.Point(411, 77);
            this.labelSaldoTiempo.Name = "labelSaldoTiempo";
            this.labelSaldoTiempo.Size = new System.Drawing.Size(90, 13);
            this.labelSaldoTiempo.TabIndex = 21;
            this.labelSaldoTiempo.Text = "saldoTiempo";
            // 
            // SaldoTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(795, 114);
            this.Controls.Add(this.labelSaldoTiempo);
            this.Controls.Add(this.labelHorasAusencias);
            this.Controls.Add(this.labelHorasTrabajadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SaldoTiempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saldo de Tiempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHorasTrabajadas;
        private System.Windows.Forms.Label labelHorasAusencias;
        private System.Windows.Forms.Label labelSaldoTiempo;
    }
}