namespace pryRepasoParaParcial
{
    partial class frmAgregarOQuitarFrutaQueLeGustaAAlumno
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFruta = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.cbFruta = new System.Windows.Forms.ComboBox();
            this.cbAlumno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(228, 170);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 37);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFruta
            // 
            this.lblFruta.AutoSize = true;
            this.lblFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruta.Location = new System.Drawing.Point(11, 94);
            this.lblFruta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFruta.Name = "lblFruta";
            this.lblFruta.Size = new System.Drawing.Size(47, 20);
            this.lblFruta.TabIndex = 8;
            this.lblFruta.Text = "Fruta";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(11, 9);
            this.lblAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(63, 20);
            this.lblAlumno.TabIndex = 7;
            this.lblAlumno.Text = "Alumno";
            // 
            // cbFruta
            // 
            this.cbFruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFruta.FormattingEnabled = true;
            this.cbFruta.Location = new System.Drawing.Point(11, 116);
            this.cbFruta.Margin = new System.Windows.Forms.Padding(2);
            this.cbFruta.Name = "cbFruta";
            this.cbFruta.Size = new System.Drawing.Size(337, 28);
            this.cbFruta.TabIndex = 6;
            // 
            // cbAlumno
            // 
            this.cbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlumno.FormattingEnabled = true;
            this.cbAlumno.Location = new System.Drawing.Point(11, 32);
            this.cbAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(337, 28);
            this.cbAlumno.TabIndex = 5;
            // 
            // frmAgregarOQuitarFrutaQueLeGustaAAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 218);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblFruta);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.cbFruta);
            this.Controls.Add(this.cbAlumno);
            this.Name = "frmAgregarOQuitarFrutaQueLeGustaAAlumno";
            this.Text = "frmAgregarOQuitarFrutaQueLeGustaAAlumno";
            this.Load += new System.EventHandler(this.frmAgregarOQuitarFrutaQueLeGustaAAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFruta;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.ComboBox cbFruta;
        private System.Windows.Forms.ComboBox cbAlumno;
    }
}