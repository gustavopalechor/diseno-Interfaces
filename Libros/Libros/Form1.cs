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

namespace Libros
{
    public partial class misLibros : Form
    {
        public int idLibro = 0;
        public misLibros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void misLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'misLibrosDataSet.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.misLibrosDataSet.libros);
            limpia();


        }
        public void limpia()
        {
            btnAlta.Enabled = true;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            btnCancelar.Visible = false;
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtPaginas.Text = "";
            txtEditorial.Text = "";
            this.librosTableAdapter.Fill(this.misLibrosDataSet.libros);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string paginas = txtPaginas.Text;
            string editorial = txtEditorial.Text;
            int pag = Convert.ToInt32(paginas);

            //Creamos la query
            string sql = "INSERT INTO libros (titulo, autor, paginas, editorial)"+ "VALUES ('" + titulo + "', '" + autor + "', " + pag+ ", '" + editorial + "')";

            //Conexión a la base de datos
            string cadena = "Data Source=LAPTOP-384MOG1E;Initial Catalog=MisLibros; Integrated Security = True";
            //Conexión a la base de dqtos
                SqlConnection con = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            //Ejecutamos
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro ingresado correctamente !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();
            }
            //Limpiamos las cajas de entrada
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtPaginas.Text = "";
            txtEditorial.Text = "";
            idLibro++;

            //Refresca el DataGridView
            this.librosTableAdapter.Fill(this.misLibrosDataSet.libros);
        }
    }
}
