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
  public partial class frmTabs : Form
  {
    public frmTabs()
    {
      InitializeComponent();
    }
    void CambiaColorFondo1(object sender, EventArgs e)
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
      Metodos.CambiaColorFondo(panel1, R, G, B);
    }
    void CambiaColorFondo2(object sender, EventArgs e)
    {
      int R = 0;
      int G = 0;
      int B = 0;
      R = (int)numR.Value;
      G = (int)numG.Value;
      B = (int)numB.Value;
      Metodos.CambiaColorFondo(panel2, R, G, B);
    }

   
  }
}
