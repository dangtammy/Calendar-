using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarCounter
{
  public class Date
  {
    private string _inputDates;

    public Date(string inputDates)
    {
      _inputDates = inputDates;
    }



    public List<string> SplitDate()
    {
      List<char> _inputList = new List<char>{};
      char[] inputArray = _inputDates.ToCharArray();

      foreach (char number in inputArray)
      {
        if(number != '/')
        {_inputList.Add(number);}
      };

      var result = _inputList.Select(c => c.ToString()).ToList();
      return result;
    }

  }
}
