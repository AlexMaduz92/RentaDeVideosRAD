namespace IPRESENTATIOS
{
    partial class IPRENTA
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
            label7 = new Label();
            label8 = new Label();
            TxtIdRenta = new TextBox();
            TxtClienteId = new TextBox();
            TxtPeliculaId = new TextBox();
            DTPFRenta = new DateTimePicker();
            DTPFRetorno = new DateTimePicker();
            TxtCantidad = new TextBox();
            TxtPrecio = new TextBox();
            DGVRenta = new DataGridView();
            BtnRentar = new Button();
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVRenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "RENTA DE VIDEOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(32, 25);
            label2.TabIndex = 1;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 2;
            label3.Text = "Codigo cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 3;
            label4.Text = "Codigo pelicula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 4;
            label5.Text = "Fecha de renta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 237);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 5;
            label6.Text = "Fecha de retorno:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 276);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 6;
            label7.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 321);
            label8.Name = "label8";
            label8.Size = new Size(64, 25);
            label8.TabIndex = 7;
            label8.Text = "Precio:";
            // 
            // TxtIdRenta
            // 
            TxtIdRenta.Location = new Point(224, 53);
            TxtIdRenta.Name = "TxtIdRenta";
            TxtIdRenta.Size = new Size(352, 31);
            TxtIdRenta.TabIndex = 8;
            // 
            // TxtClienteId
            // 
            TxtClienteId.Location = new Point(224, 102);
            TxtClienteId.Name = "TxtClienteId";
            TxtClienteId.Size = new Size(352, 31);
            TxtClienteId.TabIndex = 9;
            // 
            // TxtPeliculaId
            // 
            TxtPeliculaId.Location = new Point(224, 152);
            TxtPeliculaId.Name = "TxtPeliculaId";
            TxtPeliculaId.Size = new Size(352, 31);
            TxtPeliculaId.TabIndex = 10;
            // 
            // DTPFRenta
            // 
            DTPFRenta.Location = new Point(224, 197);
            DTPFRenta.Name = "DTPFRenta";
            DTPFRenta.Size = new Size(352, 31);
            DTPFRenta.TabIndex = 11;
            // 
            // DTPFRetorno
            // 
            DTPFRetorno.Location = new Point(224, 237);
            DTPFRetorno.Name = "DTPFRetorno";
            DTPFRetorno.Size = new Size(352, 31);
            DTPFRetorno.TabIndex = 12;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(224, 276);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(352, 31);
            TxtCantidad.TabIndex = 13;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(224, 315);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(352, 31);
            TxtPrecio.TabIndex = 14;
            // 
            // DGVRenta
            // 
            DGVRenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRenta.Location = new Point(12, 390);
            DGVRenta.Name = "DGVRenta";
            DGVRenta.RowHeadersWidth = 62;
            DGVRenta.Size = new Size(942, 225);
            DGVRenta.TabIndex = 15;
            // 
            // BtnRentar
            // 
            BtnRentar.Location = new Point(598, 321);
            BtnRentar.Name = "BtnRentar";
            BtnRentar.Size = new Size(112, 34);
            BtnRentar.TabIndex = 16;
            BtnRentar.Text = "Rentar";
            BtnRentar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(722, 321);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(112, 34);
            BtnActualizar.TabIndex = 17;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(842, 321);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(112, 34);
            BtnEliminar.TabIndex = 18;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // IPRENTA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 634);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnRentar);
            Controls.Add(DGVRenta);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtCantidad);
            Controls.Add(DTPFRetorno);
            Controls.Add(DTPFRenta);
            Controls.Add(TxtPeliculaId);
            Controls.Add(TxtClienteId);
            Controls.Add(TxtIdRenta);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IPRENTA";
            Text = "IPRENTA";
            Load += IPRENTA_Load;
            ((System.ComponentModel.ISupportInitialize)DGVRenta).EndInit();
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
        private Label label7;
        private Label label8;
        private TextBox TxtIdRenta;
        private TextBox TxtClienteId;
        private TextBox TxtPeliculaId;
        private DateTimePicker DTPFRenta;
        private DateTimePicker DTPFRetorno;
        private TextBox TxtCantidad;
        private TextBox TxtPrecio;
        private DataGridView DGVRenta;
        private Button BtnRentar;
        private Button BtnActualizar;
        private Button BtnEliminar;
    }
}