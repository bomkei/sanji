using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanji {
  public partial class Debugs {
    [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
    public static extern bool AllocConsole();

    private static void _Alert(string msg) {
      var callStack = new StackFrame(2, true);

      string file = callStack.GetFileName();
      int line = callStack.GetFileLineNumber();

      if (msg.IsEmpty()) {
        Console.WriteLine($"\t#Alert {file}:{line}");
      }
      else {
        Console.WriteLine($"\t#Alert {file}:{line}: {msg}");
      }
    }

    public static void Alert() {
      _Alert(string.Empty);
    }

    public static void Alert(string fmt, params object[] args) {
      _Alert(string.Format(fmt, args));
    }

  }
}
