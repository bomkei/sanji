using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanji {
  public static partial class ClassExtensions {
    public static bool IsEmpty(this string str) {
      return str.Length == 0;
    }

    public static Brush ToBrush(this Color color) {
      return new SolidBrush(color);
    }

    public static void DrawPixel(this Graphics gra, Pen pen, int x, int y) {
      gra.FillRectangle(new SolidBrush(pen.Color), x, y, 1, 1);
    }

    public static void DrawDashRectangle(this Graphics gra, int i, int imod, int imx, Pen pen, Pen spacepen, int x, int y, int width, int height) {
      int j = 0;

      for( j = x; j <= x + width; j++, i++ ) {
        if( (i % imod) < imx ) {
          gra.DrawPixel(spacepen, j, y);
        }
        else {
          gra.DrawPixel(pen, j, y);
        }
      }

      for( j = y; j <= y + height; j++, i++ ) {
        if( (i % imod) < imx ) {
          gra.DrawPixel(spacepen, x + width, j);
        }
        else {
          gra.DrawPixel(pen, x + width, j);
        }
      }

      for( j = x + width; j >= x; j--, i++ ) {
        if( (i % imod) < imx ) {
          gra.DrawPixel(spacepen, j, y + height);
        }
        else {
          gra.DrawPixel(pen, j, y + height);
        }
      }

      for( j = y + height; j >= y; j--, i++ ) {
        if( (i % imod) < imx ) {
          gra.DrawPixel(spacepen, x, j);
        }
        else {
          gra.DrawPixel(pen, x, j);
        }
      }
    }

    public static void DrawDashRectangle(this Graphics gra, int i, int imod, int imx, Pen pen, Pen spacepen, Rectangle rect) {
      gra.DrawDashRectangle(i, imod, imx, pen, spacepen, rect.X, rect.Y, rect.Width, rect.Height);
    }
  }
}