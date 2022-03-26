namespace TareaEjercicio3
{
    partial class Login
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aceptarbutton = new System.Windows.Forms.Button();
            this.mostrarbutton = new System.Windows.Forms.Button();
            this.usuariotextBox = new System.Windows.Forms.TextBox();
            this.clavetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptarbutton
            // 
            this.aceptarbutton.BackColor = System.Drawing.Color.IndianRed;
            this.aceptarbutton.ForeColor = System.Drawing.Color.White;
            this.aceptarbutton.Location = new System.Drawing.Point(243, 208);
            this.aceptarbutton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.aceptarbutton.Name = "aceptarbutton";
            this.aceptarbutton.Size = new System.Drawing.Size(149, 44);
            this.aceptarbutton.TabIndex = 0;
            this.aceptarbutton.Text = "Aceptar";
            this.aceptarbutton.UseVisualStyleBackColor = false;
            this.aceptarbutton.Click += new System.EventHandler(this.aceptarbutton_Click);
            // 
            // mostrarbutton
            // 
            this.mostrarbutton.BackColor = System.Drawing.Color.IndianRed;
            this.mostrarbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mostrarbutton.Location = new System.Drawing.Point(463, 208);
            this.mostrarbutton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mostrarbutton.Name = "mostrarbutton";
            this.mostrarbutton.Size = new System.Drawing.Size(149, 44);
            this.mostrarbutton.TabIndex = 1;
            this.mostrarbutton.Text = "Mostrar";
            this.mostrarbutton.UseVisualStyleBackColor = false;
            this.mostrarbutton.Click += new System.EventHandler(this.mostrarbutton_Click);
            // 
            // usuariotextBox
            // 
            this.usuariotextBox.Location = new System.Drawing.Point(243, 27);
            this.usuariotextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.usuariotextBox.Name = "usuariotextBox";
            this.usuariotextBox.Size = new System.Drawing.Size(369, 31);
            this.usuariotextBox.TabIndex = 2;
            // 
            // clavetextBox
            // 
            this.clavetextBox.Location = new System.Drawing.Point(243, 109);
            this.clavetextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.clavetextBox.Name = "clavetextBox";
            this.clavetextBox.Size = new System.Drawing.Size(369, 31);
            this.clavetextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clave";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(702, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 321);
            this.dataGridView1.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1294, 351);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clavetextBox);
            this.Controls.Add(this.usuariotextBox);
            this.Controls.Add(this.mostrarbutton);
            this.Controls.Add(this.aceptarbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarbutton;
        private System.Windows.Forms.Button mostrarbutton;
        private System.Windows.Forms.TextBox usuariotextBox;
        private System.Windows.Forms.TextBox clavetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

