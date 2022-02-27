
namespace sanji
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.picturebox_preview = new System.Windows.Forms.PictureBox();
      this.picturebox_timeline = new System.Windows.Forms.PictureBox();
      this.picturebox_player_scrollbar = new System.Windows.Forms.PictureBox();
      this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxMenuStrip_timeline = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ctxMenuStrip_tl_item = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.テキストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_timeline)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_player_scrollbar)).BeginInit();
      this.ctxMenuStrip_timeline.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.White;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // picturebox_preview
      // 
      this.picturebox_preview.Location = new System.Drawing.Point(0, 24);
      this.picturebox_preview.Name = "picturebox_preview";
      this.picturebox_preview.Size = new System.Drawing.Size(640, 360);
      this.picturebox_preview.TabIndex = 1;
      this.picturebox_preview.TabStop = false;
      // 
      // picturebox_timeline
      // 
      this.picturebox_timeline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.picturebox_timeline.Location = new System.Drawing.Point(0, 413);
      this.picturebox_timeline.Name = "picturebox_timeline";
      this.picturebox_timeline.Size = new System.Drawing.Size(1014, 175);
      this.picturebox_timeline.TabIndex = 2;
      this.picturebox_timeline.TabStop = false;
      // 
      // picturebox_player_scrollbar
      // 
      this.picturebox_player_scrollbar.Location = new System.Drawing.Point(0, 384);
      this.picturebox_player_scrollbar.Name = "picturebox_player_scrollbar";
      this.picturebox_player_scrollbar.Size = new System.Drawing.Size(640, 29);
      this.picturebox_player_scrollbar.TabIndex = 3;
      this.picturebox_player_scrollbar.TabStop = false;
      // 
      // ファイルFToolStripMenuItem
      // 
      this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
      this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
      // 
      // ctxMenuStrip_timeline
      // 
      this.ctxMenuStrip_timeline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加ToolStripMenuItem});
      this.ctxMenuStrip_timeline.Name = "ctxMenuStrip_timeline";
      this.ctxMenuStrip_timeline.Size = new System.Drawing.Size(181, 48);
      // 
      // ctxMenuStrip_tl_item
      // 
      this.ctxMenuStrip_tl_item.Name = "ctxMenuStrip_tl_item";
      this.ctxMenuStrip_tl_item.Size = new System.Drawing.Size(61, 4);
      // 
      // 追加ToolStripMenuItem
      // 
      this.追加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テキストToolStripMenuItem});
      this.追加ToolStripMenuItem.Name = "追加ToolStripMenuItem";
      this.追加ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.追加ToolStripMenuItem.Text = "アイテムを追加";
      // 
      // テキストToolStripMenuItem
      // 
      this.テキストToolStripMenuItem.Name = "テキストToolStripMenuItem";
      this.テキストToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.テキストToolStripMenuItem.Text = "テキスト";
      this.テキストToolStripMenuItem.Click += new System.EventHandler(this.テキストToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1014, 588);
      this.Controls.Add(this.picturebox_player_scrollbar);
      this.Controls.Add(this.picturebox_timeline);
      this.Controls.Add(this.picturebox_preview);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_timeline)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_player_scrollbar)).EndInit();
      this.ctxMenuStrip_timeline.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.PictureBox picturebox_preview;
    private System.Windows.Forms.PictureBox picturebox_timeline;
    private System.Windows.Forms.PictureBox picturebox_player_scrollbar;
    private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip ctxMenuStrip_timeline;
    private System.Windows.Forms.ToolStripMenuItem 追加ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem テキストToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip ctxMenuStrip_tl_item;
  }
}

