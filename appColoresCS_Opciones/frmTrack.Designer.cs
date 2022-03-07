
namespace appColoresCS_Opciones
{
  partial class frmTrack
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
      this.trkR = new System.Windows.Forms.TrackBar();
      this.trkG = new System.Windows.Forms.TrackBar();
      this.trkB = new System.Windows.Forms.TrackBar();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.trkR)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkG)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkB)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(37, 136);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 25);
      this.label3.TabIndex = 8;
      this.label3.Text = "B";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(37, 77);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 25);
      this.label2.TabIndex = 7;
      this.label2.Text = "G";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(37, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "R";
      // 
      // trkR
      // 
      this.trkR.Location = new System.Drawing.Point(100, 26);
      this.trkR.Maximum = 255;
      this.trkR.Name = "trkR";
      this.trkR.Size = new System.Drawing.Size(329, 45);
      this.trkR.TabIndex = 9;
      this.trkR.Scroll += new System.EventHandler(this.CambiaColorFondo);
      // 
      // trkG
      // 
      this.trkG.Location = new System.Drawing.Point(100, 77);
      this.trkG.Maximum = 255;
      this.trkG.Name = "trkG";
      this.trkG.Size = new System.Drawing.Size(329, 45);
      this.trkG.TabIndex = 10;
      this.trkG.Scroll += new System.EventHandler(this.CambiaColorFondo);
      // 
      // trkB
      // 
      this.trkB.Location = new System.Drawing.Point(100, 123);
      this.trkB.Maximum = 255;
      this.trkB.Name = "trkB";
      this.trkB.Size = new System.Drawing.Size(329, 45);
      this.trkB.TabIndex = 11;
      this.trkB.Scroll += new System.EventHandler(this.CambiaColorFondo);
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(546, 111);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(131, 135);
      this.panel1.TabIndex = 12;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.trkB);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.trkG);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.trkR);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(52, 90);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(479, 184);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "El Titulo";
      // 
      // frmTrack
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.Name = "frmTrack";
      this.Text = "frmTrack";
      ((System.ComponentModel.ISupportInitialize)(this.trkR)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkG)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkB)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TrackBar trkR;
    private System.Windows.Forms.TrackBar trkG;
    private System.Windows.Forms.TrackBar trkB;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}