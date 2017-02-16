using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarCounter
{
  public class Date
  {
    private string _inputDates;
    public int score = 0;

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

    public int FindYear(List<string> inputList)
    {
      string[] yearNumber = new string[]{inputList[4],inputList[5],inputList[6],inputList[7]};
      string yearString = String.Join("",yearNumber);
      int yearInt = int.Parse(yearString);
      return yearInt;
    }

    public string MonthScore(List<string> result)
    {
      int score = 0;
      int monthInt = 0;
      double lastTwoInt = 0;
      double newScore = 0;
      string dayOfWeek = "";
      //Find year
      string[] yearNumber = new string[]{result[4],result[5],result[6],result[7]};
      string yearString = String.Join("",yearNumber);
      int yearInt = int.Parse(yearString);


      //Find month
      if(result[0] == "0")
      {
      monthInt += int.Parse(result[1]);
      }
      else
      {
      string[] monthNumber = new string[]{result[0],result[1]};
      string monthString = String.Join("",monthNumber);
      monthInt += int.Parse(monthString);
      }

      //Find day
      if(result[2] == "0")
      {
        score += int.Parse(result[3]);
      }
      else
      {
      string[] dayNumber = new string[]{result[2],result[3]};
      string dayString = String.Join("",dayNumber);
        score += int.Parse(dayString);
      }

      // monthScore
      if(monthInt == 10)
      {
        score+=0;
      }
      else if(monthInt == 5)
      {
        score+=1;
      }
      else if(monthInt == 8)
      {
        score+=2;
      }
      else if(monthInt == 3 || monthInt == 11)
      {
        score+=3;
      }
      else if(monthInt == 6)
      {
        score+=4;
      }
      else if(monthInt == 9 || monthInt == 12)
      {
        score+=5;
      }
      else if(monthInt == 4 || monthInt == 7)
      {
        score+=6;
      }
      else if(monthInt == 1 && (yearInt % 400 == 0 || yearInt % 4 == 0))
      {
        score+=6;
      }
      else if(monthInt == 2 && (yearInt % 400 == 0 || yearInt % 4 == 0))
      {
        score+=2;
      }
      else if(monthInt == 1)
      {
        score+=0;
      }
      else if(monthInt == 2)
      {
        score += 3;
      }


      newScore = Convert.ToDouble(score);
      Console.WriteLine(newScore);

      //Find last two digits
      if(result[6] == "0")
      {
        lastTwoInt += Double.Parse(result[7]);
      }
      else
      {
        string[] lastTwoDigits = new string[]{result[6], result[7]};
        string lastTwoDigitsString = String.Join("", lastTwoDigits);
        lastTwoInt = Double.Parse(lastTwoDigitsString);
      }

      double totalLast = lastTwoInt + Math.Ceiling(lastTwoInt/4);
      newScore += totalLast;

      double calculation = Math.Ceiling(newScore % 7);

      if (calculation == 0)
      {
        dayOfWeek += "Saturday";
      }
      else if (calculation == 1)
      {
        dayOfWeek += "Sunday";
      }
      else if (calculation == 2)
      {
        dayOfWeek += "Monday";
      }
      else if (calculation == 3)
      {
        dayOfWeek += "Tuesday";
      }
      else if (calculation == 4)
      {
        dayOfWeek += "Wednesday";
      }
      else if (calculation == 5)
      {
        dayOfWeek += "Thursday";
      }
      if (calculation == 6)
      {
        dayOfWeek += "Friday";
      }

      return dayOfWeek;



      //
      //
      //
      // if (yearInt % 400 == 0 || yearInt % 4 == 0)
      // {
      //
      // }
      // else
      // {

      // }
    }

  }
}
