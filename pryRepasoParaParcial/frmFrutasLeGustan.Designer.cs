namespace pryRepasoParaParcial
{
    partial class frmFrutasLeGustan
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
            this.lblAlumno = new System.Windows.Forms.Label();
            this.cbAlumno = new System.Windows.Forms.ComboBox();
            this.dgvFrutas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(12, 9);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(87, 26);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Alumno";
            // 
            // cbAlumno
            // 
            this.cbAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlumno.FormattingEnabled = true;
            this.cbAlumno.Location = new System.Drawing.Point(118, 7);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(250, 28);
            this.cbAlumno.TabIndex = 1;
            // 
            // dgvFrutas
            // 
            this.dgvFrutas.AllowUserToAddRows = false;
            this.dgvFrutas.AllowUserToDeleteRows = false;
            this.dgvFrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvFrutas.Location = new System.Drawing.Point(26, 130);
            this.dgvFrutas.Name = "dgvFrutas";
            this.dgvFrutas.ReadOnly = true;
            this.dgvFrutas.Size = new System.Drawing.Size(351, 294);
            this.dgvFrutas.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Frutas";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(219, 58);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(149, 41);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "VER";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // frmFrutasLeGustan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 464);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dgvFrutas);
            this.Controls.Add(this.cbAlumno);
            this.Controls.Add(this.lblAlumno);
            this.Name = "frmFrutasLeGustan";
            this.Text = "frmFrutasLeGustan";
            this.Load += new System.EventHandler(this.frmFrutasLeGustan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.ComboBox cbAlumno;
        private System.Windows.Forms.DataGridView dgvFrutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnVer;
    }
}