namespace TareaEjercicio3
{
    partial class FrmProducto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuscarImagenbutton = new System.Windows.Forms.Button();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.ProductodataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencia";
            // 
            // BuscarImagenbutton
            // 
            this.BuscarImagenbutton.Enabled = false;
            this.BuscarImagenbutton.Location = new System.Drawing.Point(1029, 211);
            this.BuscarImagenbutton.Name = "BuscarImagenbutton";
            this.BuscarImagenbutton.Size = new System.Drawing.Size(35, 23);
            this.BuscarImagenbutton.TabIndex = 4;
            this.BuscarImagenbutton.Text = "...";
            this.BuscarImagenbutton.UseVisualStyleBackColor = true;
            this.BuscarImagenbutton.Click += new System.EventHandler(this.BuscarImagenbutton_Click);
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImagenPictureBox.Location = new System.Drawing.Point(738, 50);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(326, 155);
            this.ImagenPictureBox.TabIndex = 5;
            this.ImagenPictureBox.TabStop = false;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Location = new System.Drawing.Point(232, 50);
            this.CodigoTextBox.MaxLength = 45;
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(370, 24);
            this.CodigoTextBox.TabIndex = 6;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Location = new System.Drawing.Point(232, 92);
            this.DescripcionTextBox.MaxLength = 45;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(370, 24);
            this.DescripcionTextBox.TabIndex = 7;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Location = new System.Drawing.Point(232, 133);
            this.PrecioTextBox.MaxLength = 18;
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(370, 24);
            this.PrecioTextBox.TabIndex = 8;
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress);
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Enabled = false;
            this.ExistenciaTextBox.Location = new System.Drawing.Point(232, 181);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(370, 24);
            this.ExistenciaTextBox.TabIndex = 9;
            this.ExistenciaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciaTextBox_KeyPress);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(232, 263);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(71, 24);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(325, 263);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(82, 24);
            this.Modificarbutton.TabIndex = 11;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Enabled = false;
            this.Guardarbutton.Location = new System.Drawing.Point(425, 263);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(72, 24);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(503, 263);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 24);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Enabled = false;
            this.Cancelarbutton.Location = new System.Drawing.Point(584, 263);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(80, 24);
            this.Cancelarbutton.TabIndex = 14;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // ProductodataGridView
            // 
            this.ProductodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductodataGridView.Location = new System.Drawing.Point(-2, 309);
            this.ProductodataGridView.Name = "ProductodataGridView";
            this.ProductodataGridView.Size = new System.Drawing.Size(1202, 312);
            this.ProductodataGridView.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.ProductodataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ExistenciaTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.BuscarImagenbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BuscarImagenbutton;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.DataGridView ProductodataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}