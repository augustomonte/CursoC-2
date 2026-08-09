using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoExceptions
{
    public partial class frmExcepciones : Form
    {
        public frmExcepciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;

            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);

                r = a / b;

                lblResult.Text = "= " + r;
            }
            catch (Exception)
            {
                MessageBox.Show("Se encontro un error\nIntente nuevamente", "Atencion");
            }

        }
    }
}
