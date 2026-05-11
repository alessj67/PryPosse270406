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
            // Validaciones iniciales: si falta alguno, mostrar mensaje y salir
            if (string.IsNullOrWhiteSpace(txtDistancia.Text))
            {
                MessageBox.Show("Ingrese la distancia a recorrer", "ojo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistancia.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbCantidad.Text))
            {
                MessageBox.Show("Ingrese la cantidad de boletos a comprar", "ojo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCantidad.Focus();
                return;
            }

            // Parse seguro de entradas
            if (!int.TryParse(txtDistancia.Text.Trim(), out int distanciaParsed))
            {
                MessageBox.Show("La distancia debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDistancia.Focus();
                return;
            }

            if (!int.TryParse(cmbCantidad.Text.Trim(), out int cantidadParsed))
            {
                MessageBox.Show("La cantidad debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCantidad.Focus();
                return;
            }

            // Usar los valores parseados para la lógica
            distancia = distanciaParsed;
            varDistancia = (distancia * 5);

            if (cantidadParsed >= 7 || distancia >= 100)
            {
                varTotal = varDistancia / 2;
            }
            else
            {
                varTotal = varDistancia;
            }

            MessageBox.Show($"El total a pagar es: {varTotal}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
