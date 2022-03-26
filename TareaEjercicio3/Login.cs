using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;
using MySql.Data.MySqlClient;

namespace TareaEjercicio3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection(" server=localhost;Database=Ejercicio3; Uid=root;Pwd=madrid12;");
        DataSet ds;

        private void aceptarbutton_Click(object sender, EventArgs e)
        {

            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(usuariotextBox.Text, clavetextBox.Text);


            if (usuario == null)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta");
            }
            else
            {
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show();
                this.Hide();
            } 
            


        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        
        }

        private void mostrarbutton_Click(object sender, EventArgs e)
        {
          
            conn.Open();
            MySqlCommand mostrar = new MySqlCommand("SELECT * FROM usuario", conn);

            MySqlDataAdapter m_datos = new MySqlDataAdapter(mostrar);
            ds = new DataSet();
            m_datos.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();



        }
    }
}
