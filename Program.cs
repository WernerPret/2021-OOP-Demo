using System;
using System.Collections.Generic;


namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Dam", 30, "Pretoria", "RSA", "he/him");
      Console.WriteLine(sam.ViewProfile());
      sam.SetHobbies(new List<string>(){"Hunting", "Fishing", "Loving every day"});
      Console.WriteLine(sam.ViewProfile());
    }
  }
}
