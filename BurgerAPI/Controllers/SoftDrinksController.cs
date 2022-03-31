using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Factory.Drinks;
namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinksController : ControllerBase
    {

       [HttpGet]
        public List<SoftDrinks> Get(string SoftDrinkType = "cola",bool isDeit = false)
        {
        SoftDrinksFactory drinkFactory = new BurgerAPI.Factory.Drinks.SoftDrinksFactory();
        iDrinks drink = drinkFactory.getDrink(SoftDrinkType,isDeit);
        List<SoftDrinks> returnedDrink = new List<SoftDrinks>();
        returnedDrink.Add(new SoftDrinks(drink.getVolume(),drink.getflavour(),drink.getDiet()));
        return returnedDrink;
        }
    }
}
