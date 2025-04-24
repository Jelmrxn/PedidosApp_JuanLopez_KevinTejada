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
            cmbProducto.Items.Add("tecnología");
            cmbProducto.Items.Add("accesorio");
            cmbProducto.Items.Add("componente");
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

                lblResultado.Text = $"Entrega: {pedido.MetodoEntrega.TipoEntrega()} " +
                                    $"Costo: ${pedido.ObtenerCosto():0.00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}
