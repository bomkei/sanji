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

    AppContext appCtx;
    Timeline timeline;

    public MainForm() {
      Debugs.Alert();

      InitializeComponent();

      timeline = new Timeline(this.pictureBox_timeline);

      pictureBox_timeline.MouseDown += (object s, MouseEventArgs e) => { timeline.OnMouseDown(s, ref timeline.msBehav, e); };
      pictureBox_timeline.MouseMove += (object s, MouseEventArgs e) => { timeline.OnMouseMove(s, ref timeline.msBehav, e); };
      pictureBox_timeline.MouseUp += (object s, MouseEventArgs e) => { timeline.OnMouseUp(s, ref timeline.msBehav, e); };

      trackBar1.MouseWheel += (object s, MouseEventArgs e) => {
        var addval = e.Delta / 120;
        var bar = (TrackBar)s;

        bar.Value = addval < 0 ? Math.Max(bar.Minimum, bar.Value + addval) : Math.Min(bar.Maximum, bar.Value + addval);
      };


    }

    void InitWindow() {
      var ctx = appCtx;

      switch( ctx.windowMode ) {
        case WindowMode.One: {

          break;
        }

        // デフォルト
        case WindowMode.Multi: {
          break;
        }
      }

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
    }

    private void MainForm_Paint(object sender, PaintEventArgs e) {
      timeline.Draw();
    }
  }


}