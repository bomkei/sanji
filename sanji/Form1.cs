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
  public partial class Form1 : Form {
    Timeline timeline;
    public static Form1 form1_instance;

    public Form1() {
      InitializeComponent();

      form1_instance = this;
      timeline = new Timeline();

    }

    private void draw() {
      timeline.draw(ref picturebox_timeline);

    }

    private void Form1_Paint(object sender, PaintEventArgs e) {
      draw();
    }

    private void テキストToolStripMenuItem_Click(object sender, EventArgs e) {
      var item = new Timeline.Item {
        kind = Timeline.Item.Kind.Text,
        width = 100
      };

      timeline.add_item(item);
      draw();
    }

    private void picturebox_timeline_MouseDown(object sender, MouseEventArgs e) {
      timeline.timeline_MouseDown(sender, e);
      draw();
    }

    private void picturebox_timeline_MouseMove(object sender, MouseEventArgs e) {
      timeline.timeline_MouseMove(sender, e);
      draw();
    }

    private void picturebox_timeline_MouseUp(object sender, MouseEventArgs e) {
      timeline.timeline_MouseUp(sender, e);
      draw();
    }

    private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
      this.Close();
    }
  }


}