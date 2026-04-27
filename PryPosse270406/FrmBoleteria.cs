using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPosse270406
{
    public partial class FrmBoleteria : Form
    {
        int varDistancia = 0;
        int varCantidad = 0;
        int varTotal = 0;
        int distancia = 0;


        public FrmBoleteria()
        {
            InitializeComponent();
        }

        private void lblDistancia_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDistancia.Text == "")
            {
                MessageBox.Show("Ingrese la distancia a recorrer");
                txtDistancia.Focus();
            }
            if (cmbCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad de boletos a comprar");
                cmbCantidad.Focus();
            }

            distancia = Convert.ToInt16(txtDistancia.Text);
            if ((Convert.ToInt16(cmbCantidad.Text)) >= 7 || distancia >= 100)
            {
                
                varDistancia = (distancia * 5);
                varTotal = varDistancia / 2;
                MessageBox.Show($"El total a pagar es: {varTotal}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else            
            {
                
                varDistancia = (distancia * 5);
                varTotal = varDistancia;
                MessageBox.Show($"El total a pagar es: {varTotal}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
