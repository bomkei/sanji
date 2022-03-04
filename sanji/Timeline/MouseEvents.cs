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
    public void timeline_MouseDown(object sender, MouseEventArgs e) {
      var (pos, layer) = mouse_pos_to_item_pos(e.X, e.Y);

      click_info.index = get_item_index_from_loc(pos, layer);
      click_info.loc = new Point(pos, layer);

      // 右クリック
      if (e.Button == MouseButtons.Right) {
        if (click_info.index == -1) {
          Form1.form1_instance.ctxMenuStrip_timeline.Show(Form1.form1_instance.picturebox_timeline, e.Location);
        }
        else {
          Form1.form1_instance.ctxMenuStrip_tl_item.Show(Form1.form1_instance.picturebox_timeline, e.Location);
        }

        return;
      }


      if (click_info.index != -1) {
        var item = items[click_info.index];

        click_info.behavior_kind = ClickedItemInfo.BehaviorKind.MoveItem;
        click_info.diff = e.X - item.position;
      }


    }

    public void timeline_MouseMove(object sender, MouseEventArgs e) {
      if (click_info.behavior_kind == ClickedItemInfo.BehaviorKind.None) {
        return;
      }

      switch (click_info.behavior_kind) {
        case ClickedItemInfo.BehaviorKind.MoveItem: {
          var item = items[click_info.index];
          var (pos, layer) = (e.X - click_info.diff, e.Y / item_height);

          if (pos < 0) {
            pos = 0;
          }

          if (layer < 0) {
            layer = 0;
          }

          var hit_left = get_item_index_from_loc(pos, layer, click_info.index);
          var hit_right = get_item_index_from_loc(pos + item.width - 1, layer, click_info.index);

          if (hit_left != -1) {
            pos = items[hit_left].position + items[hit_left].width;

            if (get_item_index_from_loc(pos, layer, click_info.index) != -1) {
              break;
            }
          }

          if (hit_right != -1) {
            pos = items[hit_right].position - item.width;

            if (get_item_index_from_loc(pos, layer, click_info.index) != -1) {
              break;
            }
          }

          if (pos < 0) {
            break;
          }

          (item.position, item.layer) = (pos, layer);
          break;
        }
      }
    }

    public void timeline_MouseUp(object sender, MouseEventArgs e) {
      if (click_info.behavior_kind == ClickedItemInfo.BehaviorKind.None) {
        return;
      }

      click_info.behavior_kind = ClickedItemInfo.BehaviorKind.None;
    }
  }
}