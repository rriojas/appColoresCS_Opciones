
namespace appColoresCS_Opciones
{
  partial class frmTabs
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtB = new System.Windows.Forms.TextBox();
      this.txtG = new System.Windows.Forms.TextBox();
      this.txtR = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.panel2 = new System.Windows.Forms.Panel();
      this.numB = new System.Windows.Forms.NumericUpDown();
      this.numG = new System.Windows.Forms.NumericUpDown();
      this.numR = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(695, 483);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.panel1);
      this.tabPage1.Controls.Add(this.txtB);
      this.tabPage1.Controls.Add(this.txtG);
      this.tabPage1.Controls.Add(this.txtR);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(687, 457);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(437, 156);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(111, 110);
      this.panel1.TabIndex = 12;
      // 
      // txtB
      // 
      this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtB.Location = new System.Drawing.Point(271, 236);
      this.txtB.Name = "txtB";
      this.txtB.Size = new System.Drawing.Size(100, 30);
      this.txtB.TabIndex = 11;
      this.txtB.TextChanged += new System.EventHandler(this.CambiaColorFondo1);
      // 
      // txtG
      // 
      this.txtG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtG.Location = new System.Drawing.Point(271, 193);
      this.txtG.Name = "txtG";
      this.txtG.Size = new System.Drawing.Size(100, 30);
      this.txtG.TabIndex = 10;
      this.txtG.TextChanged += new System.EventHandler(this.CambiaColorFondo1);
      // 
      // txtR
      // 
      this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtR.Location = new System.Drawing.Point(271, 156);
      this.txtR.Name = "txtR";
      this.txtR.Size = new System.Drawing.Size(100, 30);
      this.txtR.TabIndex = 9;
      this.txtR.TextChanged += new System.EventHandler(this.CambiaColorFondo1);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(180, 239);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 25);
      this.label3.TabIndex = 8;
      this.label3.Text = "B";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(180, 200);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 25);
      this.label2.TabIndex = 7;
      this.label2.Text = "G";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(180, 159);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "R";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.panel2);
      this.tabPage2.Controls.Add(this.numB);
      this.tabPage2.Controls.Add(this.numG);
      this.tabPage2.Controls.Add(this.numR);
      this.tabPage2.Controls.Add(this.label4);
      this.tabPage2.Controls.Add(this.label5);
      this.tabPage2.Controls.Add(this.label6);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(687, 457);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Location = new System.Drawing.Point(412, 112);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(111, 110);
      this.panel2.TabIndex = 15;
      // 
      // numB
      // 
      this.numB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numB.Location = new System.Drawing.Point(219, 192);
      this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numB.Name = "numB";
      this.numB.Size = new System.Drawing.Size(120, 30);
      this.numB.TabIndex = 14;
      this.numB.ValueChanged += new System.EventHandler(this.CambiaColorFondo2);
      // 
      // numG
      // 
      this.numG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numG.Location = new System.Drawing.Point(219, 153);
      this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numG.Name = "numG";
      this.numG.Size = new System.Drawing.Size(120, 30);
      this.numG.TabIndex = 13;
      this.numG.ValueChanged += new System.EventHandler(this.CambiaColorFondo2);
      // 
      // numR
      // 
      this.numR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numR.Location = new System.Drawing.Point(219, 117);
      this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numR.Name = "numR";
      this.numR.Size = new System.Drawing.Size(120, 30);
      this.numR.TabIndex = 12;
      this.numR.ValueChanged += new System.EventHandler(this.CambiaColorFondo2);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(166, 192);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(25, 25);
      this.label4.TabIndex = 11;
      this.label4.Text = "B";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(166, 153);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(27, 25);
      this.label5.TabIndex = 10;
      this.label5.Text = "G";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(166, 112);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(25, 25);
      this.label6.TabIndex = 9;
      this.label6.Text = "R";
      // 
      // frmTabs
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(695, 481);
      this.Controls.Add(this.tabControl1);
      this.Name = "frmTabs";
      this.Text = "frmTabs";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.TextBox txtG;
    private System.Windows.Forms.TextBox txtR;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numB;
    private System.Windows.Forms.NumericUpDown numG;
    private System.Windows.Forms.NumericUpDown numR;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
  }
}