
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
      this.components = new System.ComponentModel.Container();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.picturebox_preview = new System.Windows.Forms.PictureBox();
      this.picturebox_timeline = new System.Windows.Forms.PictureBox();
      this.ctxMenuStrip_timeline = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.テキストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxMenuStrip_tl_item = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.カットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
      this.button1 = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_timeline)).BeginInit();
      this.ctxMenuStrip_timeline.SuspendLayout();
      this.ctxMenuStrip_tl_item.SuspendLayout();
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
      // ファイルFToolStripMenuItem
      // 
      this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem,
            this.終了ToolStripMenuItem});
      this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
      this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
      // 
      // 設定ToolStripMenuItem
      // 
      this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
      this.設定ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.設定ToolStripMenuItem.Text = "設定";
      // 
      // 終了ToolStripMenuItem
      // 
      this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
      this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.終了ToolStripMenuItem.Text = "終了";
      this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
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
      // ctxMenuStrip_timeline
      // 
      this.ctxMenuStrip_timeline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加ToolStripMenuItem});
      this.ctxMenuStrip_timeline.Name = "ctxMenuStrip_timeline";
      this.ctxMenuStrip_timeline.Size = new System.Drawing.Size(144, 26);
      // 
      // 追加ToolStripMenuItem
      // 
      this.追加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テキストToolStripMenuItem});
      this.追加ToolStripMenuItem.Name = "追加ToolStripMenuItem";
      this.追加ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.追加ToolStripMenuItem.Text = "アイテムを追加";
      // 
      // テキストToolStripMenuItem
      // 
      this.テキストToolStripMenuItem.Name = "テキストToolStripMenuItem";
      this.テキストToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
      this.テキストToolStripMenuItem.Text = "テキスト";
      this.テキストToolStripMenuItem.Click += new System.EventHandler(this.テキストToolStripMenuItem_Click);
      // 
      // ctxMenuStrip_tl_item
      // 
      this.ctxMenuStrip_tl_item.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集ToolStripMenuItem});
      this.ctxMenuStrip_tl_item.Name = "ctxMenuStrip_tl_item";
      this.ctxMenuStrip_tl_item.Size = new System.Drawing.Size(99, 26);
      // 
      // 編集ToolStripMenuItem
      // 
      this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.カットToolStripMenuItem});
      this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
      this.編集ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.編集ToolStripMenuItem.Text = "編集";
      // 
      // カットToolStripMenuItem
      // 
      this.カットToolStripMenuItem.Name = "カットToolStripMenuItem";
      this.カットToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
      this.カットToolStripMenuItem.Text = "カット";
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
      this.ClientSize = new System.Drawing.Size(1014, 588);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.hScrollBar1);
      this.Controls.Add(this.picturebox_timeline);
      this.Controls.Add(this.picturebox_preview);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picturebox_timeline)).EndInit();
      this.ctxMenuStrip_timeline.ResumeLayout(false);
      this.ctxMenuStrip_tl_item.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.PictureBox picturebox_preview;
    private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 追加ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem テキストToolStripMenuItem;
    public System.Windows.Forms.ContextMenuStrip ctxMenuStrip_timeline;
    public System.Windows.Forms.ContextMenuStrip ctxMenuStrip_tl_item;
    public System.Windows.Forms.PictureBox picturebox_timeline;
    private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem カットToolStripMenuItem;
    private System.Windows.Forms.HScrollBar hScrollBar1;
    private System.Windows.Forms.Button button1;
  }
}

