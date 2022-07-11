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
    public void OnMouseDown(object sender, ref MouseBehaviorInfo info, MouseEventArgs e) {

      var loc = MousePosToItemLoc(e.X, e.Y);
      var item = info.clickedItem = GetItemFromLoc(loc);

      Debugs.Alert();
      Console.WriteLine($"{loc}");
      Console.WriteLine($"{item != null}");

      switch( info.GetKindFromLocation(this, loc, e) ) {
        case MouseBehaviorInfo.Kind.MoveSeekbar: {
          info.Initialize(MouseBehaviorInfo.Kind.MoveSeekbar, loc, item);
          break;
        }

        case MouseBehaviorInfo.Kind.MoveItem: {
          info.Initialize(MouseBehaviorInfo.Kind.MoveItem, loc, item);
          info.clickDiff = item.location.position - loc.position;
          break;
        }

        case MouseBehaviorInfo.Kind.ChangeItemLength_Left: {
          info.Initialize(MouseBehaviorInfo.Kind.ChangeItemLength_Left, loc, item);
          info.leftstop = 0;
          info.rightpos = item.endpos + 1;
          info.rightstop = item.endpos;

          foreach( var x in items ) {
            if( x.location.layer == item.location.layer
              && info.leftstop < x.endpos + 1 && x.endpos + 1 < item.location.position ) {
              info.leftstop = x.endpos + 1;
            }
          }

          break;
        }

        case MouseBehaviorInfo.Kind.ChangeItemLength_Right: {
          info.Initialize(MouseBehaviorInfo.Kind.ChangeItemLength_Right, loc, item);
          info.leftpos = item.location.position;
          info.rightstop = -1;

          foreach( var x in items ) {

          }

          break;
        }

        case MouseBehaviorInfo.Kind.OpenedContextMenu_Item: {
          break;
        }

        case MouseBehaviorInfo.Kind.OpenedContextMenu_Timeline: {

          break;
        }

        default: {
          throw new NotImplementedException();
        }
      }

      Draw();
    }

    public void OnMouseMove(object sender, ref MouseBehaviorInfo info, MouseEventArgs e) {
      var loc = MousePosToItemLoc(e.X, e.Y);
      var item = info.clickedItem;

      if( !info.isDown )
        return;

      var item_loc = loc;
      item_loc.position += info.clickDiff;

      switch( info.kind ) {
        case MouseBehaviorInfo.Kind.ChangeItemLength_Left: {

          if( loc.position < info.leftstop ) {
            loc.position = info.leftstop;
          }
          else if( info.rightstop < loc.position ) {
            loc.position = info.rightstop;
          }

          item.location.position = loc.position;
          item.length = info.rightpos - loc.position;

          Console.WriteLine($"{item.length}");

          break;
        }

        case MouseBehaviorInfo.Kind.ChangeItemLength_Right: {

          item.length = loc.position - item.location.position;

          break;
        }

        case MouseBehaviorInfo.Kind.MoveItem: {
          Item collid;

          if( !TryPlaceItem(item_loc, item, out collid) ) {
            if( collid.centerpos <= loc.position ) {
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

    public void OnMouseUp(object sender, ref MouseBehaviorInfo info, MouseEventArgs e) {

      if( !info.isDown )
        return;


      info.isDown = false;

      Draw();
    }
  }
}
