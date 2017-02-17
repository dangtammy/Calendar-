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
        Dictionary<string,string> model = new Dictionary<string,string>{};
        model.Add("userInput",inputDate);
        model.Add("result",outputDate);
        return View["index.cshtml",model];
      };

    }
  }
}
