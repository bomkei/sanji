using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanji {
  public static class Utils {

    public static bool IsRangeCollid(int begin1, int end1, int begin2, int end2) {
      return begin2 <= end1 && begin1 <= end2;
    }

  }
}