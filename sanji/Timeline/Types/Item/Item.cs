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

namespace sanji.TimelineItems {

  public abstract class Item {
    public enum Kind {
      Text,
      Video,
    }

    public struct Location {
      public int layer;
      public int position;

      public Location(int layer, int position) {
        this.layer = layer;
        this.position = position;
      }

      public override string ToString() {
        return $"(Item.Location layer={layer}, position={position})";
      }
    }

    public Kind kind;
    public string name;
    public Location location;
    public int length;

    public int endpos {
      get {
        return location.position + length - 1;
      }
    }

    public int centerpos {
      get {
        return location.position + length / 2;
      }
    }

    public Item(Kind kind, Location loc, int len) {
      this.kind = kind;
      this.name = string.Empty;
      this.location = loc;
      this.length = len;
    }
  }
}
