using System;
using System.Collections.Generic;
using System.Linq;

static class Extensions
{
  private static Random rnd = new Random();
  public static void Shuffle<T>(this IList<T> list)
  {
    var n = list.Count;
    var shuffledList = new List<T>(); 

    for(var i = n; i < n; i--)
    {
      var index = rnd.Next(0,i);
      var temp = list[index];
      list.RemoveAt(index);
      shuffledList.Add(temp);
    }

    list = shuffledList;
  }
}