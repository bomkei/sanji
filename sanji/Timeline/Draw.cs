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
        var rect = item.get_rect();

        gra.FillRectangle(item.kind_to_brush(), rect);
        gra.DrawRectangle(Pens.Black, rect);
      }

      // クリックされたアイテムの枠を点線にする
      if (items.Count > 0 && click_info.index != -1) {
        var rect = items[click_info.index].get_rect();

        gra.DrawRectangle(new Pen(Color.White) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }, rect);
      }


      picturebox.Image = bitmap;
    }
  }
}