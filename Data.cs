using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using W4D1mvc.Models;

namespace W4D1mvc
{
    public static class Data
    {
        private static string defaultFilename = "~\\App_Data\\Classmates.csv";
        public static List<Person> GetClassMates(string filename = "")
        {
            if (filename == "") filename = defaultFilename;

            List<Person> peopleList = new List<Person>();

            var reader = System.IO.File.OpenText(filename);
            while (!reader.EndOfStream)
            {
                var fields = reader.ReadLine().Split(',');
                peopleList.Add(new Person(fields[0], fields[1], int.Parse(fields[2])));
            }
            reader.Close();
            return peopleList;
        }

        public static void AddClassMate(Person p, string filename)
        {
            if (filename == "") filename = defaultFilename;
            var writer = System.IO.File.AppendText(filename);
            writer.WriteLine(p.Name+","+p.HairColor+","+p.Height);
            writer.Close();
       
        }
    }
}