namespace pedidosfarmaciaa
{
    partial class PedidosForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.lblTipoMedicamento = new System.Windows.Forms.Label();
            this.cmbTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.lblDistribuidor = new System.Windows.Forms.Label();
            this.rdbDistribuidor1 = new System.Windows.Forms.RadioButton();
            this.rdbDistribuidor2 = new System.Windows.Forms.RadioButton();
            this.rdbDistribuidor3 = new System.Windows.Forms.RadioButton();
            this.lblSucursales = new System.Windows.Forms.Label();
            this.chkSucursalPrincipal = new System.Windows.Forms.CheckBox();
            this.chkSucursalSecundaria = new System.Windows.Forms.CheckBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Location = new System.Drawing.Point(36, 16);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(166, 16);
            this.lblMedicamento.TabIndex = 0;
            this.lblMedicamento.Text = "Nombre del medicamento:";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(36, 36);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(231, 22);
            this.txtMedicamento.TabIndex = 1;
            // 
            // lblTipoMedicamento
            // 
            this.lblTipoMedicamento.AutoSize = true;
            this.lblTipoMedicamento.Location = new System.Drawing.Point(36, 66);
            this.lblTipoMedicamento.Name = "lblTipoMedicamento";
            this.lblTipoMedicamento.Size = new System.Drawing.Size(142, 16);
            this.lblTipoMedicamento.TabIndex = 2;
            this.lblTipoMedicamento.Text = "Tipo de medicamento:";
            // 
            // cmbTipoMedicamento
            // 
            this.cmbTipoMedicamento.FormattingEnabled = true;
            this.cmbTipoMedicamento.Items.AddRange(new object[] {
            "Seleccione...",
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibiótico"});
            this.cmbTipoMedicamento.Location = new System.Drawing.Point(36, 85);
            this.cmbTipoMedicamento.Name = "cmbTipoMedicamento";
            this.cmbTipoMedicamento.Size = new System.Drawing.Size(230, 24);
            this.cmbTipoMedicamento.TabIndex = 3;
            // 
            // lblDistribuidor
            // 
            this.lblDistribuidor.AutoSize = true;
            this.lblDistribuidor.Location = new System.Drawing.Point(36, 122);
            this.lblDistribuidor.Name = "lblDistribuidor";
            this.lblDistribuidor.Size = new System.Drawing.Size(78, 16);
            this.lblDistribuidor.TabIndex = 4;
            this.lblDistribuidor.Text = "Distribuidor:";
            // 
            // rdbDistribuidor1
            // 
            this.rdbDistribuidor1.AutoSize = true;
            this.rdbDistribuidor1.Location = new System.Drawing.Point(36, 141);
            this.rdbDistribuidor1.Name = "rdbDistribuidor1";
            this.rdbDistribuidor1.Size = new System.Drawing.Size(79, 20);
            this.rdbDistribuidor1.TabIndex = 5;
            this.rdbDistribuidor1.Text = "Cofarma";
            this.rdbDistribuidor1.UseVisualStyleBackColor = true;
            // 
            // rdbDistribuidor2
            // 
            this.rdbDistribuidor2.AutoSize = true;
            this.rdbDistribuidor2.Location = new System.Drawing.Point(135, 141);
            this.rdbDistribuidor2.Name = "rdbDistribuidor2";
            this.rdbDistribuidor2.Size = new System.Drawing.Size(98, 20);
            this.rdbDistribuidor2.TabIndex = 6;
            this.rdbDistribuidor2.Text = "Empsephar";
            this.rdbDistribuidor2.UseVisualStyleBackColor = true;
            // 
            // rdbDistribuidor3
            // 
            this.rdbDistribuidor3.AutoSize = true;
            this.rdbDistribuidor3.Location = new System.Drawing.Point(245, 141);
            this.rdbDistribuidor3.Name = "rdbDistribuidor3";
            this.rdbDistribuidor3.Size = new System.Drawing.Size(79, 20);
            this.rdbDistribuidor3.TabIndex = 7;
            this.rdbDistribuidor3.Text = "Cemefar";
            this.rdbDistribuidor3.UseVisualStyleBackColor = true;
            // 
            // lblSucursales
            // 
            this.lblSucursales.AutoSize = true;
            this.lblSucursales.Location = new System.Drawing.Point(36, 174);
            this.lblSucursales.Name = "lblSucursales";
            this.lblSucursales.Size = new System.Drawing.Size(77, 16);
            this.lblSucursales.TabIndex = 8;
            this.lblSucursales.Text = "Sucursales:";
            // 
            // chkSucursalPrincipal
            // 
            this.chkSucursalPrincipal.AutoSize = true;
            this.chkSucursalPrincipal.Location = new System.Drawing.Point(36, 193);
            this.chkSucursalPrincipal.Name = "chkSucursalPrincipal";
            this.chkSucursalPrincipal.Size = new System.Drawing.Size(136, 20);
            this.chkSucursalPrincipal.TabIndex = 9;
            this.chkSucursalPrincipal.Text = "Sucursal Principal";
            this.chkSucursalPrincipal.UseVisualStyleBackColor = true;
            // 
            // chkSucursalSecundaria
            // 
            this.chkSucursalSecundaria.AutoSize = true;
            this.chkSucursalSecundaria.Location = new System.Drawing.Point(190, 193);
            this.chkSucursalSecundaria.Name = "chkSucursalSecundaria";
            this.chkSucursalSecundaria.Size = new System.Drawing.Size(153, 20);
            this.chkSucursalSecundaria.TabIndex = 10;
            this.chkSucursalSecundaria.Text = "Sucursal Secundaria";
            this.chkSucursalSecundaria.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(36, 242);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(123, 242);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(36, 282);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(156, 44);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(198, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 44);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 200);
            this.dataGridView1.TabIndex = 15;
            // 
            // PedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.chkSucursalSecundaria);
            this.Controls.Add(this.chkSucursalPrincipal);
            this.Controls.Add(this.lblSucursales);
            this.Controls.Add(this.rdbDistribuidor3);
            this.Controls.Add(this.rdbDistribuidor2);
            this.Controls.Add(this.rdbDistribuidor1);
            this.Controls.Add(this.lblDistribuidor);
            this.Controls.Add(this.cmbTipoMedicamento);
            this.Controls.Add(this.lblTipoMedicamento);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.lblMedicamento);
            this.Name = "PedidosForm";
            this.Text = "Sistema de Pedidos de Farmacia";
            this.Load += new System.EventHandler(this.PedidosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label lblTipoMedicamento;
        private System.Windows.Forms.ComboBox cmbTipoMedicamento;
        private System.Windows.Forms.Label lblDistribuidor;
        private System.Windows.Forms.RadioButton rdbDistribuidor1;
        private System.Windows.Forms.RadioButton rdbDistribuidor2;
        private System.Windows.Forms.RadioButton rdbDistribuidor3;
        private System.Windows.Forms.Label lblSucursales;
        private System.Windows.Forms.CheckBox chkSucursalPrincipal;
        private System.Windows.Forms.CheckBox chkSucursalSecundaria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
