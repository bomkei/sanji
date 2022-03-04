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


    public void add_item(Item item) {
      items.Add(item);

      while (true) {
        if (check_item_hit(items.IndexOf(item)) == -1) {
          break;
        }

        item.position++;
      }
    }


    
  }
}