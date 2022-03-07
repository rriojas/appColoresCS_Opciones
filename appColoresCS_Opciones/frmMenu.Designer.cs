
namespace appColoresCS_Opciones
{
  partial class frmMenu
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cajasDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.trackBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.MdiWindowListItem = this.opcionesToolStripMenuItem;
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // archivoToolStripMenuItem
      // 
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
      this.archivoToolStripMenuItem.Text = "Archivo";
      // 
      // salirToolStripMenuItem
      // 
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.salirToolStripMenuItem.Text = "Salir";
      this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
      // 
      // opcionesToolStripMenuItem
      // 
      this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajasDeTextoToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.trackBarToolStripMenuItem,
            this.tabToolStripMenuItem});
      this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
      this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
      this.opcionesToolStripMenuItem.Text = "Opciones";
      // 
      // cajasDeTextoToolStripMenuItem
      // 
      this.cajasDeTextoToolStripMenuItem.Name = "cajasDeTextoToolStripMenuItem";
      this.cajasDeTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.cajasDeTextoToolStripMenuItem.Text = "Cajas de Texto";
      this.cajasDeTextoToolStripMenuItem.Click += new System.EventHandler(this.cajasDeTextoToolStripMenuItem_Click);
      // 
      // numericUpDownToolStripMenuItem
      // 
      this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
      this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.numericUpDownToolStripMenuItem.Text = "Numeric Up Down";
      this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
      // 
      // trackBarToolStripMenuItem
      // 
      this.trackBarToolStripMenuItem.Name = "trackBarToolStripMenuItem";
      this.trackBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.trackBarToolStripMenuItem.Text = "TrackBar";
      this.trackBarToolStripMenuItem.Click += new System.EventHandler(this.trackBarToolStripMenuItem_Click);
      // 
      // tabToolStripMenuItem
      // 
      this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
      this.tabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.tabToolStripMenuItem.Text = "Tab";
      this.tabToolStripMenuItem.Click += new System.EventHandler(this.tabToolStripMenuItem_Click);
      // 
      // frmMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmMenu";
      this.Text = "frmMenu";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cajasDeTextoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem trackBarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
  }
}