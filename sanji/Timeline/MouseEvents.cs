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

      click_info.change_width_minimum_pos = 0;
      click_info.change_width_maximum_pos = int.MaxValue;

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

      // クリックした座標にアイテムがある
      if (click_info.index != -1) {
        var item = items[click_info.index];

        // 長さを変更 (左)
        if (pos < item_pos_to_draw_pos(item.position) + CHANGE_WIDTH_CLICK_RANGE) {
          click_info.behavior_kind = ClickedItemInfo.BehaviorKind.ChangeItemWidth_Left;
          click_info.change_width_base_pos = item.position + item.width;

          for (int i = item.position - 1; i >= 0; i--) {
            if (get_item_index_from_loc(i, layer, click_info.index) != -1) {
              click_info.change_width_minimum_pos = i + 1;
              break;
            }
          }
        }
        
        // 長さを変更 (右)
        else if (pos >= item_pos_to_draw_pos(item.position + item.width) - CHANGE_WIDTH_CLICK_RANGE) {
          click_info.behavior_kind = ClickedItemInfo.BehaviorKind.ChangeItemWidth_Right;
          click_info.change_width_base_pos = item.position;

          for (int i = item.position + item.width + 1; i < click_info.change_width_maximum_pos; i++) {
            if (get_item_index_from_loc(i, layer, click_info.index) != -1) {
              click_info.change_width_maximum_pos = i;
              break;
            }
          }
        }

        // 移動
        else {
          click_info.behavior_kind = ClickedItemInfo.BehaviorKind.MoveItem;
          click_info.diff = e.X - item.position;
        }
      }
    }

    private void change_mouse_cursor(object s, MouseEventArgs e) {
      var (pos, layer) = mouse_pos_to_item_pos(e.X, e.Y);
      int item_i = get_item_index_from_loc(pos, layer);

      if (item_i == -1) {
        Form1.form1_instance.Cursor = Cursors.Default;
        return;
      }

      var item = items[item_i];

      if (pos < item_pos_to_draw_pos(item.position) + CHANGE_WIDTH_CLICK_RANGE) {
        Form1.form1_instance.Cursor = Cursors.SizeWE;
      }
      else if (pos >= item_pos_to_draw_pos(item.position + item.width) - CHANGE_WIDTH_CLICK_RANGE) {
        Form1.form1_instance.Cursor = Cursors.SizeWE;
      }
      else {
        Form1.form1_instance.Cursor = Cursors.Default;
      }
    }

    public void timeline_MouseMove(object sender, MouseEventArgs e) {
      if (click_info.behavior_kind == ClickedItemInfo.BehaviorKind.None) {
        change_mouse_cursor(sender, e);
        return;
      }

      var item = items[click_info.index];
      var (pos, layer) = mouse_pos_to_item_pos(e.X, e.Y);

      //var (pos, layer) = (e.X - click_info.diff, e.Y / item_height);

      switch (click_info.behavior_kind) {
        case ClickedItemInfo.BehaviorKind.MoveItem: {
          //var item = items[click_info.index];
          //var (pos, layer) = (e.X - click_info.diff, e.Y / item_height);
          
          pos -= click_info.diff;

          if (pos < 0) {
            pos = 0;
          }

          if (layer < 0) {
            layer = 0;
          }

          var hit_left = get_item_index_from_loc(pos, layer, click_info.index);

          if (hit_left != -1) {
            pos = items[hit_left].position + items[hit_left].width;

            if (get_item_index_from_loc(pos, layer, click_info.index) != -1) {
              break;
            }
          }
          
          var hit_right = get_item_index_from_loc(pos + item.width - 1, layer, click_info.index);

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

        case ClickedItemInfo.BehaviorKind.ChangeItemWidth_Left: {
          if (pos < click_info.change_width_minimum_pos)
            pos = click_info.change_width_minimum_pos;

          if (pos >= click_info.change_width_base_pos)
            pos = click_info.change_width_base_pos;

          item.position = pos;
          item.width = click_info.change_width_base_pos - pos;

          break;
        }

        case ClickedItemInfo.BehaviorKind.ChangeItemWidth_Right: {

          if (pos >= click_info.change_width_maximum_pos)
            pos = click_info.change_width_maximum_pos;

          item.width = pos - click_info.change_width_base_pos;

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