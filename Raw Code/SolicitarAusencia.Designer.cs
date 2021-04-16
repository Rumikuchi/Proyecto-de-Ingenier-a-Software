namespace Proyecto_Fichajes
{
    partial class SolicitarAusencia
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSolicitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(635, 201);
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(196, 20);
            this.tbMotivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indique el motivo de su ausencia:";
            // 
            // bSolicitar
            // 
            this.bSolicitar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bSolicitar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSolicitar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSolicitar.Location = new System.Drawing.Point(691, 254);
            this.bSolicitar.Name = "bSolicitar";
            this.bSolicitar.Size = new System.Drawing.Size(80, 42);
            this.bSolicitar.TabIndex = 5;
            this.bSolicitar.Text = "Solicitar";
            this.bSolicitar.UseVisualStyleBackColor = false;
            this.bSolicitar.Click += new System.EventHandler(this.bSolicitar_Click);
            // 
            // SolicitarAusencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(859, 498);
            this.Controls.Add(this.bSolicitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMotivo);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SolicitarAusencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SolicitarAusencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSolicitar;
    }
}