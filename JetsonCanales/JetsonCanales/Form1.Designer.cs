namespace JetsonCanales
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
            this.Examen = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programa1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programa2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programa3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Examen
            // 
            this.Examen.AutoSize = true;
            this.Examen.Font = new System.Drawing.Font("Montserrat Subrayada", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Examen.Location = new System.Drawing.Point(128, 140);
            this.Examen.Name = "Examen";
            this.Examen.Size = new System.Drawing.Size(326, 25);
            this.Examen.TabIndex = 0;
            this.Examen.Text = "Examen Programacion iii";
            this.Examen.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programa1ToolStripMenuItem,
            this.programa2ToolStripMenuItem,
            this.programa3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programa1ToolStripMenuItem
            // 
            this.programa1ToolStripMenuItem.Name = "programa1ToolStripMenuItem";
            this.programa1ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programa1ToolStripMenuItem.Text = "Intereses";
            this.programa1ToolStripMenuItem.Click += new System.EventHandler(this.programa1ToolStripMenuItem_Click);
            // 
            // programa2ToolStripMenuItem
            // 
            this.programa2ToolStripMenuItem.Name = "programa2ToolStripMenuItem";
            this.programa2ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.programa2ToolStripMenuItem.Text = "Facturacion";
            this.programa2ToolStripMenuItem.Click += new System.EventHandler(this.programa2ToolStripMenuItem_Click_1);
            // 
            // programa3ToolStripMenuItem
            // 
            this.programa3ToolStripMenuItem.Name = "programa3ToolStripMenuItem";
            this.programa3ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.programa3ToolStripMenuItem.Text = "Multiplos";
            this.programa3ToolStripMenuItem.Click += new System.EventHandler(this.programa3ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta: 20191002733";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Examen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Examen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programa1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programa2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programa3ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

