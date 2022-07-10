
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
      this.menuStripMainForm.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStripMainForm
      // 
      this.menuStripMainForm.BackColor = System.Drawing.Color.White;
      this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
      this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
      this.menuStripMainForm.Name = "menuStripMainForm";
      this.menuStripMainForm.Size = new System.Drawing.Size(713, 24);
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ClientSize = new System.Drawing.Size(713, 468);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.hScrollBar1);
      this.Controls.Add(this.picturebox_preview);
      this.Controls.Add(this.menuStripMainForm);
      this.MainMenuStrip = this.menuStripMainForm;
      this.Name = "MainForm";
      this.Text = "preview window";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
      this.menuStripMainForm.ResumeLayout(false);
      this.menuStripMainForm.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).EndInit();
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
  }
}

