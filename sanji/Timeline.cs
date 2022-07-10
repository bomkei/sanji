using System;
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
      }

      public Kind kind;
      public string name;
      public Location location;
      public int length;

      public Item(Kind kind, Location loc, int len) {
        this.kind = kind;
        this.name = string.Empty;
        this.location = loc;
        this.length = len;
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
      public Item.Location clickedLoc;
      public Item clickedItem;
      public Item collidItem;

      public void Initialize(Kind kind, Item.Location clickedLoc) {

      }

      public void Update() {
      
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

    PictureBox picbox;
    Bitmap bmp;
    Graphics gra;
    
    public MouseBehaviorInfo msBehav;
    public List<Item> items;

    public static Timeline Instance;

    public Timeline(PictureBox picbox) {
      this.picbox = picbox;

      bmp = new Bitmap(bitmapSize.Width, bitmapSize.Height);
      gra = Graphics.FromImage(bmp);

      items = new List<Item>();

      Instance = this;
    }

    // -------- Draw ------- //
    public void Draw() {

      // background
      gra.FillRectangle(background.ToColor().ToBrush(), 0, 0, picbox.Width, picbox.Height);




    }
    // --------------------- //

    
    // ------ Events ----- //
    public void OnMouseDown(object sender, MouseEventArgs e) {

    }

    public void OnMouseMove(object sender, MouseEventArgs e) {

    }

    public void OnMouseUp(object sender, MouseEventArgs e) {

    }
    // ------------------ //


    // ---- Helpers ----- //
    public static Item GetItemFromLoc() {
      throw new NotImplementedException();
    }

    public static bool IsItemCollid(Item.Location loc, int len, Item ignore = null) {
      throw new NotImplementedException();
    }

    public static bool IsItemCollid(Item item) {
      throw new NotImplementedException();
    }
    // ------------------ //



  }
}