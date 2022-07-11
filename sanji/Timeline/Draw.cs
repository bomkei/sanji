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

    //
    public void Draw() {

      // background
      gra.FillRectangle(background.ToColor().ToBrush(), 0, 0, picbox.Width, picbox.Height);

      // layer lines
      for( int i = 0; i <= picbox.Height / layerHeight; i++ ) {
        var y = i * layerHeight;
        gra.DrawLine(new Pen(Color.FromArgb(42, 42, 42)), 0, y, picbox.Width, y);
      }

      // items
      foreach( var item in items ) {
        var (ix, iy) = ItemLocToMousePosTuple(item.layer, item.position);
        var endix = ItemLocToMousePosTuple(0, item.endpos).Item1;

        if( endix >= 0 && ix < picbox.Width ) {
          DrawItem(item);
        }
      }


      picbox.Image = bmp;

    }

    public void DrawItem(Item item) {
      var loc = item.location;

      // 描画範囲
      var itemRect = new Rectangle(loc.position, loc.layer * layerHeight + 2, item.length - 1, layerHeight - 4);

      // 外枠の色
      var boxcolor =
        msBehav.clickedItem == item
        ? Pens.DodgerBlue
        : (msBehav.mouseEnteredItem == item ? Pens.Wheat : new Pen(Color.FromArgb(120, 120, 120)));

      // 塗りつぶしの色
      var fillcolor = new SolidBrush(Color.FromArgb(80, 80, 80));

      // 長さが 1 のときは縦線を描画するだけ
      if( item.length == 1 ) {
        gra.DrawLine(boxcolor, itemRect.X, itemRect.Y, itemRect.X, itemRect.Y + itemRect.Height);
        return;
      }

      loc.position -= scrollVal.X;

      int txtlen = item.name.Length;
      for( ; txtlen > 0 && itemRect.Width < (int)gra.MeasureString(item.name.Substring(0, txtlen), font).Width; txtlen-- ) ;

      gra.FillRectangle(fillcolor, itemRect);

      gra.DrawRectangle(boxcolor, itemRect);

      gra.DrawString(item.name.Substring(0, txtlen), font, Brushes.White,
        itemRect.X, itemRect.Y + (layerHeight - (int)gra.MeasureString(item.name, font).Height) / 2);


    }
  }
}