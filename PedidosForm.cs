using System;
using System.Windows.Forms;

namespace pedidosfarmaciaa
{
    public partial class PedidosForm : Form
    {
        public PedidosForm()
        {
            InitializeComponent();

            txtMedicamento.Text = "Nombre del medicamento";
            txtMedicamento.ForeColor = System.Drawing.Color.Gray;
            txtMedicamento.GotFocus += TxtMedicamento_GotFocus;
            txtMedicamento.LostFocus += TxtMedicamento_LostFocus;
        }

        private void TxtMedicamento_GotFocus(object sender, EventArgs e)
        {
            if (txtMedicamento.Text == "Nombre del medicamento")
            {
                txtMedicamento.Text = string.Empty;
                txtMedicamento.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtMedicamento_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicamento.Text))
            {
                txtMedicamento.Text = "Nombre del medicamento";
                txtMedicamento.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtMedicamento.Text == "Nombre del medicamento" || string.IsNullOrWhiteSpace(txtMedicamento.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbTipoMedicamento.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, selecciona un tipo de medicamento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!chkSucursalPrincipal.Checked && !chkSucursalSecundaria.Checked)
            {
                MessageBox.Show("Por favor, selecciona al menos una sucursal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string distribuidor = rdbDistribuidor1.Checked ? "Cofarma" :
                                  rdbDistribuidor2.Checked ? "Empsephar" :
                                  rdbDistribuidor3.Checked ? "Cemefar" : "Ninguno";

            MessageBox.Show($"Pedido confirmado:\n" +
                            $"- Medicamento: {txtMedicamento.Text}\n" +
                            $"- Tipo: {cmbTipoMedicamento.SelectedItem}\n" +
                            $"- Distribuidor: {distribuidor}\n" +
                            $"- Cantidad: {cantidad}\n" +
                            $"- Sucursales: {(chkSucursalPrincipal.Checked ? "Principal " : "")}{(chkSucursalSecundaria.Checked ? "Secundaria" : "")}");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtMedicamento.Text = "Nombre del medicamento";
            txtMedicamento.ForeColor = System.Drawing.Color.Gray;
            cmbTipoMedicamento.SelectedIndex = 0;
            rdbDistribuidor1.Checked = false;
            rdbDistribuidor2.Checked = false;
            rdbDistribuidor3.Checked = false;
            chkSucursalPrincipal.Checked = false;
            chkSucursalSecundaria.Checked = false;
            txtCantidad.Clear();

            MessageBox.Show("Formulario reiniciado.");
        }
    }
}
