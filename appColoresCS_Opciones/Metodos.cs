using System;

using System.Drawing;

using System.Windows.Forms;

namespace appColoresCS_Opciones
{
  public class Metodos
  {
    public static void CambiaColorFondo(Form f,int R , int G, int B)
    {
      f.BackColor = Color.FromArgb(R, G, B);
    }
    public static void CambiaColorFondo(Panel f, int R, int G, int B)
    {
      f.BackColor = Color.FromArgb(R, G, B);
    }
  }
}
