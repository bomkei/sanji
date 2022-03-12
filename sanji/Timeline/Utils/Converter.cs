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
    public (int, int) mouse_pos_to_item_pos(int mx, int my) {
      return (mx, my / item_height);
    }

    //public Point mouse_pos_to_item_point(int mx, int my) {
    //  var (x, y) = mouse_pos_to_item_pos(mx, my);
    //  return new Point(x, y);
    //}

    public int get_item_index_from_loc(int position, int layer, int ignore = -1) {
      for (int i = 0; i < items.Count; i++) {
        var item = items[i];

        if (item.layer != layer || i == ignore)
          continue;

        if (item.position <= position && position < item.position + item.width)
          return i;
      }

      return -1;
    }

    private int item_pos_to_draw_pos(int pos) {


      return pos;
    }
  }
}