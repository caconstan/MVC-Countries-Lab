using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryListView
    {
        public CountryListView (List<Country> countryList)
        {
            Countries = countryList;
        }
        public List<Country> Countries { set; get; }
        public void Display()
        {
            for (int i=0; i < Countries.Count; i++)
            {
                Console.WriteLine(i+1 + ")" + Countries[i].Name );
            }
        }
    }
}
