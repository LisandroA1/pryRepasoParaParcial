namespace pryRepasoParaParcial
{
    partial class frmFrutasNoLeGustan
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
            this.dgvFruta = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.cbAlumno = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFruta
            // 
            this.dgvFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruta.Location = new System.Drawing.Point(11, 86);
            this.dgvFruta.Name = "dgvFruta";
            this.dgvFruta.RowHeadersWidth = 51;
            this.dgvFruta.RowTemplate.Height = 24;
            this.dgvFruta.Size = new System.Drawing.Size(466, 309);
            this.dgvFruta.TabIndex = 7;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(383, 10);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(94, 43);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "VER";
            this.btnVer.UseVisualStyleBackColor = true;
            //this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // cbAlumno
            // 
            this.cbAlumno.FormattingEnabled = true;
            this.cbAlumno.Location = new System.Drawing.Point(96, 18);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(264, 21);
            this.cbAlumno.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // frmFrutasNoLeGustan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 405);
            this.Controls.Add(this.dgvFruta);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cbAlumno);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmFrutasNoLeGustan";
            this.Text = "frmFrutasNoLeGustan";
            this.Load += new System.EventHandler(this.frmFrutasNoLeGustan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFruta;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox cbAlumno;
        private System.Windows.Forms.Label lblNombre;
    }
}