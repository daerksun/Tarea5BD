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
      this.label2 = new System.Windows.Forms.Label();
      this.lbMontoTotal = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lbNumPagos = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lbMontoPagos = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lbSaldoAct = new System.Windows.Forms.Label();
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
      this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtFecha.Location = new System.Drawing.Point(129, 33);
      this.dtFecha.Name = "dtFecha";
      this.dtFecha.Size = new System.Drawing.Size(135, 20);
      this.dtFecha.TabIndex = 2;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 88);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(252, 208);
      this.dataGridView1.TabIndex = 3;
      // 
      // btConsulta
      // 
      this.btConsulta.Enabled = false;
      this.btConsulta.Location = new System.Drawing.Point(189, 59);
      this.btConsulta.Name = "btConsulta";
      this.btConsulta.Size = new System.Drawing.Size(75, 23);
      this.btConsulta.TabIndex = 4;
      this.btConsulta.Text = "Consultar";
      this.btConsulta.UseVisualStyleBackColor = true;
      this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(-2, 328);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Monto Total :";
      // 
      // lbMontoTotal
      // 
      this.lbMontoTotal.AutoSize = true;
      this.lbMontoTotal.Location = new System.Drawing.Point(89, 328);
      this.lbMontoTotal.Name = "lbMontoTotal";
      this.lbMontoTotal.Size = new System.Drawing.Size(0, 13);
      this.lbMontoTotal.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(-2, 345);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(108, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "# Pagos Realizados :";
      // 
      // lbNumPagos
      // 
      this.lbNumPagos.AutoSize = true;
      this.lbNumPagos.Location = new System.Drawing.Point(128, 345);
      this.lbNumPagos.Name = "lbNumPagos";
      this.lbNumPagos.Size = new System.Drawing.Size(0, 13);
      this.lbNumPagos.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(-2, 363);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(76, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Monto Pagos :";
      // 
      // lbMontoPagos
      // 
      this.lbMontoPagos.AutoSize = true;
      this.lbMontoPagos.Location = new System.Drawing.Point(98, 363);
      this.lbMontoPagos.Name = "lbMontoPagos";
      this.lbMontoPagos.Size = new System.Drawing.Size(0, 13);
      this.lbMontoPagos.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(-2, 379);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(73, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Saldo Actual :";
      // 
      // lbSaldoAct
      // 
      this.lbSaldoAct.AutoSize = true;
      this.lbSaldoAct.Location = new System.Drawing.Point(99, 379);
      this.lbSaldoAct.Name = "lbSaldoAct";
      this.lbSaldoAct.Size = new System.Drawing.Size(0, 13);
      this.lbSaldoAct.TabIndex = 12;
      // 
      // FrmCadena
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ClientSize = new System.Drawing.Size(277, 399);
      this.Controls.Add(this.lbSaldoAct);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lbMontoPagos);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.lbNumPagos);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lbMontoTotal);
      this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMontoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNumPagos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMontoPagos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSaldoAct;
    }
}