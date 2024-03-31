namespace IPRESENTATIOS
{
    partial class IPelicula
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
            PELICULAS = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            DGVVista = new DataGridView();
            TxtId = new TextBox();
            TxtNombre = new TextBox();
            CbGenero = new ComboBox();
            TxtAutores = new TextBox();
            TxtExsitencia = new TextBox();
            TxtPrecioRenta = new TextBox();
            CHBEstado = new CheckBox();
            label8 = new Label();
            BtnGuardar = new Button();
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVVista).BeginInit();
            SuspendLayout();
            // 
            // PELICULAS
            // 
            PELICULAS.AutoSize = true;
            PELICULAS.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PELICULAS.Location = new Point(524, -6);
            PELICULAS.Name = "PELICULAS";
            PELICULAS.Size = new Size(190, 45);
            PELICULAS.TabIndex = 0;
            PELICULAS.Text = "PELICULAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 3;
            label3.Text = "Genero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 4;
            label4.Text = "Autores:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 232);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 5;
            label5.Text = "Existencia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 283);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 6;
            label6.Text = "PrecioRenta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 327);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 7;
            label7.Text = "Estado:";
            // 
            // DGVVista
            // 
            DGVVista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVVista.Location = new Point(12, 365);
            DGVVista.Name = "DGVVista";
            DGVVista.RowHeadersWidth = 62;
            DGVVista.Size = new Size(1109, 248);
            DGVVista.TabIndex = 8;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(140, 48);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(150, 31);
            TxtId.TabIndex = 9;
            TxtId.Enabled = false;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(140, 89);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(150, 31);
            TxtNombre.TabIndex = 10;
            // 
            // CbGenero
            // 
            CbGenero.Location = new Point(138, 134);
            CbGenero.Name = "CbGenero";
            CbGenero.Size = new Size(182, 33);
            CbGenero.TabIndex = 11;
            // 
            // TxtAutores
            // 
            TxtAutores.Location = new Point(138, 183);
            TxtAutores.Name = "TxtAutores";
            TxtAutores.Size = new Size(150, 31);
            TxtAutores.TabIndex = 12;
            // 
            // TxtExsitencia
            // 
            TxtExsitencia.Location = new Point(138, 229);
            TxtExsitencia.Name = "TxtExsitencia";
            TxtExsitencia.Size = new Size(150, 31);
            TxtExsitencia.TabIndex = 13;
            // 
            // TxtPrecioRenta
            // 
            TxtPrecioRenta.Location = new Point(140, 283);
            TxtPrecioRenta.Name = "TxtPrecioRenta";
            TxtPrecioRenta.Size = new Size(150, 31);
            TxtPrecioRenta.TabIndex = 14;
            // 
            // CHBEstado
            // 
            CHBEstado.AutoSize = true;
            CHBEstado.Location = new Point(142, 330);
            CHBEstado.Name = "CHBEstado";
            CHBEstado.Size = new Size(88, 29);
            CHBEstado.TabIndex = 15;
            CHBEstado.Text = "Activo";
            CHBEstado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(337, 317);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 16;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(450, 322);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(112, 34);
            BtnGuardar.TabIndex = 17;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(602, 322);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(112, 34);
            BtnActualizar.TabIndex = 18;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(765, 322);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(112, 34);
            BtnEliminar.TabIndex = 19;
            BtnEliminar.Text = "Elimianar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // IPelicula
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 625);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnGuardar);
            Controls.Add(label8);
            Controls.Add(CHBEstado);
            Controls.Add(TxtPrecioRenta);
            Controls.Add(TxtExsitencia);
            Controls.Add(TxtAutores);
            Controls.Add(CbGenero);
            Controls.Add(TxtNombre);
            Controls.Add(TxtId);
            Controls.Add(DGVVista);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PELICULAS);
            Name = "IPelicula";
            Text = "Pelicula";
            ((System.ComponentModel.ISupportInitialize)DGVVista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PELICULAS;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView DGVVista;
        private TextBox TxtId;
        private TextBox TxtNombre;
        private ComboBox CbGenero;
        private TextBox TxtAutores;
        private TextBox TxtExsitencia;
        private TextBox TxtPrecioRenta;
        private CheckBox CHBEstado;
        private Label label8;
        private Button BtnGuardar;
        private Button BtnActualizar;
        private Button BtnEliminar;
    }
}