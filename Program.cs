using System;
using System.Linq;

namespace ShellGame
{
  class Program
  {
    private static void Play()
    {
      var shells = new Shells();
      Console.WriteLine("Pick the winning shell (0,1,2)");
      var selectedShell = Convert.ToInt64(Console.ReadLine());
      Console.WriteLine($"What selected {selectedShell}");
      var winningShell = shells.Winner;
      
      if(winningShell.Id == selectedShell)
      {
        Console.WriteLine($"You chose wisely");
      }
      else
      {
        Console.WriteLine($"You chose poorly");
      }

      Console.WriteLine($"The winning shell was actually {winningShell.Id}");
      Console.WriteLine("Play again? (Y/N)");
      var playAgain = Console.ReadLine().ToString();
      if(playAgain.ToLower() == "y")
      {
        Program.Play();
      }
    }
    static void Main(string[] args)
    {
      Program.Play();
    }
  }
}
