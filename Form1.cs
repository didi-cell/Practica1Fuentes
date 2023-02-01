using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1Fuentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bNegrita_Click(object sender, EventArgs e)
        {
            labelTexto.Font = new System.Drawing.Font(labelTexto.Font, FontStyle.Bold);
        }

        private void bCursiva_Click(object sender, EventArgs e)
        {
            labelTexto.Font = new System.Drawing.Font(labelTexto.Font, FontStyle.Italic);
        }

        private void bSubrayada_Click(object sender, EventArgs e)
        {
            labelTexto.Font = new System.Drawing.Font(labelTexto.Font, FontStyle.Underline);
        }
    }
}
