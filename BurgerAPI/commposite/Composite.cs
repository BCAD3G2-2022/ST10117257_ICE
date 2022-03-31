using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.commposite.BurgerParts;
namespace BurgerAPI.commposite
{
    public class Commposite
    {
        List<String >commposites =new List<String >();
     public string part { get; set; }

   
        public Commposite(string part){
             this.part=part;
        }
      
        public string getBurgerPart()
        {      
         
          return part;
        }
        public void getBurgerPart1(String part)
        {         
         commposites.Add(part);
        }

    
         public List<string> getBurgerPart2()
        {         
        return commposites;
        }
    }

}


