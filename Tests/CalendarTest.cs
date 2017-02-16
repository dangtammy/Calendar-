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
      List<string> outputString = testDate.SplitDate();

      List<string> dateVerify = new List<string>{"0", "7", "1", "9", "2", "0", "0", "6"};
      Assert.Equal(dateVerify, outputString);
    }
  }
}
