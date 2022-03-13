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
  public partial class Timeline {
    public class Item {
      public enum Kind {
        Text,
        Video
      }

      public Kind kind;
      public int width;
      public int layer;
      public int position;
      public int rightpos{ get{ return position + width; } }

      public Rectangle get_rect() {
        return new Rectangle {
          X = this.position,
          Y = this.layer * Timeline.get_instance.item_height + 4,
          Width = this.width - 1,
          Height = Timeline.get_instance.item_height - 6
        };
      }

      public Item() {
        kind = Kind.Text;
        width = 1;
        layer = 0;
        position = 0;
      }

      public Brush kind_to_brush() {
        switch (kind) {
          case Kind.Text:
            return Brushes.LightGreen;

          case Kind.Video:
            return Brushes.Pink;
        }

        return null;
      }
    }
  }
}
