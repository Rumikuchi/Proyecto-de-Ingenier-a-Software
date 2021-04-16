namespace Proyecto_Fichajes
{
    partial class CambiarHorarioACalendario
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
            this.cbLunes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMartes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMiercoles = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbJueves = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDomingo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSabado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbViernes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione los horarios que desee establecer";
            // 
            // cbLunes
            // 
            this.cbLunes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLunes.FormattingEnabled = true;
            this.cbLunes.Location = new System.Drawing.Point(17, 83);
            this.cbLunes.Name = "cbLunes";
            this.cbLunes.Size = new System.Drawing.Size(140, 21);
            this.cbLunes.TabIndex = 1;
            this.cbLunes.SelectedIndexChanged += new System.EventHandler(this.cbLunes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lunes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Martes";
            // 
            // cbMartes
            // 
            this.cbMartes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMartes.FormattingEnabled = true;
            this.cbMartes.Location = new System.Drawing.Point(173, 83);
            this.cbMartes.Name = "cbMartes";
            this.cbMartes.Size = new System.Drawing.Size(140, 21);
            this.cbMartes.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Miércoles";
            // 
            // cbMiercoles
            // 
            this.cbMiercoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMiercoles.FormattingEnabled = true;
            this.cbMiercoles.Location = new System.Drawing.Point(332, 83);
            this.cbMiercoles.Name = "cbMiercoles";
            this.cbMiercoles.Size = new System.Drawing.Size(140, 21);
            this.cbMiercoles.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jueves";
            // 
            // cbJueves
            // 
            this.cbJueves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJueves.FormattingEnabled = true;
            this.cbJueves.Location = new System.Drawing.Point(497, 83);
            this.cbJueves.Name = "cbJueves";
            this.cbJueves.Size = new System.Drawing.Size(140, 21);
            this.cbJueves.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Domingo";
            // 
            // cbDomingo
            // 
            this.cbDomingo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDomingo.FormattingEnabled = true;
            this.cbDomingo.Location = new System.Drawing.Point(416, 157);
            this.cbDomingo.Name = "cbDomingo";
            this.cbDomingo.Size = new System.Drawing.Size(140, 21);
            this.cbDomingo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sábado";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbSabado
            // 
            this.cbSabado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSabado.FormattingEnabled = true;
            this.cbSabado.Location = new System.Drawing.Point(257, 157);
            this.cbSabado.Name = "cbSabado";
            this.cbSabado.Size = new System.Drawing.Size(140, 21);
            this.cbSabado.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Viernes";
            // 
            // cbViernes
            // 
            this.cbViernes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViernes.FormattingEnabled = true;
            this.cbViernes.Location = new System.Drawing.Point(101, 157);
            this.cbViernes.Name = "cbViernes";
            this.cbViernes.Size = new System.Drawing.Size(140, 21);
            this.cbViernes.TabIndex = 10;
            // 
            // CambiarHorarioACalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(656, 277);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDomingo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSabado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbViernes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbJueves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMiercoles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMartes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbLunes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CambiarHorarioACalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Horario Al Calendario";
            this.Load += new System.EventHandler(this.CambiarHorarioACalendario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLunes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMartes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMiercoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbJueves;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDomingo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSabado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbViernes;
    }
}