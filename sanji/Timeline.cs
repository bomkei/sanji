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

      public Brush kind_to_brush() {
        switch (kind) {
          case Kind.Text:
            return Brushes.LightGreen;

          case Kind.Video:
            return Brushes.Pink;
        }

        return null;
      }
    }

    public struct ColorProperty {
      public Color background;
      public Color bar;
    }

    public readonly int BMP_WIDTH = 1200;
    public readonly int BMP_HEIGHT = 600;

    public int clip_height = 32;

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

    public (int, int) mouse_pos_to_item_pos(int mx, int my) {
      return (mx, my / clip_height);
    }
    
    public Point mouse_pos_to_item_point(int mx, int my) {
      var (x, y) = mouse_pos_to_item_pos(mx, my);
      return new Point(x, y);
    }

    public int get_item_index_from_loc(int position, int layer) {
      for (int i = 0; i < items.Count; i++) {
        var item = items[i];

        if (item.layer != layer)
          continue;

        if (item.position <= position && position < item.position + item.width)
          return i;
      }

      return -1;
    }

    public void add_item(Item item) {
      items.Add(item);
    }

    public void draw(ref PictureBox picturebox) {
      gra.Clear(Color.White);

      // ボーダー
      for (int i = 0; i < picturebox.Height / clip_height; i++) {
        gra.DrawLine(Pens.Black, 0, i * clip_height, picturebox.Width, i * clip_height);
      }

      // アイテム描画
      foreach (var item in items) {
        gra.DrawRectangle(Pens.Black, item.position, item.layer * clip_height, item.width, clip_height);
        gra.FillRectangle(item.kind_to_brush(), item.position, item.layer * clip_height, item.width, clip_height);
      }

      picturebox.Image = bitmap;
    }

    public void timeline_MouseDown(object sender, MouseEventArgs e) {
      // 右クリック
      if (e.Button == MouseButtons.Right) {
        var (pos, layer) = mouse_pos_to_item_pos(e.X, e.Y);
        var clicked_item = get_item_index_from_loc(pos, layer);

        if (clicked_item == -1) {

        }
        else {
        }

        return;
      }

    }

    public void timeline_MouseMove(object sender, MouseEventArgs e) {

    }

    public void timeline_MouseUp(object sender, MouseEventArgs e) {

    }
  }
}