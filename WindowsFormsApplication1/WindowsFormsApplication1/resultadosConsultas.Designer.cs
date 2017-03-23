namespace WindowsFormsApplication1
{
    partial class resultadosConsultas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btConsultaA = new System.Windows.Forms.Button();
            this.btConsultaB = new System.Windows.Forms.Button();
            this.btConsultaC = new System.Windows.Forms.Button();
            this.btConsultaD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // btConsultaA
            // 
            this.btConsultaA.Location = new System.Drawing.Point(20, 12);
            this.btConsultaA.Name = "btConsultaA";
            this.btConsultaA.Size = new System.Drawing.Size(252, 45);
            this.btConsultaA.TabIndex = 1;
            this.btConsultaA.Text = "Clientes cuyo saldo global es menor al 10% del monto total de los articulos que c" +
    "ompraron";
            this.btConsultaA.UseVisualStyleBackColor = true;
            this.btConsultaA.Click += new System.EventHandler(this.btConsultaA_Click);
            // 
            // btConsultaB
            // 
            this.btConsultaB.Location = new System.Drawing.Point(278, 12);
            this.btConsultaB.Name = "btConsultaB";
            this.btConsultaB.Size = new System.Drawing.Size(252, 45);
            this.btConsultaB.TabIndex = 2;
            this.btConsultaB.Text = "Clientes que no han hecho compras este mes junto con las cadenas en donde tienen " +
    "crédito";
            this.btConsultaB.UseVisualStyleBackColor = true;
            this.btConsultaB.Click += new System.EventHandler(this.btConsultaB_Click);
            // 
            // btConsultaC
            // 
            this.btConsultaC.Location = new System.Drawing.Point(20, 63);
            this.btConsultaC.Name = "btConsultaC";
            this.btConsultaC.Size = new System.Drawing.Size(252, 45);
            this.btConsultaC.TabIndex = 3;
            this.btConsultaC.Text = "Sucursales con el monto total de ventas del mes pasado (solo ventas menores a $50" +
    ",000)";
            this.btConsultaC.UseVisualStyleBackColor = true;
            this.btConsultaC.Click += new System.EventHandler(this.btConsultaC_Click);
            // 
            // btConsultaD
            // 
            this.btConsultaD.Location = new System.Drawing.Point(278, 63);
            this.btConsultaD.Name = "btConsultaD";
            this.btConsultaD.Size = new System.Drawing.Size(252, 45);
            this.btConsultaD.TabIndex = 4;
            this.btConsultaD.Text = "Nombre de la cadena con más sucursales (Nombre y domicilio)";
            this.btConsultaD.UseVisualStyleBackColor = true;
            this.btConsultaD.Click += new System.EventHandler(this.btConsultaD_Click);
            // 
            // resultadosConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 327);
            this.Controls.Add(this.btConsultaD);
            this.Controls.Add(this.btConsultaC);
            this.Controls.Add(this.btConsultaB);
            this.Controls.Add(this.btConsultaA);
            this.Controls.Add(this.dataGridView1);
            this.Name = "resultadosConsultas";
            this.Text = "resultadosConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btConsultaA;
        private System.Windows.Forms.Button btConsultaB;
        private System.Windows.Forms.Button btConsultaC;
        private System.Windows.Forms.Button btConsultaD;
    }
}