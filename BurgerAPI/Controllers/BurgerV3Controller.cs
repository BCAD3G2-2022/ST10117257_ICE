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
    public class BurgerV3Controller : ControllerBase
    {


         [HttpGet]
        public List<string>  Get(bool tomato,bool  cheese, bool lettuce)
        {
        IComponent burgerBun = new Bun();
            IComponent burgerPatty = new Patty();
            IComponent burgerLettuce = new Lettuce();
            IComponent burgerTomato = new Tomato();
            IComponent burgerCheese= new Cheese();
//List<Commposite>commposites =new List<Commposite>();


        Commposite BaseBurger = new Commposite(burgerBun.getBurgerPart());
        BaseBurger.getBurgerPart1(burgerBun.getBurgerPart());
         BaseBurger.getBurgerPart1(burgerPatty.getBurgerPart());
         
         //  commposites.Add(new Commposite(burgerBun.getBurgerPart()));
        ///   commposites.Add(new Commposite(burgerPatty.getBurgerPart()));
       //
        
       
        // commposites=BaseBurger.components;
           if(tomato)
           {

           
BaseBurger.getBurgerPart1(burgerTomato.getBurgerPart());
           }

           if(lettuce)
           {
           
             BaseBurger.getBurgerPart1(burgerLettuce.getBurgerPart());
           }
           if (cheese)
           {  BaseBurger.getBurgerPart1(burgerCheese.getBurgerPart());
               
           }

           return BaseBurger.getBurgerPart2();;
        }
    }
}
