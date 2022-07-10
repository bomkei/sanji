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
  public partial class TimelineForm : Form {
    Timeline timeline;

    public TimelineForm() {
      InitializeComponent();

      this.timeline = new Timeline(this.pictureBox);

      pictureBox.MouseDown += (object s, MouseEventArgs e) => { timeline.OnMouseDown(s, e); };
      pictureBox.MouseMove += (object s, MouseEventArgs e) => { timeline.OnMouseMove(s, e); };
      pictureBox.MouseUp += (object s, MouseEventArgs e) => { timeline.OnMouseUp(s, e); };

      pictureBox.MouseEnter += (object s, EventArgs e) => {
      };

      pictureBox.MouseLeave += (object s, EventArgs e) => {
      };

      trackBar1.MouseWheel += (object s, MouseEventArgs e) => {
        var addval = e.Delta / 120;
        var bar = (TrackBar)s;

        bar.Value = addval < 0 ? Math.Max(bar.Minimum, bar.Value + addval) : Math.Min(bar.Maximum, bar.Value + addval);
      };

      this.Paint += TimelineForm_Paint;

    }

    private void TimelineForm_Paint(object sender, PaintEventArgs e) {
      timeline.Draw();
    }

    private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) {

    }

    private void TimelineForm_Shown(object sender, EventArgs e) {
      timeline.Draw();
    }
  }
}
