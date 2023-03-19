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
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPLay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
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
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(176, 613);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(142, 51);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Atras";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPLay
            // 
            this.btnPLay.Location = new System.Drawing.Point(324, 613);
            this.btnPLay.Name = "btnPLay";
            this.btnPLay.Size = new System.Drawing.Size(142, 51);
            this.btnPLay.TabIndex = 3;
            this.btnPLay.Text = "Play";
            this.btnPLay.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(472, 613);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(142, 51);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(620, 613);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 51);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(817, 613);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(142, 51);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // Escritorio_reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 689);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPLay);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.dataGridView_Canciones);
            this.Controls.Add(this.dataGridView_lista_reproduccion);
            this.Name = "Escritorio_reproductor";
            this.Text = "Escritorio_reproductor";
            this.Load += new System.EventHandler(this.Escritorio_reproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lista_reproduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Canciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_lista_reproduccion;
        private System.Windows.Forms.DataGridView dataGridView_Canciones;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPLay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnStop;
    }
}