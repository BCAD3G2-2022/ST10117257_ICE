using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace BurgerAPI.Factory.Drinks
{
    public class SoftDrinksFactory
    {

        public iDrinks returnInstance;


        public iDrinks getDrink(String burgerType, bool isDiet)
        {
            switch (burgerType)
            {
                case ("cola"):
                    returnInstance = new ColaDrink(isDiet);
                    break;
                case ("fanta"):
                    returnInstance = new Fanta(isDiet);
                    break;

            }

            return returnInstance;


        }
    }


}


