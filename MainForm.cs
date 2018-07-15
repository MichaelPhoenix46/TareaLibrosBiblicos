using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RegistroLibrosBiblicos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroDeLibrosBiblicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RLibros r = new UI.Registros.RLibros();
            r.Show();
        }

        private void ConsultaDeLibrosBiblicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.CLibros c = new UI.Consultas.CLibros();
            c.Show();
        }
    }
}
