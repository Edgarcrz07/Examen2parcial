using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaEjercicio3
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        ProductosDA productoDA = new ProductosDA();
     
        Pedidos factura = new Pedidos();
        Producto producto;


        List<DetallePedidos>detallePedidosLista= new List<DetallePedidos>();
        decimal subTotal = decimal.Zero;
            decimal isv=decimal.Zero;
        decimal totalApagar=decimal.Zero;

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            DetalledataGridView.DataSource = detallePedidosLista;
        }

        private void CodigoProductotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                producto=new Producto();
                producto = productoDA.GetProductoPorCodigo(CodigoProductotextBox.Text);
                DescripcionProductotextBox.Text = producto.Descripcion;
                CantidadtextBox.Focus();


            }
            else
            {
                producto = null;
                DescripcionProductotextBox.Clear();
                CantidadtextBox.Clear();

            }

        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadtextBox.Text) )
            {
              DetallePedidos detallePedidos = new DetallePedidos();
                detallePedidos.CodigoProducto = producto.Codigo;
                detallePedidos.Descripcion = producto.Descripcion;
                detallePedidos.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
                detallePedidos.Precio=producto.Precio;
                detallePedidos.Total= producto.Precio * Convert.ToInt32(CantidadtextBox.Text);

                subTotal += detallePedidos.Total;
                isv = subTotal * 0.15M;
                totalApagar = subTotal + isv;
               
                detallePedidosLista.Add(detallePedidos);
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = detallePedidosLista;




            }
            

        }
    }
}
