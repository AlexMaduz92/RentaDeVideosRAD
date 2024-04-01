namespace IPRESENTATIOS
{
    partial class IRenta
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
            DTPFechaRenta = new DateTimePicker();
            DTPFechaRetorno = new DateTimePicker();
            TxtCantidad = new TextBox();
            TxtPrecio = new TextBox();
            BtnRentar = new Button();
            DGVRenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVRenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 48);
            label1.TabIndex = 0;
            label1.Text = "RENTA DE VIDEOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 74);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 111);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 2;
            label3.Text = "Codigo Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 150);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 3;
            label4.Text = "Codigo de pelicula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 190);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 4;
            label5.Text = "Fecha renta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 236);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Fecha retorno:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 277);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 6;
            label7.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 319);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 7;
            label8.Text = "Precio Renta:";
            // 
            // TxtIdRenta
            // 
            TxtIdRenta.Location = new Point(205, 74);
            TxtIdRenta.Name = "TxtIdRenta";
            TxtIdRenta.Size = new Size(352, 31);
            TxtIdRenta.TabIndex = 8;
            // 
            // TxtClienteId
            // 
            TxtClienteId.Location = new Point(205, 111);
            TxtClienteId.Name = "TxtClienteId";
            TxtClienteId.Size = new Size(352, 31);
            TxtClienteId.TabIndex = 9;
            // 
            // TxtPeliculaId
            // 
            TxtPeliculaId.Location = new Point(205, 147);
            TxtPeliculaId.Name = "TxtPeliculaId";
            TxtPeliculaId.Size = new Size(352, 31);
            TxtPeliculaId.TabIndex = 10;
            // 
            // DTPFechaRenta
            // 
            DTPFechaRenta.Location = new Point(205, 190);
            DTPFechaRenta.Name = "DTPFechaRenta";
            DTPFechaRenta.Size = new Size(352, 31);
            DTPFechaRenta.TabIndex = 11;
            // 
            // DTPFechaRetorno
            // 
            DTPFechaRetorno.Location = new Point(205, 236);
            DTPFechaRetorno.Name = "DTPFechaRetorno";
            DTPFechaRetorno.Size = new Size(352, 31);
            DTPFechaRetorno.TabIndex = 12;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(205, 277);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(352, 31);
            TxtCantidad.TabIndex = 13;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(205, 319);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(352, 31);
            TxtPrecio.TabIndex = 14;
            // 
            // BtnRentar
            // 
            BtnRentar.Location = new Point(663, 319);
            BtnRentar.Name = "BtnRentar";
            BtnRentar.Size = new Size(112, 34);
            BtnRentar.TabIndex = 15;
            BtnRentar.Text = "Rentar";
            BtnRentar.UseVisualStyleBackColor = true;
            // 
            // DGVRenta
            // 
            DGVRenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRenta.Location = new Point(21, 388);
            DGVRenta.Name = "DGVRenta";
            DGVRenta.RowHeadersWidth = 62;
            DGVRenta.Size = new Size(1404, 316);
            DGVRenta.TabIndex = 16;
            // 
            // IRenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 716);
            Controls.Add(DGVRenta);
            Controls.Add(BtnRentar);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtCantidad);
            Controls.Add(DTPFechaRetorno);
            Controls.Add(DTPFechaRenta);
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
            Name = "IRenta";
            Text = "Form1";
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
        private DateTimePicker DTPFechaRenta;
        private DateTimePicker DTPFechaRetorno;
        private TextBox TxtCantidad;
        private TextBox TxtPrecio;
        private Button BtnRentar;
        private DataGridView DGVRenta;
    }
}