using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class Country
    {
    public Country (string name, string continent, string[] colors)
    {
        this.Name = name;
        this.Continent = continent;
        this.Colors = new List<string>(colors);
    }
    public string Name { set; get; }
    public string Continent { set; get; }
    public List<string> Colors { set; get; }

    }
}
