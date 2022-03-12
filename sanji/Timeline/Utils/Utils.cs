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
    private int check_item_hit(int index, int ignore = -1) {
      var self = items[index];

      for (int i = 0; i < items.Count; i++) {
        var item = items[i];

        if (i == ignore || i == index || item.layer != self.layer)
          continue;

        int
          a = self.position,
          b = self.rightpos,
          c = item.position,
          d = item.rightpos;

        int[][] chkmap = {
          new int[] { a, b, c },
          new int[] { a, b, d },
          new int[] { c, d, a },
          new int[] { c, d, b }
        };

        foreach (var x in chkmap) {
          if (x[0] <= x[2] && x[2] <= x[1]) {
            return i;
          }
        }
      }

      return -1;
    }
  }
}