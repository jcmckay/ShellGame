using System;
using System.Collections.Generic;
using System.Linq;

namespace ShellGame
{
  class Shells
  {
    private static IList<Shell> shells;
    public Shell Winner { get => shells.First(s => s.Ball != null); }
    public Shells()
    {
       GetShells();
    }

    private static void GetShells()
    {
      var shells = new List<Shell>();
      var rnd = new Random();
      
      for(int i = 0; i < 3; i++)
      {
        shells.Add(new Shell(i, i == rnd.Next(0,3) ? new Ball() : null));
      }
    }
  }
}