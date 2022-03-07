using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appColoresCS_Opciones
{
  public partial class frmTextBox : Form
  {
    public frmTextBox()
    {
      InitializeComponent();
    }
    void CambiaColorFondo(object sender, EventArgs e)
    {
      int R = 0;
      if (txtR.Text != "")
      {
        R = int.Parse(txtR.Text);
      }
      int G = 0;
      if (txtG.Text != "")
      {
        G = int.Parse(txtG.Text);
      }
      int B = 0;
      if (txtB.Text != "")
      {
        B = int.Parse(txtB.Text);
      }
      Metodos.CambiaColorFondo(this, R, G, B);
    }
    

  }
}
