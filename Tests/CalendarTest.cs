using System;
using System.Collections.Generic;
using Xunit;

namespace CalendarCounter
{
  public class DateTest
  {
    [Fact]
    public void SplitDate_ForDateNumberInput_Split()
    {
      string inputDate = "07/19/2006";
      Date testDate = new Date(inputDate);
      List<string> splitDate = testDate.SplitDate();

      List<string> dateVerify = new List<string>{"0", "7", "1", "9", "2", "0", "0", "6"};
      Assert.Equal(dateVerify, splitDate);
    }
    [Fact]
    public void FindYear_ForDateNumberInput_YearString()
    {
      string inputDate = "07/19/2006";
      Date testDate = new Date(inputDate);
      List<string> splitDate = testDate.SplitDate();
      int inputYear = testDate.FindYear(splitDate);

      int verifyYear = 2006;
      Assert.Equal(inputYear,verifyYear);
    }
    [Fact]
    public void MonthScore_ForDateNumberInput_GetMonthScore()
    {
      string inputDate = "19/07/2006";
      Date testDate = new Date(inputDate);
      List<string> splitDate = testDate.SplitDate();
      int outputScore = testDate.MonthScore(splitDate);

      int verifyScore = 6;
      Assert.Equal(verifyScore, outputScore);
    }

  }
}
