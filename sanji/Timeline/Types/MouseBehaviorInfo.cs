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
      public int leftpos;
      public int rightpos;
      public int leftstop;
      public int rightstop;

      public void Initialize(Kind kind, Item.Location clickedLoc, Item clickedItem) {
        this.kind = kind;
        this.isDown = true;
        this.clickedLoc = clickedLoc;
        this.clickedItem = clickedItem;
        this.collidItem = null;
      }

      // -------------------------------- //
      //  GetKindFromLocation
      //  
      //  params:
      //    tl      = instance of Timeline
      //    loc     = clicked location
      // -------------------------------- //
      public Kind GetKindFromLocation(Timeline tl, Item.Location loc, MouseEventArgs e) {

        //var loc = MousePosToItemLoc(e.X, e.Y);
        var item = this.clickedItem = tl.GetItemFromLoc(loc);

        const int rangeOfChangeLength = 15;

        Debugs.Alert();
        Console.WriteLine($"{loc}");
        Console.WriteLine($"{item != null}");

        // クリックした場所にアイテムがある
        if( item != null ) {

          Debugs.Alert();

          var actpos = tl.ItemLocToMousePos(item.location.layer, item.location.position);
          var actpos_end = tl.ItemLocToMousePos(item.location.layer, item.location.position + item.length);

          Console.WriteLine($"");

          if( e.X <= actpos.X + rangeOfChangeLength ) {
            return Kind.ChangeItemLength_Left;
          }
          else if( actpos_end.X - rangeOfChangeLength <= e.X ) {
            return Kind.ChangeItemLength_Right;
          }
          else {
            return Kind.MoveItem;
          }
        }
        
        // ない
        return Kind.MoveSeekbar;
      }
    }
  }
}
