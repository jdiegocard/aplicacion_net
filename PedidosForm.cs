using System;
using System.Data;
using System.Windows.Forms;

namespace pedidosfarmaciaa
{
    public partial class PedidosForm : Form
    {
        private DataTable tablaPedidos; // Tabla en memoria

        public PedidosForm()
        {
            InitializeComponent();

            // Inicializar la tabla de pedidos
            InicializarTablaPedidos();
        }

        private void InicializarTablaPedidos()
        {
            // Crear la tabla y columnas
            tablaPedidos = new DataTable();
            tablaPedidos.Columns.Add("Medicamento", typeof(string));
            tablaPedidos.Columns.Add("Tipo", typeof(string));
            tablaPedidos.Columns.Add("Distribuidor", typeof(string));
            tablaPedidos.Columns.Add("Cantidad", typeof(int));
            tablaPedidos.Columns.Add("Sucursales", typeof(string));

            // Enlazar la tabla la form
            dataGridView1.DataSource = tablaPedidos;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar Medicamento
            if (string.IsNullOrWhiteSpace(txtMedicamento.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar Tipo de Medicamento
            if (cmbTipoMedicamento.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, selecciona un tipo de medicamento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar Distribuidor
            if (!rdbDistribuidor1.Checked && !rdbDistribuidor2.Checked && !rdbDistribuidor3.Checked)
            {
                MessageBox.Show("Por favor, selecciona un distribuidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener Distribuidor
            string distribuidor = rdbDistribuidor1.Checked ? "Cofarma" :
                                  rdbDistribuidor2.Checked ? "Empsephar" :
                                  rdbDistribuidor3.Checked ? "Cemefar" : "Ninguno";

            // Validar Sucursales
            if (!chkSucursalPrincipal.Checked && !chkSucursalSecundaria.Checked)
            {
                MessageBox.Show("Por favor, selecciona al menos una sucursal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar Cantidad
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener Sucursales
            string sucursales = (chkSucursalPrincipal.Checked ? "Principal " : "") +
                                (chkSucursalSecundaria.Checked ? "Secundaria" : "");

            // Agregar el pedido a la tabla
            tablaPedidos.Rows.Add(txtMedicamento.Text, cmbTipoMedicamento.SelectedItem.ToString(), distribuidor, cantidad, sucursales);

            // Mostrar confirmación
            MessageBox.Show($"Pedido confirmado:\n" +
                            $"- Medicamento: {txtMedicamento.Text}\n" +
                            $"- Tipo: {cmbTipoMedicamento.SelectedItem}\n" +
                            $"- Cantidad: {cantidad}\n" +
                            $"- Distribuidor: {distribuidor}\n" +
                            $"- Sucursales: {sucursales}");

            // Reiniciar el formulario
            BtnCancelar_Click(sender, e);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Reiniciar el formulario
            txtMedicamento.Clear();
            cmbTipoMedicamento.SelectedIndex = 0;
            rdbDistribuidor1.Checked = false;
            rdbDistribuidor2.Checked = false;
            rdbDistribuidor3.Checked = false;
            chkSucursalPrincipal.Checked = false;
            chkSucursalSecundaria.Checked = false;
            txtCantidad.Clear();

            MessageBox.Show("Formulario reiniciado.");
        }

        private void PedidosForm_Load(object sender, EventArgs e)
        {
            // Configuración inicial
            cmbTipoMedicamento.SelectedIndex = 0;
        }
    }
}
