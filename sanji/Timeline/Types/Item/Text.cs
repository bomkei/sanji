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

namespace sanji.TimelineItems {
  public class TextItem : Item {
    public string text;

    public TextItem(string text, Location loc)
      : base(Kind.Text, loc, 100) {

    }
  }
}
