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

      this.Paint += TimelineForm_Paint;

    }

    private void TimelineForm_Paint(object sender, PaintEventArgs e) {
      timeline.Draw();
    }


  }
}
