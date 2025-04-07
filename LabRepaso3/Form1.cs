using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRepaso3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Agregar_Propietario formAgregarPropietario = new Form_Agregar_Propietario();
            formAgregarPropietario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Visualizar form_Visualizar = new Form_Visualizar();
            form_Visualizar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
