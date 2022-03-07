using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appColoresCS_Opciones
{
  public partial class frmLogin : Form
  {
    frmMenu m;
    MySqlConnection cnx;
    public frmLogin(frmMenu menu)
    {
      InitializeComponent();
      m = menu;
      string cadena = "server=localhost;user=root;database=bd1;port=3306;password=";
      cnx = new MySqlConnection(cadena);

    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      cnx.Open();
      string sql = "SELECT idUsuario FROM usuario WHERE estatus=1 and usr='"+ txtUsuario.Text + "' and pwd=sha1('" + txtClave.Text + "');";
      MySqlCommand cmd = new MySqlCommand(sql, cnx);
      object result = cmd.ExecuteScalar();
      if (result != null)
      {
        m.Opacity = 1;
        m.ShowInTaskbar = true;
        this.Close();
      }
      else
      {
        MessageBox.Show("ERROR");
      }
      cnx.Close();
    }
  }
}
