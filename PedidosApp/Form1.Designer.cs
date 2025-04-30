namespace PedidosApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.cmbFiltroEntrega = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(415, 113);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(180, 26);
            this.txtCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digitar nombre cliente:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(948, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(540, 48);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Cotizacion tarifa de envio";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(415, 190);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(174, 28);
            this.cmbProducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione tipo de producto:";
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(415, 282);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(99, 24);
            this.chkUrgente.TabIndex = 5;
            this.chkUrgente.Text = "Urgencia";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione tipo de urgencia:";
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(415, 366);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(152, 26);
            this.nudPeso.TabIndex = 7;
            // 
            // nudDistancia
            // 
            this.nudDistancia.Location = new System.Drawing.Point(415, 463);
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(152, 26);
            this.nudDistancia.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese el peso del producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingrese el numero de kms\r\nde distancia del trayecto del envio:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(676, 165);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(194, 65);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Confirmar solicitud";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "¿Desea confirmar la solicitud para ver el costo de su envio?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(735, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 40);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(847, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 48);
            this.label8.TabIndex = 14;
            this.label8.Text = "Historial pedidos";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(755, 406);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 62;
            this.dgvHistorial.RowTemplate.Height = 28;
            this.dgvHistorial.Size = new System.Drawing.Size(511, 389);
            this.dgvHistorial.TabIndex = 15;
            // 
            // cmbFiltroEntrega
            // 
            this.cmbFiltroEntrega.FormattingEnabled = true;
            this.cmbFiltroEntrega.Location = new System.Drawing.Point(227, 667);
            this.cmbFiltroEntrega.Name = "cmbFiltroEntrega";
            this.cmbFiltroEntrega.Size = new System.Drawing.Size(163, 28);
            this.cmbFiltroEntrega.TabIndex = 16;
            this.cmbFiltroEntrega.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEntrega_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "Filtrar pedidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 930);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbFiltroEntrega);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudDistancia);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.NumericUpDown nudDistancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFiltroEntrega;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dgvHistorial;
    }
}

