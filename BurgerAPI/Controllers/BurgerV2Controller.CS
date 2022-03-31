using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.commposite;
using BurgerAPI.commposite.BurgerParts;
namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurgerV2Controller : ControllerBase
    {

       [HttpGet]
        public List<Commposite>  Get(bool tomato,bool  cheese, bool lettuce)
        {
        IComponent burgerBun = new Bun();
            IComponent burgerPatty = new Patty();
            IComponent burgerLettuce = new Lettuce();
            IComponent burgerTomato = new Tomato();
            IComponent burgerCheese= new Cheese();
List<Commposite>commposites =new List<Commposite>();


           //Commposite BaseBurger = new Commposite();
           commposites.Add(new Commposite(burgerBun.getBurgerPart()));
           commposites.Add(new Commposite(burgerPatty.getBurgerPart()));
       
        
       
        // commposites=BaseBurger.components;
           if(tomato)
           {
 commposites.Add(new Commposite(burgerTomato.getBurgerPart()));
           

           }

           if(lettuce)
           {
             commposites.Add(new Commposite(burgerLettuce.getBurgerPart()));
           }
           if (cheese)
           {
                 commposites.Add(new Commposite(burgerCheese.getBurgerPart()));
           }

           return commposites;
        }

      
    }
}
