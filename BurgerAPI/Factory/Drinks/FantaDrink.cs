using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Factory.Drinks{
public class Fanta : iDrinks
{
    private bool isDiet;
    public Fanta(bool isDiet){
        this.isDiet=isDiet;

    }
        public bool getDiet()
        {
              return isDiet;
        }

        public string getflavour()
        {
            return "Fanta";
        }

        public string getVolume()
        {
            return "250ml";
        }
    }
}