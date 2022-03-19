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

    private (int, int) get_move_range(int item_index) {
      int min = 0;
      int max = int.MaxValue;

      var item = items[item_index];

      for (int i = 0; i < items.Count; i++) {
        var x = items[i];

        if (i == item_index || x.layer != item.layer)
          continue;

        if (min < x.rightpos && x.rightpos < item.position) {
          min = x.rightpos + 1;
        }

        if (item.position <= x.position - item.width && x.position - item.width < max) {
          max = x.position - item.width;
        }
      }

      return (min, max);
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

    public void timeline_MouseDown(object sender, MouseEventArgs e) {
      var (pos, layer) = mouse_pos_to_item_pos(e.X, e.Y);

      click_info.index = get_item_index_from_loc(pos, layer);
      click_info.loc = new Point(pos, layer);

      click_info.change_width_minimum_pos = 0;
      click_info.change_width_maximum_pos = int.MaxValue;
      click_info.range_updated = false;

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
          // 動作の種類
          click_info.behavior_kind = ClickedItemInfo.BehaviorKind.ChangeItemWidth_Left;

          // ?
          click_info.change_width_base_pos = item.position + item.width;

          // 
          click_info.change_width_minimum_pos = 0;

          // 左側にアイテムがあるときは、そのアイテムの rightpos までとする
          foreach (var ix in items) {
          
          }
        }

        // 長さを変更 (右)
        else if (pos >= item_pos_to_draw_pos(item.position + item.width) - CHANGE_WIDTH_CLICK_RANGE) {
          click_info.behavior_kind = ClickedItemInfo.BehaviorKind.ChangeItemWidth_Right;
          click_info.change_width_base_pos = item.position;

          foreach (var ix in items) {
            if (ix.layer != layer)
              continue;

            if (item.rightpos <= ix.position && click_info.change_width_base_pos < ix.position)
              click_info.change_width_maximum_pos = ix.position;
          }
        }

        // 移動
        else {
          click_info.behavior_kind = ClickedItemInfo.BehaviorKind.MoveItem;
          click_info.diff = e.X - item.position;

          (click_info.move_min, click_info.move_max) = get_move_range(click_info.index);
        }
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
          var (save_pos, save_layer) = (item.position, item.layer);

          pos -= click_info.diff;

          if (pos < 0)
            pos = 0;

          if (layer < 0)
            layer = 0;

          (item.position, item.layer) = (pos, layer);
          var hit = check_item_hit(click_info.index);

          if (hit == -1) {
            (click_info.move_min, click_info.move_max) = get_move_range(click_info.index);
            break;
          }
          else {
            if (pos < click_info.move_min) {
              pos = click_info.move_min;
            }

            if (pos > click_info.move_max) {
              pos = click_info.move_max;
            }

            (item.position, item.layer) = (pos, save_layer);
          }

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