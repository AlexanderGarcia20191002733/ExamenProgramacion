namespace JetsonCanales
{
    partial class Facturacion
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
            this.textBox1Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1Precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Resultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1Nombre
            // 
            this.textBox1Nombre.Location = new System.Drawing.Point(33, 47);
            this.textBox1Nombre.Name = "textBox1Nombre";
            this.textBox1Nombre.Size = new System.Drawing.Size(178, 20);
            this.textBox1Nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Producto";
            // 
            // textBox1Precio
            // 
            this.textBox1Precio.Location = new System.Drawing.Point(33, 73);
            this.textBox1Precio.Name = "textBox1Precio";
            this.textBox1Precio.Size = new System.Drawing.Size(178, 20);
            this.textBox1Precio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio";
            // 
            // textBox1Cantidad
            // 
            this.textBox1Cantidad.Location = new System.Drawing.Point(33, 99);
            this.textBox1Cantidad.Name = "textBox1Cantidad";
            this.textBox1Cantidad.Size = new System.Drawing.Size(178, 20);
            this.textBox1Cantidad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // textBox1Resultado
            // 
            this.textBox1Resultado.Location = new System.Drawing.Point(33, 155);
            this.textBox1Resultado.Name = "textBox1Resultado";
            this.textBox1Resultado.Size = new System.Drawing.Size(178, 20);
            this.textBox1Resultado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total a Pagar Descuento Incluido 15%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Nuevo ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1Resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1Cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1Precio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1Nombre);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1Resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}