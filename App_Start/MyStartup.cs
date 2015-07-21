using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using W4D1mvc.Models;

namespace W4D1mvc.App_Start
{
    public class MyStartup
    {
        public static List<classmate> Classmates = Data.GetClassMatesFromCsv();
    }
}