using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatosCURP.obtenerCurp;

namespace DatosCURP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        curpSoapClient cu = new curpSoapClient();
        private void btnCurp_Click(object sender, EventArgs e)
        {
            if (txtap.Text != string.Empty && txtam.Text != string.Empty && txtNomb.Text != string.Empty && txtano.Text != string.Empty && txtDia.Text != string.Empty)
            {
                try
                {
                    MessageBox.Show("Tu CURP es 0\n" + cu.generar(txtap.Text, txtam.Text, txtNomb.Text, txtano.Text, (cmbmes.SelectedIndex + 1).ToString(), txtDia.Text, cmbSexo.SelectedItem.ToString()));
                }
                catch (FormatException ex)
                {

                    MessageBox.Show("Debes de ingresar los datos correctos", ex.Message);
                }

            }
            else 
            {
                MessageBox.Show("Debes de llenar todos los campos necesarios");
            }
            
        }
    }
}
