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
  public partial class MainForm : Form {
    [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
    private static extern bool AllocConsole();

    public MainForm() {
      AllocConsole();
      InitializeComponent();

    }

    void onMouseDown(object sender, MouseEventArgs e) {

    }
    
    void onMouseMove(object sender, MouseEventArgs e) {

    }
    
    void onMouseUp(object sender, MouseEventArgs e) {

    }

    private void テキストToolStripMenuItem_Click(object sender, EventArgs e) {

    }

    private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
    }
  }


}