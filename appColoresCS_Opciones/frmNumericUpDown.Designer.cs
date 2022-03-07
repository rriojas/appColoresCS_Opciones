
namespace appColoresCS_Opciones
{
  partial class frmNumericUpDown
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
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.numR = new System.Windows.Forms.NumericUpDown();
      this.numG = new System.Windows.Forms.NumericUpDown();
      this.numB = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(122, 201);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 25);
      this.label3.TabIndex = 5;
      this.label3.Text = "B";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(122, 162);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 25);
      this.label2.TabIndex = 4;
      this.label2.Text = "G";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(122, 121);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 25);
      this.label1.TabIndex = 3;
      this.label1.Text = "R";
      // 
      // numR
      // 
      this.numR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numR.Location = new System.Drawing.Point(175, 126);
      this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numR.Name = "numR";
      this.numR.Size = new System.Drawing.Size(120, 30);
      this.numR.TabIndex = 6;
      this.numR.ValueChanged += new System.EventHandler(this.CambiaColorFondo);
      // 
      // numG
      // 
      this.numG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numG.Location = new System.Drawing.Point(175, 162);
      this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numG.Name = "numG";
      this.numG.Size = new System.Drawing.Size(120, 30);
      this.numG.TabIndex = 7;
      this.numG.ValueChanged += new System.EventHandler(this.CambiaColorFondo);
      // 
      // numB
      // 
      this.numB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numB.Location = new System.Drawing.Point(175, 201);
      this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numB.Name = "numB";
      this.numB.Size = new System.Drawing.Size(120, 30);
      this.numB.TabIndex = 8;
      this.numB.ValueChanged += new System.EventHandler(this.CambiaColorFondo);
      // 
      // frmNumericUpDown
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.numB);
      this.Controls.Add(this.numG);
      this.Controls.Add(this.numR);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmNumericUpDown";
      this.Text = "frmNumericpDown";
      ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numR;
    private System.Windows.Forms.NumericUpDown numG;
    private System.Windows.Forms.NumericUpDown numB;
  }
}