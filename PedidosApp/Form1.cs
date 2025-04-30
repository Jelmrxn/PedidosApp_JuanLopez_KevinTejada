using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Items btn CheckBox
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarHistorialPedidos();
            cmbProducto.Items.Add("tecnología");
            cmbProducto.Items.Add("accesorio");
            cmbProducto.Items.Add("componente");

            // Llenar el ComboBox de filtro con los nuevos tipos de entrega incluyendo opción Todos para seleccionarlos Todos
            cmbFiltroEntrega.Items.Add("tecnología");
            cmbFiltroEntrega.Items.Add("accesorio");
            cmbFiltroEntrega.Items.Add("componente");
            cmbFiltroEntrega.Items.Add("Todos");


            // Cargar pedidos iniciales si existen
            CargarHistorialPedidos();

        }

        //Implementacion funcion boton calcular, btnCalcular_Click

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = txtCliente.Text;
                string producto = cmbProducto.SelectedItem.ToString();
                bool urgente = chkUrgente.Checked;
                double peso = Convert.ToDouble(nudPeso.Value);
                int distancia = Convert.ToInt32(nudDistancia.Value);

                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instancia.AgregarPedido(pedido);

                CargarHistorialPedidos();

                // Llamada al método para actualizar el DataGridView con el nuevo pedido agregado

                lblResultado.Text = $"Entrega: {pedido.MetodoEntrega.TipoEntrega()} " +
                                    $"Costo: ${pedido.ObtenerCosto():0.00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarHistorialPedidos()
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = RegistroPedidos.Instancia.ObtenerPedidos();

            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        //Logica de filtrado de cmbFiltroEntrega
        private void cmbFiltroEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener todos los pedidos
            List<Pedido> todosLosPedidos = RegistroPedidos.Instancia.ObtenerPedidos();

            // Obtener filtro seleccionado
            string filtroSeleccionado = cmbFiltroEntrega.SelectedItem?.ToString();

            List<Pedido> pedidosFiltrados;

            if (string.IsNullOrEmpty(filtroSeleccionado) || filtroSeleccionado.Equals("Todos", StringComparison.OrdinalIgnoreCase))
            {
                pedidosFiltrados = todosLosPedidos;
            }
            else
            {
                pedidosFiltrados = todosLosPedidos
                    .Where(p => p.Producto.Equals(filtroSeleccionado, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Actualizar el DataGridView
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = pedidosFiltrados;
        }
    }
}
