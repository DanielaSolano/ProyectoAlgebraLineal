namespace ProyectoAlgebraLineal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCargarOriginal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFiltros = new System.Windows.Forms.ComboBox();
            this.btnPersonalizado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 311);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(504, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 311);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnCargarOriginal
            // 
            this.btnCargarOriginal.Location = new System.Drawing.Point(232, 431);
            this.btnCargarOriginal.Name = "btnCargarOriginal";
            this.btnCargarOriginal.Size = new System.Drawing.Size(120, 39);
            this.btnCargarOriginal.TabIndex = 3;
            this.btnCargarOriginal.Text = "Aplicar filtro a imagen";
            this.btnCargarOriginal.UseVisualStyleBackColor = true;
            this.btnCargarOriginal.Click += new System.EventHandler(this.btnCargarOriginal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtro Digital Aplicado:";
            // 
            // comboBoxFiltros
            // 
            this.comboBoxFiltros.FormattingEnabled = true;
            this.comboBoxFiltros.Location = new System.Drawing.Point(380, 441);
            this.comboBoxFiltros.Name = "comboBoxFiltros";
            this.comboBoxFiltros.Size = new System.Drawing.Size(209, 21);
            this.comboBoxFiltros.TabIndex = 5;
            // 
            // btnPersonalizado
            // 
            this.btnPersonalizado.Location = new System.Drawing.Point(752, 431);
            this.btnPersonalizado.Name = "btnPersonalizado";
            this.btnPersonalizado.Size = new System.Drawing.Size(126, 31);
            this.btnPersonalizado.TabIndex = 6;
            this.btnPersonalizado.Text = "Definir Personalizado";
            this.btnPersonalizado.UseVisualStyleBackColor = true;
            this.btnPersonalizado.Click += new System.EventHandler(this.btnPersonalizado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 528);
            this.Controls.Add(this.btnPersonalizado);
            this.Controls.Add(this.comboBoxFiltros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargarOriginal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCargarOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFiltros;
        private System.Windows.Forms.Button btnPersonalizado;
    }
}

