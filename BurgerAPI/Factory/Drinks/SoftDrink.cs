using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Factory.Drinks{
    public class SoftDrinks{
        public string volume { get; set; }
         public string flavour { get; set; }
         public bool diet { get; set; }
        
       
        public SoftDrinks(string volume,string flavour,bool diet){
            this.volume=volume;
            this.flavour=flavour;      
            this.diet=diet;     
        }
       
    }
}