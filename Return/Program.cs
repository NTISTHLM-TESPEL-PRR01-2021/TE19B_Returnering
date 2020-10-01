using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      int hp = 100;

      string answer = AskQuestion();

      Console.WriteLine("Du skrev " + answer);

      Console.ReadLine();
    }

    static string AskQuestion()
    {
      Console.WriteLine("Skriv A, B eller C");
      string a = Console.ReadLine();
''
      return a;
    }

    // static void Hello()
    // {
    //   hp = 50;

    //   int strength = 100;

    //   Console.WriteLine("hej");
    // }

  }
}
