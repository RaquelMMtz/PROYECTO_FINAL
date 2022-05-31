namespace SistemaTecnm_Proyecto_Final_
{
    partial class FrmVerificacion
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
            this.btnCS3 = new System.Windows.Forms.Button();
            this.btnCalendario2 = new System.Windows.Forms.Button();
            this.btnSalir3 = new System.Windows.Forms.Button();
            this.btnEvento2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCS3
            // 
            this.btnCS3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCS3.Location = new System.Drawing.Point(595, 442);
            this.btnCS3.Name = "btnCS3";
            this.btnCS3.Size = new System.Drawing.Size(126, 32);
            this.btnCS3.TabIndex = 7;
            this.btnCS3.Text = "Cerrar Sesion";
            this.btnCS3.UseVisualStyleBackColor = true;
            // 
            // btnCalendario2
            // 
            this.btnCalendario2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario2.Location = new System.Drawing.Point(179, 442);
            this.btnCalendario2.Name = "btnCalendario2";
            this.btnCalendario2.Size = new System.Drawing.Size(108, 36);
            this.btnCalendario2.TabIndex = 6;
            this.btnCalendario2.Text = "Calendario";
            this.btnCalendario2.UseVisualStyleBackColor = true;
            this.btnCalendario2.Click += new System.EventHandler(this.btnCalendario2_Click);
            // 
            // btnSalir3
            // 
            this.btnSalir3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir3.Location = new System.Drawing.Point(745, 442);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(87, 34);
            this.btnSalir3.TabIndex = 5;
            this.btnSalir3.Text = "Salir";
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // btnEvento2
            // 
            this.btnEvento2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvento2.Location = new System.Drawing.Point(43, 442);
            this.btnEvento2.Name = "btnEvento2";
            this.btnEvento2.Size = new System.Drawing.Size(102, 36);
            this.btnEvento2.TabIndex = 4;
            this.btnEvento2.Text = "Evento";
            this.btnEvento2.UseVisualStyleBackColor = true;
            this.btnEvento2.Click += new System.EventHandler(this.btnEvento2_Click);
            // 
            // FrmVerificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.btnCS3);
            this.Controls.Add(this.btnCalendario2);
            this.Controls.Add(this.btnSalir3);
            this.Controls.Add(this.btnEvento2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmVerificacion";
            this.Text = "VERIFICACION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCS3;
        private System.Windows.Forms.Button btnCalendario2;
        private System.Windows.Forms.Button btnSalir3;
        private System.Windows.Forms.Button btnEvento2;
    }
}