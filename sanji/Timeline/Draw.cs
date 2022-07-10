using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sanji.TimelineItems;

namespace sanji {
  public partial class Timeline {
    public void Draw() {

      // background
      gra.FillRectangle(background.ToColor().ToBrush(), 0, 0, picbox.Width, picbox.Height);

      for (int i = 0; i < 10; i++) {
        var y = i * layerHeight;
        gra.DrawLine(new Pen(Color.FromArgb(42, 42, 42)), 0, y, picbox.Width, y);
      }

      foreach (var item in items) {
        DrawItem(item);
      }


      picbox.Image = bmp;

    }

    public void DrawItem(Item item) {
      var loc = item.location;

      loc.position -= scrollVal.X;

      var itemRect = new Rectangle(loc.position, loc.layer * layerHeight + 2, item.length - 1, layerHeight - 4);

      gra.FillRectangle(Brushes.DimGray, itemRect);

      gra.DrawRectangle(new Pen(Color.FromArgb(48, 48, 48)), itemRect);

    }
  }
}
