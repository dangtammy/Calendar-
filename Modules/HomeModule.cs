using Nancy;
using CalendarCounter;
using System;
using System.Collections.Generic;

namespace CalendarCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ =>{
        string inputDate = Request.Form["date"];
        Date testDate = new Date(inputDate);
        List<string> splitDate = testDate.SplitDate();
        string outputDate = testDate.Calculate(splitDate);
        return View["index.cshtml", outputDate];
      };

    }
  }
}
