using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Factory.Drinks{
public class ColaDrink : iDrinks
{
    private bool isDiet;
    public ColaDrink(bool isDiet){
        this.isDiet=isDiet;

    }
        public bool getDiet()
        {
              return isDiet;
        }

        public string getflavour()
        {
            return "Cola";
        }

        public string getVolume()
        {
            return "250ml";
        }
    }
}