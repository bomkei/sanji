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
    public void OnMouseDown(object sender, MouseEventArgs e) {

      var loc = MousePosToItemLoc(e.X, e.Y);
      var item = GetItemFromLoc(loc);

      Debugs.Alert();
      Console.WriteLine($"{loc}");
      Console.WriteLine($"{item != null}");

      // クリックした場所にアイテムがある
      if (item != null) {

        // アイテム移動
        msBehav.Initialize(MouseBehaviorInfo.Kind.MoveItem, loc, item);
        msBehav.clickDiff = item.location.position - loc.position;

      }
      // ない
      else {
        msBehav.Initialize(MouseBehaviorInfo.Kind.MoveSeekbar, loc, item);
      }

      Draw();
    }

    public void OnMouseMove(object sender, MouseEventArgs e) {
      var loc = MousePosToItemLoc(e.X, e.Y);
      var item = msBehav.clickedItem;

      if (!msBehav.isDown)
        return;

      var item_loc = loc;
      item_loc.position += msBehav.clickDiff;

      switch (msBehav.kind) {
        case MouseBehaviorInfo.Kind.MoveItem: {
          Item collid;

          if (!TryPlaceItem(item_loc, item, out collid)) {
            if (collid.centerpos <= loc.position) {
              TryPlaceItem(new Item.Location(item_loc.layer, collid.endpos + 1), item, out collid);
            }
            else {
              TryPlaceItem(new Item.Location(item_loc.layer, collid.location.position - item.length), item, out collid);
            }
          }

          break;
        }
      }

      Draw();
    }

    public void OnMouseUp(object sender, MouseEventArgs e) {

      if (!msBehav.isDown)
        return;


      msBehav.isDown = false;

      Draw();
    }
  }
}
