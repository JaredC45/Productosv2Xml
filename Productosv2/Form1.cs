namespace Productosv2
{
    public partial class Form1 : Form
    {
        private List<Producto> productos;
        private GestionProducto gestor;
        public Form1()
        {
            InitializeComponent();
            gestor = new GestionProducto();
            productos = gestor.LeerProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var nombre = txtNombre.Text;
                var precio = decimal.Parse(txtPrecio.Text);
                var cantidad = int.Parse(txtCantidad.Text);


                var productoExistente = productos.FirstOrDefault(p => p.Nombre == nombre && p.Precio == precio);

                if (productoExistente != null)
                {
                    // Si existe, solo aumentar la cantidad
                    productoExistente.Cantidad += cantidad;
                    MessageBox.Show($"La cantidad del producto '{nombre}' ha sido actualizada.");
                }
                else
                {

                    var nuevoProducto = new Producto
                    {
                        Nombre = nombre,
                        Precio = precio,
                        Cantidad = cantidad
                    };
                    productos.Add(nuevoProducto);
                    MessageBox.Show("Producto agregado correctamente.");
                }


                gestor.GuardarProductos(productos);
                LimpiarCampos();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
