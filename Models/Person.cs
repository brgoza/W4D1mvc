using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace W4D1mvc.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string HairColor { get; set; }
        public int Height { get; set; }

        public Person(string name, string hairColor, int height)
        {
            Name = name;
            HairColor = hairColor;
            Height = height;
        }
    }
}