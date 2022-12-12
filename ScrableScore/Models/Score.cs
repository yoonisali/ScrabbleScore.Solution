using System;
using System.Collections.Generic;

namespace ScrableScore.Models
{
  public class Score
  {
    private Dictionary<char, int> scoreKey = new Dictionary<char, int>()
    {
      {'a', 1},
      {'e', 1},
      {'i', 1},
      {'o', 1},
      {'u', 1},
      {'l', 1},
      {'n', 1},
      {'r', 1},
      {'s', 1},
      {'t', 1},
      {'d', 2},
      {'g', 2},
      {'b', 3},
      {'c', 3},
      {'m', 3},
      {'p', 3},
      {'f', 4},
      {'h', 4},
      {'v', 4},
      {'w', 4},
      {'y', 4},
      {'k', 5},
      {'j', 8},
      {'x', 8},
      {'q', 10},
      {'z', 10}
    };

    public string Response;

    public char[] SplitWord(string input)
    {
      string lowerInput = input.ToLower();
      char[] splitInput = lowerInput.ToCharArray();
      return splitInput;
    }

    public void ValueScore(char[] splitInput)
    {
      int score = 0;
      bool isValid = true;
      foreach(char element in splitInput)
      {
        if (scoreKey.ContainsKey(element))
        {
          score = score + scoreKey[element];
        }
        else
        {
          isValid = false;
        }
      }

      if (isValid)
      {
        Response = score.ToString();
      }
      else
      {
        Response = "INVALID INPUT!";
      }
    }
  }
}