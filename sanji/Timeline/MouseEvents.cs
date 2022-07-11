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
    Item.Location _AdjustItemLocation(Item.Location loc, ref MouseBehaviorInfo info) {
      if( loc.position < info.leftstop )
        loc.position = info.leftstop;
      else if( info.rightstop != -1 && loc.position > info.rightstop )
        loc.position = info.rightstop;

      return loc;
    }

    public void OnMouseDown(PictureBox sender, ref MouseBehaviorInfo info, MouseEventArgs e) {

      var loc = MousePosToItemLoc(e.X, e.Y);
      var item = info.clickedItem = GetItemFromLoc(loc);

      Debugs.Alert();
      Console.WriteLine($"{loc}");
      Console.WriteLine($"{item != null}");

      //info.clickedItem = item;

      switch( info.GetKindFromLocation(this, loc, e) ) {
        case MouseBehaviorInfo.Kind.MoveSeekbar: {
          info.Initialize(MouseBehaviorInfo.Kind.MoveSeekbar, loc, item);
          break;
        }

        case MouseBehaviorInfo.Kind.MoveItem: {
          info.Initialize(MouseBehaviorInfo.Kind.MoveItem, loc, item);
          info.clickDiff = item.position - loc.position;
          break;
        }

        case MouseBehaviorInfo.Kind.ChangeItemLength_Left: {
          info.Initialize(MouseBehaviorInfo.Kind.ChangeItemLength_Left, loc, item);
          info.leftstop = 0;
          info.rightpos = item.endpos + 1;
          info.rightstop = item.endpos;

          foreach( var x in items ) {
            if( x != item && x.layer == item.layer
              && info.leftstop < x.endpos + 1 && x.endpos < item.position ) {
              info.leftstop = x.endpos + 1;
            }
          }

          break;
        }

        case MouseBehaviorInfo.Kind.ChangeItemLength_Right: {
          info.Initialize(MouseBehaviorInfo.Kind.ChangeItemLength_Right, loc, item);
          info.leftstop = item.position + 1;
          info.rightstop = -1;

          foreach( var x in items ) {
            if( x != item && x.layer == item.layer
              && (item.endpos < x.position && (x.position < info.rightstop || info.rightstop == -1)) ) {
              info.rightstop = x.position;
            }
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

    public void OnMouseMove(PictureBox sender, ref MouseBehaviorInfo info, MouseEventArgs e) {
      var loc = MousePosToItemLoc(e.X, e.Y);
      var item = info.clickedItem;

      // 押下されていない
      if( !info.isDown ) {
        sender.Cursor = Cursors.Default;
        info.mouseEnteredItem = GetItemFromLoc(loc);

        switch( info.GetKindFromLocation(this, loc, e) ) {
          case MouseBehaviorInfo.Kind.MoveItem: {

            break;
          }

          case MouseBehaviorInfo.Kind.ChangeItemLength_Left: {
            sender.Cursor = Cursors.SizeWE;

            break;
          }

          case MouseBehaviorInfo.Kind.ChangeItemLength_Right: {
            sender.Cursor = Cursors.SizeWE;

            break;
          }
        }

        Draw();
        return;
      }

      var item_loc = loc;
      
      info.mouseEnteredItem = null;
      item_loc.position += info.clickDiff;

      switch( info.kind ) {
        case MouseBehaviorInfo.Kind.ChangeItemLength_Left: {
          loc = _AdjustItemLocation(loc, ref info);

          item.position = loc.position;
          item.length = info.rightpos - loc.position;

          Console.WriteLine($"{item.length}");

          break;
        }

        case MouseBehaviorInfo.Kind.ChangeItemLength_Right: {
          loc = _AdjustItemLocation(loc, ref info);

          item.length = loc.position - item.position;

          break;
        }

        case MouseBehaviorInfo.Kind.MoveItem: {
          Item collid;

          if( !TryPlaceItem(item_loc, item, out collid) ) {
            if( collid.centerpos <= loc.position ) {
              TryPlaceItem(new Item.Location(item_loc.layer, collid.endpos + 1), item, out collid);
            }
            else {
              TryPlaceItem(new Item.Location(item_loc.layer, collid.position - item.length), item, out collid);
            }
          }

          break;
        }
      }

      Draw();
    }

    public void OnMouseUp(PictureBox sender, ref MouseBehaviorInfo info, MouseEventArgs e) {

      if( !info.isDown )
        return;


      info.isDown = false;

      Draw();
    }
  }
}
