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
    public class Item {
      public enum Kind {
        Text,
        Video
      }

      public Kind kind;
      public int width;
      public int layer;
      public int position;

      public Item() {
        kind = Kind.Text;
        width = 1;
        layer = 0;
        position = 0;
      }
    }

    public struct ColorProperty {
      public Color background;
      public Color bar;
    }

    public readonly int BMP_WIDTH = 1200;
    public readonly int BMP_HEIGHT = 600;

    public List<Item> items;
    public ColorProperty color_property;
    public Bitmap bitmap;
    private Graphics gra;

    public Timeline() {
      items = new List<Item>();
      bitmap = new Bitmap(BMP_WIDTH, BMP_HEIGHT);
      gra = Graphics.FromImage(bitmap);

      color_property = new ColorProperty {
        background = Color.White,
        bar = Color.Red
      };
    }

    public void add_item(Item item) {
      items.Add(item);
    }

    public void draw(ref PictureBox picturebox) {
      gra.Clear(Color.White);



      picturebox.Image = bitmap;
    }
  }
}