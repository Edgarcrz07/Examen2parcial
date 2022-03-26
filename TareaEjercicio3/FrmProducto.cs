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
            BuscarImagenbutton.Image = null;


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

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ImagenPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                producto.Imagen = ms.GetBuffer();

                if (operacion == "Nuevo")
                {

                    bool inserto = productoDA.InsertarProducto(producto);
                    
                        DesabilitarHablitarControles();
                        limpiarControles();
                        MessageBox.Show("Producto Ingresado");
                    


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
    }
}
