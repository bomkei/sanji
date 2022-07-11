
namespace sanji
{
  partial class MainForm
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
      this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.picturebox_preview = new System.Windows.Forms.PictureBox();
      this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
      this.button1 = new System.Windows.Forms.Button();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
      this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
      this.pictureBox_timeline = new System.Windows.Forms.PictureBox();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.menuStripMainForm.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox_timeline)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStripMainForm
      // 
      this.menuStripMainForm.BackColor = System.Drawing.Color.White;
      this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
      this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
      this.menuStripMainForm.Name = "menuStripMainForm";
      this.menuStripMainForm.Size = new System.Drawing.Size(976, 24);
      this.menuStripMainForm.TabIndex = 0;
      this.menuStripMainForm.Text = "menuStrip1";
      // 
      // ファイルFToolStripMenuItem
      // 
      this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
      this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
      this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
      // 
      // 終了ToolStripMenuItem
      // 
      this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
      this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.終了ToolStripMenuItem.Text = "終了";
      // 
      // picturebox_preview
      // 
      this.picturebox_preview.BackColor = System.Drawing.Color.Black;
      this.picturebox_preview.Location = new System.Drawing.Point(0, 24);
      this.picturebox_preview.Name = "picturebox_preview";
      this.picturebox_preview.Size = new System.Drawing.Size(640, 360);
      this.picturebox_preview.TabIndex = 1;
      this.picturebox_preview.TabStop = false;
      // 
      // hScrollBar1
      // 
      this.hScrollBar1.Location = new System.Drawing.Point(0, 384);
      this.hScrollBar1.Name = "hScrollBar1";
      this.hScrollBar1.Size = new System.Drawing.Size(577, 28);
      this.hScrollBar1.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(579, 384);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(60, 28);
      this.button1.TabIndex = 4;
      this.button1.Text = "再生";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
      this.pictureBox2.Location = new System.Drawing.Point(0, 444);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(64, 197);
      this.pictureBox2.TabIndex = 10;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
      this.pictureBox1.Location = new System.Drawing.Point(64, 412);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(887, 32);
      this.pictureBox1.TabIndex = 9;
      this.pictureBox1.TabStop = false;
      // 
      // hScrollBar2
      // 
      this.hScrollBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.hScrollBar2.Location = new System.Drawing.Point(64, 617);
      this.hScrollBar2.Name = "hScrollBar2";
      this.hScrollBar2.Size = new System.Drawing.Size(912, 24);
      this.hScrollBar2.TabIndex = 8;
      // 
      // vScrollBar1
      // 
      this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.vScrollBar1.Location = new System.Drawing.Point(952, 412);
      this.vScrollBar1.Name = "vScrollBar1";
      this.vScrollBar1.Size = new System.Drawing.Size(24, 205);
      this.vScrollBar1.TabIndex = 7;
      // 
      // pictureBox_timeline
      // 
      this.pictureBox_timeline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox_timeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.pictureBox_timeline.Location = new System.Drawing.Point(64, 444);
      this.pictureBox_timeline.Name = "pictureBox_timeline";
      this.pictureBox_timeline.Size = new System.Drawing.Size(887, 173);
      this.pictureBox_timeline.TabIndex = 6;
      this.pictureBox_timeline.TabStop = false;
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(0, 415);
      this.trackBar1.Maximum = 100;
      this.trackBar1.Minimum = 1;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(64, 45);
      this.trackBar1.TabIndex = 11;
      this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trackBar1.Value = 1;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ClientSize = new System.Drawing.Size(976, 641);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.hScrollBar2);
      this.Controls.Add(this.vScrollBar1);
      this.Controls.Add(this.pictureBox_timeline);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.hScrollBar1);
      this.Controls.Add(this.picturebox_preview);
      this.Controls.Add(this.menuStripMainForm);
      this.MainMenuStrip = this.menuStripMainForm;
      this.Name = "MainForm";
      this.Text = "preview window";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
      this.menuStripMainForm.ResumeLayout(false);
      this.menuStripMainForm.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox_timeline)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStripMainForm;
    private System.Windows.Forms.PictureBox picturebox_preview;
    private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    private System.Windows.Forms.HScrollBar hScrollBar1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.HScrollBar hScrollBar2;
    private System.Windows.Forms.VScrollBar vScrollBar1;
    private System.Windows.Forms.TrackBar trackBar1;
    public System.Windows.Forms.PictureBox pictureBox_timeline;
  }
}

