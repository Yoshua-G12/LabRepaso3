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
    public partial class Form_Agregar_Propietario : Form
    {
        public Form_Agregar_Propietario()
        {
            InitializeComponent();
        }
        List<Propietario> propietarios = new List<Propietario>();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Visualizar form_Visualizar = new Form_Visualizar();
            form_Visualizar.ShowDialog();   
        }

        private void Form_Agregar_Propietario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PropietariioArchivo clienteArchivo = new PropietariioArchivo();
            string nuevoDPI = txtdpi.Text.Trim();


            bool yaExiste = propietarios.Any(v => v.dpi.Equals(nuevoDPI, StringComparison.OrdinalIgnoreCase));

            if (yaExiste)
            {
                MessageBox.Show("Ya existe este usuario, comprueba el nit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Propietario propietario = new Propietario
            {
                dpi = nuevoDPI,
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
            };
            

            propietarios.Add(propietario);
            clienteArchivo.Guardar("../../Clientes.json", propietarios);

            txtnombre.Clear();
            txtapellido.Clear();
            txtdpi.Clear();
            txtnocasa.Clear();
            txtcuota.Clear();
        }
    }
}
