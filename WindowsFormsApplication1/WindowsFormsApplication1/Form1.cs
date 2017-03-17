using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadosConsultas rC = new resultadosConsultas();
            rC.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadena fc = new FrmCadena();
            fc.Show();
        }


    }
}
