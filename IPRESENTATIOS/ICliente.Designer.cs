namespace IPRESENTATIOS
{
    partial class ICliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtIdCliente = new TextBox();
            TxtNombres = new TextBox();
            TxtApellidos = new TextBox();
            DTPFechaIngreso = new DateTimePicker();
            CBActivo = new CheckBox();
            DGVCliente = new DataGridView();
            BtnGuardar = new Button();
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, -1);
            label1.Name = "label1";
            label1.Size = new Size(188, 48);
            label1.TabIndex = 0;
            label1.Text = "CLIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 69);
            label2.Name = "label2";
            label2.Size = new Size(32, 25);
            label2.TabIndex = 1;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 110);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 155);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 3;
            label4.Text = "Apellidos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 193);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 4;
            label5.Text = "Fecha de ingreso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 234);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 5;
            label6.Text = "Estado:";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(201, 63);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(405, 31);
            TxtIdCliente.TabIndex = 6;
            // 
            // TxtNombres
            // 
            TxtNombres.Location = new Point(201, 110);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(405, 31);
            TxtNombres.TabIndex = 7;
            // 
            // TxtApellidos
            // 
            TxtApellidos.Location = new Point(201, 155);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new Size(405, 31);
            TxtApellidos.TabIndex = 8;
            // 
            // DTPFechaIngreso
            // 
            DTPFechaIngreso.Location = new Point(201, 193);
            DTPFechaIngreso.Name = "DTPFechaIngreso";
            DTPFechaIngreso.Size = new Size(404, 31);
            DTPFechaIngreso.TabIndex = 9;
            // 
            // CBActivo
            // 
            CBActivo.AutoSize = true;
            CBActivo.Location = new Point(201, 239);
            CBActivo.Name = "CBActivo";
            CBActivo.Size = new Size(88, 29);
            CBActivo.TabIndex = 10;
            CBActivo.Text = "Activo";
            CBActivo.UseVisualStyleBackColor = true;
            // 
            // DGVCliente
            // 
            DGVCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCliente.Location = new Point(7, 279);
            DGVCliente.Name = "DGVCliente";
            DGVCliente.RowHeadersWidth = 62;
            DGVCliente.Size = new Size(803, 254);
            DGVCliente.TabIndex = 11;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(660, 69);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(112, 34);
            BtnGuardar.TabIndex = 12;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(660, 129);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(112, 34);
            BtnActualizar.TabIndex = 13;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(660, 194);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(112, 33);
            BtnEliminar.TabIndex = 14;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // ICliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 530);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnGuardar);
            Controls.Add(DGVCliente);
            Controls.Add(CBActivo);
            Controls.Add(DTPFechaIngreso);
            Controls.Add(TxtApellidos);
            Controls.Add(TxtNombres);
            Controls.Add(TxtIdCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ICliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ICliente";
            ((System.ComponentModel.ISupportInitialize)DGVCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtIdCliente;
        private TextBox TxtNombres;
        private TextBox TxtApellidos;
        private DateTimePicker DTPFechaIngreso;
        private CheckBox CBActivo;
        private DataGridView DGVCliente;
        private Button BtnGuardar;
        private Button BtnActualizar;
        private Button BtnEliminar;
    }
}