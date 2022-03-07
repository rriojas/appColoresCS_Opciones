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
  public partial class frmMenu : Form
  {
    public frmMenu()
    {
      InitializeComponent();
      this.Opacity = 0;
      this.ShowInTaskbar = false;
      frmLogin f = new frmLogin(this);
      f.WindowState = FormWindowState.Maximized;
      f.ShowDialog();
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void cajasDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmTextBox f = new frmTextBox();
      f.MdiParent = this;
      f.WindowState = FormWindowState.Maximized;
      f.Show();
    }

    private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmNumericUpDown f = new frmNumericUpDown();
      f.MdiParent = this;
      f.WindowState = FormWindowState.Maximized;
      f.Show();
    }

    private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmTrack f = new frmTrack();
      f.MdiParent = this;
      f.WindowState = FormWindowState.Maximized;
      f.Show();
    }

    private void tabToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmTabs f = new frmTabs();
      f.MdiParent = this;
      f.WindowState = FormWindowState.Maximized;
      f.Show();

    }
  }
}
