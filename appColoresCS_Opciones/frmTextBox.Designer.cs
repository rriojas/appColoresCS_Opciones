
namespace appColoresCS_Opciones
{
  partial class frmTextBox
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtR = new System.Windows.Forms.TextBox();
      this.txtG = new System.Windows.Forms.TextBox();
      this.txtB = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(63, 104);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "R";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(63, 145);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "G";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(63, 184);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 25);
      this.label3.TabIndex = 2;
      this.label3.Text = "B";
      // 
      // txtR
      // 
      this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtR.Location = new System.Drawing.Point(154, 101);
      this.txtR.Name = "txtR";
      this.txtR.Size = new System.Drawing.Size(100, 30);
      this.txtR.TabIndex = 3;
      this.txtR.TextChanged += new System.EventHandler(this.CambiaColorFondo);
      // 
      // txtG
      // 
      this.txtG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtG.Location = new System.Drawing.Point(154, 138);
      this.txtG.Name = "txtG";
      this.txtG.Size = new System.Drawing.Size(100, 30);
      this.txtG.TabIndex = 4;
      this.txtG.TextChanged += new System.EventHandler(this.CambiaColorFondo);
      // 
      // txtB
      // 
      this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtB.Location = new System.Drawing.Point(154, 181);
      this.txtB.Name = "txtB";
      this.txtB.Size = new System.Drawing.Size(100, 30);
      this.txtB.TabIndex = 5;
      this.txtB.TextChanged += new System.EventHandler(this.CambiaColorFondo);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.txtB);
      this.Controls.Add(this.txtG);
      this.Controls.Add(this.txtR);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtR;
    private System.Windows.Forms.TextBox txtG;
    private System.Windows.Forms.TextBox txtB;
  }
}

