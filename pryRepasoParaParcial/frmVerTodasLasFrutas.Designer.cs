namespace pryRepasoParaParcial
{
    partial class frmVerTodasLasFrutas
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
            this.FRUTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFruta
            // 
            this.dgvFruta.AllowUserToAddRows = false;
            this.dgvFruta.AllowUserToDeleteRows = false;
            this.dgvFruta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FRUTA,
            this.NOMBRE});
            this.dgvFruta.Location = new System.Drawing.Point(11, 11);
            this.dgvFruta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFruta.Name = "dgvFruta";
            this.dgvFruta.ReadOnly = true;
            this.dgvFruta.RowHeadersWidth = 51;
            this.dgvFruta.RowTemplate.Height = 24;
            this.dgvFruta.Size = new System.Drawing.Size(415, 311);
            this.dgvFruta.TabIndex = 1;
            // 
            // FRUTA
            // 
            this.FRUTA.HeaderText = "FRUTA";
            this.FRUTA.MinimumWidth = 6;
            this.FRUTA.Name = "FRUTA";
            this.FRUTA.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // frmVerTodasLasFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 345);
            this.Controls.Add(this.dgvFruta);
            this.Name = "frmVerTodasLasFrutas";
            this.Text = "frmVerTodasLasFrutas";
            this.Load += new System.EventHandler(this.frmVerTodasLasFrutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRUTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
    }
}