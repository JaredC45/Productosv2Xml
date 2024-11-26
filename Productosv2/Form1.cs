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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listBoxProductos.Items.Clear();

            if (productos.Count == 0)
            {
                MessageBox.Show("Aún no se han agregado productos.");
                return; // Salir del método si no hay productos
            }

            foreach (var producto in productos)
            {
                listBoxProductos.Items.Add($"{producto.Nombre} - Precio: {producto.Precio:C} - Cantidad: {producto.Cantidad}");
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Favor Complete las casillas para vender un producto.");
                return;
            }

            var nombre = txtNombre.Text;
            var productoExistente = productos.FirstOrDefault(p => p.Nombre == nombre);

            if (productoExistente != null)
            {
                if (productoExistente.Cantidad >= cantidad)
                {
                    productoExistente.Cantidad -= cantidad;
                    MessageBox.Show($"Se han vendido {cantidad} unidades del producto '{nombre}'.");


                    if (productoExistente.Cantidad == 0)
                    {
                        productos.Remove(productoExistente);
                        MessageBox.Show($"El producto '{nombre}' ha sido eliminado de la lista.");
                    }
                }
                else
                {
                    MessageBox.Show($"No hay suficiente cantidad del producto '{nombre}' para vender.");
                }
            }
            else
            {
                MessageBox.Show($"El producto '{nombre}' no existe en la lista.");
            }


            gestor.GuardarProductos(productos);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.");
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero positivo.");
                return false;
            }

            return true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
