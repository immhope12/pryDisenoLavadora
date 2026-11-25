using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDisenoLavadora
{
    public partial class frmLavados : Form
    {
        // Vectores paralelos para guardar los lavados del día
        string[] clientes = new string[100];
        string[] patentes = new string[100];
        string[] servicios = new string[100];
        int[] cantidades = new int[100];
        string[] entregas = new string[100];
        decimal[] totales = new decimal[100];
        int cantidadRegistros = 0;

        // Acumuladores de recaudación
        decimal recExterior = 0m, recCompleto = 0m, recEncerado = 0m;
        decimal recNormal = 0m, recExpress = 0m;

        public frmLavados()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingresá el nombre del cliente.");
                txtCliente.Focus();
                return;
            }

            string patente = txtPatente.Text.Trim();
            if (patente.Length < 6 || patente.Length > 7)
            {
                MessageBox.Show("La patente debe tener 6 o 7 caracteres.");
                txtPatente.Focus();
                return;
            }

            if (cmbServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná un servicio.");
                cmbServicio.Focus();
                return;
            }

            int cantidad;
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 1 || cantidad > 5)
            {
                MessageBox.Show("Ingresá una cantidad válida entre 1 y 5.");
                txtCantidad.Focus();
                return;
            }

            if (!btnNormal.Checked && !btnExpres.Checked)
            {
                MessageBox.Show("Seleccioná un tipo de entrega.");
                btnNormal.Focus();
                return;
            }

            decimal precioUnitario = 0m;
            switch (cmbServicio.Text)
            {
                case "Lavado exterior":
                    precioUnitario = 8000m;
                    break;
                case "Lavado completo":
                    precioUnitario = 14000m;
                    break;
                case "Lavado con encerado":
                    precioUnitario = 20000m;
                    break;
            }

            decimal subtotal = precioUnitario * cantidad;

            decimal recargo = 0m;
            if (btnExpres.Checked)
            {
                recargo = subtotal * 0.25m;
            }

            int porcentajeDescuento = 0;
            if (cantidad >= 4 && cantidad <= 5)
            {
                porcentajeDescuento = 15;
            }
            else if (cantidad >= 2 && cantidad <= 3)
            {
                porcentajeDescuento = 10;
            }

            if (chkClienteFrecuente.Checked)
            {
                porcentajeDescuento += 5;
            }

            decimal montoDescuento = subtotal * (porcentajeDescuento / 100m);
            decimal total = subtotal + recargo - montoDescuento;

            lblSubtotal.Text = "$ " + subtotal.ToString("N2");
            lblRecargo.Text = "$ " + recargo.ToString("N2");
            lblDescuento.Text = porcentajeDescuento + "% ($ " + montoDescuento.ToString("N2") + ")";
            lblTotal.Text = "$ " + total.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtPatente.Clear();
            cmbServicio.SelectedIndex = -1;
            txtCantidad.Clear();
            btnNormal.Checked = true;
            chkClienteFrecuente.Checked = false;

            lblSubtotal.Text = "$0,00";
            lblRecargo.Text = "$0,00";
            lblDescuento.Text = "$0,00";
            lblTotal.Text = "$0,00";

            txtCliente.Focus();
        }

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingresá el nombre del cliente.");
                txtCliente.Focus();
                return;
            }

            string patente = txtPatente.Text.Trim().ToUpper();
            if (patente.Length < 6 || patente.Length > 7)
            {
                MessageBox.Show("La patente debe tener 6 o 7 caracteres.");
                txtPatente.Focus();
                return;
            }

            if (cmbServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná un servicio.");
                cmbServicio.Focus();
                return;
            }

            int cantidad;
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 1 || cantidad > 5)
            {
                MessageBox.Show("Ingresá una cantidad válida entre 1 y 5.");
                txtCantidad.Focus();
                return;
            }

            if (!btnNormal.Checked && !btnExpres.Checked)
            {
                MessageBox.Show("Seleccioná un tipo de entrega.");
                btnNormal.Focus();
                return;
            }

            if (cantidadRegistros >= 100)
            {
                MessageBox.Show("Se alcanzó el límite de 100 lavados diarios.");
                return;
            }

            decimal precioUnitario = 0m;
            switch (cmbServicio.Text)
            {
                case "Lavado exterior":
                    precioUnitario = 8000m;
                    break;
                case "Lavado completo":
                    precioUnitario = 14000m;
                    break;
                case "Lavado con encerado":
                    precioUnitario = 20000m;
                    break;
            }

            decimal subtotal = precioUnitario * cantidad;
            decimal recargo = btnExpres.Checked ? subtotal * 0.25m : 0m;

            int porcentajeDescuento = 0;
            if (cantidad >= 4 && cantidad <= 5)
            {
                porcentajeDescuento = 15;
            }
            else if (cantidad >= 2 && cantidad <= 3)
            {
                porcentajeDescuento = 10;
            }

            if (chkClienteFrecuente.Checked)
            {
                porcentajeDescuento += 5;
            }

            decimal montoDescuento = subtotal * (porcentajeDescuento / 100m);
            decimal total = subtotal + recargo - montoDescuento;
            string tipoEntrega = btnExpres.Checked ? "Express" : "Normal";
            clientes[cantidadRegistros] = txtCliente.Text.Trim();
            patentes[cantidadRegistros] = patente;
            servicios[cantidadRegistros] = cmbServicio.Text;
            cantidades[cantidadRegistros] = cantidad;
            entregas[cantidadRegistros] = tipoEntrega;
            totales[cantidadRegistros] = total;
            cantidadRegistros++;
            dgvLavados.Rows.Add(
                txtCliente.Text.Trim(),
                patente,
                cmbServicio.Text,
                cantidad,
                tipoEntrega,
                "$ " + total.ToString("N2")
            );

            
            if (cmbServicio.Text == "Lavado exterior") recExterior += total;
            else if (cmbServicio.Text == "Lavado completo") recCompleto += total;
            else if (cmbServicio.Text == "Lavado con encerado") recEncerado += total;

            if (btnExpres.Checked) recExpress += total;
            else recNormal += total;

            lblLavadoTotal.Text = "$ " + recExterior.ToString("N2");
            lblCompletoTotal.Text = "$ " + recCompleto.ToString("N2");
            lblEnceradoTotal.Text = "$ " + recEncerado.ToString("N2");
            lblNormalTotal.Text = "$ " + recNormal.ToString("N2");
            lblExpresTotal.Text = "$ " + recExpress.ToString("N2");

            MessageBox.Show("Lavado registrado correctamente.");
            btnLimpiar.PerformClick();
        }

        private void btnConsultaPatente_Click(object sender, EventArgs e)
        {
            string patenteBuscada = txtPatenteConsulta.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(patenteBuscada))
            {
                MessageBox.Show("Ingresá una patente para consultar.");
                txtPatenteConsulta.Focus();
                return;
            }

            lstConsulta.Items.Clear();
            int encontrados = 0;

            for (int i = 0; i < cantidadRegistros; i++)
            {
                if (patentes[i] == patenteBuscada)
                {
                    lstConsulta.Items.Add($"{clientes[i]} - {servicios[i]} ({cantidades[i]} veh.) - {entregas[i]} - $ {totales[i]:N2}");
                    encontrados++;
                }
            }

            if (encontrados == 0)
            {
                MessageBox.Show("No hay lavados registrados para esa patente.");
            }
        }
    }
}