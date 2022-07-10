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



          break;
        }
      }

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

  }


}