using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Factory;
namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurgerController : ControllerBase
    {

       [HttpGet]
        public List<Burger> Get(string burgerType = "plain")
        {
        BurgerAPI.Factory.BurgerFactory burgerFactory = new BurgerAPI.Factory.BurgerFactory();
        BurgerAPI.Factory.iBurger burger = burgerFactory.getBurger(burgerType);
        List<Burger> returnedBurger = new List<Burger>();
        returnedBurger.Add(new Burger( burger.getPatty(),burger.getBun()));
        return returnedBurger;
        }
    }
}
