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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        string operacion = string.Empty;


        ProductosDA productoDA = new ProductosDA();

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HablitarControles();



        }
        private void HablitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;
            BuscarImagenbutton.Enabled = true;
            Guardarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
            Nuevobutton.Enabled = false;
            Modificarbutton.Enabled=false;



        }
      
        private void DesabilitarHablitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;
            BuscarImagenbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            Nuevobutton.Enabled = true;
            Modificarbutton.Enabled = true;



        }
        private void limpiarControles()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();
            ImagenPictureBox.Image = null;


        }



        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el codigo");
                    CodigoTextBox.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(DescripcionTextBox.Text))
                {
                    errorProvider1.SetError(DescripcionTextBox, "Ingrese una descripcion");
                    CodigoTextBox.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese un precio");
                    CodigoTextBox.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(ExistenciaTextBox.Text))
                {
                    errorProvider1.SetError(ExistenciaTextBox, "Ingrese una existencia");
                    CodigoTextBox.Focus();
                    return;

                }

                Producto producto = new Producto();
                producto.Codigo = CodigoTextBox.Text;
                producto.Descripcion = DescripcionTextBox.Text;
                producto.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                producto.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);
                if (ImagenPictureBox.Image!=null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    ImagenPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    producto.Imagen = ms.GetBuffer();

                }
                

                if (operacion == "Nuevo")
                {

                    bool insertar = productoDA.InsertarProducto(producto);

                    if (insertar)
                    {
                        DesabilitarHablitarControles();
                        limpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto Ingresado");
                    }



                }
                else if (operacion =="Modificar")
                {
                    bool modifico = productoDA.ModificarProducto(producto);
                    if (modifico)
                    {
                        limpiarControles();
                        DesabilitarHablitarControles();
                        ListarProductos();
                        MessageBox.Show("Producto Modificado");
                    }
                }

            }
            catch (Exception)
            {


            }
            






        }

        private void BuscarImagenbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                ImagenPictureBox.Image=Image.FromFile(dialog.FileName);
            }

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();

        }
        private void ListarProductos()
        {
            ProductodataGridView.DataSource = productoDA.ListarProductos();

        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& char.IsControl(e.KeyChar) && (e.KeyChar !='.')   )
            {
                e.Handled = true;

            }
            if ((e.KeyChar=='.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;

            }


        }

        private void ExistenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            


        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (ProductodataGridView.SelectedRows.Count >0)
            {
                CodigoTextBox.Text = ProductodataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripcionTextBox.Text = ProductodataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
               PrecioTextBox.Text = ProductodataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                ExistenciaTextBox.Text = ProductodataGridView.CurrentRow.Cells["Existencia"].Value.ToString();

                var temporal = productoDA.SeleccionarImagen(ProductodataGridView.CurrentRow.Cells["Codigo"].Value.ToString());
                if (temporal.Length >0)
                {
                    System.IO.MemoryStream ms=new System.IO.MemoryStream(temporal);
                    ImagenPictureBox.Image = System.Drawing.Image.FromStream(ms);


                }
                else
                {
                    ImagenPictureBox.Image = null;
                }
                HablitarControles();
                CodigoTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ProductodataGridView.SelectedRows.Count > 0)

            {
                bool elimino = productoDA.EliminarProducto(ProductodataGridView.CurrentRow.Cells["Codigo"].Value.ToString());
                if (elimino)
                {
                    ListarProductos();
                    MessageBox.Show("El producto ha sido eliminado", "Atencion",  MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto", "Atencion",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Atencion",  MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
