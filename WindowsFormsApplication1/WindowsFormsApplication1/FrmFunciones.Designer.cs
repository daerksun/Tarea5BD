namespace WindowsFormsApplication1 {
  partial class FrmFunciones {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btCons1 = new System.Windows.Forms.Button();
      this.BTProc = new System.Windows.Forms.Button();
      this.cbSucursales = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.cbProductos = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbMonto = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btCons1
      // 
      this.btCons1.Location = new System.Drawing.Point(25, 19);
      this.btCons1.Name = "btCons1";
      this.btCons1.Size = new System.Drawing.Size(240, 37);
      this.btCons1.TabIndex = 0;
      this.btCons1.Text = "Cantidad de articulos por sucursal";
      this.btCons1.UseVisualStyleBackColor = true;
      this.btCons1.Click += new System.EventHandler(this.btCons1_Click);
      // 
      // BTProc
      // 
      this.BTProc.Location = new System.Drawing.Point(24, 19);
      this.BTProc.Name = "BTProc";
      this.BTProc.Size = new System.Drawing.Size(240, 37);
      this.BTProc.TabIndex = 1;
      this.BTProc.Text = "Núm de cadenas con precio menor";
      this.BTProc.UseVisualStyleBackColor = true;
      this.BTProc.Click += new System.EventHandler(this.BTProc_Click);
      // 
      // cbSucursales
      // 
      this.cbSucursales.FormattingEnabled = true;
      this.cbSucursales.Location = new System.Drawing.Point(79, 74);
      this.cbSucursales.Name = "cbSucursales";
      this.cbSucursales.Size = new System.Drawing.Size(186, 21);
      this.cbSucursales.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 77);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Sucursal";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btCons1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.cbSucursales);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(289, 111);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Función";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.tbMonto);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.cbProductos);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.BTProc);
      this.groupBox2.Location = new System.Drawing.Point(12, 138);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(289, 140);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Procedimiento";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(203, 284);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(98, 27);
      this.button1.TabIndex = 6;
      this.button1.Text = "Salir";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(25, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Producto";
      // 
      // cbProductos
      // 
      this.cbProductos.FormattingEnabled = true;
      this.cbProductos.Location = new System.Drawing.Point(79, 75);
      this.cbProductos.Name = "cbProductos";
      this.cbProductos.Size = new System.Drawing.Size(185, 21);
      this.cbProductos.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(25, 106);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Monto";
      // 
      // tbMonto
      // 
      this.tbMonto.Location = new System.Drawing.Point(79, 103);
      this.tbMonto.Name = "tbMonto";
      this.tbMonto.Size = new System.Drawing.Size(185, 20);
      this.tbMonto.TabIndex = 5;
      // 
      // FrmFunciones
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(323, 329);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "FrmFunciones";
      this.Text = "Funciones y procedimientos";
      this.Load += new System.EventHandler(this.funciones_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btCons1;
    private System.Windows.Forms.Button BTProc;
    private System.Windows.Forms.ComboBox cbSucursales;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox tbMonto;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cbProductos;
    private System.Windows.Forms.Label label2;
  }
}