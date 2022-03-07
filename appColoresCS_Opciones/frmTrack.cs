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
  public partial class frmTrack : Form
  {
    public frmTrack()
    {
      InitializeComponent();
    }
    void CambiaColorFondo(object sender, EventArgs e)
    {
      int R = 0;
      int G = 0;
      int B = 0;
      R = (int)trkR.Value;
      G = (int)trkG.Value;
      B = (int)trkB.Value;
      Metodos.CambiaColorFondo(panel1, R, G, B);
    }
  }
}
