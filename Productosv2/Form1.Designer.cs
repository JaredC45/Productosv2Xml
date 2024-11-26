namespace Productosv2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            btnAgregar = new Button();
            btnMostrar = new Button();
            btnVender = new Button();
            listBoxProductos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 205);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(184, 263);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(184, 333);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Snow;
            btnAgregar.Location = new Point(24, 67);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 40);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Snow;
            btnMostrar.Location = new Point(151, 67);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(102, 40);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.Snow;
            btnVender.Location = new Point(280, 67);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(99, 40);
            btnVender.TabIndex = 5;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // listBoxProductos
            // 
            listBoxProductos.BackColor = Color.Snow;
            listBoxProductos.FormattingEnabled = true;
            listBoxProductos.Location = new Point(652, 275);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(370, 344);
            listBoxProductos.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(47, 205);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 7;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Snow;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(47, 263);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Snow;
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(47, 333);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 9;
            label3.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImage = Properties.Resources.pngtree_supermarket_aisle_interior_blurred_background_image_15664460;
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(listBoxProductos);
            groupBox1.Location = new Point(-3, -4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1124, 685);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.download_removebg_preview__3_;
            pictureBox5.Location = new Point(122, 263);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 591);
            label6.Name = "label6";
            label6.Size = new Size(262, 17);
            label6.TabIndex = 16;
            label6.Text = "Proyecto hecho por: Giovannni y Jared";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.download_removebg_preview__2_;
            pictureBox4.Location = new Point(122, 187);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.images_removebg_preview__2_;
            pictureBox3.Location = new Point(856, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnMostrar);
            groupBox2.Controls.Add(btnVender);
            groupBox2.Location = new Point(47, 439);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(538, 125);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.images_removebg_preview__1_;
            pictureBox2.Location = new Point(310, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Snow;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(471, 58);
            label4.Name = "label4";
            label4.Size = new Size(304, 35);
            label4.TabIndex = 0;
            label4.Text = "Supermercado Express";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Snow;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(752, 216);
            label5.Name = "label5";
            label5.Size = new Size(167, 23);
            label5.TabIndex = 12;
            label5.Text = "Lista de Productos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 673);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Button btnAgregar;
        private Button btnMostrar;
        private Button btnVender;
        private ListBox listBoxProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private GroupBox groupBox2;
        private Label label6;
    }
}
