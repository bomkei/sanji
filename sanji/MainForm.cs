using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanji {
  public partial class MainForm : Form {

    enum WindowMode {
      One,
      Multi,
    }

    class AppContext {
      public WindowMode windowMode;


      public AppContext() {
        // デバッグ用コンストラクタ
        // リリースでは使わない

        windowMode = WindowMode.Multi;


      }
    }

    TimelineForm timelineForm;
    AppContext appCtx;

    public MainForm() {
      Debugs.Alert();

      timelineForm = new TimelineForm();

      InitializeComponent();

    }

    void InitWindow() {
      var ctx = appCtx;

      switch (ctx.windowMode) {
        case WindowMode.One: {
          timelineForm.TopLevel = false;

          break;
        }

        // デフォルト
        case WindowMode.Multi: {
          timelineForm.Owner = this;

          this.Size = new Size(
            picturebox_preview.Width + 16,
            menuStripMainForm.Height + picturebox_preview.Height + hScrollBar1.Height + 40);

          break;
        }
      }

      timelineForm.Location = new Point(this.Location.X, this.Location.Y + this.Height);
      timelineForm.Show();
    }

    private void MainForm_Load(object sender, EventArgs e) {
      appCtx = new AppContext();

      InitWindow();

    }

    void OnMouseDown(object sender, MouseEventArgs e) {

    }
    
    void OnMouseMove(object sender, MouseEventArgs e) {

    }
    
    void OnMouseUp(object sender, MouseEventArgs e) {

    }

    private void テキストToolStripMenuItem_Click(object sender, EventArgs e) {

    }

    private void MainForm_SizeChanged(object sender, EventArgs e) {
      //switch (this.WindowState) {
      //  case FormWindowState.Minimized: {
      //    timelineForm.WindowState = FormWindowState.Minimized;
      //    break;
      //  }

      //  case FormWindowState.Normal: {
      //    timelineForm.WindowState = FormWindowState.Normal;
      //    break;
      //  }
      //}
    }
  }


}