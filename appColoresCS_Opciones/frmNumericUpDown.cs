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
  public partial class frmNumericUpDown : Form
  {
    public frmNumericUpDown()
    {
      InitializeComponent();
    }
    void CambiaColorFondo(object sender, EventArgs e)
    {
      int R = 0;
      int G = 0;
      int B = 0;
      R = (int)numR.Value;
      G = (int)numG.Value;
      B = (int)numB.Value;
      Metodos.CambiaColorFondo(this,R, G, B);
    }
  }
}
