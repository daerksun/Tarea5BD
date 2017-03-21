namespace WindowsFormsApplication1
{
    partial class FrmCadena
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
      this.cbClientes = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dtFecha = new System.Windows.Forms.DateTimePicker();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btConsulta = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // cbClientes
      // 
      this.cbClientes.FormattingEnabled = true;
      this.cbClientes.Location = new System.Drawing.Point(117, 7);
      this.cbClientes.Name = "cbClientes";
      this.cbClientes.Size = new System.Drawing.Size(147, 21);
      this.cbClientes.TabIndex = 0;
      this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(99, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Nombre del Cliente:";
      // 
      // dtFecha
      // 
      this.dtFecha.Location = new System.Drawing.Point(270, 8);
      this.dtFecha.Name = "dtFecha";
      this.dtFecha.Size = new System.Drawing.Size(219, 20);
      this.dtFecha.TabIndex = 2;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(13, 65);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(476, 255);
      this.dataGridView1.TabIndex = 3;
      // 
      // btConsulta
      // 
      this.btConsulta.Enabled = false;
      this.btConsulta.Location = new System.Drawing.Point(414, 34);
      this.btConsulta.Name = "btConsulta";
      this.btConsulta.Size = new System.Drawing.Size(75, 23);
      this.btConsulta.TabIndex = 4;
      this.btConsulta.Text = "Consultar";
      this.btConsulta.UseVisualStyleBackColor = true;
      this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
      // 
      // FrmCadena
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ClientSize = new System.Drawing.Size(501, 419);
      this.Controls.Add(this.btConsulta);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.dtFecha);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbClientes);
      this.Name = "FrmCadena";
      this.Text = "Compras";
      this.Load += new System.EventHandler(this.FrmCadena_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btConsulta;
    }
}