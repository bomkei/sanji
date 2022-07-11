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
    public Item.Location MousePosToItemLoc(int x, int y) {
      y /= layerHeight;

      if( x < 0 )
        x = 0;

      if( y < 0 )
        y = 0;

      return new Item.Location(y, x);
    }

    public (int, int) ItemLocToMousePosTuple(int layer, int position) {
      return (position, layer * layerHeight);
    }

    public Point ItemLocToMousePos(int layer, int position) {
      var (x, y) = ItemLocToMousePosTuple(layer, position);

      return new Point(x, y);
    }

    public bool TryPlaceItem(Item.Location loc, Item item, out Item collid) {
      Debugs.Alert();

      if( loc.position < 0 )
        loc.position = 0;

      collid = IsItemCollid(loc, item.length, item);

      if( collid == null ) {
        item.location = loc;
        return true;
      }

      return false;
    }

    public Item GetItemFromLoc(Item.Location loc) {
      foreach( var item in items ) {
        if( item.layer == loc.layer && item.position <= loc.position && loc.position <= item.endpos ) {
          return item;
        }
      }

      return null;
    }

    public Item IsItemCollid(Item.Location loc, int len, Item ignore = null) {
      foreach( var item in items ) {
        if( item != ignore && item.layer == loc.layer
          && Utils.IsRangeCollid(loc.position, loc.position + len - 1, item.position, item.endpos) ) {
          return item;
        }
      }

      return null;
    }

    public Item IsItemCollid(Item item) {
      return IsItemCollid(item.location, item.length, item);
    }
  }
}
