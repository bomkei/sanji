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

namespace sanji {
  public partial class Timeline {

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
          return $"{{layer={layer}, position={position}}}";
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

    public class TextItem : Item {
      public string text;

      public TextItem(string text, Location loc)
        : base(Kind.Text, loc, 100) {

      }
    }

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

    struct RGB {
      public int r, g, b;

      public RGB(int r, int g, int b) {
        (this.r, this.g, this.b) = (r, g, b);
      }

      public Color ToColor() {
        return Color.FromArgb(r, g, b);
      }
    }

    readonly Size bitmapSize = new Size(2000, 1000);
    readonly RGB background = new RGB(64, 64, 64);

    int layerHeight = 32;
    Stopwatch sw = new Stopwatch();

    PictureBox picbox;
    Bitmap bmp;
    Graphics gra;
    Graphics gra_picbox;

    public MouseBehaviorInfo msBehav;
    public List<Item> items;
    public Point scrollval;

    public static Timeline Instance;

    public Timeline(PictureBox picbox) {
      this.picbox = picbox;

      bmp = new Bitmap(bitmapSize.Width, bitmapSize.Height);
      gra = Graphics.FromImage(bmp);

      picbox.Image = bmp;
      gra_picbox = Graphics.FromImage(picbox.Image);

      items = new List<Item>();

      for (int i = 0; i < 5; i++) {
        var item = new TextItem("yeah", new Item.Location(0, 0));
        items.Add(item);
      }
      

      Instance = this;
    }

    // -------- Draw ------- //
    public void Draw() {

      // background
      gra.FillRectangle(background.ToColor().ToBrush(), 0, 0, picbox.Width, picbox.Height);

      for (int i = 0; i < 10; i++) {
        var y = i * layerHeight;
        gra.DrawLine(new Pen(Color.FromArgb(42, 42, 42)), 0, y, picbox.Width, y);
      }

      foreach (var item in items) {
        DrawItem(item);
      }


      picbox.Image = bmp;

    }

    public void DrawItem(Item item) {
      var loc = item.location;

      loc.position -= scrollval.X;

      var itemRect = new Rectangle(loc.position, loc.layer * layerHeight + 2, item.length, layerHeight - 4);

      gra.FillRectangle(Brushes.DimGray, itemRect);

      gra.DrawRectangle(new Pen(Color.FromArgb(48,48,48)), itemRect);

    }
    // --------------------- //


    // ------ Events ----- //
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
    // ------------------ //


    // ---- Helpers ----- //
    public Item.Location MousePosToItemLoc(int x, int y) {
      y /= layerHeight;

      if (x < 0)
        x = 0;

      if (y < 0)
        y = 0;

      return new Item.Location(y, x);
    }

    public bool TryPlaceItem(Item.Location loc, Item item, out Item collid) {
      Debugs.Alert();

      if (loc.position < 0)
        loc.position = 0;

      collid = IsItemCollid(loc, item.length, item);

      if (collid == null) {
        item.location = loc;
        return true;
      }

      return false;
    }

    public Item GetItemFromLoc(Item.Location loc) {
      foreach (var item in items) {
        if (item.location.layer == loc.layer && item.location.position <= loc.position && loc.position <= item.endpos) {
          return item;
        }
      }

      return null;
    }

    public Item IsItemCollid(Item.Location loc, int len, Item ignore = null) {
      foreach (var item in items) {
        if (item != ignore && item.location.layer == loc.layer
          && Utils.IsRangeCollid(loc.position, loc.position + len - 1, item.location.position, item.endpos)) {
          return item;
        }
      }

      return null;
    }

    public Item IsItemCollid(Item item) {
      return IsItemCollid(item.location, item.length, item);
    }
    // ------------------ //



  }
}
