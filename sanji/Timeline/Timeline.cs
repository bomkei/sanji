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
    public Point scrollVal;
    public int seekBarPos;

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
  }
}
