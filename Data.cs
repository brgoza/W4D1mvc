using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.WebPages;
using W4D1mvc.Models;

namespace W4D1mvc
{
    public static class Data
    {
        private static string defaultFilename = "\\App_Data\\Classmates.csv";

        public static List<classmate> GetClassMatesFromCsv(string filename = "")
        {

            if (filename == "") filename = defaultFilename;

            if (!System.IO.File.Exists(filename)) filename = GetNewFileName();

            List<classmate> peopleList = new List<classmate>();

            var reader = System.IO.File.OpenText(filename);
            int counter = 0;
            while (!reader.EndOfStream)
            {
                var fields = reader.ReadLine().Split(',');
                peopleList.Add(new classmate(fields[0], fields[1], int.Parse(fields[2])));
                counter++;
            }
            reader.Close();
            return peopleList;
        }

        private static string GetNewFileName()
        {
            return HostingEnvironment.MapPath(@"~\App_Data\classmates.csv");
        }

        public static void SaveClassMates()
        {
            StringBuilder sb = new StringBuilder();
            foreach (classmate c in App_Start.MyStartup.Classmates)
            {
                sb.AppendLine(string.Format("{0},{1},{2}", c.Name, c.HairColor, c.Height));
            }
             System.IO.File.WriteAllText(GetNewFileName(), sb.ToString());
        }

    }
}