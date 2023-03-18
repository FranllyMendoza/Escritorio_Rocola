namespace Escritorio_Rocola.registro
{
    partial class Escritorio_reproductor
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
            this.dataGridView_lista_reproduccion = new System.Windows.Forms.DataGridView();
            this.dataGridView_Canciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lista_reproduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Canciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_lista_reproduccion
            // 
            this.dataGridView_lista_reproduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lista_reproduccion.Location = new System.Drawing.Point(81, 36);
            this.dataGridView_lista_reproduccion.Name = "dataGridView_lista_reproduccion";
            this.dataGridView_lista_reproduccion.RowHeadersWidth = 62;
            this.dataGridView_lista_reproduccion.RowTemplate.Height = 28;
            this.dataGridView_lista_reproduccion.Size = new System.Drawing.Size(475, 537);
            this.dataGridView_lista_reproduccion.TabIndex = 0;
            // 
            // dataGridView_Canciones
            // 
            this.dataGridView_Canciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Canciones.Location = new System.Drawing.Point(620, 36);
            this.dataGridView_Canciones.Name = "dataGridView_Canciones";
            this.dataGridView_Canciones.RowHeadersWidth = 62;
            this.dataGridView_Canciones.RowTemplate.Height = 28;
            this.dataGridView_Canciones.Size = new System.Drawing.Size(475, 537);
            this.dataGridView_Canciones.TabIndex = 1;
            // 
            // Escritorio_reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 689);
            this.Controls.Add(this.dataGridView_Canciones);
            this.Controls.Add(this.dataGridView_lista_reproduccion);
            this.Name = "Escritorio_reproductor";
            this.Text = "Escritorio_reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lista_reproduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Canciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_lista_reproduccion;
        private System.Windows.Forms.DataGridView dataGridView_Canciones;
    }
}