using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.commposite.BurgerParts;
namespace BurgerAPI.commposite{
public class BurgerFactory_V2{
   public  IComponent returnInstance;

   public IComponent getBurgerPart(String burgerPart)
    {
       switch(burgerPart)
       {
           case("Bun"):
           returnInstance = new Bun();
           break;
           case("Patty"):
           returnInstance = new Patty();
            break;
           case("Tomato"):
           returnInstance = new Tomato();
           break;
           case("Cheese"):
           returnInstance = new Cheese();
           break;
           case("Lettuce"):
           returnInstance = new Lettuce();
           break;          

       }

        return returnInstance;


    }

}

}
