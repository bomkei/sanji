﻿using System;
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
        MoveItem
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

      public int index;
      public int diff;
      public Point loc;
      public BehaviorKind behavior_kind;
      public static int dash_counter; // 点線描画の回転
    }



  }
}