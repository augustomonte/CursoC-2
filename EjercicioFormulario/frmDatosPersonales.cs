using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFormulario
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void frmDatosPersonales_Load(object sender, EventArgs e)
        {
            // Cartel Datos
            MessageBox.Show("Cargue sus datos personales", "Bienvenido");
        }



        List<Persona> personas = new List<Persona>();
        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = SystemColors.Window;
            txtApellido.BackColor = SystemColors.Window;
            txtEdad.BackColor = SystemColors.Window;
            txtDireccion.BackColor = SystemColors.Window;

            if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0 && txtEdad.Text.Length > 0 && txtDireccion.Text.Length > 0)
            {
                Persona p = new Persona();

                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                p.Edad = int.Parse(txtEdad.Text);
                p.Direccion = txtDireccion.Text;

                bool existe = false;
                foreach (Persona item in personas)
                {
                    if(item.Nombre == p.Nombre && item.Apellido == p.Apellido && item.Edad == p.Edad && item.Direccion == p.Direccion)
                    {
                        existe = true;
                        break;
                    }
                }
                if (existe)
                    MessageBox.Show("Los datos ingresados ya existen.", "Atención");
                else
                {
                    lvResultados.Items.Add(p.Nombre);
                    lvResultados.Items.Add(p.Apellido);
                    lvResultados.Items.Add(p.Edad.ToString());
                    lvResultados.Items.Add(p.Direccion);
                    personas.Add(p);
                }
            }
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Salmon;
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Salmon;
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Salmon;
            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Salmon;







        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8))
                e.Handled = true;
        }
    }
}
