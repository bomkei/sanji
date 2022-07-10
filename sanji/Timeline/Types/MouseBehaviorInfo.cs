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
    public struct MouseBehaviorInfo {
      public enum Kind {
        MoveSeekbar,
        MoveItem,
        ChangeItemLength_Left,
        ChangeItemLength_Right,
        OpenedContextMenu_Item,
        OpenedContextMenu_Timeline,
      }

      public Kind kind;
      public bool isDown;
      public Item.Location clickedLoc;
      public Item clickedItem;
      public Item collidItem;
      public int clickDiff;

      public void Initialize(Kind kind, Item.Location clickedLoc, Item clickedItem) {
        this.kind = kind;
        this.isDown = true;
        this.clickedLoc = clickedLoc;
        this.clickedItem = clickedItem;
        this.collidItem = null;
      }
    }
  }
}
