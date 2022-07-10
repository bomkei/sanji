namespace sanji {
  partial class TimelineForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
      this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox
      // 
      this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.pictureBox.Location = new System.Drawing.Point(64, 32);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(640, 240);
      this.pictureBox.TabIndex = 0;
      this.pictureBox.TabStop = false;
      // 
      // vScrollBar1
      // 
      this.vScrollBar1.Location = new System.Drawing.Point(705, 0);
      this.vScrollBar1.Name = "vScrollBar1";
      this.vScrollBar1.Size = new System.Drawing.Size(24, 272);
      this.vScrollBar1.TabIndex = 1;
      // 
      // hScrollBar1
      // 
      this.hScrollBar1.Location = new System.Drawing.Point(64, 272);
      this.hScrollBar1.Name = "hScrollBar1";
      this.hScrollBar1.Size = new System.Drawing.Size(665, 24);
      this.hScrollBar1.TabIndex = 2;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
      this.pictureBox1.Location = new System.Drawing.Point(64, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(640, 32);
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
      this.pictureBox2.Location = new System.Drawing.Point(0, 32);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(64, 264);
      this.pictureBox2.TabIndex = 4;
      this.pictureBox2.TabStop = false;
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(0, 4);
      this.trackBar1.Maximum = 100;
      this.trackBar1.Minimum = 1;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(64, 45);
      this.trackBar1.TabIndex = 5;
      this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trackBar1.Value = 1;
      // 
      // TimelineForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ClientSize = new System.Drawing.Size(729, 296);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.hScrollBar1);
      this.Controls.Add(this.vScrollBar1);
      this.Controls.Add(this.pictureBox);
      this.Controls.Add(this.trackBar1);
      this.Name = "TimelineForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "TimelineForm";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.VScrollBar vScrollBar1;
    private System.Windows.Forms.HScrollBar hScrollBar1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.TrackBar trackBar1;
  }
}