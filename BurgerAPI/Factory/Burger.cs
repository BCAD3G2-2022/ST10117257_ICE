using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Factory{
    public class Burger{
        public string patty { get; set; }
         public string bun { get; set; }
          public string extra { get; set; }
        
        public Burger(string patty,string bun){
            this.patty=patty;
            this.bun=bun;
        }
        public Burger(string patty,string bun,string extra){
            this.patty=patty;
            this.bun=bun;
            this.extra=extra;
        }
    }
}