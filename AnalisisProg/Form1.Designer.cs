namespace AnalisisProg
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnOrdenarInsertion = new System.Windows.Forms.Button();
            this.lblTiempoini = new System.Windows.Forms.Label();
            this.lblTiempofin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.btnOrdenarQuick = new System.Windows.Forms.Button();
            this.blBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarSecuencial = new System.Windows.Forms.Button();
            this.btnBuscarBinaria = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(33, 69);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(356, 25);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Números";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstOrdenada);
            this.groupBox1.Controls.Add(this.lstDatos);
            this.groupBox1.Location = new System.Drawing.Point(33, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros: 0";
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.ItemHeight = 16;
            this.lstOrdenada.Location = new System.Drawing.Point(200, 21);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(141, 196);
            this.lstOrdenada.TabIndex = 1;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 16;
            this.lstDatos.Location = new System.Drawing.Point(17, 21);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(141, 196);
            this.lstDatos.TabIndex = 0;
            // 
            // btnOrdenarInsertion
            // 
            this.btnOrdenarInsertion.Location = new System.Drawing.Point(33, 100);
            this.btnOrdenarInsertion.Name = "btnOrdenarInsertion";
            this.btnOrdenarInsertion.Size = new System.Drawing.Size(168, 37);
            this.btnOrdenarInsertion.TabIndex = 3;
            this.btnOrdenarInsertion.Text = "Ordenar (Insertion)";
            this.btnOrdenarInsertion.UseVisualStyleBackColor = true;
            this.btnOrdenarInsertion.Click += new System.EventHandler(this.btnOrdenarInsertion_Click);
            // 
            // lblTiempoini
            // 
            this.lblTiempoini.AutoSize = true;
            this.lblTiempoini.Location = new System.Drawing.Point(30, 515);
            this.lblTiempoini.Name = "lblTiempoini";
            this.lblTiempoini.Size = new System.Drawing.Size(161, 16);
            this.lblTiempoini.TabIndex = 4;
            this.lblTiempoini.Text = "Tiempo de inicio: 00:00:00";
            // 
            // lblTiempofin
            // 
            this.lblTiempofin.AutoSize = true;
            this.lblTiempofin.Location = new System.Drawing.Point(30, 540);
            this.lblTiempofin.Name = "lblTiempofin";
            this.lblTiempofin.Size = new System.Drawing.Size(143, 16);
            this.lblTiempofin.TabIndex = 5;
            this.lblTiempofin.Text = "Tiempo de fin: 00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de Registros:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(184, 40);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(205, 22);
            this.txtCantidad.TabIndex = 7;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(33, 582);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(137, 16);
            this.lblDuracion.TabIndex = 8;
            this.lblDuracion.Text = "Duración: 0 segundos";
            // 
            // btnOrdenarQuick
            // 
            this.btnOrdenarQuick.Location = new System.Drawing.Point(221, 100);
            this.btnOrdenarQuick.Name = "btnOrdenarQuick";
            this.btnOrdenarQuick.Size = new System.Drawing.Size(168, 37);
            this.btnOrdenarQuick.TabIndex = 9;
            this.btnOrdenarQuick.Text = "Ordenar (Quick)";
            this.btnOrdenarQuick.UseVisualStyleBackColor = true;
            this.btnOrdenarQuick.Click += new System.EventHandler(this.btnOrdenarQuick_Click);
            // 
            // blBuscar
            // 
            this.blBuscar.AutoSize = true;
            this.blBuscar.Location = new System.Drawing.Point(33, 170);
            this.blBuscar.Name = "blBuscar";
            this.blBuscar.Size = new System.Drawing.Size(52, 16);
            this.blBuscar.TabIndex = 10;
            this.blBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(92, 170);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(297, 22);
            this.txtBuscar.TabIndex = 11;
            // 
            // btnBuscarSecuencial
            // 
            this.btnBuscarSecuencial.Location = new System.Drawing.Point(33, 198);
            this.btnBuscarSecuencial.Name = "btnBuscarSecuencial";
            this.btnBuscarSecuencial.Size = new System.Drawing.Size(168, 37);
            this.btnBuscarSecuencial.TabIndex = 12;
            this.btnBuscarSecuencial.Text = "Buscar (Secuencial)";
            this.btnBuscarSecuencial.UseVisualStyleBackColor = true;
            this.btnBuscarSecuencial.Click += new System.EventHandler(this.btnBuscarSecuencial_Click);
            // 
            // btnBuscarBinaria
            // 
            this.btnBuscarBinaria.Location = new System.Drawing.Point(221, 198);
            this.btnBuscarBinaria.Name = "btnBuscarBinaria";
            this.btnBuscarBinaria.Size = new System.Drawing.Size(168, 37);
            this.btnBuscarBinaria.TabIndex = 13;
            this.btnBuscarBinaria.Text = "Buscar (Binarial)";
            this.btnBuscarBinaria.UseVisualStyleBackColor = true;
            this.btnBuscarBinaria.Click += new System.EventHandler(this.btnBuscarBinaria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 618);
            this.Controls.Add(this.btnBuscarBinaria);
            this.Controls.Add(this.btnBuscarSecuencial);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.blBuscar);
            this.Controls.Add(this.btnOrdenarQuick);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTiempofin);
            this.Controls.Add(this.lblTiempoini);
            this.Controls.Add(this.btnOrdenarInsertion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrdenarInsertion;
        private System.Windows.Forms.Label lblTiempoini;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Label lblTiempofin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.ListBox lstOrdenada;
        private System.Windows.Forms.Button btnOrdenarQuick;
        private System.Windows.Forms.Label blBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscarSecuencial;
        private System.Windows.Forms.Button btnBuscarBinaria;
    }
}

