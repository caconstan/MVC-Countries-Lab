using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryController
    {
        List<Country> CountryDb = new List<Country>()
        {
            new Country("United States","North America",new string[]{"Red","White","Blue"}),
            new Country("Canada","North America",new string[]{"Red","White"}),
            new Country("Mexico","North America",new string[]{"Green","White","Red"}),
            new Country("Argentina","South America",new string[]{"Light blue","White"}),
            new Country("Brazil","South America",new string[]{"Green","Yellow"}),
            new Country("Spain","Europe",new string[]{"Red","Gold"}),
            new Country("United Kingdom","Europe",new string[]{"Red","White","Blue"}),
            new Country("France","Europe",new string[]{"Blue","White","Red"})
        };
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView();
            cv.DisplayCountry = c;
            cv.Display();
        }

        public void WelcomeAction()
        {
            // This will take no parameter and pass CountryDb into the CountryListView class.
            Console.WriteLine("\nHello, welcome to the country app. " +
            "Please select a country from the following list:");

            CountryListView clv = new CountryListView(this.CountryDb);
            clv.Display();

            int selectedCountry = 0;
            
            while (!int.TryParse(Console.ReadLine(), out selectedCountry) ||
                selectedCountry > this.CountryDb.Count ||
                selectedCountry < 1)
            {
                Console.WriteLine("I'm sorry, I didn't understand. Please try again.");
            }

            // call CountryView
            this.CountryAction(CountryDb[selectedCountry-1]);

            Console.WriteLine("Would you like to learn about another country?");
            string cont = Console.ReadLine();
            if (cont.Equals("y"))
            {
                WelcomeAction();
            }
        }
    }
}
