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
    public class ClickedItemInfo {
      public enum BehaviorKind {
        None,
        MoveItem,
        ChangeItemWidth_Left,
        ChangeItemWidth_Right,
      }

      private static ClickedItemInfo _instance;
      public static ClickedItemInfo get_instance() {
        if (_instance == null) {
          _instance = new ClickedItemInfo();
        }

        return _instance;
      }

      private ClickedItemInfo() {
      }

      public int change_width_minimum_pos; // left
      public int change_width_maximum_pos; // right
      public int change_width_base_pos;

      public int move_min;
      public int move_max;
      public bool range_updated;

      public int index;
      public int diff;
      public Point loc;

      // マウスイベント用関数が行う動作を判別するための Kind です ( 名前が微妙 )
      public BehaviorKind behavior_kind;

      public static int dash_tick;
      public static int dash_counter; // 点線描画の回転

    }



  }
}