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
    public partial struct MouseBehaviorInfo {
      /* ----------------------------------- //
       *  GetKindFromLocation
       *  
       *  about:
       *    Judge the kind from location mouse clicked.
       *    
       *  params:
       *    tl    = instance of Timeline
       *    loc   = clicked location
       *    e     = event args
       *    
       *  return;
       *    Judged kind
      // ----------------------------------- */
      public Kind GetKindFromLocation(Timeline tl, Item.Location loc, MouseEventArgs e) {

        //var loc = MousePosToItemLoc(e.X, e.Y);
        var item = tl.GetItemFromLoc(loc);

        const int rangeOfChangeLength = 15;

        Debugs.Alert();
        Debugs.Print($"{loc}");
        Debugs.Print($"{item != null}");

        // クリックした場所にアイテムがある
        if( item != null ) {

          Debugs.Alert();

          var actpos = tl.ItemLocToMousePos(item.layer, item.position);
          var actpos_end = tl.ItemLocToMousePos(item.layer, item.position + item.length);

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
