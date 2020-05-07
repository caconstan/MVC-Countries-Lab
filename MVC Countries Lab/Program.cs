using System;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController myLiege = new CountryController();
            myLiege.WelcomeAction();
        }
    }
}
