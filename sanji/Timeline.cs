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

      public Rectangle get_rect {
        get {
          return new Rectangle {
            X = this.position,
            Y = this.layer * Timeline.get_instance.item_height + 4,
            Width = this.width - 1,
            Height = Timeline.get_instance.item_height - 6
          };
        }
      }


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
      // UI の色の設定とかいつか変えれるようにしたい
      public Color background;
      public Color bar;
    }

    public class TimelineInstanceIsNotAsssignmented : Exception {
      public TimelineInstanceIsNotAsssignmented()
        : base("static instance of Timeline is not assignmented.", null) {

      }
    }

    public readonly int BMP_WIDTH = 2000;
    public readonly int BMP_HEIGHT = 1000;


    // 外部・子クラスからのインスタンス取得用
    // 今のところ はシングルトンにしています
    private static Timeline _instance;
    public static Timeline get_instance {
      get {
        if (_instance == null) {
          throw new TimelineInstanceIsNotAsssignmented();
        }

        return _instance;
      }
    }

    public int item_height = 32;

    public List<Item> items;
    public ColorProperty color_property;
    public Bitmap bitmap;
    private Graphics gra;

    public class ClickedItemInfo {
      public enum BehaviorKind {
        None,
        MoveItem
      }

      private static ClickedItemInfo _instance;
      public static ClickedItemInfo get_instance() {
        if (_instance == null) {
          _instance = new ClickedItemInfo();
        }

        return _instance;
      }

      private ClickedItemInfo() {
      }

      public int index;
      public int diff;
      public Point loc;
      public BehaviorKind behavior_kind;
      public static int dash_counter; // 点線描画の回転
    }

    public ClickedItemInfo click_info;


    public Timeline() {
      _instance = this;

      items = new List<Item>();
      bitmap = new Bitmap(BMP_WIDTH, BMP_HEIGHT);
      gra = Graphics.FromImage(bitmap);

      click_info = ClickedItemInfo.get_instance();

      color_property = new ColorProperty {
        background = Color.White,
        bar = Color.Red
      };
    }

    public (int, int) mouse_pos_to_item_pos(int mx, int my) {
      return (mx, my / item_height);
    }

    public Point mouse_pos_to_item_point(int mx, int my) {
      var (x, y) = mouse_pos_to_item_pos(mx, my);
      return new Point(x, y);
    }

    public int get_item_index_from_loc(int position, int layer, int ignore = -1) {
      for (int i = 0; i < items.Count; i++) {
        var item = items[i];

        if (item.layer != layer || i == ignore)
          continue;

        if (item.position <= position && position < item.position + item.width)
          return i;
      }

      return -1;
    }

    private int check_item_hit(int index, int ignore = -1) {
      var item = items[index];

      for (int i = 0; i < item.width; i++) {
        var j = get_item_index_from_loc(item.position + i, item.layer, index);

        if (j != -1) {
          return j;
        }
      }

      return -1;
    }

    public void add_item(Item item) {
      items.Add(item);

      while (true) {
        if (check_item_hit(items.IndexOf(item)) == -1) {
          break;
        }

        item.position++;
      }
    }

    // ------------------------------------------------------------ //
    //  描画
    // ------------------------------------------------------------ //
    public void draw(ref PictureBox picturebox) {
      gra.Clear(Color.White);

      // ボーダー
      for (int i = 0; i <= picturebox.Height / item_height; i++) {
        gra.DrawLine(Pens.Black, 0, i * item_height, picturebox.Width, i * item_height);
      }

      // アイテム描画
      foreach (var item in items) {
        var rect = item.get_rect;

        gra.FillRectangle(item.kind_to_brush(), rect);
        gra.DrawRectangle(Pens.Black, rect);
      }

      // クリックされたアイテムの枠を点線にする
      if (items.Count > 0 && click_info.index != -1) {
        var rect = items[click_info.index].get_rect;

        gra.DrawRectangle(new Pen(Color.White) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }, rect);
      }


      picturebox.Image = bitmap;
    }

    public void timeline_MouseDown(object sender, MouseEventArgs e) {
      var (pos, layer) = mouse_pos_to_item_pos(e.X, e.Y);

      click_info.index = get_item_index_from_loc(pos, layer);
      click_info.loc = new Point(pos, layer);

      // 右クリック
      if (e.Button == MouseButtons.Right) {
        if (click_info.index == -1) {
          Form1.form1_instance.ctxMenuStrip_timeline.Show(Form1.form1_instance.picturebox_timeline, e.Location);
        }
        else {
          Form1.form1_instance.ctxMenuStrip_tl_item.Show(Form1.form1_instance.picturebox_timeline, e.Location);
        }

        return;
      }


      if (click_info.index != -1) {
        var item = items[click_info.index];

        click_info.behavior_kind = ClickedItemInfo.BehaviorKind.MoveItem;
        click_info.diff = e.X - item.position;
      }


    }

    public void timeline_MouseMove(object sender, MouseEventArgs e) {
      if (click_info.behavior_kind == ClickedItemInfo.BehaviorKind.None) {
        return;
      }

      switch (click_info.behavior_kind) {
        case ClickedItemInfo.BehaviorKind.MoveItem: {
          var item = items[click_info.index];
          var (pos, layer) = (e.X - click_info.diff, e.Y / item_height);

          if (pos < 0) {
            pos = 0;
          }

          if (layer < 0) {
            layer = 0;
          }

          var hit_left = get_item_index_from_loc(pos, layer);
          var hit_right = get_item_index_from_loc(pos + item.width - 1, layer);

          if (hit_left != -1 && hit_left != click_info.index) {
            pos = items[hit_left].position + items[hit_left].width;

            if (get_item_index_from_loc(pos, layer, click_info.index) != -1 ) {
              break;
            }
          }

          if (hit_right != -1 && hit_right != click_info.index) {
            pos = items[hit_right].position - item.width;

            if (get_item_index_from_loc(pos, layer, click_info.index) != -1) {
              break;
            }
          }

          if (pos < 0) {
            break;
          }

          (item.position, item.layer) = (pos, layer);
          break;
        }
      }
    }

    public void timeline_MouseUp(object sender, MouseEventArgs e) {
      if (click_info.behavior_kind == ClickedItemInfo.BehaviorKind.None) {
        return;
      }

      click_info.behavior_kind = ClickedItemInfo.BehaviorKind.None;
    }
  }
}