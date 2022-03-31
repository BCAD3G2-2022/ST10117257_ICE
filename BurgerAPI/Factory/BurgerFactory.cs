using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace BurgerAPI.Factory{
public class BurgerFactory{
   public  iBurger returnInstance;

   public iBurger getBurger(String burgerType)
    {
       switch(burgerType)
       {
           case("chicken"):
           returnInstance = new _ChickenBurger();
           break;
           case("plain"):
           returnInstance = new PlainBurger();
            break;
           case("cheese"):
           returnInstance = new _CheeseBurger();
           break;

       }

        return returnInstance;


    }

}

}
