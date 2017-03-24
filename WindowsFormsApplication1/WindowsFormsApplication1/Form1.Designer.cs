namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.procedimientosYFuncionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.procedimientosYFuncionesToolStripMenuItem,
            this.salirToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(518, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // consultasToolStripMenuItem
      // 
      this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultadosToolStripMenuItem,
            this.comprasToolStripMenuItem});
      this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
      this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.consultasToolStripMenuItem.Text = "Consultas";
      // 
      // resultadosToolStripMenuItem
      // 
      this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
      this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.resultadosToolStripMenuItem.Text = "Resultados";
      this.resultadosToolStripMenuItem.Click += new System.EventHandler(this.resultadosToolStripMenuItem_Click);
      // 
      // comprasToolStripMenuItem
      // 
      this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
      this.comprasToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.comprasToolStripMenuItem.Text = "Compras";
      this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
      // 
      // procedimientosYFuncionesToolStripMenuItem
      // 
      this.procedimientosYFuncionesToolStripMenuItem.Name = "procedimientosYFuncionesToolStripMenuItem";
      this.procedimientosYFuncionesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.procedimientosYFuncionesToolStripMenuItem.Text = "Procesos";
      this.procedimientosYFuncionesToolStripMenuItem.Click += new System.EventHandler(this.procedimientosYFuncionesToolStripMenuItem_Click);
      // 
      // salirToolStripMenuItem
      // 
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.salirToolStripMenuItem.Text = "Salir";
      this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(518, 262);
      this.Controls.Add(this.menuStrip1);
      this.Name = "Form1";
      this.Text = "Menú principal";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimientosYFuncionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}

