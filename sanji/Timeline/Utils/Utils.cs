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
    private bool _is_item_collid(int l, int r, int ll, int rr)
      => l > ll ? _is_item_collid(ll, rr, l, r) : ll <= r;

    private int check_item_hit(int index, int ignore = -1) {
      var self = items[index];

      for (int i = 0; i < items.Count; i++) {
        var item = items[i];

        if (i == index || item.layer != self.layer)
          continue;

        if (_is_item_collid(self.position, self.rightpos, item.position, item.rightpos))
          return i;
      }

      return -1;
    }
  }
}